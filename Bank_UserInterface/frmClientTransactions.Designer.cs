namespace Bank_C__Full_Project
{
    partial class frmClientTransactions
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
            this.tabManageClients = new System.Windows.Forms.TabControl();
            this.tabDeopsit = new System.Windows.Forms.TabPage();
            this.btDeposit = new System.Windows.Forms.Button();
            this.lblCurrentBalanceDeposit = new System.Windows.Forms.Label();
            this.nudDepositBalance = new System.Windows.Forms.NumericUpDown();
            this.lblDepositBalance = new System.Windows.Forms.Label();
            this.cbDepositAccNumbers = new System.Windows.Forms.ComboBox();
            this.lblDepositAccNumber = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.tabWithDraw = new System.Windows.Forms.TabPage();
            this.lblCurrentBalanceWithDraw = new System.Windows.Forms.Label();
            this.btWithDraw = new System.Windows.Forms.Button();
            this.nudClientWithDrawBalance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientWithDraw = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabTotalBalances = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSortingDesc = new System.Windows.Forms.RadioButton();
            this.rbSortinAsc = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBalancesNumber = new System.Windows.Forms.Label();
            this.lblTotalBalancesWord = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTotalBalancesSearch = new System.Windows.Forms.TextBox();
            this.lvShowClientsBalanceInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabTransferBalance = new System.Windows.Forms.TabPage();
            this.lblTotalBalanceTransferTo = new System.Windows.Forms.Label();
            this.lblTotalBalanceTransferFrom = new System.Windows.Forms.Label();
            this.cbTransferToShowAccNumbers = new System.Windows.Forms.ComboBox();
            this.lblTransferTo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.nudTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cbTransferFromShowAccNumbers = new System.Windows.Forms.ComboBox();
            this.lblTransferFrom = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabTransferLog = new System.Windows.Forms.TabPage();
            this.lblNumberOfClientsInTransferLogForm = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDescTransferLog = new System.Windows.Forms.RadioButton();
            this.rbAccTransferLog = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchAccNumberTransferLog = new System.Windows.Forms.TextBox();
            this.lvTransferLog = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabManageClients.SuspendLayout();
            this.tabDeopsit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositBalance)).BeginInit();
            this.tabWithDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientWithDrawBalance)).BeginInit();
            this.tabTotalBalances.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabTransferBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).BeginInit();
            this.tabTransferLog.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageClients
            // 
            this.tabManageClients.Controls.Add(this.tabDeopsit);
            this.tabManageClients.Controls.Add(this.tabWithDraw);
            this.tabManageClients.Controls.Add(this.tabTotalBalances);
            this.tabManageClients.Controls.Add(this.tabTransferBalance);
            this.tabManageClients.Controls.Add(this.tabTransferLog);
            this.tabManageClients.Location = new System.Drawing.Point(243, 12);
            this.tabManageClients.Name = "tabManageClients";
            this.tabManageClients.SelectedIndex = 0;
            this.tabManageClients.Size = new System.Drawing.Size(963, 514);
            this.tabManageClients.TabIndex = 1;
            this.tabManageClients.SelectedIndexChanged += new System.EventHandler(this.tabManageClients_SelectedIndexChanged);
            // 
            // tabDeopsit
            // 
            this.tabDeopsit.BackColor = System.Drawing.Color.White;
            this.tabDeopsit.Controls.Add(this.btDeposit);
            this.tabDeopsit.Controls.Add(this.lblCurrentBalanceDeposit);
            this.tabDeopsit.Controls.Add(this.nudDepositBalance);
            this.tabDeopsit.Controls.Add(this.lblDepositBalance);
            this.tabDeopsit.Controls.Add(this.cbDepositAccNumbers);
            this.tabDeopsit.Controls.Add(this.lblDepositAccNumber);
            this.tabDeopsit.Controls.Add(this.panel20);
            this.tabDeopsit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabDeopsit.ForeColor = System.Drawing.Color.White;
            this.tabDeopsit.Location = new System.Drawing.Point(4, 22);
            this.tabDeopsit.Name = "tabDeopsit";
            this.tabDeopsit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeopsit.Size = new System.Drawing.Size(955, 488);
            this.tabDeopsit.TabIndex = 0;
            this.tabDeopsit.Text = "Deposit";
            this.tabDeopsit.Click += new System.EventHandler(this.tabShowClients_Click);
            // 
            // btDeposit
            // 
            this.btDeposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeposit.Enabled = false;
            this.btDeposit.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btDeposit.ForeColor = System.Drawing.Color.White;
            this.btDeposit.Location = new System.Drawing.Point(32, 319);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(139, 53);
            this.btDeposit.TabIndex = 83;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = false;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // lblCurrentBalanceDeposit
            // 
            this.lblCurrentBalanceDeposit.AutoSize = true;
            this.lblCurrentBalanceDeposit.BackColor = System.Drawing.Color.White;
            this.lblCurrentBalanceDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceDeposit.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCurrentBalanceDeposit.Location = new System.Drawing.Point(29, 156);
            this.lblCurrentBalanceDeposit.Name = "lblCurrentBalanceDeposit";
            this.lblCurrentBalanceDeposit.Size = new System.Drawing.Size(0, 19);
            this.lblCurrentBalanceDeposit.TabIndex = 82;
            // 
            // nudDepositBalance
            // 
            this.nudDepositBalance.BackColor = System.Drawing.Color.RosyBrown;
            this.nudDepositBalance.Enabled = false;
            this.nudDepositBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nudDepositBalance.ForeColor = System.Drawing.Color.Black;
            this.nudDepositBalance.Location = new System.Drawing.Point(30, 235);
            this.nudDepositBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDepositBalance.Name = "nudDepositBalance";
            this.nudDepositBalance.Size = new System.Drawing.Size(203, 27);
            this.nudDepositBalance.TabIndex = 81;
            // 
            // lblDepositBalance
            // 
            this.lblDepositBalance.AutoSize = true;
            this.lblDepositBalance.BackColor = System.Drawing.Color.White;
            this.lblDepositBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositBalance.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblDepositBalance.Location = new System.Drawing.Point(28, 213);
            this.lblDepositBalance.Name = "lblDepositBalance";
            this.lblDepositBalance.Size = new System.Drawing.Size(73, 19);
            this.lblDepositBalance.TabIndex = 80;
            this.lblDepositBalance.Text = "Balance";
            // 
            // cbDepositAccNumbers
            // 
            this.cbDepositAccNumbers.BackColor = System.Drawing.Color.White;
            this.cbDepositAccNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepositAccNumbers.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbDepositAccNumbers.FormattingEnabled = true;
            this.cbDepositAccNumbers.Location = new System.Drawing.Point(29, 103);
            this.cbDepositAccNumbers.Name = "cbDepositAccNumbers";
            this.cbDepositAccNumbers.Size = new System.Drawing.Size(204, 24);
            this.cbDepositAccNumbers.TabIndex = 79;
            this.cbDepositAccNumbers.SelectedIndexChanged += new System.EventHandler(this.cbDepositAccNumbers_SelectedIndexChanged);
            // 
            // lblDepositAccNumber
            // 
            this.lblDepositAccNumber.AutoSize = true;
            this.lblDepositAccNumber.BackColor = System.Drawing.Color.White;
            this.lblDepositAccNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAccNumber.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblDepositAccNumber.Location = new System.Drawing.Point(29, 67);
            this.lblDepositAccNumber.Name = "lblDepositAccNumber";
            this.lblDepositAccNumber.Size = new System.Drawing.Size(111, 19);
            this.lblDepositAccNumber.TabIndex = 78;
            this.lblDepositAccNumber.Text = "Acc. Number";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.RosyBrown;
            this.panel20.Location = new System.Drawing.Point(30, 127);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 1);
            this.panel20.TabIndex = 77;
            // 
            // tabWithDraw
            // 
            this.tabWithDraw.BackColor = System.Drawing.Color.White;
            this.tabWithDraw.Controls.Add(this.lblCurrentBalanceWithDraw);
            this.tabWithDraw.Controls.Add(this.btWithDraw);
            this.tabWithDraw.Controls.Add(this.nudClientWithDrawBalance);
            this.tabWithDraw.Controls.Add(this.label1);
            this.tabWithDraw.Controls.Add(this.cbClientWithDraw);
            this.tabWithDraw.Controls.Add(this.label2);
            this.tabWithDraw.Controls.Add(this.panel1);
            this.tabWithDraw.Location = new System.Drawing.Point(4, 22);
            this.tabWithDraw.Name = "tabWithDraw";
            this.tabWithDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithDraw.Size = new System.Drawing.Size(955, 488);
            this.tabWithDraw.TabIndex = 1;
            this.tabWithDraw.Text = "WithDraw";
            // 
            // lblCurrentBalanceWithDraw
            // 
            this.lblCurrentBalanceWithDraw.AutoSize = true;
            this.lblCurrentBalanceWithDraw.BackColor = System.Drawing.Color.White;
            this.lblCurrentBalanceWithDraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceWithDraw.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCurrentBalanceWithDraw.Location = new System.Drawing.Point(28, 152);
            this.lblCurrentBalanceWithDraw.Name = "lblCurrentBalanceWithDraw";
            this.lblCurrentBalanceWithDraw.Size = new System.Drawing.Size(0, 19);
            this.lblCurrentBalanceWithDraw.TabIndex = 90;
            // 
            // btWithDraw
            // 
            this.btWithDraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btWithDraw.Enabled = false;
            this.btWithDraw.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btWithDraw.ForeColor = System.Drawing.Color.White;
            this.btWithDraw.Location = new System.Drawing.Point(31, 318);
            this.btWithDraw.Name = "btWithDraw";
            this.btWithDraw.Size = new System.Drawing.Size(139, 53);
            this.btWithDraw.TabIndex = 89;
            this.btWithDraw.Text = "WithDraw";
            this.btWithDraw.UseVisualStyleBackColor = false;
            this.btWithDraw.Click += new System.EventHandler(this.btWithDraw_Click);
            // 
            // nudClientWithDrawBalance
            // 
            this.nudClientWithDrawBalance.BackColor = System.Drawing.Color.RosyBrown;
            this.nudClientWithDrawBalance.Enabled = false;
            this.nudClientWithDrawBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nudClientWithDrawBalance.ForeColor = System.Drawing.Color.Black;
            this.nudClientWithDrawBalance.Location = new System.Drawing.Point(29, 234);
            this.nudClientWithDrawBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudClientWithDrawBalance.Name = "nudClientWithDrawBalance";
            this.nudClientWithDrawBalance.Size = new System.Drawing.Size(203, 27);
            this.nudClientWithDrawBalance.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(27, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Balance";
            // 
            // cbClientWithDraw
            // 
            this.cbClientWithDraw.BackColor = System.Drawing.Color.White;
            this.cbClientWithDraw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientWithDraw.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbClientWithDraw.FormattingEnabled = true;
            this.cbClientWithDraw.Location = new System.Drawing.Point(28, 102);
            this.cbClientWithDraw.Name = "cbClientWithDraw";
            this.cbClientWithDraw.Size = new System.Drawing.Size(204, 21);
            this.cbClientWithDraw.TabIndex = 86;
            this.cbClientWithDraw.SelectedIndexChanged += new System.EventHandler(this.cbClientWithDraw_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 85;
            this.label2.Text = "Acc. Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(29, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 84;
            // 
            // tabTotalBalances
            // 
            this.tabTotalBalances.BackColor = System.Drawing.Color.White;
            this.tabTotalBalances.Controls.Add(this.groupBox1);
            this.tabTotalBalances.Controls.Add(this.panel2);
            this.tabTotalBalances.Controls.Add(this.label14);
            this.tabTotalBalances.Controls.Add(this.panel14);
            this.tabTotalBalances.Controls.Add(this.lvShowClientsBalanceInfo);
            this.tabTotalBalances.Location = new System.Drawing.Point(4, 22);
            this.tabTotalBalances.Name = "tabTotalBalances";
            this.tabTotalBalances.Size = new System.Drawing.Size(955, 488);
            this.tabTotalBalances.TabIndex = 2;
            this.tabTotalBalances.Text = "Total Balances";
            this.tabTotalBalances.Click += new System.EventHandler(this.tabTotalBalances_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSortingDesc);
            this.groupBox1.Controls.Add(this.rbSortinAsc);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(794, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 53);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // rbSortingDesc
            // 
            this.rbSortingDesc.ForeColor = System.Drawing.Color.Black;
            this.rbSortingDesc.Location = new System.Drawing.Point(80, 19);
            this.rbSortingDesc.Name = "rbSortingDesc";
            this.rbSortingDesc.Size = new System.Drawing.Size(57, 24);
            this.rbSortingDesc.TabIndex = 1;
            this.rbSortingDesc.TabStop = true;
            this.rbSortingDesc.Text = "Desc";
            this.rbSortingDesc.UseVisualStyleBackColor = true;
            this.rbSortingDesc.CheckedChanged += new System.EventHandler(this.rbSortingDesc_CheckedChanged);
            // 
            // rbSortinAsc
            // 
            this.rbSortinAsc.ForeColor = System.Drawing.Color.Black;
            this.rbSortinAsc.Location = new System.Drawing.Point(6, 19);
            this.rbSortinAsc.Name = "rbSortinAsc";
            this.rbSortinAsc.Size = new System.Drawing.Size(46, 24);
            this.rbSortinAsc.TabIndex = 0;
            this.rbSortinAsc.TabStop = true;
            this.rbSortinAsc.Text = "Asc";
            this.rbSortinAsc.UseVisualStyleBackColor = true;
            this.rbSortinAsc.CheckedChanged += new System.EventHandler(this.rbSortinAsc_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalBalancesNumber);
            this.panel2.Controls.Add(this.lblTotalBalancesWord);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 100);
            this.panel2.TabIndex = 80;
            // 
            // lblTotalBalancesNumber
            // 
            this.lblTotalBalancesNumber.AutoSize = true;
            this.lblTotalBalancesNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesNumber.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesNumber.Location = new System.Drawing.Point(10, 16);
            this.lblTotalBalancesNumber.Name = "lblTotalBalancesNumber";
            this.lblTotalBalancesNumber.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalancesNumber.TabIndex = 18;
            // 
            // lblTotalBalancesWord
            // 
            this.lblTotalBalancesWord.AutoSize = true;
            this.lblTotalBalancesWord.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesWord.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesWord.Location = new System.Drawing.Point(10, 49);
            this.lblTotalBalancesWord.Name = "lblTotalBalancesWord";
            this.lblTotalBalancesWord.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalancesWord.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label14.Location = new System.Drawing.Point(14, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 19);
            this.label14.TabIndex = 79;
            this.label14.Text = "Search Acc. Number";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel14.Controls.Add(this.pictureBox2);
            this.panel14.Controls.Add(this.txtTotalBalancesSearch);
            this.panel14.ForeColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(18, 156);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel14.Size = new System.Drawing.Size(198, 21);
            this.panel14.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Bank_C__Full_Project.Properties.Resources.search2;
            this.pictureBox2.Location = new System.Drawing.Point(157, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtTotalBalancesSearch
            // 
            this.txtTotalBalancesSearch.BackColor = System.Drawing.Color.White;
            this.txtTotalBalancesSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBalancesSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalBalancesSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBalancesSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtTotalBalancesSearch.Location = new System.Drawing.Point(0, 0);
            this.txtTotalBalancesSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtTotalBalancesSearch.Name = "txtTotalBalancesSearch";
            this.txtTotalBalancesSearch.Size = new System.Drawing.Size(198, 20);
            this.txtTotalBalancesSearch.TabIndex = 0;
            this.txtTotalBalancesSearch.TextChanged += new System.EventHandler(this.txtTotalBalancesSearch_TextChanged);
            // 
            // lvShowClientsBalanceInfo
            // 
            this.lvShowClientsBalanceInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShowClientsBalanceInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShowClientsBalanceInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lvShowClientsBalanceInfo.FullRowSelect = true;
            this.lvShowClientsBalanceInfo.GridLines = true;
            this.lvShowClientsBalanceInfo.HideSelection = false;
            this.lvShowClientsBalanceInfo.Location = new System.Drawing.Point(3, 229);
            this.lvShowClientsBalanceInfo.Name = "lvShowClientsBalanceInfo";
            this.lvShowClientsBalanceInfo.Size = new System.Drawing.Size(995, 256);
            this.lvShowClientsBalanceInfo.TabIndex = 77;
            this.lvShowClientsBalanceInfo.UseCompatibleStateImageBehavior = false;
            this.lvShowClientsBalanceInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AccNumber";
            this.columnHeader2.Width = 241;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.Width = 404;
            // 
            // tabTransferBalance
            // 
            this.tabTransferBalance.Controls.Add(this.lblTotalBalanceTransferTo);
            this.tabTransferBalance.Controls.Add(this.lblTotalBalanceTransferFrom);
            this.tabTransferBalance.Controls.Add(this.cbTransferToShowAccNumbers);
            this.tabTransferBalance.Controls.Add(this.lblTransferTo);
            this.tabTransferBalance.Controls.Add(this.panel4);
            this.tabTransferBalance.Controls.Add(this.btnTransfer);
            this.tabTransferBalance.Controls.Add(this.nudTransferAmount);
            this.tabTransferBalance.Controls.Add(this.lblTotalAmount);
            this.tabTransferBalance.Controls.Add(this.cbTransferFromShowAccNumbers);
            this.tabTransferBalance.Controls.Add(this.lblTransferFrom);
            this.tabTransferBalance.Controls.Add(this.panel3);
            this.tabTransferBalance.Location = new System.Drawing.Point(4, 22);
            this.tabTransferBalance.Name = "tabTransferBalance";
            this.tabTransferBalance.Size = new System.Drawing.Size(955, 488);
            this.tabTransferBalance.TabIndex = 3;
            this.tabTransferBalance.Text = "TransferBalance";
            this.tabTransferBalance.UseVisualStyleBackColor = true;
            // 
            // lblTotalBalanceTransferTo
            // 
            this.lblTotalBalanceTransferTo.AutoSize = true;
            this.lblTotalBalanceTransferTo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceTransferTo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalBalanceTransferTo.Location = new System.Drawing.Point(567, 138);
            this.lblTotalBalanceTransferTo.Name = "lblTotalBalanceTransferTo";
            this.lblTotalBalanceTransferTo.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalanceTransferTo.TabIndex = 100;
            // 
            // lblTotalBalanceTransferFrom
            // 
            this.lblTotalBalanceTransferFrom.AutoSize = true;
            this.lblTotalBalanceTransferFrom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceTransferFrom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalBalanceTransferFrom.Location = new System.Drawing.Point(156, 138);
            this.lblTotalBalanceTransferFrom.Name = "lblTotalBalanceTransferFrom";
            this.lblTotalBalanceTransferFrom.Size = new System.Drawing.Size(0, 25);
            this.lblTotalBalanceTransferFrom.TabIndex = 99;
            // 
            // cbTransferToShowAccNumbers
            // 
            this.cbTransferToShowAccNumbers.BackColor = System.Drawing.Color.White;
            this.cbTransferToShowAccNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferToShowAccNumbers.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbTransferToShowAccNumbers.FormattingEnabled = true;
            this.cbTransferToShowAccNumbers.Location = new System.Drawing.Point(571, 98);
            this.cbTransferToShowAccNumbers.Name = "cbTransferToShowAccNumbers";
            this.cbTransferToShowAccNumbers.Size = new System.Drawing.Size(204, 21);
            this.cbTransferToShowAccNumbers.TabIndex = 98;
            this.cbTransferToShowAccNumbers.SelectedIndexChanged += new System.EventHandler(this.cbTransferChoseAccNumber_SelectedIndexChanged);
            this.cbTransferToShowAccNumbers.Click += new System.EventHandler(this.ComboBoxedOnClieck_TransferShowAccNumbers_Click);
            // 
            // lblTransferTo
            // 
            this.lblTransferTo.AutoSize = true;
            this.lblTransferTo.BackColor = System.Drawing.Color.White;
            this.lblTransferTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferTo.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTransferTo.Location = new System.Drawing.Point(571, 62);
            this.lblTransferTo.Name = "lblTransferTo";
            this.lblTransferTo.Size = new System.Drawing.Size(104, 19);
            this.lblTransferTo.TabIndex = 97;
            this.lblTransferTo.Text = "Transfer To";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Location = new System.Drawing.Point(572, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 96;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(398, 282);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(139, 53);
            this.btnTransfer.TabIndex = 95;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // nudTransferAmount
            // 
            this.nudTransferAmount.BackColor = System.Drawing.Color.RosyBrown;
            this.nudTransferAmount.Enabled = false;
            this.nudTransferAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nudTransferAmount.ForeColor = System.Drawing.Color.Black;
            this.nudTransferAmount.Location = new System.Drawing.Point(368, 209);
            this.nudTransferAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTransferAmount.Name = "nudTransferAmount";
            this.nudTransferAmount.Size = new System.Drawing.Size(203, 27);
            this.nudTransferAmount.TabIndex = 94;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTotalAmount.Location = new System.Drawing.Point(364, 177);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(121, 19);
            this.lblTotalAmount.TabIndex = 93;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // cbTransferFromShowAccNumbers
            // 
            this.cbTransferFromShowAccNumbers.BackColor = System.Drawing.Color.White;
            this.cbTransferFromShowAccNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferFromShowAccNumbers.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbTransferFromShowAccNumbers.FormattingEnabled = true;
            this.cbTransferFromShowAccNumbers.Location = new System.Drawing.Point(157, 98);
            this.cbTransferFromShowAccNumbers.Name = "cbTransferFromShowAccNumbers";
            this.cbTransferFromShowAccNumbers.Size = new System.Drawing.Size(204, 21);
            this.cbTransferFromShowAccNumbers.TabIndex = 92;
            this.cbTransferFromShowAccNumbers.SelectedIndexChanged += new System.EventHandler(this.cbTransferChoseAccNumber_SelectedIndexChanged);
            this.cbTransferFromShowAccNumbers.Click += new System.EventHandler(this.ComboBoxedOnClieck_TransferShowAccNumbers_Click);
            // 
            // lblTransferFrom
            // 
            this.lblTransferFrom.AutoSize = true;
            this.lblTransferFrom.BackColor = System.Drawing.Color.White;
            this.lblTransferFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferFrom.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTransferFrom.Location = new System.Drawing.Point(157, 62);
            this.lblTransferFrom.Name = "lblTransferFrom";
            this.lblTransferFrom.Size = new System.Drawing.Size(124, 19);
            this.lblTransferFrom.TabIndex = 91;
            this.lblTransferFrom.Text = "Transfer From";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Location = new System.Drawing.Point(158, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 90;
            // 
            // tabTransferLog
            // 
            this.tabTransferLog.Controls.Add(this.lblNumberOfClientsInTransferLogForm);
            this.tabTransferLog.Controls.Add(this.groupBox2);
            this.tabTransferLog.Controls.Add(this.label3);
            this.tabTransferLog.Controls.Add(this.panel5);
            this.tabTransferLog.Controls.Add(this.lvTransferLog);
            this.tabTransferLog.Location = new System.Drawing.Point(4, 22);
            this.tabTransferLog.Name = "tabTransferLog";
            this.tabTransferLog.Size = new System.Drawing.Size(955, 488);
            this.tabTransferLog.TabIndex = 4;
            this.tabTransferLog.Text = "TransferLog";
            this.tabTransferLog.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfClientsInTransferLogForm
            // 
            this.lblNumberOfClientsInTransferLogForm.AutoSize = true;
            this.lblNumberOfClientsInTransferLogForm.BackColor = System.Drawing.Color.White;
            this.lblNumberOfClientsInTransferLogForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfClientsInTransferLogForm.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblNumberOfClientsInTransferLogForm.Location = new System.Drawing.Point(17, 146);
            this.lblNumberOfClientsInTransferLogForm.Name = "lblNumberOfClientsInTransferLogForm";
            this.lblNumberOfClientsInTransferLogForm.Size = new System.Drawing.Size(0, 19);
            this.lblNumberOfClientsInTransferLogForm.TabIndex = 92;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDescTransferLog);
            this.groupBox2.Controls.Add(this.rbAccTransferLog);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox2.Location = new System.Drawing.Point(797, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 53);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting";
            // 
            // rbDescTransferLog
            // 
            this.rbDescTransferLog.ForeColor = System.Drawing.Color.Black;
            this.rbDescTransferLog.Location = new System.Drawing.Point(80, 19);
            this.rbDescTransferLog.Name = "rbDescTransferLog";
            this.rbDescTransferLog.Size = new System.Drawing.Size(57, 24);
            this.rbDescTransferLog.TabIndex = 1;
            this.rbDescTransferLog.TabStop = true;
            this.rbDescTransferLog.Text = "Desc";
            this.rbDescTransferLog.UseVisualStyleBackColor = true;
            this.rbDescTransferLog.CheckedChanged += new System.EventHandler(this.rbDescTransferLog_CheckedChanged);
            // 
            // rbAccTransferLog
            // 
            this.rbAccTransferLog.ForeColor = System.Drawing.Color.Black;
            this.rbAccTransferLog.Location = new System.Drawing.Point(6, 19);
            this.rbAccTransferLog.Name = "rbAccTransferLog";
            this.rbAccTransferLog.Size = new System.Drawing.Size(46, 24);
            this.rbAccTransferLog.TabIndex = 0;
            this.rbAccTransferLog.TabStop = true;
            this.rbAccTransferLog.Text = "Asc";
            this.rbAccTransferLog.UseVisualStyleBackColor = true;
            this.rbAccTransferLog.CheckedChanged += new System.EventHandler(this.rbAccTransferLog_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Search Acc. Number";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtSearchAccNumberTransferLog);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(21, 100);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel5.Size = new System.Drawing.Size(198, 21);
            this.panel5.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bank_C__Full_Project.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(157, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchAccNumberTransferLog
            // 
            this.txtSearchAccNumberTransferLog.BackColor = System.Drawing.Color.White;
            this.txtSearchAccNumberTransferLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchAccNumberTransferLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchAccNumberTransferLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccNumberTransferLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtSearchAccNumberTransferLog.Location = new System.Drawing.Point(0, 0);
            this.txtSearchAccNumberTransferLog.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtSearchAccNumberTransferLog.Name = "txtSearchAccNumberTransferLog";
            this.txtSearchAccNumberTransferLog.Size = new System.Drawing.Size(198, 20);
            this.txtSearchAccNumberTransferLog.TabIndex = 0;
            this.txtSearchAccNumberTransferLog.TextChanged += new System.EventHandler(this.txtSearchAccNumberTransferLog_TextChanged);
            // 
            // lvTransferLog
            // 
            this.lvTransferLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTransferLog.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lvTransferLog.FullRowSelect = true;
            this.lvTransferLog.GridLines = true;
            this.lvTransferLog.HideSelection = false;
            this.lvTransferLog.Location = new System.Drawing.Point(3, 195);
            this.lvTransferLog.Name = "lvTransferLog";
            this.lvTransferLog.Size = new System.Drawing.Size(949, 290);
            this.lvTransferLog.TabIndex = 78;
            this.lvTransferLog.UseCompatibleStateImageBehavior = false;
            this.lvTransferLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "AccNumber From";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "AccNumber To";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Amount";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date Transfer";
            this.columnHeader8.Width = 300;
            // 
            // frmClientTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 528);
            this.Controls.Add(this.tabManageClients);
            this.Name = "frmClientTransactions";
            this.Text = "frmClientTransactions";
            this.Load += new System.EventHandler(this.frmClientTransactions_Load);
            this.tabManageClients.ResumeLayout(false);
            this.tabDeopsit.ResumeLayout(false);
            this.tabDeopsit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositBalance)).EndInit();
            this.tabWithDraw.ResumeLayout(false);
            this.tabWithDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientWithDrawBalance)).EndInit();
            this.tabTotalBalances.ResumeLayout(false);
            this.tabTotalBalances.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabTransferBalance.ResumeLayout(false);
            this.tabTransferBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).EndInit();
            this.tabTransferLog.ResumeLayout(false);
            this.tabTransferLog.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageClients;
        private System.Windows.Forms.TabPage tabDeopsit;
        private System.Windows.Forms.TabPage tabWithDraw;
        private System.Windows.Forms.TabPage tabTotalBalances;
        private System.Windows.Forms.TabPage tabTransferBalance;
        private System.Windows.Forms.TabPage tabTransferLog;
        private System.Windows.Forms.ComboBox cbDepositAccNumbers;
        private System.Windows.Forms.Label lblDepositAccNumber;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.NumericUpDown nudDepositBalance;
        private System.Windows.Forms.Label lblDepositBalance;
        private System.Windows.Forms.Label lblCurrentBalanceDeposit;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithDraw;
        private System.Windows.Forms.NumericUpDown nudClientWithDrawBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientWithDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentBalanceWithDraw;
        private System.Windows.Forms.ListView lvShowClientsBalanceInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTotalBalancesSearch;
        private System.Windows.Forms.Label lblTotalBalancesNumber;
        private System.Windows.Forms.Label lblTotalBalancesWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSortingDesc;
        private System.Windows.Forms.RadioButton rbSortinAsc;
        private System.Windows.Forms.ComboBox cbTransferToShowAccNumbers;
        private System.Windows.Forms.Label lblTransferTo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.NumericUpDown nudTransferAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ComboBox cbTransferFromShowAccNumbers;
        private System.Windows.Forms.Label lblTransferFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBalanceTransferTo;
        private System.Windows.Forms.Label lblTotalBalanceTransferFrom;
        private System.Windows.Forms.ListView lvTransferLog;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchAccNumberTransferLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDescTransferLog;
        private System.Windows.Forms.RadioButton rbAccTransferLog;
        private System.Windows.Forms.Label lblNumberOfClientsInTransferLogForm;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}