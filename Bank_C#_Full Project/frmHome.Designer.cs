namespace Bank_C__Full_Project
{
    partial class frmHome
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnManageClient = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(368, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Welcome To Our Bank";
            // 
            // btnManageClient
            // 
            this.btnManageClient.BackColor = System.Drawing.Color.RosyBrown;
            this.btnManageClient.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClient.ForeColor = System.Drawing.Color.White;
            this.btnManageClient.Location = new System.Drawing.Point(316, 75);
            this.btnManageClient.Name = "btnManageClient";
            this.btnManageClient.Size = new System.Drawing.Size(362, 62);
            this.btnManageClient.TabIndex = 26;
            this.btnManageClient.Text = "Manage Client";
            this.btnManageClient.UseVisualStyleBackColor = false;
            this.btnManageClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTransactions.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(316, 177);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(362, 62);
            this.btnTransactions.TabIndex = 27;
            this.btnTransactions.Text = "Client Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.RosyBrown;
            this.btnManageUsers.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(316, 279);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(362, 62);
            this.btnManageUsers.TabIndex = 28;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyExchange.ForeColor = System.Drawing.Color.White;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(316, 383);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(362, 62);
            this.btnCurrencyExchange.TabIndex = 29;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.UseVisualStyleBackColor = false;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 513);
            this.Controls.Add(this.btnCurrencyExchange);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnManageClient);
            this.Controls.Add(this.label3);
            this.Name = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManageClient;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnCurrencyExchange;
    }
}