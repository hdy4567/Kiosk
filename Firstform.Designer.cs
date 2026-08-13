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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            LanStatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_herein
            // 
            btn_herein.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_herein.Location = new Point(4, 0);
            btn_herein.Margin = new Padding(4, 5, 4, 5);
            btn_herein.Name = "btn_herein";
            btn_herein.Size = new Size(397, 595);
            btn_herein.TabIndex = 0;
            btn_herein.Text = "매장 식사";
            btn_herein.UseVisualStyleBackColor = true;
            btn_herein.Click += btn_start_Click;
            // 
            // btn_togo
            // 
            btn_togo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_togo.Location = new Point(0, 5);
            btn_togo.Margin = new Padding(4, 5, 4, 5);
            btn_togo.Name = "btn_togo";
            btn_togo.Size = new Size(397, 590);
            btn_togo.TabIndex = 2;
            btn_togo.Text = "포장 주문";
            btn_togo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_herein);
            panel1.Controls.Add(btn_herein);
            panel1.Location = new Point(164, 205);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 600);
            panel1.TabIndex = 4;
            // 
            // lb_herein
            // 
            lb_herein.BorderStyle = BorderStyle.FixedSingle;
            lb_herein.Location = new Point(117, 370);
            lb_herein.Margin = new Padding(4, 0, 4, 0);
            lb_herein.Name = "lb_herein";
            lb_herein.Size = new Size(178, 60);
            lb_herein.TabIndex = 6;
            lb_herein.Text = "Here In ! ";
            lb_herein.TextAlign = ContentAlignment.MiddleCenter;
            lb_herein.Click += btn_start_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_togo);
            panel2.Location = new Point(644, 205);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 600);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(117, 370);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 60);
            label2.TabIndex = 7;
            label2.Text = "To go !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_KorCh
            // 
            btn_KorCh.Location = new Point(309, 23);
            btn_KorCh.Margin = new Padding(4, 5, 4, 5);
            btn_KorCh.Name = "btn_KorCh";
            btn_KorCh.Size = new Size(134, 58);
            btn_KorCh.TabIndex = 10;
            btn_KorCh.Text = "한국";
            btn_KorCh.UseVisualStyleBackColor = true;
            // 
            // btn_JapCh
            // 
            btn_JapCh.Location = new Point(166, 23);
            btn_JapCh.Margin = new Padding(4, 5, 4, 5);
            btn_JapCh.Name = "btn_JapCh";
            btn_JapCh.Size = new Size(134, 58);
            btn_JapCh.TabIndex = 10;
            btn_JapCh.Text = "日本語";
            btn_JapCh.UseVisualStyleBackColor = true;
            // 
            // btn_EngCh
            // 
            btn_EngCh.Location = new Point(23, 23);
            btn_EngCh.Margin = new Padding(4, 5, 4, 5);
            btn_EngCh.Name = "btn_EngCh";
            btn_EngCh.Size = new Size(134, 58);
            btn_EngCh.TabIndex = 9;
            btn_EngCh.Text = "English";
            btn_EngCh.UseVisualStyleBackColor = true;
            // 
            // LanStatePanel
            // 
            LanStatePanel.BorderColor = Color.Black;
            LanStatePanel.BorderRadius = 90;
            LanStatePanel.BorderSize = 1F;
            LanStatePanel.BottomBorderRadius = 40;
            LanStatePanel.Controls.Add(btn_KorCh);
            LanStatePanel.Controls.Add(btn_EngCh);
            LanStatePanel.Controls.Add(btn_JapCh);
            LanStatePanel.Location = new Point(674, 20);
            LanStatePanel.Margin = new Padding(4, 5, 4, 5);
            LanStatePanel.Name = "LanStatePanel";
            LanStatePanel.RoundBottomLeft = true;
            LanStatePanel.RoundBottomRight = true;
            LanStatePanel.RoundTopLeft = true;
            LanStatePanel.RoundTopRight = true;
            LanStatePanel.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            LanStatePanel.ShadowDepth = 8;
            LanStatePanel.ShowShadow = true;
            LanStatePanel.Size = new Size(470, 103);
            LanStatePanel.TabIndex = 9;
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 1050);
            Controls.Add(LanStatePanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Firstform";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            LanStatePanel.ResumeLayout(false);
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
    }
}
