namespace Bank
{
    partial class Bank
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
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtTransaction = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSendFrom = new System.Windows.Forms.TextBox();
            this.lblSendFrom = new System.Windows.Forms.Label();
            this.txtSendTo = new System.Windows.Forms.TextBox();
            this.lblSentTo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(48, 88);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(95, 16);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(149, 88);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(199, 22);
            this.txtAccountName.TabIndex = 1;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(149, 138);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(199, 22);
            this.txtAccountNo.TabIndex = 3;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(48, 138);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(79, 16);
            this.lblAccountNo.TabIndex = 2;
            this.lblAccountNo.Text = "Account No.";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(149, 188);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(199, 22);
            this.txtBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(48, 188);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(51, 36);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(297, 22);
            this.txtAccount.TabIndex = 6;
            this.txtAccount.Text = "Account Details";
            this.txtAccount.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTransaction
            // 
            this.txtTransaction.Location = new System.Drawing.Point(425, 36);
            this.txtTransaction.Name = "txtTransaction";
            this.txtTransaction.Size = new System.Drawing.Size(311, 22);
            this.txtTransaction.TabIndex = 13;
            this.txtTransaction.Text = "Transactions";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(501, 182);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(235, 22);
            this.txtAmount.TabIndex = 12;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(422, 188);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount";
            // 
            // txtSendFrom
            // 
            this.txtSendFrom.Location = new System.Drawing.Point(501, 135);
            this.txtSendFrom.Name = "txtSendFrom";
            this.txtSendFrom.Size = new System.Drawing.Size(235, 22);
            this.txtSendFrom.TabIndex = 10;
            // 
            // lblSendFrom
            // 
            this.lblSendFrom.AutoSize = true;
            this.lblSendFrom.Location = new System.Drawing.Point(422, 138);
            this.lblSendFrom.Name = "lblSendFrom";
            this.lblSendFrom.Size = new System.Drawing.Size(73, 16);
            this.lblSendFrom.TabIndex = 9;
            this.lblSendFrom.Text = "Send From";
            // 
            // txtSendTo
            // 
            this.txtSendTo.Location = new System.Drawing.Point(501, 88);
            this.txtSendTo.Name = "txtSendTo";
            this.txtSendTo.Size = new System.Drawing.Size(235, 22);
            this.txtSendTo.TabIndex = 8;
            // 
            // lblSentTo
            // 
            this.lblSentTo.AutoSize = true;
            this.lblSentTo.Location = new System.Drawing.Point(422, 88);
            this.lblSentTo.Name = "lblSentTo";
            this.lblSentTo.Size = new System.Drawing.Size(59, 16);
            this.lblSentTo.TabIndex = 7;
            this.lblSentTo.Text = "Send To";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(51, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 60);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.Blue;
            this.btnGet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(275, 242);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(172, 60);
            this.btnGet.TabIndex = 15;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(51, 322);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(396, 101);
            this.dgvAccounts.TabIndex = 16;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTransaction);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtSendFrom);
            this.Controls.Add(this.lblSendFrom);
            this.Controls.Add(this.txtSendTo);
            this.Controls.Add(this.lblSentTo);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Name = "Bank";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSendFrom;
        private System.Windows.Forms.Label lblSendFrom;
        private System.Windows.Forms.TextBox txtSendTo;
        private System.Windows.Forms.Label lblSentTo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridView dgvAccounts;
    }
}

