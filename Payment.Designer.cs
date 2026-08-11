namespace Kiosk
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            button7 = new Button();
            label3 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(264, 426);
            button6.Name = "button6";
            button6.Size = new Size(200, 68);
            button6.TabIndex = 20;
            button6.Text = "이전";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(155, 426);
            button5.Name = "button5";
            button5.Size = new Size(103, 68);
            button5.TabIndex = 19;
            button5.Text = "전체 취소";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(345, 98);
            button4.Name = "button4";
            button4.Size = new Size(186, 91);
            button4.TabIndex = 18;
            button4.Text = "카카오 페이";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(250, 98);
            button3.Name = "button3";
            button3.Size = new Size(89, 91);
            button3.TabIndex = 16;
            button3.Text = "네이버 페이";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(153, 98);
            button2.Name = "button2";
            button2.Size = new Size(89, 91);
            button2.TabIndex = 15;
            button2.Text = "카드 결제";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(153, 67);
            label2.Name = "label2";
            label2.Size = new Size(378, 28);
            label2.TabIndex = 14;
            label2.Text = "결제 방식";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(135, 17);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(135, 32);
            label4.Name = "label4";
            label4.Size = new Size(249, 23);
            label4.TabIndex = 22;
            label4.Text = "결제 방식을 선택해주세요 ! ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(135, 17);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 21;
            label5.Text = "Step2.";
            // 
            // button7
            // 
            button7.Location = new Point(153, 195);
            button7.Name = "button7";
            button7.Size = new Size(186, 91);
            button7.TabIndex = 23;
            button7.Text = "삼성페이";
            button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(153, 298);
            label3.Name = "label3";
            label3.Size = new Size(378, 28);
            label3.TabIndex = 24;
            label3.Text = "상품권 결제";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            button8.Location = new Point(153, 329);
            button8.Name = "button8";
            button8.Size = new Size(186, 91);
            button8.TabIndex = 25;
            button8.Text = "쿠폰 / 상품권 복합 결제";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(button8);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button button7;
        private Label label3;
        private Button button8;
    }
}