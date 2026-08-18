using System;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kiosk
{
    public class SmsService
    {
        // api 문서 제일 왼쪽 상단 대시보드에서 키 값 가져와야 함. 
        // https://www.figma.com/board/EYl6PAsWEA2K3gVaDmnzEM/Kiosk?node-id=0-1&t=0kQY2BQBO7zMICSu-1
        private readonly string apiKey = "NCSOVG24QAL0IGQM";
        private readonly string apiSecret = "X2EPBHPYZWSYKPAQUNCCU4BUGMYCLAXK";
        private readonly string senderNumber = "01050334000"; // 발신번호 지정

        // HMAC SHA256 서명 생성 (Solapi 인증 스펙)
        private string GetSignature(string data, string key)
        {
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key));
            byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        // 인증 헤더 구성 (Solapi 스펙)
        private string GetAuthorizationHeader()
        {
            // 12~20자 이내 규칙에 맞춰 16자리 Salt 생성
            string salt = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
            // 밀리초가 없는 고정 ISO-8601 UTC 포맷 지정
            string date = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss'Z'", System.Globalization.CultureInfo.InvariantCulture);
            string data = date + salt;

            // 디버깅 정밀 추적용 로그 
            System.Diagnostics.Debug.WriteLine($"[Solapi Auth Debug] ---------------------------------------------");
            System.Diagnostics.Debug.WriteLine($"[1] API Key: {apiKey}");
            System.Diagnostics.Debug.WriteLine($"[2] API Secret Length: {apiSecret?.Length ?? 0}");
            System.Diagnostics.Debug.WriteLine($"[3] ISO Date: {date}");
            System.Diagnostics.Debug.WriteLine($"[4] Salt: {salt}");
            System.Diagnostics.Debug.WriteLine($"[5] String-to-Sign: {data}");

            // HMAC-SHA256으로 서명을 생성합니다
            string signature;
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(apiSecret)))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));

                var sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                signature = sb.ToString();
            }

            System.Diagnostics.Debug.WriteLine($"[6] Generated Signature: {signature}");
            System.Diagnostics.Debug.WriteLine($"[Solapi Auth Debug] ---------------------------------------------");

            return $"HMAC-SHA256 apiKey={apiKey}, date={date}, salt={salt}, signature={signature}";
        }

        // 공용 SMS 전송 메서드
        public async Task<string> SendSmsAsync(string to, string text)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", GetAuthorizationHeader());

                    var messagePayload = new
                    {
                        message = new
                        {
                            to = to,
                            from = senderNumber,
                            text = text
                        }
                    };

                    string jsonContent = JsonConvert.SerializeObject(messagePayload);
                    var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("https://api.solapi.com/messages/v4/send", httpContent);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        System.Diagnostics.Debug.WriteLine($"[SmsService] 문자 전송 성공: {responseBody}");
                        return responseBody;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"[SmsService] 문자 전송 실패 (HTTP {response.StatusCode}): {responseBody}");
                        return responseBody;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[SmsService] 문자 전송 예외 발생: {ex.Message}");
                return $"{{\"errorCode\":\"Exception\",\"errorMessage\":\"{ex.Message}\"}}";
            }
        }
    }
}
