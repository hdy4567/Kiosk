namespace sushikiosk
{
    partial class ReceiptForm
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
            lblTitle = new Label();
            lblOrderDate = new Label();
            txtReceipt = new TextBox();
            btnClose = new Button();
            lblReceiptTotal = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(139, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "주문 내역";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderDate.Location = new Point(100, 95);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(50, 20);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "label1";
            // 
            // txtReceipt
            // 
            txtReceipt.BackColor = Color.White;
            txtReceipt.BorderStyle = BorderStyle.None;
            txtReceipt.Location = new Point(2, 168);
            txtReceipt.Multiline = true;
            txtReceipt.Name = "txtReceipt";
            txtReceipt.ReadOnly = true;
            txtReceipt.Size = new Size(404, 163);
            txtReceipt.TabIndex = 1;
            txtReceipt.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(139, 428);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblReceiptTotal
            // 
            lblReceiptTotal.AutoSize = true;
            lblReceiptTotal.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblReceiptTotal.Location = new Point(12, 350);
            lblReceiptTotal.Name = "lblReceiptTotal";
            lblReceiptTotal.Size = new Size(116, 25);
            lblReceiptTotal.TabIndex = 0;
            lblReceiptTotal.Text = "총 금액 : 0원";
            lblReceiptTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "주문 일시 :";
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 508);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(txtReceipt);
            Controls.Add(lblReceiptTotal);
            Controls.Add(lblOrderDate);
            Controls.Add(lblTitle);
            Name = "ReceiptForm";
            Text = "ReceiptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrderDate;
        private TextBox txtReceipt;
        private Button btnClose;
        private Label lblReceiptTotal;
        private Label label1;
    }
}