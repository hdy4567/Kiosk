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
    public partial class Here_In : Form
    {
        public Here_In()
        {
            InitializeComponent();
            buttons_arrayform();
        }

        List<Button> buttons = new List<Button>();
        bool[] table_state = new bool[35];

        

        private void buttons_arrayform()
        {

            for (int i = 1; i <= 34; i++)
            {
                // 이름으로 컨트롤 검색 (예: "button1", "button2"...)
                Control[] found = this.Controls.Find($"button{i}", true);

                if (found.Length > 0 && found[0] is Button btn)
                {
                    btn.Tag = i; // 버튼 고유 번호(1~34)를 Tag에 저장 (클릭 시 식별용)

                    // 34개의 공용 클릭 이벤트 메서드를 연결합니다.
                    btn.Click += Here_In_Button_Click;

                    buttons.Add(btn); // 리스트에 버튼 추가
                }
            }
        }

        private void Here_In_Button_Click(object sender, EventArgs e)
        {
            Button clicked_Button = sender as Button;
            if (clicked_Button == null) return;

            // 버튼의 Tag에 저장해둔 고유 인덱스 번호(1~34) 가져오기
            int btn_Index = (int)clicked_Button.Tag;
            
            // 해당 버튼의 상태를 토글(클릭할 때마다 true/false 전환) 또는 true로 고정
            // 여기서는 클릭 시 true로 변경하고 이미지를 바꾸는 예시입니다.
            table_state[btn_Index] = true;
            clicked_Button.BackColor = Color.LightSteelBlue;

            // 클릭된 해당 버튼의 이미지 교체 및 시각 효과 변경
            // (Properties.Resources에 'SelectedImage'라는 이미지가 등록되어 있어야 합니다)
            //clickedButton.BackgroundImage = Properties.Resources.SelectedImage;

            MessageBox.Show($"{btn_Index}번 테이블이 선택되었습니다. 상태: {table_state[btn_Index]}");
        }


    }
}
