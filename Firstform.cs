using sushikiosk;
using System.Linq.Expressions;

namespace Kiosk
{
    public partial class Firstform : BaseLanguageForm
    {
        private readonly string[] hereinTexts = { "Eat In", "店内飲食", "매장 식사" };
        private readonly string[] togoTexts = { "Take Out", "持ち帰り", "포장 주문" };

        public Firstform()
        {
            InitializeComponent();

            // 첫 화면에서, 언어 선택 버튼 이벤트 바인딩
            btn_EngCh.Click += (s, e) => LanguageManager.SetLanguage(0); // English
            btn_JapCh.Click += (s, e) => LanguageManager.SetLanguage(1); // Japanese
            btn_KorCh.Click += (s, e) => LanguageManager.SetLanguage(2); // Korean
        }


        // BaseLanguageForm 클래스에서 상속 
        protected override void ApplyLanguage()
        {
            int langIndex = LanguageManager.CurrentLanguageIndex;
            btn_herein.Text = hereinTexts[langIndex];
            btn_togo.Text = togoTexts[langIndex];
        }

        private void SendOrderTypeToAdmin(string orderType)
        {
            try
            {
                // MainAdminForm 소켓 포트인 9000으로 TCP 연결을 수립합니다.
                using (System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("192.168.0.62", 9000))
                using (System.Net.Sockets.NetworkStream stream = client.GetStream())
                {
                    // 전송할 패킷 데이터를 JSON 형식 스트링으로 구성
                    string message = $"{{\"Action\": \"NEW_ORDER_TYPE\", \"OrderType\": \"{orderType}\"}}";
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(message);

                    // 스트림에 쓰기 작업 수행
                    stream.Write(data, 0, data.Length);
                    stream.Flush();

                    // 전송이 끝났음을 서버에 명시적으로 전달 (Shutdown Send)
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
    }
}
