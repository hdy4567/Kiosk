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
using System.Drawing.Drawing2D;

namespace Kiosk
{
    public partial class Payment : Form
    {
        private string selectedPaymentMethod = "";

        // 다국어 텍스트 정의 (0: 영어, 1: 일본어, 2: 한국어)
        private readonly string[] label4Texts = { "Please select a payment method!", "お支払い方法を選択してください！", "결제 방식을 선택해주세요 !" };
        private readonly string[] label2Texts = { "Payment Method", "お支払い方法", "결제 방식" };
        private readonly string[] label3Texts = { "Voucher Payment", "商品券決済", "상품권 결제" };
        private readonly string[] cardTexts = { "Card Payment", "カード決済", "카드 결제" };
        private readonly string[] naverTexts = { "Naver Pay", "ネイバーペイ", "네이버 페이" };
        private readonly string[] kakaoTexts = { "Kakao Pay", "カカオペイ", "카카오 페이" };
        private readonly string[] samsungTexts = { "Samsung Pay", "サムスンペイ", "삼성페이" };
        private readonly string[] couponTexts = { "Coupon / Voucher", "クーポン・商品券", "쿠폰 / 상품권 복합 결제" };
        private readonly string[] allDeleteTexts = { "Cancel All", "すべて取消", "전체 취소" };
        private readonly string[] backTexts = { "Back", "戻る", "이전" };

        // 회원 및 적립 관련 다국어 텍스트 정의 (0: 영어, 1: 일본어, 2: 한국어)
        private readonly string[] cusIdTexts = { "Member ID", "会員番号", "회원번호" };
        private readonly string[] phonenumTexts = { "Phone Number", "携帯電話番号", "휴대폰 번호" };
        private readonly string[] sumTexts = { "Total Amount", "対象金額", "대상금액" };
        private readonly string[] cusNameTexts = { "Member Name", "会員名", "회원명" };
        private readonly string[] savePointTexts = { "Remaining Points", "残高ポイント", "잔여 포인트" };
        private readonly string[] del2Texts = { "Delete", "削除", "삭제" };
        private readonly string[] button32Texts = { "Cancel", "キャンセル", "취소" };
        private readonly string[] savepointTexts = { "Earn Points", "ポイント積立", "포인트 적립" };
        private readonly string[] receiveTexts = { "Earn Complete", "積立完了", "적립 완료" };

        // 동적으로 추가될 수 있는 회원/적립 관련 예비 컨트롤 필드 선언 (컴파일 오류 방지)
        private Label lb_cusId;
        private Label lb_phonenum;
        private Label lb_sum;
        private Label lb_cusName;
        private Label lb_savePoint;
        private Button btn_del2;
        private Button button32;
        private Button btn_savepoint;
        private Button btn_receive;

        public class DB_return
        {

            public int UsedPoint; //사용한 포인트
            public int TotalAmount; // 정가 총합
            public int EarnedPoint { get; set; } // 이번 결제로 적립한 포인트
            public int MemberId { get; set; } // 회원번호(비회원은 0)
            public string PaymentMethod { get; set; } // 결제 수단(신용카드, 앱선결제 등)
        }





        public class ReceiptItem
        {
            public string MenuName { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public int DiscountQty { get; set; }
            public string Category { get; set; }

            public int SubTotal
            {
                get { return Price * (Quantity - DiscountQty); }
            }
        }

        public class ReceiptData
        {
            public string ReceiptNo { get; set; }
            public DateTime PaymentTime { get; set; }
            public string OrderType { get; set; }
            public string PaymentMethod { get; set; }
            public int TotalAmount { get; set; }
            public List<ReceiptItem> Items { get; set; }
        }

        public Payment()
        {
            InitializeComponent();

            // 언어 변경 이벤트 구독
            LanguageManager.LanguageChanged += ApplyLanguage;

            // 폼이 닫힐 때 이벤트 구독 해제 (메모리 누수 방지)
            this.FormClosed += (s, e) =>
            {
                LanguageManager.LanguageChanged -= ApplyLanguage;
            };

            // 최초 1회 현재 언어 적용
            ApplyLanguage();
        }

        // MenuForm에서 누적되어 전달된 주문 항목 보관용 필드
        private List<sushikiosk.MenuForm.OrderItem> receivedOrderList = new List<sushikiosk.MenuForm.OrderItem>();

        // 회원 정보 및 결제 연계 변수
        public int memberId = 0;
        public int usedPoint = 0;
        public string customerPhoneNumber = "";

        // Pop_MemberNum 또는 외부에서 주문 내역을 함께 넘겨받는 생성자 오버로드
        public Payment(List<sushikiosk.MenuForm.OrderItem> orders) : this()
        {
            this.receivedOrderList = orders;
        }

        public void SetPaymentDetails(int memberId, int usedPoint, string phoneNumber, int originalAmount)
        {
            this.memberId = memberId;
            this.usedPoint = usedPoint;
            this.customerPhoneNumber = phoneNumber;
        }





        private void ApplyLanguage()
        {
            int langIndex = LanguageManager.CurrentLanguageIndex;

            if (label4 != null) label4.Text = label4Texts[langIndex];
            if (label2 != null) label2.Text = label2Texts[langIndex];
            if (label3 != null) label3.Text = label3Texts[langIndex];
            if (btn_card != null) btn_card.Text = cardTexts[langIndex];
            if (btn_naverPay != null) btn_naverPay.Text = naverTexts[langIndex];
            if (btn_KakaoPay != null) btn_KakaoPay.Text = kakaoTexts[langIndex];
            if (btn_SamsungPay != null) btn_SamsungPay.Text = samsungTexts[langIndex];
            if (btn_coupon != null) btn_coupon.Text = couponTexts[langIndex];
            if (btn_allDelete != null) btn_allDelete.Text = allDeleteTexts[langIndex];
            if (btn_back != null) btn_back.Text = backTexts[langIndex];

            // 회원 및 적립 관련 컨트롤 다국어 바인딩 (직접 조건문 검사)
            if (lb_cusId != null) lb_cusId.Text = cusIdTexts[langIndex];
            if (lb_phonenum != null) lb_phonenum.Text = phonenumTexts[langIndex];
            if (lb_sum != null) lb_sum.Text = sumTexts[langIndex];
            if (lb_cusName != null) lb_cusName.Text = cusNameTexts[langIndex];
            if (lb_savePoint != null) lb_savePoint.Text = savePointTexts[langIndex];
            if (btn_del2 != null) btn_del2.Text = del2Texts[langIndex];
            if (button32 != null) button32.Text = button32Texts[langIndex];
            if (btn_savepoint != null) btn_savepoint.Text = savepointTexts[langIndex];
            if (btn_receive != null) btn_receive.Text = receiveTexts[langIndex];
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // 결제 버튼 이벤트 동적 연결
            //if (btn_card != null) btn_card.Click += (s, ev) => SendPaymentRequest("Card");
            //if (btn_naverPay != null) btn_naverPay.Click += (s, ev) => SendPaymentRequest("NaverPay");
            //if (btn_KakaoPay != null) btn_KakaoPay.Click += (s, ev) => SendPaymentRequest("KakaoPay");
            //if (btn_SamsungPay != null) btn_SamsungPay.Click += (s, ev) => SendPaymentRequest("SamsungPay");

            roundedPanel2.Hide();

            // 영수증 패널 배경
            roundedPanel2.BackColor = Color.White;

            // 영수증 내용 영역 배경
            richTextBox1.BackColor = Color.White;

            richTextBox1.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// MenuForm에서 받은 주문테이블 정보 (orderList)를 받아서,
        /// 결제 방식 버튼 클릭 시, 
        /// 클라이언트 또는 DB에 결제 요청을 전송하는 공통 메서드입니다.
        /// </summary>
        /// <param name="paymentMethod">결제 방식 (Card, NaverPay, KakaoPay, SamsungPay 등)</param>
        private void SendPaymentRequest(string paymentMethod)
        {
            try
            {

                //MessageBox.Show(statusMessages[langIndex], "Payment Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // [디버깅 용영역]: 전달된 데이터가 잘 매핑되었는지 로그 및 메시지박스로 검증
                int totalAmount = 0;
                string itemsSummary = "";

                if (receivedOrderList != null && receivedOrderList.Count > 0)
                {
                    totalAmount = receivedOrderList.Sum(item => item.Price * item.Quantity);
                    itemsSummary = string.Join("\n", receivedOrderList.Select(item =>
                        $"- {item.Name}: {item.Price}원 x {item.Quantity}개 = {item.Price * item.Quantity}원 (이벤트 여부: {item.IsFree})"));
                }
                else
                {
                    itemsSummary = "(장바구니가 비어 있습니다)";
                }

                // 1단계 주문 데이터(NEW_ORDER) 규격 디버깅용 JSON 생성 시뮬레이션
                var debugOrderData = new
                {
                    Action = "NEW_ORDER",
                    Identifier = "T02-01",
                    Source = "키오스크",
                    OrderType = "매장",
                    OrderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    TotalAmount = totalAmount,
                    Status = "조리 중",
                    Items = receivedOrderList.Select(i => new
                    {
                        MenuName = i.Name,
                        Price = i.Price,
                        Quantity = i.Quantity,
                        DiscountQty = i.IsFree ? i.Quantity : 0,
                        SubTotal = i.Price * i.Quantity
                    }).ToList()
                };

                // 2단계 결제 데이터(PAYMENT_COMPLETE) 규격 디버깅용 JSON 생성 시뮬레이션
                // 회원번호나 포인트 사용량이 연계되어 있을 경우를 가정하여 작성합니다.
                int debugMemberId = 1001;
                int usedPoint = 0;
                int finalTotalAmount = totalAmount - usedPoint;

                var debugPaymentData = new
                {
                    Action = "PAYMENT_COMPLETE",
                    Identifier = "T02-01",
                    MemberId = debugMemberId,
                    OriginalAmount = totalAmount,
                    UsedPoint = usedPoint,
                    TotalAmount = finalTotalAmount,
                    PaymentMethod = paymentMethod == "Card" ? "신용카드" :
                                    paymentMethod == "NaverPay" ? "네이버페이" :
                                    paymentMethod == "KakaoPay" ? "카카오페이" : paymentMethod
                };

                // JSON 문자열 변환 검증 (System.Text.Json 사용)
                string orderJsonStr = System.Text.Json.JsonSerializer.Serialize(debugOrderData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                string paymentJsonStr = System.Text.Json.JsonSerializer.Serialize(debugPaymentData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                // 디버깅 정보를 콘솔/출력창에 로깅
                System.Diagnostics.Debug.WriteLine("========= [KIOSK DEBUG START] =========");
                System.Diagnostics.Debug.WriteLine($"결제 수단: {paymentMethod}");
                System.Diagnostics.Debug.WriteLine($"총 결제 금액: {totalAmount}원");
                System.Diagnostics.Debug.WriteLine($"주문 상세 리스트:\n{itemsSummary}");
                System.Diagnostics.Debug.WriteLine($"[1단계 주문 전송 JSON]:\n{orderJsonStr}");
                System.Diagnostics.Debug.WriteLine($"[2단계 결제 완료 JSON]:\n{paymentJsonStr}");
                System.Diagnostics.Debug.WriteLine("========= [KIOSK DEBUG END] =========");

                // --- [서버 연동 시뮬레이션 코드 추가] ---
                // 1. 관리자 폼으로부터 받은 가상 응답 문자열 (JSON 규격)
                int calculatedEarnedPoint = (int)(totalAmount * 0.01); // 10% 적립
                string simulatedServerResponse = $"{{\n  \"Status\": \"SUCCESS\",\n  \"ReceiptNo\": \"ORD-20260814-001\",\n  \"UsedPoint\": {usedPoint},\n  \"EarnedPoint\": {calculatedEarnedPoint},\n  \"Message\": \"Payment processed successfully.\"\n}}";

                // 2. 서버로부터 수신한 JSON 응답 데이터 파싱
                using (System.Text.Json.JsonDocument responseDoc = System.Text.Json.JsonDocument.Parse(simulatedServerResponse))
                {
                    string status = responseDoc.RootElement.GetProperty("Status").GetString();
                    string message = responseDoc.RootElement.GetProperty("Message").GetString();
                    string receiptNo = responseDoc.RootElement.TryGetProperty("ReceiptNo", out var receiptProp) ? receiptProp.GetString() : "";

                    if (status == "SUCCESS")
                    {
                        // 3. 수신 성공 시 키오스크 화면에 성공 알림 팝업 노출 (적립/사용 포인트 포함)
                        int resUsedPoint = responseDoc.RootElement.TryGetProperty("UsedPoint", out var usedProp) ? usedProp.GetInt32() : 0;
                        int resEarnedPoint = responseDoc.RootElement.TryGetProperty("EarnedPoint", out var earnedProp) ? earnedProp.GetInt32() : 0;

                        string popupMessage = $"[결제 및 주문 성공]\n\n" +
                                             $"상태: 성공했습니다 (SUCCESS)\n" +
                                             $"영수증 번호: {receiptNo}\n" +
                                             $"서버 메시지: {message}\n\n" +
                                             $"결제수단: {paymentMethod}\n" +
                                             $"원금 금액: {totalAmount:N0}원\n" +
                                             $"사용된 포인트: -{resUsedPoint:N0} P\n" +
                                             $"최종 결제 금액: {finalTotalAmount:N0}원\n" +
                                             $"이번에 적립된 포인트: +{resEarnedPoint:N0} P";

                        MessageBox.Show(popupMessage, "관리자 응답 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("결제 요청에 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"디버깅 및 서버 연동 시뮬레이션 중 오류 발생: {ex.Message}");
            }
        }


        private ReceiptData CreateReceipt(string paymentMethod)
        {
            List<ReceiptItem> items = new List<ReceiptItem>();

            foreach (sushikiosk.MenuForm.OrderItem order in receivedOrderList)
            {
                ReceiptItem receiptItem = new ReceiptItem
                {
                    // 당첨된 메뉴라면 이름 뒤에 표시
                    MenuName = order.IsFree
                        ? order.Name + " (당첨!)"
                        : order.Name,

                    Price = order.Price,
                    Quantity = order.Quantity,

                    // 당첨 메뉴는 전체 수량을 무료 처리
                    DiscountQty = order.IsFree
                        ? order.Quantity
                        : 0,

                    Category = order.Category
                };

                items.Add(receiptItem);
            }

            return new ReceiptData
            {
                // 관리자 TCP 연결 전 임시값
                ReceiptNo = "ORD-TEST-001",
                PaymentTime = DateTime.Now,
                OrderType = "매장",
                PaymentMethod = paymentMethod,

                // 무료 당첨 메뉴는 SubTotal이 0이므로 자동 제외
                TotalAmount = items.Sum(item => item.SubTotal),

                Items = items
            };
        }



        private void ShowReceipt(ReceiptData receipt)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==========================================");
            sb.AppendLine();
            sb.AppendLine("          [ 초밥 키오스크 영수증 ]");
            sb.AppendLine();
            sb.AppendLine("==========================================");
            sb.AppendLine();

            sb.AppendLine("영수증번호 : " + receipt.ReceiptNo);
            sb.AppendLine(
                "결제일시   : " +
                receipt.PaymentTime.ToString("yyyy-MM-dd HH:mm:ss"));

            sb.AppendLine(
                "주문유형   : [키오스크] - " +
                receipt.OrderType);

            sb.AppendLine();
            sb.AppendLine("==========================================");
            sb.AppendLine();

            sb.AppendLine("상품명\t수량\t금액");
            sb.AppendLine();

            foreach (ReceiptItem item in receipt.Items)
            {
                string unit;

                if (item.Category == "활어/참치" ||
                    item.Category == "해산물" ||
                    item.Category == "롤/마끼" ||
                    item.Category == "단품/기타초밥")
                {
                    unit = "접시";
                }
                else
                {
                    unit = "개";
                }

                sb.AppendLine(
                    $"{item.MenuName}\t{item.Quantity}{unit}\t{item.SubTotal:N0}원"
                );
            }

            sb.AppendLine();
            sb.AppendLine("==========================================");
            sb.AppendLine();

            sb.AppendLine(
                "합계금액 : " + receipt.TotalAmount.ToString("N0") + "원");

            sb.AppendLine(
                "결제수단 : " +
                receipt.PaymentMethod);

            sb.AppendLine();
            sb.AppendLine("==========================================");
            sb.AppendLine();
            sb.AppendLine("          이용해 주셔서 감사합니다!");
            sb.AppendLine();
            sb.AppendLine("==========================================");

            richTextBox1.Text = sb.ToString();

            richTextBox1.SelectAll();

            richTextBox1.SelectionTabs = new int[]
            {
                210,    // 수량 열 시작 위치
                300     // 금액 열 시작 위치
            };

            richTextBox1.DeselectAll();

        }

        private void RoundRichTextBox()
        {
            int radius = 80;

            Rectangle rect = new Rectangle(
                0,
                0,
                richTextBox1.Width,
                richTextBox1.Height
            );

            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            richTextBox1.Region = new Region(path);
        }

        private void CompletePayment(string paymentMethod)
        {
            if (receivedOrderList == null || receivedOrderList.Count == 0)
            {
                MessageBox.Show("주문 내역이 없습니다.");
                return;
            }

            selectedPaymentMethod = paymentMethod;

            // 실제 주문내역으로 영수증 생성
            ReceiptData receipt = CreateReceipt(selectedPaymentMethod);

            ShowReceipt(receipt);

            roundedPanel2.Show();
            roundedPanel2.BringToFront();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Pop_MemberNum memeber = new Pop_MemberNum(this.receivedOrderList);
            memeber.Show();
            this.Hide();
        }

        private void btn_card_Click_1(object sender, EventArgs e)
        {
            CompletePayment("신용카드");
        }

        private void btn_naverPay_Click_1(object sender, EventArgs e)
        {
            CompletePayment("네이버페이");
        }

        private void btn_KakaoPay_Click_1(object sender, EventArgs e)
        {
            CompletePayment("카카오페이");

        }

        private void btn_SamsungPay_Click_1(object sender, EventArgs e)
        {
            CompletePayment("삼성페이");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 쿠폰 / 상품권 클릭 시 결제 처리
            CompletePayment("쿠폰 / 상품권");
        }
    }
}
