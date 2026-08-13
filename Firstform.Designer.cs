namespace Kiosk
{
    partial class Firstform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_herein = new Button();
            btn_togo = new Button();
            panel1 = new Panel();
            lb_herein = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btn_KorCh = new Button();
            btn_JapCh = new Button();
            btn_EngCh = new Button();
            LanStatePanel = new Kiosk.Controls.RoundedPanel();
            label1 = new Label();
            roundedPanel1 = new Kiosk.Controls.RoundedPanel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            LanStatePanel.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_herein
            // 
            btn_herein.BackColor = Color.SandyBrown;
            btn_herein.Dock = DockStyle.Fill;
            btn_herein.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_herein.Location = new Point(0, 0);
            btn_herein.Margin = new Padding(4, 5, 4, 5);
            btn_herein.Name = "btn_herein";
            btn_herein.Size = new Size(447, 348);
            btn_herein.TabIndex = 0;
            btn_herein.Text = "매장 식사";
            btn_herein.UseVisualStyleBackColor = false;
            btn_herein.Click += btn_start_Click;
            // 
            // btn_togo
            // 
            btn_togo.BackColor = SystemColors.GradientActiveCaption;
            btn_togo.Dock = DockStyle.Fill;
            btn_togo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_togo.Location = new Point(0, 0);
            btn_togo.Name = "btn_togo";
            btn_togo.Size = new Size(444, 348);
            btn_togo.TabIndex = 2;
            btn_togo.Text = "포장 주문";
            btn_togo.UseVisualStyleBackColor = false;
            btn_togo.Click += btn_togo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_herein);
            panel1.Controls.Add(btn_herein);
            panel1.Location = new Point(104, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 348);
            panel1.TabIndex = 4;
            // 
            // lb_herein
            // 
            lb_herein.BackColor = Color.White;
            lb_herein.BorderStyle = BorderStyle.FixedSingle;
            lb_herein.Location = new Point(143, 193);
            lb_herein.Name = "lb_herein";
            lb_herein.Size = new Size(157, 75);
            lb_herein.TabIndex = 6;
            lb_herein.Text = "Here In ! ";
            lb_herein.TextAlign = ContentAlignment.MiddleCenter;
            lb_herein.Click += btn_start_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_togo);
            panel2.Location = new Point(606, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 348);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(152, 193);
            label2.Name = "label2";
            label2.Size = new Size(157, 75);
            label2.TabIndex = 7;
            label2.Text = "To go !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_KorCh
            // 
            btn_KorCh.BackColor = SystemColors.ActiveCaption;
            btn_KorCh.Location = new Point(220, 14);
            btn_KorCh.Name = "btn_KorCh";
            btn_KorCh.Size = new Size(94, 35);
            btn_KorCh.TabIndex = 10;
            btn_KorCh.Text = "한국";
            btn_KorCh.UseVisualStyleBackColor = false;
            // 
            // btn_JapCh
            // 
            btn_JapCh.BackColor = SystemColors.ActiveCaption;
            btn_JapCh.Location = new Point(116, 14);
            btn_JapCh.Name = "btn_JapCh";
            btn_JapCh.Size = new Size(94, 35);
            btn_JapCh.TabIndex = 10;
            btn_JapCh.Text = "日本語";
            btn_JapCh.UseVisualStyleBackColor = false;
            btn_JapCh.Click += btn_JapCh_Click;
            // 
            // btn_EngCh
            // 
            btn_EngCh.BackColor = SystemColors.ActiveCaption;
            btn_EngCh.Location = new Point(16, 14);
            btn_EngCh.Name = "btn_EngCh";
            btn_EngCh.Size = new Size(94, 35);
            btn_EngCh.TabIndex = 9;
            btn_EngCh.Text = "English";
            btn_EngCh.UseVisualStyleBackColor = false;
            // 
            // LanStatePanel
            // 
            LanStatePanel.BackColor = Color.White;
            LanStatePanel.BorderColor = Color.Black;
            LanStatePanel.BorderRadius = 90;
            LanStatePanel.BorderSize = 1F;
            LanStatePanel.BottomBorderRadius = 40;
            LanStatePanel.Controls.Add(btn_KorCh);
            LanStatePanel.Controls.Add(btn_EngCh);
            LanStatePanel.Controls.Add(btn_JapCh);
            LanStatePanel.Location = new Point(758, 0);
            LanStatePanel.Name = "LanStatePanel";
            LanStatePanel.RoundBottomLeft = true;
            LanStatePanel.RoundBottomRight = true;
            LanStatePanel.RoundTopLeft = true;
            LanStatePanel.RoundTopRight = true;
            LanStatePanel.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            LanStatePanel.ShadowDepth = 8;
            LanStatePanel.ShowShadow = true;
            LanStatePanel.Size = new Size(329, 62);
            LanStatePanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 71);
            label1.Name = "label1";
            label1.Size = new Size(430, 41);
            label1.TabIndex = 10;
            label1.Text = "원하시는 서비스를 선택해주세요! ";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Info;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderRadius = 90;
            roundedPanel1.BorderSize = 1F;
            roundedPanel1.BottomBorderRadius = 40;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(LanStatePanel);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(panel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Location = new Point(34, 31);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.RoundBottomLeft = true;
            roundedPanel1.RoundBottomRight = true;
            roundedPanel1.RoundTopLeft = true;
            roundedPanel1.RoundTopRight = true;
            roundedPanel1.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            roundedPanel1.ShadowDepth = 8;
            roundedPanel1.ShowShadow = true;
            roundedPanel1.Size = new Size(1144, 574);
            roundedPanel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(343, 112);
            label3.Name = "label3";
            label3.Size = new Size(430, 5);
            label3.TabIndex = 70;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(372, 66);
            label4.Name = "label4";
            label4.Size = new Size(366, 5);
            label4.TabIndex = 69;
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 93, 78);
            ClientSize = new Size(1219, 630);
            Controls.Add(roundedPanel1);
            Name = "Firstform";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            LanStatePanel.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_herein;
        private Button btn_togo;
        private Panel panel1;
        private Label lb_herein;
        private Panel panel2;
        private Label label2;
        private Button btn_KorCh;
        private Button btn_JapCh;
        private Button btn_EngCh;
        private Controls.RoundedPanel LanStatePanel;
        private Label label1;
        private Controls.RoundedPanel roundedPanel1;
        private Label label3;
        private Label label4;
    }
}
