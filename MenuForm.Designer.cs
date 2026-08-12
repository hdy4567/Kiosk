namespace sushikiosk
{
    partial class MenuForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            flpMenu = new FlowLayoutPanel();
            panelMenu1 = new Panel();
            btnAdd1 = new Button();
            lblMenuPrice1 = new Label();
            lblMenuName1 = new Label();
            picMenu1 = new PictureBox();
            panelMenu2 = new Panel();
            btnAdd2 = new Button();
            lblMenuPrice2 = new Label();
            lblMenuName2 = new Label();
            picMenu2 = new PictureBox();
            panelMenu3 = new Panel();
            btnAdd3 = new Button();
            lblMenuPrice3 = new Label();
            lblMenuName3 = new Label();
            picMenu3 = new PictureBox();
            panelMenu4 = new Panel();
            btnAdd4 = new Button();
            lblMenuPrice4 = new Label();
            lblMenuName4 = new Label();
            picMenu4 = new PictureBox();
            panelMenu5 = new Panel();
            btnAdd5 = new Button();
            lblMenuPrice5 = new Label();
            lblMenuName5 = new Label();
            picMenu5 = new PictureBox();
            panelMenu6 = new Panel();
            btnAdd6 = new Button();
            lblMenuPrice6 = new Label();
            lblMenuName6 = new Label();
            picMenu6 = new PictureBox();
            panelMenu7 = new Panel();
            btnAdd7 = new Button();
            lblMenuPrice7 = new Label();
            lblMenuName7 = new Label();
            picMenu7 = new PictureBox();
            panelMenu8 = new Panel();
            btnAdd8 = new Button();
            lblMenuPrice8 = new Label();
            lblMenuName8 = new Label();
            picMenu8 = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPage = new Label();
            panel1 = new Panel();
            btnOrder = new Button();
            lblTotalPrice = new Label();
            dgvOrder = new DataGridView();
            colMenuName = new DataGridViewTextBoxColumn();
            colMinus = new DataGridViewButtonColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPlus = new DataGridViewButtonColumn();
            colPrice = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnOrderHistory = new Button();
            btnCallStaff = new Button();
            menuStrip1.SuspendLayout();
            flpMenu.SuspendLayout();
            panelMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu1).BeginInit();
            panelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu2).BeginInit();
            panelMenu3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu3).BeginInit();
            panelMenu4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu4).BeginInit();
            panelMenu5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu5).BeginInit();
            panelMenu6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu6).BeginInit();
            panelMenu7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu7).BeginInit();
            panelMenu8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem5, toolStripMenuItem4, toolStripMenuItem6 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1219, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(113, 32);
            toolStripMenuItem1.Text = "활어/참치";
            toolStripMenuItem1.Click += Category_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem2.ForeColor = Color.Black;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(84, 32);
            toolStripMenuItem2.Text = "해산물";
            toolStripMenuItem2.Click += Category_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem3.ForeColor = Color.Black;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(93, 32);
            toolStripMenuItem3.Text = "롤/마끼";
            toolStripMenuItem3.Click += Category_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem5.ForeColor = Color.Black;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(153, 32);
            toolStripMenuItem5.Text = "단품/기타초밥";
            toolStripMenuItem5.Click += Category_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem4.ForeColor = Color.Black;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(182, 32);
            toolStripMenuItem4.Text = "사이드/면/디저트";
            toolStripMenuItem4.Click += Category_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem6.ForeColor = Color.Black;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(64, 32);
            toolStripMenuItem6.Text = "음료";
            toolStripMenuItem6.Click += Category_Click;
            // 
            // flpMenu
            // 
            flpMenu.Controls.Add(panelMenu1);
            flpMenu.Controls.Add(panelMenu2);
            flpMenu.Controls.Add(panelMenu3);
            flpMenu.Controls.Add(panelMenu4);
            flpMenu.Controls.Add(panelMenu5);
            flpMenu.Controls.Add(panelMenu6);
            flpMenu.Controls.Add(panelMenu7);
            flpMenu.Controls.Add(panelMenu8);
            flpMenu.Location = new Point(12, 39);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(774, 571);
            flpMenu.TabIndex = 1;
            // 
            // panelMenu1
            // 
            panelMenu1.Controls.Add(btnAdd1);
            panelMenu1.Controls.Add(lblMenuPrice1);
            panelMenu1.Controls.Add(lblMenuName1);
            panelMenu1.Controls.Add(picMenu1);
            panelMenu1.Location = new Point(3, 3);
            panelMenu1.Name = "panelMenu1";
            panelMenu1.Size = new Size(187, 276);
            panelMenu1.TabIndex = 0;
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(58, 208);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(75, 23);
            btnAdd1.TabIndex = 2;
            btnAdd1.Text = "담기";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice1
            // 
            lblMenuPrice1.AutoSize = true;
            lblMenuPrice1.Location = new Point(58, 158);
            lblMenuPrice1.Name = "lblMenuPrice1";
            lblMenuPrice1.Size = new Size(39, 15);
            lblMenuPrice1.TabIndex = 1;
            lblMenuPrice1.Text = "label1";
            // 
            // lblMenuName1
            // 
            lblMenuName1.AutoSize = true;
            lblMenuName1.Location = new Point(58, 132);
            lblMenuName1.Name = "lblMenuName1";
            lblMenuName1.Size = new Size(39, 15);
            lblMenuName1.TabIndex = 1;
            lblMenuName1.Text = "label1";
            // 
            // picMenu1
            // 
            picMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu1.Location = new Point(3, 3);
            picMenu1.Name = "picMenu1";
            picMenu1.Size = new Size(181, 115);
            picMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu1.TabIndex = 0;
            picMenu1.TabStop = false;
            // 
            // panelMenu2
            // 
            panelMenu2.Controls.Add(btnAdd2);
            panelMenu2.Controls.Add(lblMenuPrice2);
            panelMenu2.Controls.Add(lblMenuName2);
            panelMenu2.Controls.Add(picMenu2);
            panelMenu2.Location = new Point(196, 3);
            panelMenu2.Name = "panelMenu2";
            panelMenu2.Size = new Size(187, 276);
            panelMenu2.TabIndex = 0;
            // 
            // btnAdd2
            // 
            btnAdd2.Location = new Point(58, 208);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(75, 23);
            btnAdd2.TabIndex = 2;
            btnAdd2.Text = "담기";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice2
            // 
            lblMenuPrice2.AutoSize = true;
            lblMenuPrice2.Location = new Point(58, 158);
            lblMenuPrice2.Name = "lblMenuPrice2";
            lblMenuPrice2.Size = new Size(39, 15);
            lblMenuPrice2.TabIndex = 1;
            lblMenuPrice2.Text = "label1";
            // 
            // lblMenuName2
            // 
            lblMenuName2.AutoSize = true;
            lblMenuName2.Location = new Point(58, 132);
            lblMenuName2.Name = "lblMenuName2";
            lblMenuName2.Size = new Size(39, 15);
            lblMenuName2.TabIndex = 1;
            lblMenuName2.Text = "label1";
            // 
            // picMenu2
            // 
            picMenu2.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu2.Location = new Point(3, 3);
            picMenu2.Name = "picMenu2";
            picMenu2.Size = new Size(184, 115);
            picMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu2.TabIndex = 0;
            picMenu2.TabStop = false;
            // 
            // panelMenu3
            // 
            panelMenu3.Controls.Add(btnAdd3);
            panelMenu3.Controls.Add(lblMenuPrice3);
            panelMenu3.Controls.Add(lblMenuName3);
            panelMenu3.Controls.Add(picMenu3);
            panelMenu3.Location = new Point(389, 3);
            panelMenu3.Name = "panelMenu3";
            panelMenu3.Size = new Size(187, 276);
            panelMenu3.TabIndex = 0;
            // 
            // btnAdd3
            // 
            btnAdd3.Location = new Point(58, 208);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(75, 23);
            btnAdd3.TabIndex = 2;
            btnAdd3.Text = "담기";
            btnAdd3.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice3
            // 
            lblMenuPrice3.AutoSize = true;
            lblMenuPrice3.Location = new Point(58, 158);
            lblMenuPrice3.Name = "lblMenuPrice3";
            lblMenuPrice3.Size = new Size(39, 15);
            lblMenuPrice3.TabIndex = 1;
            lblMenuPrice3.Text = "label1";
            // 
            // lblMenuName3
            // 
            lblMenuName3.AutoSize = true;
            lblMenuName3.Location = new Point(58, 132);
            lblMenuName3.Name = "lblMenuName3";
            lblMenuName3.Size = new Size(39, 15);
            lblMenuName3.TabIndex = 1;
            lblMenuName3.Text = "label1";
            // 
            // picMenu3
            // 
            picMenu3.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu3.Location = new Point(3, 3);
            picMenu3.Name = "picMenu3";
            picMenu3.Size = new Size(184, 115);
            picMenu3.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu3.TabIndex = 0;
            picMenu3.TabStop = false;
            // 
            // panelMenu4
            // 
            panelMenu4.Controls.Add(btnAdd4);
            panelMenu4.Controls.Add(lblMenuPrice4);
            panelMenu4.Controls.Add(lblMenuName4);
            panelMenu4.Controls.Add(picMenu4);
            panelMenu4.Location = new Point(582, 3);
            panelMenu4.Name = "panelMenu4";
            panelMenu4.Size = new Size(187, 276);
            panelMenu4.TabIndex = 0;
            // 
            // btnAdd4
            // 
            btnAdd4.Location = new Point(58, 208);
            btnAdd4.Name = "btnAdd4";
            btnAdd4.Size = new Size(75, 23);
            btnAdd4.TabIndex = 2;
            btnAdd4.Text = "담기";
            btnAdd4.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice4
            // 
            lblMenuPrice4.AutoSize = true;
            lblMenuPrice4.Location = new Point(58, 158);
            lblMenuPrice4.Name = "lblMenuPrice4";
            lblMenuPrice4.Size = new Size(39, 15);
            lblMenuPrice4.TabIndex = 1;
            lblMenuPrice4.Text = "label1";
            // 
            // lblMenuName4
            // 
            lblMenuName4.AutoSize = true;
            lblMenuName4.Location = new Point(58, 132);
            lblMenuName4.Name = "lblMenuName4";
            lblMenuName4.Size = new Size(39, 15);
            lblMenuName4.TabIndex = 1;
            lblMenuName4.Text = "label1";
            // 
            // picMenu4
            // 
            picMenu4.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu4.Location = new Point(3, 3);
            picMenu4.Name = "picMenu4";
            picMenu4.Size = new Size(184, 115);
            picMenu4.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu4.TabIndex = 0;
            picMenu4.TabStop = false;
            // 
            // panelMenu5
            // 
            panelMenu5.Controls.Add(btnAdd5);
            panelMenu5.Controls.Add(lblMenuPrice5);
            panelMenu5.Controls.Add(lblMenuName5);
            panelMenu5.Controls.Add(picMenu5);
            panelMenu5.Location = new Point(3, 285);
            panelMenu5.Name = "panelMenu5";
            panelMenu5.Size = new Size(187, 276);
            panelMenu5.TabIndex = 0;
            // 
            // btnAdd5
            // 
            btnAdd5.Location = new Point(58, 208);
            btnAdd5.Name = "btnAdd5";
            btnAdd5.Size = new Size(75, 23);
            btnAdd5.TabIndex = 2;
            btnAdd5.Text = "담기";
            btnAdd5.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice5
            // 
            lblMenuPrice5.AutoSize = true;
            lblMenuPrice5.Location = new Point(58, 158);
            lblMenuPrice5.Name = "lblMenuPrice5";
            lblMenuPrice5.Size = new Size(39, 15);
            lblMenuPrice5.TabIndex = 1;
            lblMenuPrice5.Text = "label1";
            // 
            // lblMenuName5
            // 
            lblMenuName5.AutoSize = true;
            lblMenuName5.Location = new Point(58, 132);
            lblMenuName5.Name = "lblMenuName5";
            lblMenuName5.Size = new Size(39, 15);
            lblMenuName5.TabIndex = 1;
            lblMenuName5.Text = "label1";
            // 
            // picMenu5
            // 
            picMenu5.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu5.Location = new Point(3, 3);
            picMenu5.Name = "picMenu5";
            picMenu5.Size = new Size(184, 115);
            picMenu5.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu5.TabIndex = 0;
            picMenu5.TabStop = false;
            // 
            // panelMenu6
            // 
            panelMenu6.Controls.Add(btnAdd6);
            panelMenu6.Controls.Add(lblMenuPrice6);
            panelMenu6.Controls.Add(lblMenuName6);
            panelMenu6.Controls.Add(picMenu6);
            panelMenu6.Location = new Point(196, 285);
            panelMenu6.Name = "panelMenu6";
            panelMenu6.Size = new Size(187, 276);
            panelMenu6.TabIndex = 0;
            // 
            // btnAdd6
            // 
            btnAdd6.Location = new Point(58, 208);
            btnAdd6.Name = "btnAdd6";
            btnAdd6.Size = new Size(75, 23);
            btnAdd6.TabIndex = 2;
            btnAdd6.Text = "담기";
            btnAdd6.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice6
            // 
            lblMenuPrice6.AutoSize = true;
            lblMenuPrice6.Location = new Point(58, 158);
            lblMenuPrice6.Name = "lblMenuPrice6";
            lblMenuPrice6.Size = new Size(39, 15);
            lblMenuPrice6.TabIndex = 1;
            lblMenuPrice6.Text = "label1";
            // 
            // lblMenuName6
            // 
            lblMenuName6.AutoSize = true;
            lblMenuName6.Location = new Point(58, 132);
            lblMenuName6.Name = "lblMenuName6";
            lblMenuName6.Size = new Size(39, 15);
            lblMenuName6.TabIndex = 1;
            lblMenuName6.Text = "label1";
            // 
            // picMenu6
            // 
            picMenu6.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu6.Location = new Point(3, 3);
            picMenu6.Name = "picMenu6";
            picMenu6.Size = new Size(184, 115);
            picMenu6.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu6.TabIndex = 0;
            picMenu6.TabStop = false;
            // 
            // panelMenu7
            // 
            panelMenu7.Controls.Add(btnAdd7);
            panelMenu7.Controls.Add(lblMenuPrice7);
            panelMenu7.Controls.Add(lblMenuName7);
            panelMenu7.Controls.Add(picMenu7);
            panelMenu7.Location = new Point(389, 285);
            panelMenu7.Name = "panelMenu7";
            panelMenu7.Size = new Size(187, 276);
            panelMenu7.TabIndex = 0;
            // 
            // btnAdd7
            // 
            btnAdd7.Location = new Point(58, 208);
            btnAdd7.Name = "btnAdd7";
            btnAdd7.Size = new Size(75, 23);
            btnAdd7.TabIndex = 2;
            btnAdd7.Text = "담기";
            btnAdd7.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice7
            // 
            lblMenuPrice7.AutoSize = true;
            lblMenuPrice7.Location = new Point(58, 158);
            lblMenuPrice7.Name = "lblMenuPrice7";
            lblMenuPrice7.Size = new Size(39, 15);
            lblMenuPrice7.TabIndex = 1;
            lblMenuPrice7.Text = "label1";
            // 
            // lblMenuName7
            // 
            lblMenuName7.AutoSize = true;
            lblMenuName7.Location = new Point(58, 132);
            lblMenuName7.Name = "lblMenuName7";
            lblMenuName7.Size = new Size(39, 15);
            lblMenuName7.TabIndex = 1;
            lblMenuName7.Text = "label1";
            // 
            // picMenu7
            // 
            picMenu7.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu7.Location = new Point(3, 3);
            picMenu7.Name = "picMenu7";
            picMenu7.Size = new Size(184, 115);
            picMenu7.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu7.TabIndex = 0;
            picMenu7.TabStop = false;
            // 
            // panelMenu8
            // 
            panelMenu8.Controls.Add(btnAdd8);
            panelMenu8.Controls.Add(lblMenuPrice8);
            panelMenu8.Controls.Add(lblMenuName8);
            panelMenu8.Controls.Add(picMenu8);
            panelMenu8.Location = new Point(582, 285);
            panelMenu8.Name = "panelMenu8";
            panelMenu8.Size = new Size(187, 276);
            panelMenu8.TabIndex = 0;
            // 
            // btnAdd8
            // 
            btnAdd8.Location = new Point(58, 208);
            btnAdd8.Name = "btnAdd8";
            btnAdd8.Size = new Size(75, 23);
            btnAdd8.TabIndex = 2;
            btnAdd8.Text = "담기";
            btnAdd8.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrice8
            // 
            lblMenuPrice8.AutoSize = true;
            lblMenuPrice8.Location = new Point(58, 158);
            lblMenuPrice8.Name = "lblMenuPrice8";
            lblMenuPrice8.Size = new Size(39, 15);
            lblMenuPrice8.TabIndex = 1;
            lblMenuPrice8.Text = "label1";
            // 
            // lblMenuName8
            // 
            lblMenuName8.AutoSize = true;
            lblMenuName8.Location = new Point(58, 132);
            lblMenuName8.Name = "lblMenuName8";
            lblMenuName8.Size = new Size(39, 15);
            lblMenuName8.TabIndex = 1;
            lblMenuName8.Text = "label1";
            // 
            // picMenu8
            // 
            picMenu8.BackgroundImageLayout = ImageLayout.Stretch;
            picMenu8.Location = new Point(3, 3);
            picMenu8.Name = "picMenu8";
            picMenu8.Size = new Size(184, 115);
            picMenu8.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu8.TabIndex = 0;
            picMenu8.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(208, 635);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(90, 40);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "이전";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(498, 635);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(90, 40);
            btnNext.TabIndex = 3;
            btnNext.Text = "다음";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPage.Location = new Point(366, 639);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(63, 25);
            lblPage.TabIndex = 4;
            lblPage.Text = "1  /  3";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(dgvOrder);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(792, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 571);
            panel1.TabIndex = 5;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(156, 511);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(100, 40);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(140, 443);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(116, 25);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "총 금액 : 0원";
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.BackgroundColor = Color.White;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { colMenuName, colMinus, colQuantity, colPlus, colPrice });
            dgvOrder.Location = new Point(3, 69);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(413, 319);
            dgvOrder.TabIndex = 1;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // colMenuName
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMenuName.DefaultCellStyle = dataGridViewCellStyle1;
            colMenuName.HeaderText = "메뉴";
            colMenuName.Name = "colMenuName";
            colMenuName.ReadOnly = true;
            colMenuName.Width = 120;
            // 
            // colMinus
            // 
            colMinus.HeaderText = "-";
            colMinus.Name = "colMinus";
            colMinus.ReadOnly = true;
            colMinus.Width = 20;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            colQuantity.HeaderText = "수량";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 90;
            // 
            // colPlus
            // 
            colPlus.HeaderText = "+";
            colPlus.Name = "colPlus";
            colPlus.ReadOnly = true;
            colPlus.Width = 20;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            colPrice.HeaderText = "금액";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 27);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "장바구니?";
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrderHistory.Location = new Point(1111, 635);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(100, 40);
            btnOrderHistory.TabIndex = 4;
            btnOrderHistory.Text = "주문 내역";
            btnOrderHistory.UseVisualStyleBackColor = true;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnCallStaff
            // 
            btnCallStaff.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCallStaff.Location = new Point(792, 635);
            btnCallStaff.Name = "btnCallStaff";
            btnCallStaff.Size = new Size(100, 40);
            btnCallStaff.TabIndex = 6;
            btnCallStaff.Text = "직원 호출";
            btnCallStaff.UseVisualStyleBackColor = true;
            btnCallStaff.Click += btnCallStaff_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 700);
            Controls.Add(btnCallStaff);
            Controls.Add(btnOrderHistory);
            Controls.Add(panel1);
            Controls.Add(lblPage);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(flpMenu);
            Controls.Add(menuStrip1);
            Name = "MenuForm";
            Text = "메뉴 조회/주문";
            Load += MenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flpMenu.ResumeLayout(false);
            panelMenu1.ResumeLayout(false);
            panelMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu1).EndInit();
            panelMenu2.ResumeLayout(false);
            panelMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu2).EndInit();
            panelMenu3.ResumeLayout(false);
            panelMenu3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu3).EndInit();
            panelMenu4.ResumeLayout(false);
            panelMenu4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu4).EndInit();
            panelMenu5.ResumeLayout(false);
            panelMenu5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu5).EndInit();
            panelMenu6.ResumeLayout(false);
            panelMenu6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu6).EndInit();
            panelMenu7.ResumeLayout(false);
            panelMenu7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu7).EndInit();
            panelMenu8.ResumeLayout(false);
            panelMenu8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private FlowLayoutPanel flpMenu;
        private Panel panelMenu1;
        private Button btnAdd1;
        private Label lblMenuPrice1;
        private Label lblMenuName1;
        private PictureBox picMenu1;
        private Panel panelMenu2;
        private Button btnAdd2;
        private Label lblMenuPrice2;
        private Label lblMenuName2;
        private PictureBox picMenu2;
        private Panel panelMenu3;
        private Button btnAdd3;
        private Label lblMenuPrice3;
        private Label lblMenuName3;
        private PictureBox picMenu3;
        private Panel panelMenu4;
        private Button btnAdd4;
        private Label lblMenuPrice4;
        private Label lblMenuName4;
        private PictureBox picMenu4;
        private Panel panelMenu5;
        private Button btnAdd5;
        private Label lblMenuPrice5;
        private Label lblMenuName5;
        private PictureBox picMenu5;
        private Panel panelMenu6;
        private Button btnAdd6;
        private Label lblMenuPrice6;
        private Label lblMenuName6;
        private PictureBox picMenu6;
        private Panel panelMenu7;
        private Button btnAdd7;
        private Label lblMenuPrice7;
        private Label lblMenuName7;
        private PictureBox picMenu7;
        private Panel panelMenu8;
        private Button btnAdd8;
        private Label lblMenuPrice8;
        private Label lblMenuName8;
        private PictureBox picMenu8;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPage;
        private Panel panel1;
        private DataGridView dgvOrder;
        private Label label1;
        private Button btnOrder;
        private Label lblTotalPrice;
        private DataGridViewTextBoxColumn colMenuName;
        private DataGridViewButtonColumn colMinus;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colPlus;
        private DataGridViewTextBoxColumn colPrice;
        private Button btnOrderHistory;
        private Button btnCallStaff;
    }
}