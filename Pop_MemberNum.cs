using sushikiosk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Pop_MemberNum : BaseLanguageForm
    {
        // MenuForm.cs 주문 데이터를 넘겨받을 리스트 필드 추가
        private List<sushikiosk.MenuForm.OrderItem> orderList = new List<sushikiosk.MenuForm.OrderItem>();

        
        //EarnedPoint: 이번 결제로 적립한 포인트
        //추가 MemberId: 회원번호(비회원은 0)
        //PaymentMethod: 결제 수단(신용카드, 앱선결제 등)
        public Pop_MemberNum()
        {
            InitializeComponent();
            pnlStamp.Hide();
            pnl_Pop_Membership.Hide();
        }

        // MenuForm에서 넘어올 때 사용할 생성자 오버로드
        public Pop_MemberNum(List<sushikiosk.MenuForm.OrderItem> orders) : this()
        {
            this.orderList = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payform = new Payment(this.orderList);
            payform.Show();
            this.Hide();
        }

        // 포인트 적립 다국어 메시지 템플릿 (0: 영어, 1: 일본어, 2: 한국어)
        private readonly string[] pointAskMessages = { "Would you like to earn points?", "ポイントを積立しますか？", "포인트를 적립하시겠습니까?" };
        private readonly string[] pointAskTitles = { "Earn Points", "ポイント積立", "포인트 적립" };
        string[] inputs = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "00", "000", "Clear ", "<-" };

        private readonly string[] label4Texts = { "Please select a saving method!", "積立手段を選択してください！", "적립수단을 선택해주세요 !" };
        private readonly string[] label3Texts = { "Saving Menu", "積立メニュー", "적립 메뉴" };
        private readonly string[] phoneSelectTexts = { "Phone Number", "携帯電話番号", "휴대폰 번호" };
        private readonly string[] cusSelectTexts = { "Member Card", "会員カード", "회원 카드" };
        private readonly string[] allDeleteTexts = { "Clear All", "すべて削除", "전체 삭제" };
        private readonly string[] backTexts = { "Back", "戻る", "이전" };
        private readonly string[] receiveTexts = { "Earn Complete", "積立完了", "적립 완료" };
        private readonly string[] roundTop1Texts = { "Earn", "積立", "적립" };
        private readonly string[] cusIdTexts = { "Member ID", "会員番号", "회원번호" };
        private readonly string[] cusId1Texts = { "Member ID", "会員番号", "회원번호" };


        private readonly string[] phonenumTexts = { "Phone Number", "携帯電話番号", "휴대폰 번호" };
        private readonly string[] sumTexts = { "Total Amount", "対象金額", "대상금액" };
        private readonly string[] cusNameTexts = { "Member Name", "会員명", "회원명" };
        private readonly string[] savePointTexts = { "Remaining Points", "残高ポイント", "잔여 포인트" };

        // 텍스트 정의
        private readonly string[] label2Texts = { "Payment Method", "お支払い方法", "결제 방식" };
        private readonly string[] label19Texts = { "Accumulated Stamps", "累積スタンプ", "누적 스탬프" };
        private readonly string[] label14Texts = { "Stamp Earn", "スタンプ積立", "스탬프 적립" };
        private readonly string[] lb_cusid1Texts = { "Member ID", "会員番号", "회원번호" };
        private readonly string[] lb_cusidTexts = { "Member ID", "会員番号", "회원번호" };

        private readonly string[] del1Texts = { "Close", "閉じる", "닫기" };
        private readonly string[] del2Texts = { "Close", "閉じる", "닫기" };
        private readonly string[] button32Texts = { "Cancel", "キャンセル", "취소" };
        private readonly string[] searchTexts = { "1. Search", "1. 照会", "1. 조회" };
        private readonly string[] savepointTexts = { "Earn Points", "ポイント積立", "포인트 적립" };
        private readonly string[] saveTexts = { "Earn", "積立", "적립" };



        private void button2_Click(object sender, EventArgs e)
        {
            int lang = LanguageManager.CurrentLanguageIndex;
            DialogResult result = MessageBox.Show(
                pointAskMessages[lang],
                pointAskTitles[lang],
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                // 메인 선택 패널 숨기기
                roundedPanel2.Hide();

                pnl_Pop_Membership.Show();
                pnl_Pop_Membership.BringToFront();
                //pnl_Pop_Membership.Focus();
            }
        }


        private void Membership_Load(object sender, EventArgs e)
        {
            // 폼 안의 모든 Button 컨트롤을 찾아서 입력 버튼인 경우 이벤트를 바인딩합니다.
            BindNumButtons(this);
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lang = LanguageManager.CurrentLanguageIndex;
            DialogResult result = MessageBox.Show(
                pointAskMessages[lang],
                pointAskTitles[lang],
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                // 메인 선택 패널 숨기기
                //roundedPanel2.Hide();

                pnlStamp.Show();
                pnlStamp.BringToFront();
                pnlStamp.Focus();
            }

        }

        private void Pop_Membership_Load(object sender, EventArgs e)
        {
            // pnlStamp의 tableLayoutPanel2 숫자판의 btn_pl 버튼들을 회원번호에 입력
            // btn_plClear 입력 시 "" 초기화
            // btn_pl1 입력시 1입력 
            lb_point.Focus();
            // 폼 안의 모든 Button 컨트롤을 찾아서 입력 버튼인 경우 이벤트를 바인딩합니다.
            BindNumButtons(this);
        }
        private void Pop_MemberNum_Load(object sender, EventArgs e)
        {
            // 폼 안의 모든 Button 컨트롤을 찾아서 입력 버튼인 경우 이벤트를 바인딩합니다.
            BindNumButtons(this);
        }

        private void BindNumButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn && inputs.Contains(btn.Text))
                {
                    btn.Click += NumButton_Click;
                }
                else if (control.HasChildren)
                {
                    BindNumButtons(control); // 패널 등 하위 컨테이너에 있는 버튼도 탐색
                }
            }
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // pnl_Pop_Membership의 tableLayoutPanel1의 버튼인 경우 (휴대폰 번호 입력)
                if (IsChildOf(btn, tableLayoutPanel1))
                {
                    string raw = lb_cusNum.Text.StartsWith("010-") ? lb_cusNum.Text.Substring(4).Replace("-", "") : lb_cusNum.Text.Replace("-", "");
                    if (btn.Text == "Clear ")
                    {
                        raw = "";
                    }
                    else if (btn.Text == "<-")
                    {
                        if (raw.Length > 0)
                        {
                            raw = raw.Substring(0, raw.Length - 1);
                        }
                    }
                    else
                    {
                        raw += btn.Text;
                        if (raw.Length > 8)
                        {
                            raw = raw.Substring(0, 8);
                        }
                    }

                    if (raw.Length >= 4)
                    {
                        lb_cusNum.Text = "010-" + raw.Substring(0, 4) + "-" + raw.Substring(4);
                    }
                    else
                    {
                        lb_cusNum.Text = "010-" + raw;
                    }
                }
                // tableLayoutPanel2의 버튼인 경우 lb_point(회원번호)에 입력
                else if (IsChildOf(btn, tableLayoutPanel2))
                {
                    if (btn.Text == "Clear ")
                    {
                        lb_point.Text = "";
                    }
                    else if (btn.Text == "<-")
                    {
                        if (lb_point.Text.Length > 0)
                        {
                            lb_point.Text = lb_point.Text.Substring(0, lb_point.Text.Length - 1);
                        }
                    }
                    else
                    {
                        // 회원번호 자릿수를 최대 4자리로 제한
                        if (lb_point.Text.Length < 4)
                        {
                            lb_point.Text += btn.Text;
                        }
                    }
                }
            }
        }







        // 특정 컨트롤이 특정 부모 컨트롤(패널 등)의 하위에 포함되어 있는지 확인하는 헬퍼 메서드
        private bool IsChildOf(Control child, Control parent)
        {
            Control current = child.Parent;
            while (current != null)
            {
                if (current == parent) return true;
                current = current.Parent;
            }
            return false;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_topEarn_Click(object sender, EventArgs e)
        {

        }

        private void btn_topEarn_Paint(object sender, PaintEventArgs e)
        {
            //Control ctrl = (Control)sender;
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //int radius = 15;

            //// 전체 컨트롤 크기 구하기
            //Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            //// 위쪽 양쪽 모서리만 둥글게 깎는 경로(Path) 정의
            //path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // 위쪽 왼쪽
            //path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // 위쪽 오른쪽
            //path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom); // 아래쪽은 직각 유지
            //path.CloseFigure();

            //// 주황색 배경 채우기 (현재 쓰신 주황색 RGB 값에 맞게 변경 가능)
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 128, 0)))
            //{
            //    e.Graphics.FillPath(brush, path);
            //}
            //ctrl.Region = new Region(path);


        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_topEarn_Click_1(object sender, EventArgs e)
        {

        }

        private void roundTopPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundToplabel1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStamp_Paint(object sender, PaintEventArgs e)
        {

        }


        /// <summary>
        /// MenuForm.cs에서 받은 주문테이블 정보(orderList)를 반환합니다.
        /// </summary>
        public List<sushikiosk.MenuForm.OrderItem> Get_orderList(){
            return this.orderList;
        }




        private void btn_del1_Click(object sender, EventArgs e)
        {
            pnlStamp.Hide();
            roundedPanel2.Show(); // 메인 선택 패널 다시 표시
        }
        //private void btn_dell1_Click(object sender, EventArgs e)
        //{
        //}

        private void btn_del2_Click(object sender, EventArgs e)
        {

            pnl_Pop_Membership.Hide();
            roundedPanel2.Show(); // 메인 선택 패널 다시 표시

        }

        protected override void ApplyLanguage()
        {
            int langIndex = LanguageManager.CurrentLanguageIndex;

            label4.Text = label4Texts[langIndex];
            label3.Text = label3Texts[langIndex];
            btn_PhoneSelect.Text = phoneSelectTexts[langIndex];
            btn_cusSelect.Text = cusSelectTexts[langIndex];
            btn_allDelete.Text = allDeleteTexts[langIndex];
            btn_back.Text = backTexts[langIndex];
            btn_receive.Text = receiveTexts[langIndex];
            lb_roundTop1.Text = roundTop1Texts[langIndex];
            lb_cusid.Text = cusIdTexts[langIndex];
            lb_cusid1.Text = cusId1Texts[langIndex];
            lb_phonenum.Text = phonenumTexts[langIndex];
            lb_sum.Text = sumTexts[langIndex];
            lb_cusName.Text = cusNameTexts[langIndex];
            lb_savePoint.Text = savePointTexts[langIndex];
            roundedToplabel1.Text = roundTop1Texts[langIndex];


            if (lb_cusid != null) lb_cusid.Text = lb_cusidTexts[langIndex];
            if (lb_cusid1 != null) lb_cusid1.Text = lb_cusid1Texts[langIndex];
            if (lb_sum1 != null) lb_sum1.Text = sumTexts[langIndex];
            if (lb_savePoint1 != null) lb_savePoint1.Text = savePointTexts[langIndex];
            if (lb_cusName1 != null) lb_cusName1.Text = cusNameTexts[langIndex];

            // 추가 구성 컨트롤 번역 대입
            if (btn_del2 != null) btn_del2.Text = del2Texts[langIndex];
            if (button32 != null) button32.Text = button32Texts[langIndex];
            if (btn_savepoint != null) btn_savepoint.Text = savepointTexts[langIndex];
            if (label2 != null) label2.Text = label2Texts[langIndex];
            if (label19 != null) label19.Text = label19Texts[langIndex];
            if (btn_del1 != null) btn_del1.Text = del1Texts[langIndex];
            if (button29 != null) button29.Text = searchTexts[langIndex];
            if (btn_save != null) btn_save.Text = saveTexts[langIndex];
            if (btn_receive != null) btn_receive.Text = receiveTexts[langIndex];
        }




        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           

            // 1. 원금 계산 (주문 정보 바탕)
            int originalAmount = 0;

            if (this.orderList != null && this.orderList.Count > 0)
            {
                originalAmount = this.orderList.Sum(item => item.Price * item.Quantity);
            }

            // 포인트 계산 (예: 결제 총액의 10%를 적립)
            int EarnedPoint = (int)(originalAmount * 0.1);

            // 2. 입력된 회원 번호 및 포인트 바인딩 정보 파싱
            string memberIdStr = lb_point.Text;
            int memberId = 0;
            int usedPoint = 0;

            // 디자이너의 텍스트 필드에서 가져옴 (숫자 판을 통해 입력된 값)
            if (!string.IsNullOrEmpty(memberIdStr))
            {
                int.TryParse(memberIdStr, out memberId);
            }

            // 디버그용 샘플 회원 DB 매칭 시뮬레이션
            int dbMemberId = 1001;      // 시뮬레이션 타겟 회원 ID
            int dbRemainingPoints = 5000; // 시뮬레이션 타겟 잔여 포인트
            //int 5000 = 
            string dbMemberName = "홍길동";

            // 만약 입력된 회원번호가 매칭된다면
            if (memberId == dbMemberId)
            {
                // 사용할 포인트 계산 (원금 한도 내에서 1000포인트 단위 단위 사용 예시)
                usedPoint = Math.Min(originalAmount, 2000); 
                
                // UI 바인딩
                if (tb_OriginalAmount != null) tb_OriginalAmount.Text = originalAmount.ToString();
                if (lb_UsedPoint != null) lb_UsedPoint.Text = usedPoint.ToString();
                if (lb_cusName1 != null) lb_cusName1.Text = dbMemberName;
                if (lb_savePoint1 != null) lb_savePoint1.Text = (dbRemainingPoints - usedPoint).ToString();
            }
            else
            {
                // 비회원 혹은 불일치 시
                usedPoint = 0;
                if (tb_OriginalAmount != null) tb_OriginalAmount.Text = originalAmount.ToString();
                if (lb_UsedPoint != null) lb_UsedPoint.Text = "0";
            }




            

            // 3. 결제 창(Payment) 객체를 생성하고 데이터 연동
            // Payment 생성자에 주문 목록과 전달할 회원/포인트 정보를 함께 파싱하여 넘겨줍니다.
            Payment pay_form = new Payment(this.orderList);
            
            // Payment 폼 내부에 포인트 관련 필드가 있다면 연동해 줍니다.
            // (Payment 클래스에 public 변수나 Property가 정의되어 있다면 반영)
            // pay_form.SetPaymentDetails(memberId, originalAmount, usedPoint); 

            pay_form.Show();
            this.Hide();

            MessageBox.Show($"{EarnedPoint} 포인트 적립 완료되었습니다 !");
        }

        private void btn_savepoint_Click(object sender, EventArgs e)
        {
            // 1. 원금 계산 (주문 정보 바탕)
            int originalAmount = 0;

            if (this.orderList != null && this.orderList.Count > 0)
            {
                originalAmount = this.orderList.Sum(item => item.Price * item.Quantity);
            }

            // 포인트 계산 (예: 결제 총액의 10%를 적립)
            int EarnedPoint = (int)(originalAmount * 0.1);

            // 2. 입력된 회원 번호 및 포인트 바인딩 정보 파싱
            string memberIdStr = lb_point.Text;
            int memberId = 0;
            int usedPoint = 0;

            // 디자이너의 텍스트 필드에서 가져옴 (숫자 판을 통해 입력된 값)
            if (!string.IsNullOrEmpty(memberIdStr))
            {
                int.TryParse(memberIdStr, out memberId);
            }

            // 디버그용 샘플 회원 DB 매칭 시뮬레이션
            int dbMemberId = 1001;      // 시뮬레이션 타겟 회원 ID
            int dbRemainingPoints = 5000; // 시뮬레이션 타겟 잔여 포인트
            //int 5000 = 
            string dbMemberName = "홍길동";

            // 만약 입력된 회원번호가 매칭된다면
            if (memberId == dbMemberId)
            {
                // 사용할 포인트 계산 (원금 한도 내에서 1000포인트 단위 단위 사용 예시)
                usedPoint = Math.Min(originalAmount, 2000);

                // UI 바인딩
                if (tb_OriginalAmount != null) tb_OriginalAmount.Text = originalAmount.ToString();
                if (lb_UsedPoint != null) lb_UsedPoint.Text = usedPoint.ToString();
                if (lb_cusName1 != null) lb_cusName1.Text = dbMemberName;
                if (lb_savePoint1 != null) lb_savePoint1.Text = (dbRemainingPoints - usedPoint).ToString();
            }
            else
            {
                // 비회원 혹은 불일치 시
                usedPoint = 0;
                if (tb_OriginalAmount != null) tb_OriginalAmount.Text = originalAmount.ToString();
                if (lb_UsedPoint != null) lb_UsedPoint.Text = "0";
            }






            // 3. 결제 창(Payment) 객체를 생성하고 데이터 연동
            // Payment 생성자에 주문 목록과 전달할 회원/포인트 정보를 함께 파싱하여 넘겨줍니다.
            Payment pay_form = new Payment(this.orderList);

            // Payment 폼 내부에 포인트 관련 필드가 있다면 연동해 줍니다.
            // (Payment 클래스에 public 변수나 Property가 정의되어 있다면 반영)
            // pay_form.SetPaymentDetails(memberId, originalAmount, usedPoint); 

            pay_form.Show();
            this.Hide();

            MessageBox.Show($"{EarnedPoint} 포인트 적립 완료되었습니다 !");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm mf= new MenuForm();
            mf.Show();
            this.Hide();
        }
    }
}