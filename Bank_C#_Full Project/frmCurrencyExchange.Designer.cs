namespace Bank_C__Full_Project
{
    partial class frmCurrencyExchange
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
            this.tabUpdateRate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrenyInfo = new System.Windows.Forms.Label();
            this.cbUpdateRateCurrencyCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.tabShowCurrencies = new System.Windows.Forms.TabPage();
            this.lvShowCurrencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSortinAsc = new System.Windows.Forms.RadioButton();
            this.rbSortingDesc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabManageClients = new System.Windows.Forms.TabControl();
            this.lblCurrencyFrom = new System.Windows.Forms.Label();
            this.cbCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.cbCurrencyTo = new System.Windows.Forms.ComboBox();
            this.lblCurrencyFromShowInfo = new System.Windows.Forms.Label();
            this.tabCurrencyCalculator = new System.Windows.Forms.TabPage();
            this.lblCurrencyToShowInfo = new System.Windows.Forms.Label();
            this.nudConvertCurrency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAmountExchange = new System.Windows.Forms.Label();
            this.tabUpdateRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).BeginInit();
            this.tabShowCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabManageClients.SuspendLayout();
            this.tabCurrencyCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvertCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUpdateRate
            // 
            this.tabUpdateRate.BackColor = System.Drawing.Color.White;
            this.tabUpdateRate.Controls.Add(this.btnUpdateRate);
            this.tabUpdateRate.Controls.Add(this.numUpdateRate);
            this.tabUpdateRate.Controls.Add(this.label7);
            this.tabUpdateRate.Controls.Add(this.cbUpdateRateCurrencyCode);
            this.tabUpdateRate.Controls.Add(this.lblCurrenyInfo);
            this.tabUpdateRate.Controls.Add(this.label2);
            this.tabUpdateRate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateRate.Name = "tabUpdateRate";
            this.tabUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateRate.Size = new System.Drawing.Size(944, 479);
            this.tabUpdateRate.TabIndex = 1;
            this.tabUpdateRate.Text = "Update Rate";
            this.tabUpdateRate.Click += new System.EventHandler(this.tabUpdateRate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Currency Code";
            // 
            // lblCurrenyInfo
            // 
            this.lblCurrenyInfo.AutoSize = true;
            this.lblCurrenyInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyInfo.Location = new System.Drawing.Point(24, 108);
            this.lblCurrenyInfo.Name = "lblCurrenyInfo";
            this.lblCurrenyInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyInfo.TabIndex = 45;
            // 
            // cbUpdateRateCurrencyCode
            // 
            this.cbUpdateRateCurrencyCode.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbUpdateRateCurrencyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUpdateRateCurrencyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUpdateRateCurrencyCode.BackColor = System.Drawing.Color.White;
            this.cbUpdateRateCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateRateCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbUpdateRateCurrencyCode.FormattingEnabled = true;
            this.cbUpdateRateCurrencyCode.Location = new System.Drawing.Point(28, 61);
            this.cbUpdateRateCurrencyCode.Name = "cbUpdateRateCurrencyCode";
            this.cbUpdateRateCurrencyCode.Size = new System.Drawing.Size(198, 24);
            this.cbUpdateRateCurrencyCode.TabIndex = 47;
            this.cbUpdateRateCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbUpdateRateCurrencyCode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(24, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "New Rate ($)";
            // 
            // numUpdateRate
            // 
            this.numUpdateRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numUpdateRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdateRate.DecimalPlaces = 5;
            this.numUpdateRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdateRate.Location = new System.Drawing.Point(28, 238);
            this.numUpdateRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpdateRate.Name = "numUpdateRate";
            this.numUpdateRate.Size = new System.Drawing.Size(198, 27);
            this.numUpdateRate.TabIndex = 49;
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateRate.Location = new System.Drawing.Point(28, 324);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(198, 49);
            this.btnUpdateRate.TabIndex = 50;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // tabShowCurrencies
            // 
            this.tabShowCurrencies.BackColor = System.Drawing.Color.White;
            this.tabShowCurrencies.Controls.Add(this.label1);
            this.tabShowCurrencies.Controls.Add(this.groupBox1);
            this.tabShowCurrencies.Controls.Add(this.pictureBox1);
            this.tabShowCurrencies.Controls.Add(this.panel1);
            this.tabShowCurrencies.Controls.Add(this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList);
            this.tabShowCurrencies.Controls.Add(this.lvShowCurrencies);
            this.tabShowCurrencies.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabShowCurrencies.ForeColor = System.Drawing.Color.White;
            this.tabShowCurrencies.Location = new System.Drawing.Point(4, 22);
            this.tabShowCurrencies.Name = "tabShowCurrencies";
            this.tabShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowCurrencies.Size = new System.Drawing.Size(944, 479);
            this.tabShowCurrencies.TabIndex = 0;
            this.tabShowCurrencies.Text = "Show Currencies";
            this.tabShowCurrencies.Click += new System.EventHandler(this.tabShowClients_Click);
            // 
            // lvShowCurrencies
            // 
            this.lvShowCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvShowCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShowCurrencies.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lvShowCurrencies.FullRowSelect = true;
            this.lvShowCurrencies.GridLines = true;
            this.lvShowCurrencies.HideSelection = false;
            this.lvShowCurrencies.Location = new System.Drawing.Point(6, 153);
            this.lvShowCurrencies.Name = "lvShowCurrencies";
            this.lvShowCurrencies.Size = new System.Drawing.Size(931, 323);
            this.lvShowCurrencies.TabIndex = 0;
            this.lvShowCurrencies.UseCompatibleStateImageBehavior = false;
            this.lvShowCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Country Name";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Currency Code";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Currency Name";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rate";
            this.columnHeader4.Width = 220;
            // 
            // txtSearchByCurrencyCodeOrCountryForShowCurrencyList
            // 
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.Location = new System.Drawing.Point(14, 79);
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.Name = "txtSearchByCurrencyCodeOrCountryForShowCurrencyList";
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.Size = new System.Drawing.Size(197, 17);
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.TabIndex = 1;
            this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList.TextChanged += new System.EventHandler(this.txtSearchByCurrencyCodeOrCountryForShowCurrencyList_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(14, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_C__Full_Project.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(185, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSortingDesc);
            this.groupBox1.Controls.Add(this.rbSortinAsc);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(794, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Currency\r\nCode/Country";
            // 
            // tabManageClients
            // 
            this.tabManageClients.Controls.Add(this.tabShowCurrencies);
            this.tabManageClients.Controls.Add(this.tabUpdateRate);
            this.tabManageClients.Controls.Add(this.tabCurrencyCalculator);
            this.tabManageClients.Location = new System.Drawing.Point(245, 2);
            this.tabManageClients.Name = "tabManageClients";
            this.tabManageClients.SelectedIndex = 0;
            this.tabManageClients.Size = new System.Drawing.Size(952, 505);
            this.tabManageClients.TabIndex = 1;
            this.tabManageClients.SelectedIndexChanged += new System.EventHandler(this.tabManageClients_SelectedIndexChanged);
            // 
            // lblCurrencyFrom
            // 
            this.lblCurrencyFrom.AutoSize = true;
            this.lblCurrencyFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrencyFrom.Location = new System.Drawing.Point(126, 75);
            this.lblCurrencyFrom.Name = "lblCurrencyFrom";
            this.lblCurrencyFrom.Size = new System.Drawing.Size(123, 19);
            this.lblCurrencyFrom.TabIndex = 48;
            this.lblCurrencyFrom.Text = "Currency From";
            // 
            // cbCurrencyFrom
            // 
            this.cbCurrencyFrom.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyFrom.BackColor = System.Drawing.Color.White;
            this.cbCurrencyFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyFrom.FormattingEnabled = true;
            this.cbCurrencyFrom.Location = new System.Drawing.Point(130, 108);
            this.cbCurrencyFrom.Name = "cbCurrencyFrom";
            this.cbCurrencyFrom.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyFrom.TabIndex = 49;
            this.cbCurrencyFrom.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyFrom_SelectedIndexChanged);
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrencyTo.Location = new System.Drawing.Point(467, 75);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(101, 19);
            this.lblCurrencyTo.TabIndex = 50;
            this.lblCurrencyTo.Text = "Currency To";
            // 
            // cbCurrencyTo
            // 
            this.cbCurrencyTo.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyTo.BackColor = System.Drawing.Color.White;
            this.cbCurrencyTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyTo.FormattingEnabled = true;
            this.cbCurrencyTo.Location = new System.Drawing.Point(471, 108);
            this.cbCurrencyTo.Name = "cbCurrencyTo";
            this.cbCurrencyTo.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyTo.TabIndex = 51;
            this.cbCurrencyTo.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyTo_SelectedIndexChanged);
            // 
            // lblCurrencyFromShowInfo
            // 
            this.lblCurrencyFromShowInfo.AutoSize = true;
            this.lblCurrencyFromShowInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyFromShowInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrencyFromShowInfo.Location = new System.Drawing.Point(126, 151);
            this.lblCurrencyFromShowInfo.Name = "lblCurrencyFromShowInfo";
            this.lblCurrencyFromShowInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrencyFromShowInfo.TabIndex = 52;
            // 
            // tabCurrencyCalculator
            // 
            this.tabCurrencyCalculator.BackColor = System.Drawing.Color.White;
            this.tabCurrencyCalculator.Controls.Add(this.lblAmountExchange);
            this.tabCurrencyCalculator.Controls.Add(this.btnConvert);
            this.tabCurrencyCalculator.Controls.Add(this.nudConvertCurrency);
            this.tabCurrencyCalculator.Controls.Add(this.label3);
            this.tabCurrencyCalculator.Controls.Add(this.lblCurrencyToShowInfo);
            this.tabCurrencyCalculator.Controls.Add(this.lblCurrencyFromShowInfo);
            this.tabCurrencyCalculator.Controls.Add(this.cbCurrencyTo);
            this.tabCurrencyCalculator.Controls.Add(this.lblCurrencyTo);
            this.tabCurrencyCalculator.Controls.Add(this.cbCurrencyFrom);
            this.tabCurrencyCalculator.Controls.Add(this.lblCurrencyFrom);
            this.tabCurrencyCalculator.Location = new System.Drawing.Point(4, 22);
            this.tabCurrencyCalculator.Name = "tabCurrencyCalculator";
            this.tabCurrencyCalculator.Size = new System.Drawing.Size(944, 479);
            this.tabCurrencyCalculator.TabIndex = 2;
            this.tabCurrencyCalculator.Text = "Currency Calculator";
            this.tabCurrencyCalculator.Click += new System.EventHandler(this.tabCurrencyCalculator_Click);
            // 
            // lblCurrencyToShowInfo
            // 
            this.lblCurrencyToShowInfo.AutoSize = true;
            this.lblCurrencyToShowInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyToShowInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrencyToShowInfo.Location = new System.Drawing.Point(467, 151);
            this.lblCurrencyToShowInfo.Name = "lblCurrencyToShowInfo";
            this.lblCurrencyToShowInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrencyToShowInfo.TabIndex = 53;
            // 
            // nudConvertCurrency
            // 
            this.nudConvertCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nudConvertCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudConvertCurrency.DecimalPlaces = 5;
            this.nudConvertCurrency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConvertCurrency.Location = new System.Drawing.Point(130, 264);
            this.nudConvertCurrency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudConvertCurrency.Name = "nudConvertCurrency";
            this.nudConvertCurrency.Size = new System.Drawing.Size(198, 27);
            this.nudConvertCurrency.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(126, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Amount to Exchange";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnConvert.Location = new System.Drawing.Point(130, 325);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(198, 49);
            this.btnConvert.TabIndex = 56;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAmountExchange
            // 
            this.lblAmountExchange.AutoSize = true;
            this.lblAmountExchange.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAmountExchange.Location = new System.Drawing.Point(135, 394);
            this.lblAmountExchange.Name = "lblAmountExchange";
            this.lblAmountExchange.Size = new System.Drawing.Size(0, 28);
            this.lblAmountExchange.TabIndex = 57;
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 519);
            this.Controls.Add(this.tabManageClients);
            this.Name = "frmCurrencyExchange";
            this.Text = "frmCurrencyExchange";
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            this.tabUpdateRate.ResumeLayout(false);
            this.tabUpdateRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).EndInit();
            this.tabShowCurrencies.ResumeLayout(false);
            this.tabShowCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabManageClients.ResumeLayout(false);
            this.tabCurrencyCalculator.ResumeLayout(false);
            this.tabCurrencyCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvertCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabUpdateRate;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.NumericUpDown numUpdateRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUpdateRateCurrencyCode;
        private System.Windows.Forms.Label lblCurrenyInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabShowCurrencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSortingDesc;
        private System.Windows.Forms.RadioButton rbSortinAsc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchByCurrencyCodeOrCountryForShowCurrencyList;
        private System.Windows.Forms.ListView lvShowCurrencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabManageClients;
        private System.Windows.Forms.TabPage tabCurrencyCalculator;
        private System.Windows.Forms.Label lblCurrencyFromShowInfo;
        private System.Windows.Forms.ComboBox cbCurrencyTo;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.ComboBox cbCurrencyFrom;
        private System.Windows.Forms.Label lblCurrencyFrom;
        private System.Windows.Forms.Label lblCurrencyToShowInfo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.NumericUpDown nudConvertCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmountExchange;
    }
}