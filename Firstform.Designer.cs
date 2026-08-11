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
            panel3 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_herein
            // 
            btn_herein.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_herein.Location = new Point(0, 0);
            btn_herein.Name = "btn_herein";
            btn_herein.Size = new Size(210, 262);
            btn_herein.TabIndex = 0;
            btn_herein.Text = "매장 식사";
            btn_herein.UseVisualStyleBackColor = true;
            btn_herein.Click += btn_start_Click;
            // 
            // btn_togo
            // 
            btn_togo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_togo.Location = new Point(0, 3);
            btn_togo.Name = "btn_togo";
            btn_togo.Size = new Size(210, 262);
            btn_togo.TabIndex = 2;
            btn_togo.Text = "포장 주문";
            btn_togo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_herein);
            panel1.Controls.Add(btn_herein);
            panel1.Location = new Point(183, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 265);
            panel1.TabIndex = 4;
            // 
            // lb_herein
            // 
            lb_herein.BorderStyle = BorderStyle.FixedSingle;
            lb_herein.Location = new Point(43, 211);
            lb_herein.Name = "lb_herein";
            lb_herein.Size = new Size(115, 26);
            lb_herein.TabIndex = 6;
            lb_herein.Text = "Here In ! ";
            lb_herein.TextAlign = ContentAlignment.MiddleCenter;
            lb_herein.Click += btn_start_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_togo);
            panel2.Location = new Point(447, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 265);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(47, 211);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 7;
            label2.Text = "To go !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(488, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 39);
            panel3.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(205, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 10;
            button4.Text = "한국";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(105, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 35);
            button2.TabIndex = 10;
            button2.Text = "日本語";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(5, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 9;
            button1.Text = "English";
            button1.UseVisualStyleBackColor = true;
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 454);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Firstform";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_herein;
        private Button btn_togo;
        private Panel panel1;
        private Label lb_herein;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}
