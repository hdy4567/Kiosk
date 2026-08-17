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
            btn_waiting = new Kiosk.Controls.RoundedButton();
            label3 = new Label();
            label4 = new Label();
            pnl_queue = new Kiosk.Controls.RoundedPanel();
            pnl_inputNum = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btn_inputQueue = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            pnl_inputNumArray = new Kiosk.Controls.RoundedPanel();
            roundedButton1 = new Kiosk.Controls.RoundedButton();
            textBox1 = new TextBox();
            btn_inputNumArray8 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray7 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray6 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray5 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray4 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray3 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray2 = new Kiosk.Controls.RoundedButton();
            btn_inputNumArray1 = new Kiosk.Controls.RoundedButton();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            LanStatePanel.SuspendLayout();
            roundedPanel1.SuspendLayout();
            pnl_queue.SuspendLayout();
            pnl_inputNum.SuspendLayout();
            pnl_inputNumArray.SuspendLayout();
            SuspendLayout();
            // 
            // btn_herein
            // 
            btn_herein.BackColor = Color.SandyBrown;
            btn_herein.Dock = DockStyle.Fill;
            btn_herein.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_herein.Location = new Point(0, 0);
            btn_herein.Margin = new Padding(6, 8, 6, 8);
            btn_herein.Name = "btn_herein";
            btn_herein.Size = new Size(639, 580);
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
            btn_togo.Margin = new Padding(4, 5, 4, 5);
            btn_togo.Name = "btn_togo";
            btn_togo.Size = new Size(634, 580);
            btn_togo.TabIndex = 2;
            btn_togo.Text = "포장 주문";
            btn_togo.UseVisualStyleBackColor = false;
            btn_togo.Click += btn_togo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_herein);
            panel1.Controls.Add(btn_herein);
            panel1.Location = new Point(149, 237);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 580);
            panel1.TabIndex = 4;
            // 
            // lb_herein
            // 
            lb_herein.BackColor = Color.White;
            lb_herein.BorderStyle = BorderStyle.FixedSingle;
            lb_herein.Location = new Point(204, 322);
            lb_herein.Margin = new Padding(4, 0, 4, 0);
            lb_herein.Name = "lb_herein";
            lb_herein.Size = new Size(223, 124);
            lb_herein.TabIndex = 6;
            lb_herein.Text = "Here In ! ";
            lb_herein.TextAlign = ContentAlignment.MiddleCenter;
            lb_herein.Click += btn_start_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_togo);
            panel2.Location = new Point(866, 237);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 580);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(217, 322);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 124);
            label2.TabIndex = 7;
            label2.Text = "To go !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_KorCh
            // 
            btn_KorCh.BackColor = SystemColors.ActiveCaption;
            btn_KorCh.Location = new Point(314, 23);
            btn_KorCh.Margin = new Padding(4, 5, 4, 5);
            btn_KorCh.Name = "btn_KorCh";
            btn_KorCh.Size = new Size(134, 58);
            btn_KorCh.TabIndex = 10;
            btn_KorCh.Text = "한국";
            btn_KorCh.UseVisualStyleBackColor = false;
            // 
            // btn_JapCh
            // 
            btn_JapCh.BackColor = SystemColors.ActiveCaption;
            btn_JapCh.Location = new Point(166, 23);
            btn_JapCh.Margin = new Padding(4, 5, 4, 5);
            btn_JapCh.Name = "btn_JapCh";
            btn_JapCh.Size = new Size(134, 58);
            btn_JapCh.TabIndex = 10;
            btn_JapCh.Text = "日本語";
            btn_JapCh.UseVisualStyleBackColor = false;
            btn_JapCh.Click += btn_JapCh_Click;
            // 
            // btn_EngCh
            // 
            btn_EngCh.BackColor = SystemColors.ActiveCaption;
            btn_EngCh.Location = new Point(23, 23);
            btn_EngCh.Margin = new Padding(4, 5, 4, 5);
            btn_EngCh.Name = "btn_EngCh";
            btn_EngCh.Size = new Size(134, 58);
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
            LanStatePanel.Location = new Point(1083, 0);
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
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(490, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(648, 68);
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
            roundedPanel1.Controls.Add(btn_waiting);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(LanStatePanel);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(panel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Location = new Point(49, 52);
            roundedPanel1.Margin = new Padding(4, 5, 4, 5);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.RoundBottomLeft = true;
            roundedPanel1.RoundBottomRight = true;
            roundedPanel1.RoundTopLeft = true;
            roundedPanel1.RoundTopRight = true;
            roundedPanel1.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            roundedPanel1.ShadowDepth = 8;
            roundedPanel1.ShowShadow = true;
            roundedPanel1.Size = new Size(1634, 957);
            roundedPanel1.TabIndex = 11;
            // 
            // btn_waiting
            // 
            btn_waiting.BackColor = Color.Crimson;
            btn_waiting.BorderColor = Color.Black;
            btn_waiting.BorderRadius = 40;
            btn_waiting.BorderSize = 2F;
            btn_waiting.FlatAppearance.BorderSize = 0;
            btn_waiting.FlatStyle = FlatStyle.Flat;
            btn_waiting.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_waiting.ForeColor = Color.Black;
            btn_waiting.Location = new Point(430, 828);
            btn_waiting.Name = "btn_waiting";
            btn_waiting.Size = new Size(783, 99);
            btn_waiting.TabIndex = 71;
            btn_waiting.Text = "웨이팅";
            btn_waiting.UseVisualStyleBackColor = false;
            btn_waiting.Click += btn_waiting_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(490, 187);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(614, 8);
            label3.TabIndex = 70;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(531, 110);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(523, 8);
            label4.TabIndex = 69;
            // 
            // pnl_queue
            // 
            pnl_queue.BackColor = SystemColors.Window;
            pnl_queue.BorderColor = Color.Black;
            pnl_queue.BorderRadius = 90;
            pnl_queue.BorderSize = 1F;
            pnl_queue.BottomBorderRadius = 40;
            pnl_queue.Controls.Add(pnl_inputNum);
            pnl_queue.Controls.Add(pnl_inputNumArray);
            pnl_queue.Controls.Add(label6);
            pnl_queue.Location = new Point(64, 55);
            pnl_queue.Name = "pnl_queue";
            pnl_queue.RoundBottomLeft = true;
            pnl_queue.RoundBottomRight = true;
            pnl_queue.RoundTopLeft = true;
            pnl_queue.RoundTopRight = true;
            pnl_queue.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            pnl_queue.ShadowDepth = 8;
            pnl_queue.ShowShadow = true;
            pnl_queue.Size = new Size(1619, 954);
            pnl_queue.TabIndex = 72;
            // 
            // pnl_inputNum
            // 
            pnl_inputNum.BackColor = SystemColors.ActiveCaptionText;
            pnl_inputNum.ColumnCount = 3;
            pnl_inputNum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnl_inputNum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnl_inputNum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnl_inputNum.Controls.Add(button1, 0, 0);
            pnl_inputNum.Controls.Add(button2, 2, 0);
            pnl_inputNum.Controls.Add(button3, 0, 1);
            pnl_inputNum.Controls.Add(button4, 1, 1);
            pnl_inputNum.Controls.Add(button5, 2, 1);
            pnl_inputNum.Controls.Add(button6, 0, 2);
            pnl_inputNum.Controls.Add(button7, 1, 2);
            pnl_inputNum.Controls.Add(button8, 2, 2);
            pnl_inputNum.Controls.Add(btn_inputQueue, 2, 4);
            pnl_inputNum.Controls.Add(button10, 2, 3);
            pnl_inputNum.Controls.Add(button12, 1, 3);
            pnl_inputNum.Controls.Add(button13, 0, 3);
            pnl_inputNum.Controls.Add(button14, 1, 4);
            pnl_inputNum.Controls.Add(button15, 0, 4);
            pnl_inputNum.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            pnl_inputNum.Location = new Point(1047, 290);
            pnl_inputNum.Margin = new Padding(4, 5, 4, 5);
            pnl_inputNum.Name = "pnl_inputNum";
            pnl_inputNum.RowCount = 5;
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnl_inputNum.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnl_inputNum.Size = new Size(502, 573);
            pnl_inputNum.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            pnl_inputNum.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(4, 5);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(326, 104);
            button1.TabIndex = 6;
            button1.Text = "Clear ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(338, 5);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(160, 90);
            button2.TabIndex = 16;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(4, 119);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(159, 104);
            button3.TabIndex = 21;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(171, 119);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(159, 104);
            button4.TabIndex = 18;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(338, 119);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(160, 90);
            button5.TabIndex = 19;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(4, 233);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(159, 90);
            button6.TabIndex = 20;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(171, 233);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(159, 90);
            button7.TabIndex = 25;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(338, 233);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(160, 90);
            button8.TabIndex = 24;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = false;
            // 
            // btn_inputQueue
            // 
            btn_inputQueue.BackColor = SystemColors.ButtonShadow;
            btn_inputQueue.FlatStyle = FlatStyle.Flat;
            btn_inputQueue.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputQueue.Location = new Point(338, 461);
            btn_inputQueue.Margin = new Padding(4, 5, 4, 5);
            btn_inputQueue.Name = "btn_inputQueue";
            btn_inputQueue.Size = new Size(160, 90);
            btn_inputQueue.TabIndex = 35;
            btn_inputQueue.Text = "웨이팅 시작";
            btn_inputQueue.UseVisualStyleBackColor = false;
            btn_inputQueue.Click += btn_inputQueue_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Control;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(338, 347);
            button10.Margin = new Padding(4, 5, 4, 5);
            button10.Name = "button10";
            button10.Size = new Size(160, 90);
            button10.TabIndex = 26;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Control;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(171, 347);
            button12.Margin = new Padding(4, 5, 4, 5);
            button12.Name = "button12";
            button12.Size = new Size(159, 90);
            button12.TabIndex = 22;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.Control;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(4, 347);
            button13.Margin = new Padding(4, 5, 4, 5);
            button13.Name = "button13";
            button13.Size = new Size(159, 90);
            button13.TabIndex = 23;
            button13.Text = "7";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.Control;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(171, 461);
            button14.Margin = new Padding(4, 5, 4, 5);
            button14.Name = "button14";
            button14.Size = new Size(159, 90);
            button14.TabIndex = 33;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.Control;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(4, 461);
            button15.Margin = new Padding(4, 5, 4, 5);
            button15.Name = "button15";
            button15.Size = new Size(159, 90);
            button15.TabIndex = 34;
            button15.Text = "010";
            button15.UseVisualStyleBackColor = false;
            // 
            // pnl_inputNumArray
            // 
            pnl_inputNumArray.BorderColor = Color.Gray;
            pnl_inputNumArray.BorderRadius = 90;
            pnl_inputNumArray.BorderSize = 4F;
            pnl_inputNumArray.BottomBorderRadius = 40;
            pnl_inputNumArray.Controls.Add(roundedButton1);
            pnl_inputNumArray.Controls.Add(textBox1);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray8);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray7);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray6);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray5);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray4);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray3);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray2);
            pnl_inputNumArray.Controls.Add(btn_inputNumArray1);
            pnl_inputNumArray.Location = new Point(851, 89);
            pnl_inputNumArray.Name = "pnl_inputNumArray";
            pnl_inputNumArray.RoundBottomLeft = true;
            pnl_inputNumArray.RoundBottomRight = true;
            pnl_inputNumArray.RoundTopLeft = true;
            pnl_inputNumArray.RoundTopRight = true;
            pnl_inputNumArray.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            pnl_inputNumArray.ShadowDepth = 8;
            pnl_inputNumArray.ShowShadow = true;
            pnl_inputNumArray.Size = new Size(742, 179);
            pnl_inputNumArray.TabIndex = 7;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.White;
            roundedButton1.BorderColor = Color.Silver;
            roundedButton1.BorderRadius = 40;
            roundedButton1.BorderSize = 2F;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(257, 3);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(201, 73);
            roundedButton1.TabIndex = 48;
            roundedButton1.Text = "010-";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 22F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(331, 84);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 60);
            textBox1.TabIndex = 47;
            textBox1.Text = "-";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_inputNumArray8
            // 
            btn_inputNumArray8.BackColor = Color.White;
            btn_inputNumArray8.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray8.BorderRadius = 40;
            btn_inputNumArray8.BorderSize = 2F;
            btn_inputNumArray8.FlatAppearance.BorderSize = 0;
            btn_inputNumArray8.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray8.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray8.ForeColor = Color.Black;
            btn_inputNumArray8.Location = new Point(611, 77);
            btn_inputNumArray8.Name = "btn_inputNumArray8";
            btn_inputNumArray8.Size = new Size(74, 92);
            btn_inputNumArray8.TabIndex = 45;
            btn_inputNumArray8.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray7
            // 
            btn_inputNumArray7.BackColor = Color.White;
            btn_inputNumArray7.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray7.BorderRadius = 40;
            btn_inputNumArray7.BorderSize = 2F;
            btn_inputNumArray7.FlatAppearance.BorderSize = 0;
            btn_inputNumArray7.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray7.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray7.ForeColor = Color.Black;
            btn_inputNumArray7.Location = new Point(531, 77);
            btn_inputNumArray7.Name = "btn_inputNumArray7";
            btn_inputNumArray7.Size = new Size(74, 92);
            btn_inputNumArray7.TabIndex = 44;
            btn_inputNumArray7.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray6
            // 
            btn_inputNumArray6.BackColor = Color.White;
            btn_inputNumArray6.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray6.BorderRadius = 40;
            btn_inputNumArray6.BorderSize = 2F;
            btn_inputNumArray6.FlatAppearance.BorderSize = 0;
            btn_inputNumArray6.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray6.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray6.ForeColor = Color.Black;
            btn_inputNumArray6.Location = new Point(454, 77);
            btn_inputNumArray6.Name = "btn_inputNumArray6";
            btn_inputNumArray6.Size = new Size(74, 92);
            btn_inputNumArray6.TabIndex = 43;
            btn_inputNumArray6.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray5
            // 
            btn_inputNumArray5.BackColor = Color.White;
            btn_inputNumArray5.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray5.BorderRadius = 40;
            btn_inputNumArray5.BorderSize = 2F;
            btn_inputNumArray5.FlatAppearance.BorderSize = 0;
            btn_inputNumArray5.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray5.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray5.ForeColor = Color.Black;
            btn_inputNumArray5.Location = new Point(374, 77);
            btn_inputNumArray5.Name = "btn_inputNumArray5";
            btn_inputNumArray5.Size = new Size(74, 92);
            btn_inputNumArray5.TabIndex = 42;
            btn_inputNumArray5.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray4
            // 
            btn_inputNumArray4.BackColor = Color.White;
            btn_inputNumArray4.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray4.BorderRadius = 40;
            btn_inputNumArray4.BorderSize = 2F;
            btn_inputNumArray4.FlatAppearance.BorderSize = 0;
            btn_inputNumArray4.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray4.ForeColor = Color.Black;
            btn_inputNumArray4.Location = new Point(250, 74);
            btn_inputNumArray4.Name = "btn_inputNumArray4";
            btn_inputNumArray4.Size = new Size(74, 92);
            btn_inputNumArray4.TabIndex = 41;
            btn_inputNumArray4.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray3
            // 
            btn_inputNumArray3.BackColor = Color.White;
            btn_inputNumArray3.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray3.BorderRadius = 40;
            btn_inputNumArray3.BorderSize = 2F;
            btn_inputNumArray3.FlatAppearance.BorderSize = 0;
            btn_inputNumArray3.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray3.ForeColor = Color.Black;
            btn_inputNumArray3.Location = new Point(167, 74);
            btn_inputNumArray3.Name = "btn_inputNumArray3";
            btn_inputNumArray3.Size = new Size(74, 92);
            btn_inputNumArray3.TabIndex = 40;
            btn_inputNumArray3.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray2
            // 
            btn_inputNumArray2.BackColor = Color.White;
            btn_inputNumArray2.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray2.BorderRadius = 40;
            btn_inputNumArray2.BorderSize = 2F;
            btn_inputNumArray2.FlatAppearance.BorderSize = 0;
            btn_inputNumArray2.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray2.ForeColor = Color.Black;
            btn_inputNumArray2.Location = new Point(87, 77);
            btn_inputNumArray2.Name = "btn_inputNumArray2";
            btn_inputNumArray2.Size = new Size(74, 92);
            btn_inputNumArray2.TabIndex = 39;
            btn_inputNumArray2.UseVisualStyleBackColor = false;
            // 
            // btn_inputNumArray1
            // 
            btn_inputNumArray1.BackColor = Color.White;
            btn_inputNumArray1.BorderColor = SystemColors.ActiveBorder;
            btn_inputNumArray1.BorderRadius = 40;
            btn_inputNumArray1.BorderSize = 2F;
            btn_inputNumArray1.FlatAppearance.BorderSize = 0;
            btn_inputNumArray1.FlatStyle = FlatStyle.Flat;
            btn_inputNumArray1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inputNumArray1.ForeColor = Color.Black;
            btn_inputNumArray1.Location = new Point(7, 77);
            btn_inputNumArray1.Name = "btn_inputNumArray1";
            btn_inputNumArray1.Size = new Size(74, 92);
            btn_inputNumArray1.TabIndex = 38;
            btn_inputNumArray1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.WindowText;
            label6.Location = new Point(-3, 0);
            label6.Name = "label6";
            label6.Size = new Size(829, 954);
            label6.TabIndex = 37;
            label6.Text = "label6";
            // 
            // Firstform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 93, 78);
            ClientSize = new Size(1741, 1050);
            Controls.Add(roundedPanel1);
            Controls.Add(pnl_queue);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Firstform";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            LanStatePanel.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            pnl_queue.ResumeLayout(false);
            pnl_inputNum.ResumeLayout(false);
            pnl_inputNumArray.ResumeLayout(false);
            pnl_inputNumArray.PerformLayout();
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
        private Controls.RoundedButton btn_waiting;
        private Controls.RoundedPanel pnl_queue;
        private Controls.RoundedPanel pnl_inputNumArray;
        private TableLayoutPanel pnl_inputNum;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btn_inputQueue;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label6;
        private Controls.RoundedButton btn_inputNumArray1;
        private Controls.RoundedButton btn_inputNumArray8;
        private Controls.RoundedButton btn_inputNumArray7;
        private Controls.RoundedButton btn_inputNumArray6;
        private Controls.RoundedButton btn_inputNumArray5;
        private Controls.RoundedButton btn_inputNumArray4;
        private Controls.RoundedButton btn_inputNumArray3;
        private Controls.RoundedButton btn_inputNumArray2;
        private Controls.RoundedButton roundedButton1;
        private TextBox textBox1;
    }
}
