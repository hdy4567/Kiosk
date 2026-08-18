using sushikiosk;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using Newtonsoft.Json;

namespace Kiosk
{
    public partial class Firstform : BaseLanguageForm
    {
        private readonly string[] hereinTexts = { "Eat In", "店内飲食", "매장 식사" };
        private readonly string[] togoTexts = { "Take Out", "持ち帰り", "포장 주문" };

        // SMS 발송 서비스 인스턴스
        private readonly SmsService smsService = new SmsService();

        // 발송 대기 메시지 큐 (메시지 목록 그룹)
        private readonly List<object> messageGroup = new List<object>();

        // 대기 정보 목업 변수 (실제 데이터 연동 가능)
        private int queueNum = 1;      // 발급되는 대기번호
        private int currentNum = 5;    // 현재 앞의 대기팀수

        private Kiosk.Controls.RoundedButton[] inputNumButtons = null!;
        private int currentInputIndex = 0;

        public Firstform()
        {
            InitializeComponent();

            // 대기 팝업 패널을 띄우기 전 초기 상태로 숨겨둡니다.
            pnl_queue.Hide();

            // 첫 화면에서, 언어 선택 버튼 이벤트 바인딩
            btn_EngCh.Click += (s, e) => LanguageManager.SetLanguage(0); // English
            btn_JapCh.Click += (s, e) => LanguageManager.SetLanguage(1); // Japanese
            btn_KorCh.Click += (s, e) => LanguageManager.SetLanguage(2); // Korean

            // 가상 키패드 배열 로직 초기화
            InitializeNumArrayLogic();
        }
        // BaseLanguageForm 클래스에서 상속    
        protected override void ApplyLanguage()
        {
            int langIndex = LanguageManager.CurrentLanguageIndex;
            btn_herein.Text = hereinTexts[langIndex];
            btn_togo.Text = togoTexts[langIndex];
        }

        private void InitializeNumArrayLogic()
        {
            // btn_inputNumArray들을 순서대로 배열로 묶기
            inputNumButtons = new Kiosk.Controls.RoundedButton[]
            {
                btn_inputNumArray1, btn_inputNumArray2, btn_inputNumArray3,
                btn_inputNumArray4, btn_inputNumArray5, btn_inputNumArray6,
                btn_inputNumArray7, btn_inputNumArray8
            };

            // 모든 버튼 이벤트 등록 및 가상 키패드 전용 설정
            for (int i = 0; i < inputNumButtons.Length; i++)
            {
                int index = i;
                inputNumButtons[i].GotFocus += (s, e) =>
                {
                    currentInputIndex = index;
                    HighlightActiveTextbox();
                };
                inputNumButtons[i].LostFocus += (s, e) =>
                {
                    HighlightActiveTextbox();
                };
            }

            // 버튼과 버튼 이벤트를 배열화해서, 계산기처럼 작동하도록 구현
            Button[] numButtons = { button3, button4, button5, button6, button7, button8, button13, button12, button10, button14 };
            foreach (var btn in numButtons)
            {
                btn.Click += (s, e) =>
                {
                    AppendChar(btn.Text);
                };
            }

            // 특수 기능 버튼들 연결
            button15.Click += (s, e) => AppendString("010"); // 010 버튼
            btn_inputQueue.Click += (s, e) => // 000 버튼 (수신 번호 전송 버튼으로 변경)
            {
                string userPhoneNumber = string.Join("", inputNumButtons.Select(btn => btn.Text));
                if (string.IsNullOrEmpty(userPhoneNumber))
                {
                    MessageBox.Show("수신 번호를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _ = RegisterAndSendWaitingSmsAsync(userPhoneNumber);
            };
            button2.Click += (s, e) => RemoveLastChar();    // Backspace (<-) 버튼
            button1.Click += (s, e) => ClearAllNumArray();  // Clear 버튼

            // 첫 번째 텍스트박스 활성화 및 포커스 설정
            if (inputNumButtons.Length > 0)
            {
                inputNumButtons[0].Focus();
                HighlightActiveTextbox();
            }
        }

        private void AppendChar(string val)
        {
            if (currentInputIndex >= inputNumButtons.Length) return;

            inputNumButtons[currentInputIndex].Text = val;

            // 다음 인덱스 텍스트박스로 포커스 이동
            if (currentInputIndex < inputNumButtons.Length - 1)
            {
                currentInputIndex++;
                inputNumButtons[currentInputIndex].Focus();
            }
        }

        private void AppendString(string val)
        {
            foreach (char c in val)
            {
                if (currentInputIndex >= inputNumButtons.Length) break;
                inputNumButtons[currentInputIndex].Text = c.ToString();
                if (currentInputIndex < inputNumButtons.Length - 1)
                {
                    currentInputIndex++;
                }
            }
            if (currentInputIndex < inputNumButtons.Length)
            {
                inputNumButtons[currentInputIndex].Focus();
            }
            HighlightActiveTextbox();
        }

        private void RemoveLastChar()
        {
            if (currentInputIndex >= inputNumButtons.Length) currentInputIndex = inputNumButtons.Length - 1;

            if (string.IsNullOrEmpty(inputNumButtons[currentInputIndex].Text) && currentInputIndex > 0)
            {
                currentInputIndex--;
            }

            inputNumButtons[currentInputIndex].Text = "";
            inputNumButtons[currentInputIndex].Focus();
            HighlightActiveTextbox();
        }

        private void HighlightActiveTextbox()
        {
            if (inputNumButtons == null) return;
            for (int i = 0; i < inputNumButtons.Length; i++)
            {
                if (i == currentInputIndex)
                {
                    inputNumButtons[i].BorderColor = SystemColors.MenuHighlight;
                    inputNumButtons[i].BorderSize = 3f;
                }
                else
                {
                    inputNumButtons[i].BorderColor = SystemColors.ActiveBorder;
                    inputNumButtons[i].BorderSize = 2f;
                }
            }
        }

        private void ClearAllNumArray()
        {
            foreach (var btn in inputNumButtons)
            {
                btn.Text = "";
            }
            currentInputIndex = 0;
            inputNumButtons[0].Focus();
            HighlightActiveTextbox();
        }




        /// <summary>
        /// 수신번호(전화번호) 입력 받을 폼 팝업 후, 수신번호 입력시 
        /// 대기 큐 등록(1회차) 및 호출(2회차)을 가상으로 시뮬레이션하는 메서드
        /// </summary>
        /// <param name="userPhoneNumber"></param>
        /// <returns></returns>
        public async Task RegisterAndSendWaitingSmsAsync(string userPhoneNumber)
        {
            // 수신 번호가 010으로 시작하지 않으면 강제로 붙여서 표준화
            userPhoneNumber = "010" + userPhoneNumber;

            // [1회차] 웨이팅 등록 완료 문자 내용 구성 (SMS 단문 규격)
            string registerMessage = $"[모블스시]대기{queueNum}번 접수완료/대기{currentNum}팀/순서가 되면 문자로 안내해드립니다.";

            Console.WriteLine($"대기번호 {queueNum}번 고객님 {userPhoneNumber}");

            // 1회차 문자 전송용 메시지 객체를 생성하여 그룹 큐(messageGroup)에 담음
            var msgObject = new
            {
                to = userPhoneNumber,
                text = registerMessage
            };
            messageGroup.Add(msgObject);

            // 실제 SMS 발송 실행 
            string responseJson = await smsService.SendSmsAsync(userPhoneNumber, registerMessage);
            dynamic? response = JsonConvert.DeserializeObject(responseJson);
            if (response != null && response.statusCode == null && response.errorCode == null)
            {
                MessageBox.Show("웨이팅 등록 문자가 발송되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (response != null)
            {
                Console.WriteLine("Error Code:" + response.errorCode);
                Console.WriteLine("Error Message:" + response.errorMessage);
            }

            // [2회차 시뮬레이션용 대기] 임시 테스트를 위해 3초 후 순번 호출 전송
            /*
            await Task.Delay(3000);

            // [2회차] 입장 안내 문자 내용 구성 (SMS 단문 규격)
            //string entranceMessage = $"[모블스시] 입장 안내\n" +
            //                         $"대기번호 {queueNum}번 고객님, 지금 매장으로 입장해 주세요!\n\n" +
            //                         $"호출 후 3분 이내에 미입장 시 대기가 자동으로 취소될 수 있습니다.\n" +
            //                         $"매장 입구 직원에게 본 메시지를 보여주시기 바랍니다.";
            string entranceMessage = $"[모블스시]대기{queueNum}번 고객님 지금 입장해주세요.(3분미입장시 자동취소)";

            // 2회차 문자 전송
            string callResponseJson = await smsService.SendSmsAsync(userPhoneNumber, entranceMessage);
            dynamic? callResponse = JsonConvert.DeserializeObject(callResponseJson);
            if (callResponse != null && callResponse.statusCode == null && callResponse.errorCode == null)
            {
                // 성공적으로 2회차 메시지가 발송되면 messageGroup 큐에서 제거
                messageGroup.Remove(msgObject);
                MessageBox.Show("입장 안내 문자가 발송되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 호출 만료 제한 시간 (현재 시간 기준 3분 뒤) 설정
                DateTime limitedMinutes = DateTime.Now.AddMinutes(3);

                // [시뮬레이션] 3분 초과 여부 체크 (즉시 취소 처리를 확인하기 위해 가상 비교)
                if (DateTime.Now >= limitedMinutes || (DateTime.Now - limitedMinutes.AddMinutes(-3)).TotalMinutes >= 3)
                {
                    MessageBox.Show("대기 제한 시간(3분)이 초과되어 대기열 큐에서 자동으로 제거되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            */

            // 테스트용 번호 업데이트
            queueNum++;
            if (currentNum > 0) currentNum--;
        }


        private void SendOrderTypeToAdmin(string orderType)
        {
            try
            {
                // MainAdminForm 소켓 포트인 9000으로 TCP 연결을 수립합니다. 
                // 테스팅용 자기 자신 
                using (System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 9000))
                //using (System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("192.168.0.62", 9000))

                using (System.Net.Sockets.NetworkStream stream = client.GetStream())
                {
                    // 전송할 패킷 데이터를 JSON 형식 스트링으로 구성
                    string message = $"{{\"Action\": \"NEW_ORDER_TYPE\", \"OrderType\": \"{orderType}\"}}";
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(message);

                    // 스트림에 쓰기 작업 수행
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    client.Client.Shutdown(System.Net.Sockets.SocketShutdown.Send);

                    System.Diagnostics.Debug.WriteLine($"[Firstform 디버그] 관리자 폼으로 전송 완료: {message}");
                    MessageBox.Show($"관리자 전송 완료: {orderType}", "디버그 통신 체크", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Firstform 디버그] 관리자 통신 중 오류 발생: {ex.Message}");
                MessageBox.Show($"관리자 전송 실패 ({ex.Message})", "디버그 통신 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void btn_start_Click(object sender, EventArgs e)
        {
            SendOrderTypeToAdmin("매장");

            Here_In hereinform = new Here_In();
            hereinform.Show();
            this.Hide();
        }

        private void lb_herein_Click(object sender, EventArgs e)
        {

        }

        private void btn_JapCh_Click(object sender, EventArgs e)
        {

        }

        private void btn_togo_Click(object sender, EventArgs e)
        {
            SendOrderTypeToAdmin("포장");

            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void btn_waiting_Click(object sender, EventArgs e)
        {
            pnl_queue.Show();
            pnl_queue.BringToFront();
        }

        private void btn_inputQueue_Click(object sender, EventArgs e)
        {
            string userPhoneNumber = string.Join("", inputNumButtons.Select(btn => btn.Text));
            // 만약, 비어있거나 잘못된 값이라면 
            if (string.IsNullOrEmpty(userPhoneNumber))
            {
                MessageBox.Show("수신 번호를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _ = RegisterAndSendWaitingSmsAsync(userPhoneNumber);
        }
    }
}
