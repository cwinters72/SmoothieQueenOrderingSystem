namespace SmoothieQueenOrderingStystem
{
    partial class frmSmoothieQueen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSmoothieQueen));
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSizesList = new System.Windows.Forms.ComboBox();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.rdoOrganic = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMesquitePowder = new System.Windows.Forms.CheckBox();
            this.chkGojiBerries = new System.Windows.Forms.CheckBox();
            this.chkEnergyBooster = new System.Windows.Forms.CheckBox();
            this.chkChiaSeeds = new System.Windows.Forms.CheckBox();
            this.chkAcaiPowder = new System.Windows.Forms.CheckBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlPriceList = new System.Windows.Forms.Panel();
            this.lblNumOfSmoothies = new System.Windows.Forms.Label();
            this.lblSmoothieTotal = new System.Windows.Forms.Label();
            this.lblAddInCharge = new System.Windows.Forms.Label();
            this.lblOrganic = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSmoothiePrice = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSmoothieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpStyle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPriceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(1704, 40);
            this.mnuMenuStrip.TabIndex = 1;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.cancelSmoothieToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 482);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSizesList
            // 
            this.cmbSizesList.BackColor = System.Drawing.Color.White;
            this.cmbSizesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizesList.FormattingEnabled = true;
            this.cmbSizesList.Location = new System.Drawing.Point(46, 362);
            this.cmbSizesList.Name = "cmbSizesList";
            this.cmbSizesList.Size = new System.Drawing.Size(421, 45);
            this.cmbSizesList.TabIndex = 4;
            this.cmbSizesList.Text = "Select Your Size";
            this.cmbSizesList.SelectedIndexChanged += new System.EventHandler(this.cmbSizesList_SelectedIndexChanged);
            // 
            // grpStyle
            // 
            this.grpStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpStyle.Controls.Add(this.rdoOrganic);
            this.grpStyle.Controls.Add(this.rdoRegular);
            this.grpStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStyle.ForeColor = System.Drawing.Color.Black;
            this.grpStyle.Location = new System.Drawing.Point(46, 98);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(421, 214);
            this.grpStyle.TabIndex = 5;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Delicious or Nutritious";
            // 
            // rdoOrganic
            // 
            this.rdoOrganic.AutoSize = true;
            this.rdoOrganic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOrganic.Location = new System.Drawing.Point(22, 117);
            this.rdoOrganic.Name = "rdoOrganic";
            this.rdoOrganic.Size = new System.Drawing.Size(170, 41);
            this.rdoOrganic.TabIndex = 1;
            this.rdoOrganic.Text = "Organic ";
            this.rdoOrganic.UseVisualStyleBackColor = true;
            this.rdoOrganic.CheckedChanged += new System.EventHandler(this.rdoOrganic_CheckedChanged);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Checked = true;
            this.rdoRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegular.Location = new System.Drawing.Point(22, 54);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(159, 41);
            this.rdoRegular.TabIndex = 0;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.rdoRegular_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMesquitePowder);
            this.panel1.Controls.Add(this.chkGojiBerries);
            this.panel1.Controls.Add(this.chkEnergyBooster);
            this.panel1.Controls.Add(this.chkChiaSeeds);
            this.panel1.Controls.Add(this.chkAcaiPowder);
            this.panel1.Location = new System.Drawing.Point(46, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 346);
            this.panel1.TabIndex = 6;
            // 
            // chkMesquitePowder
            // 
            this.chkMesquitePowder.AutoSize = true;
            this.chkMesquitePowder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMesquitePowder.Location = new System.Drawing.Point(22, 280);
            this.chkMesquitePowder.Name = "chkMesquitePowder";
            this.chkMesquitePowder.Size = new System.Drawing.Size(294, 41);
            this.chkMesquitePowder.TabIndex = 4;
            this.chkMesquitePowder.Text = "Mesquite Powder";
            this.chkMesquitePowder.UseVisualStyleBackColor = true;
            this.chkMesquitePowder.CheckedChanged += new System.EventHandler(this.chkMesquitePowder_CheckedChanged);
            // 
            // chkGojiBerries
            // 
            this.chkGojiBerries.AutoSize = true;
            this.chkGojiBerries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGojiBerries.Location = new System.Drawing.Point(22, 218);
            this.chkGojiBerries.Name = "chkGojiBerries";
            this.chkGojiBerries.Size = new System.Drawing.Size(215, 41);
            this.chkGojiBerries.TabIndex = 3;
            this.chkGojiBerries.Text = "Goji Berries";
            this.chkGojiBerries.UseVisualStyleBackColor = true;
            this.chkGojiBerries.CheckedChanged += new System.EventHandler(this.chkGojiBerries_CheckedChanged);
            // 
            // chkEnergyBooster
            // 
            this.chkEnergyBooster.AutoSize = true;
            this.chkEnergyBooster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnergyBooster.Location = new System.Drawing.Point(22, 154);
            this.chkEnergyBooster.Name = "chkEnergyBooster";
            this.chkEnergyBooster.Size = new System.Drawing.Size(268, 41);
            this.chkEnergyBooster.TabIndex = 2;
            this.chkEnergyBooster.Text = "Energy Booster";
            this.chkEnergyBooster.UseVisualStyleBackColor = true;
            this.chkEnergyBooster.CheckedChanged += new System.EventHandler(this.chkEnergyBooster_CheckedChanged);
            // 
            // chkChiaSeeds
            // 
            this.chkChiaSeeds.AutoSize = true;
            this.chkChiaSeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChiaSeeds.Location = new System.Drawing.Point(22, 98);
            this.chkChiaSeeds.Name = "chkChiaSeeds";
            this.chkChiaSeeds.Size = new System.Drawing.Size(213, 41);
            this.chkChiaSeeds.TabIndex = 1;
            this.chkChiaSeeds.Text = "Chia Seeds";
            this.chkChiaSeeds.UseVisualStyleBackColor = true;
            this.chkChiaSeeds.CheckedChanged += new System.EventHandler(this.chkChiaSeeds_CheckedChanged);
            // 
            // chkAcaiPowder
            // 
            this.chkAcaiPowder.AutoSize = true;
            this.chkAcaiPowder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAcaiPowder.Location = new System.Drawing.Point(22, 32);
            this.chkAcaiPowder.Name = "chkAcaiPowder";
            this.chkAcaiPowder.Size = new System.Drawing.Size(229, 41);
            this.chkAcaiPowder.TabIndex = 0;
            this.chkAcaiPowder.Text = "Acai Powder";
            this.chkAcaiPowder.UseVisualStyleBackColor = true;
            this.chkAcaiPowder.CheckedChanged += new System.EventHandler(this.chkAcaiPowder_CheckedChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddToOrder.Location = new System.Drawing.Point(627, 941);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(237, 67);
            this.btnAddToOrder.TabIndex = 7;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(1423, 941);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 67);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckOut.Location = new System.Drawing.Point(1025, 941);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(237, 67);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pnlPriceList
            // 
            this.pnlPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlPriceList.Controls.Add(this.lblNumOfSmoothies);
            this.pnlPriceList.Controls.Add(this.lblSmoothieTotal);
            this.pnlPriceList.Controls.Add(this.lblAddInCharge);
            this.pnlPriceList.Controls.Add(this.lblOrganic);
            this.pnlPriceList.Controls.Add(this.lblSize);
            this.pnlPriceList.Location = new System.Drawing.Point(627, 622);
            this.pnlPriceList.Name = "pnlPriceList";
            this.pnlPriceList.Size = new System.Drawing.Size(1033, 226);
            this.pnlPriceList.TabIndex = 10;
            // 
            // lblNumOfSmoothies
            // 
            this.lblNumOfSmoothies.AutoSize = true;
            this.lblNumOfSmoothies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfSmoothies.Location = new System.Drawing.Point(24, 140);
            this.lblNumOfSmoothies.Name = "lblNumOfSmoothies";
            this.lblNumOfSmoothies.Size = new System.Drawing.Size(236, 31);
            this.lblNumOfSmoothies.TabIndex = 4;
            this.lblNumOfSmoothies.Text = "Num of Smoothies";
            // 
            // lblSmoothieTotal
            // 
            this.lblSmoothieTotal.AutoSize = true;
            this.lblSmoothieTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothieTotal.Location = new System.Drawing.Point(396, 74);
            this.lblSmoothieTotal.Name = "lblSmoothieTotal";
            this.lblSmoothieTotal.Size = new System.Drawing.Size(374, 55);
            this.lblSmoothieTotal.TabIndex = 3;
            this.lblSmoothieTotal.Text = "Smoothie Total:";
            // 
            // lblAddInCharge
            // 
            this.lblAddInCharge.AutoSize = true;
            this.lblAddInCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInCharge.Location = new System.Drawing.Point(24, 98);
            this.lblAddInCharge.Name = "lblAddInCharge";
            this.lblAddInCharge.Size = new System.Drawing.Size(210, 31);
            this.lblAddInCharge.TabIndex = 2;
            this.lblAddInCharge.Text = "Add In Charge:  ";
            // 
            // lblOrganic
            // 
            this.lblOrganic.AutoSize = true;
            this.lblOrganic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganic.Location = new System.Drawing.Point(24, 59);
            this.lblOrganic.Name = "lblOrganic";
            this.lblOrganic.Size = new System.Drawing.Size(227, 31);
            this.lblOrganic.TabIndex = 1;
            this.lblOrganic.Text = "Organic Charge:  ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(24, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(185, 31);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size Charge:  ";
            // 
            // lblSmoothiePrice
            // 
            this.lblSmoothiePrice.AutoSize = true;
            this.lblSmoothiePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSmoothiePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothiePrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblSmoothiePrice.Location = new System.Drawing.Point(621, 588);
            this.lblSmoothiePrice.Name = "lblSmoothiePrice";
            this.lblSmoothiePrice.Size = new System.Drawing.Size(211, 31);
            this.lblSmoothiePrice.TabIndex = 0;
            this.lblSmoothiePrice.Text = "Smoothie Price";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(347, 433);
            this.numQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 44);
            this.numQuantity.TabIndex = 11;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(39, 433);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(280, 37);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Smoothie Quantity";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.addToOrderToolStripMenuItem.Text = "Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cancelSmoothieToolStripMenuItem
            // 
            this.cancelSmoothieToolStripMenuItem.Name = "cancelSmoothieToolStripMenuItem";
            this.cancelSmoothieToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.cancelSmoothieToolStripMenuItem.Text = "Cancel Smoothie";
            this.cancelSmoothieToolStripMenuItem.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmSmoothieQueen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1704, 1054);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblSmoothiePrice);
            this.Controls.Add(this.pnlPriceList);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.cmbSizesList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMenuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.mnuMenuStrip;
            this.Name = "frmSmoothieQueen";
            this.Text = "Smoothie Queen";
            this.Load += new System.EventHandler(this.SmoothieQueen_Load);
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPriceList.ResumeLayout(false);
            this.pnlPriceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSizesList;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.RadioButton rdoOrganic;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkMesquitePowder;
        private System.Windows.Forms.CheckBox chkGojiBerries;
        private System.Windows.Forms.CheckBox chkEnergyBooster;
        private System.Windows.Forms.CheckBox chkChiaSeeds;
        private System.Windows.Forms.CheckBox chkAcaiPowder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlPriceList;
        private System.Windows.Forms.Label lblSmoothiePrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOrganic;
        private System.Windows.Forms.Label lblAddInCharge;
        private System.Windows.Forms.Label lblSmoothieTotal;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblNumOfSmoothies;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelSmoothieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

