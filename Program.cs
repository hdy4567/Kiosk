namespace Kiosk
{
    internal static class Program
    {
        // 실습 환경(학원 등)에 맞게 관리자 컴퓨터의 IP 주소를 이 변수 하나로 제어합니다.
        // 다른 컴퓨터가 서버일 경우, 해당 컴퓨터의 IP(예: "192.168.0.X")로 변경하세요.
        public static string ServerIP = "127.0.0.1";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Firstform());
        }
    }
}