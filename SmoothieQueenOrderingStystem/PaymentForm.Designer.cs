namespace SmoothieQueenOrderingStystem
{
    partial class PaymentForm
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
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lstCardTypes = new System.Windows.Forms.ListBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cmbExpMonth = new System.Windows.Forms.ComboBox();
            this.cmbExpYear = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkDefaultOption = new System.Windows.Forms.CheckBox();
            this.lblCashReceived = new System.Windows.Forms.Label();
            this.txtCashReceived = new System.Windows.Forms.TextBox();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.rdoCreditCard);
            this.grpPaymentMethod.Controls.Add(this.rdoCash);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentMethod.Location = new System.Drawing.Point(105, 48);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(734, 138);
            this.grpPaymentMethod.TabIndex = 0;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Payment Options";
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(35, 80);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(109, 35);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(327, 80);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(184, 35);
            this.rdoCreditCard.TabIndex = 1;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.rdoCreditCard_CheckedChanged);
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(108, 278);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(141, 31);
            this.lblCardType.TabIndex = 1;
            this.lblCardType.Text = "Card Type";
            // 
            // lstCardTypes
            // 
            this.lstCardTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCardTypes.FormattingEnabled = true;
            this.lstCardTypes.ItemHeight = 31;
            this.lstCardTypes.Items.AddRange(new object[] {
            "American Express",
            "Discover",
            "Mastercard",
            "Visa"});
            this.lstCardTypes.Location = new System.Drawing.Point(432, 278);
            this.lstCardTypes.Name = "lstCardTypes";
            this.lstCardTypes.Size = new System.Drawing.Size(407, 159);
            this.lstCardTypes.TabIndex = 2;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(108, 482);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(176, 31);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(432, 475);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(407, 38);
            this.txtCardNumber.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(108, 579);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(199, 31);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // cmbExpMonth
            // 
            this.cmbExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpMonth.FormattingEnabled = true;
            this.cmbExpMonth.Location = new System.Drawing.Point(432, 579);
            this.cmbExpMonth.Name = "cmbExpMonth";
            this.cmbExpMonth.Size = new System.Drawing.Size(192, 39);
            this.cmbExpMonth.TabIndex = 6;
            this.cmbExpMonth.Text = "Month";
            this.cmbExpMonth.SelectedIndexChanged += new System.EventHandler(this.cmbExpMonth_SelectedIndexChanged);
            // 
            // cmbExpYear
            // 
            this.cmbExpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpYear.FormattingEnabled = true;
            this.cmbExpYear.Location = new System.Drawing.Point(647, 579);
            this.cmbExpYear.Name = "cmbExpYear";
            this.cmbExpYear.Size = new System.Drawing.Size(192, 39);
            this.cmbExpYear.TabIndex = 7;
            this.cmbExpYear.Text = "Year";
            this.cmbExpYear.SelectedIndexChanged += new System.EventHandler(this.cmbExpYear_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Location = new System.Drawing.Point(395, 768);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(237, 67);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(647, 768);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 67);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkDefaultOption
            // 
            this.chkDefaultOption.AutoSize = true;
            this.chkDefaultOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultOption.Location = new System.Drawing.Point(432, 676);
            this.chkDefaultOption.Name = "chkDefaultOption";
            this.chkDefaultOption.Size = new System.Drawing.Size(352, 35);
            this.chkDefaultOption.TabIndex = 10;
            this.chkDefaultOption.Text = "Save as Default Payment";
            this.chkDefaultOption.UseVisualStyleBackColor = true;
            // 
            // lblCashReceived
            // 
            this.lblCashReceived.AutoSize = true;
            this.lblCashReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReceived.Location = new System.Drawing.Point(108, 226);
            this.lblCashReceived.Name = "lblCashReceived";
            this.lblCashReceived.Size = new System.Drawing.Size(199, 31);
            this.lblCashReceived.TabIndex = 11;
            this.lblCashReceived.Text = "Cash Received";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashReceived.Location = new System.Drawing.Point(432, 226);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(407, 38);
            this.txtCashReceived.TabIndex = 12;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(944, 863);
            this.Controls.Add(this.txtCashReceived);
            this.Controls.Add(this.lblCashReceived);
            this.Controls.Add(this.chkDefaultOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbExpYear);
            this.Controls.Add(this.cmbExpMonth);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lstCardTypes);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.grpPaymentMethod);
            this.Name = "PaymentForm";
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.ListBox lstCardTypes;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cmbExpMonth;
        private System.Windows.Forms.ComboBox cmbExpYear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDefaultOption;
        private System.Windows.Forms.Label lblCashReceived;
        private System.Windows.Forms.TextBox txtCashReceived;
    }
}