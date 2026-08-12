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
    public partial class Payment : Form
    {
        // 결제 방식 선택 안내 문구 열거형 배열 (0: 영어, 1: 일본어, 2: 한국어)
        private readonly string[] label4Texts = {
            "Please select a payment method!", "お支払い方法を選択してください！", "결제 방식을 선택해주세요 !"
        };

        public Payment()
        {
            InitializeComponent();

            // 언어 변경 이벤트 구독
            LanguageManager.LanguageChanged += ApplyLanguage;

            // 폼이 닫힐 때 이벤트 구독 해제 (메모리 누수 방지)
            this.FormClosed += (s, e) => {
                LanguageManager.LanguageChanged -= ApplyLanguage;
            };

            // 최초 1회 현재 언어 적용
            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            int langIndex = LanguageManager.CurrentLanguageIndex;
                label4.Text = label4Texts[langIndex];

            
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
