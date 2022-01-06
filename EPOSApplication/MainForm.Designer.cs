namespace EPOSApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.unitsInputPanel = new System.Windows.Forms.Panel();
            this.unitsInputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfUnitsLabel = new System.Windows.Forms.Label();
            this.suitSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.suitSizeListBox = new System.Windows.Forms.ListBox();
            this.suitBrandGroupBox = new System.Windows.Forms.GroupBox();
            this.suitBrandListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.searchOrdersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.cartViewPanel = new System.Windows.Forms.Panel();
            this.cartCountLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.cartItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.SuitBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalPanel = new System.Windows.Forms.Panel();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalValueLabel = new System.Windows.Forms.Label();
            this.orderIDPanel = new System.Windows.Forms.Panel();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.orderIDValueLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.myCartLabel = new System.Windows.Forms.Label();
            this.specterSuitsLabel = new System.Windows.Forms.Label();
            this.totalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.specterSuitsLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.clearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.viewInventoryButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reportButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addToCartButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkoutButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.unitInputButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuPanel.SuspendLayout();
            this.unitsInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInputNumericUpDown)).BeginInit();
            this.suitSizeGroupBox.SuspendLayout();
            this.suitBrandGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cartViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemsDataGridView)).BeginInit();
            this.subTotalPanel.SuspendLayout();
            this.orderIDPanel.SuspendLayout();
            this.totalPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specterSuitsLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMenuPanel.Controls.Add(this.unitsInputPanel);
            this.mainMenuPanel.Controls.Add(this.suitSizeGroupBox);
            this.mainMenuPanel.Controls.Add(this.suitBrandGroupBox);
            this.mainMenuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuPanel.Location = new System.Drawing.Point(244, 12);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(491, 372);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // unitsInputPanel
            // 
            this.unitsInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitsInputPanel.Controls.Add(this.unitsInputNumericUpDown);
            this.unitsInputPanel.Controls.Add(this.numberOfUnitsLabel);
            this.unitsInputPanel.Location = new System.Drawing.Point(244, 213);
            this.unitsInputPanel.Name = "unitsInputPanel";
            this.unitsInputPanel.Size = new System.Drawing.Size(220, 108);
            this.unitsInputPanel.TabIndex = 2;
            // 
            // unitsInputNumericUpDown
            // 
            this.unitsInputNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.unitsInputNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.unitsInputNumericUpDown.Location = new System.Drawing.Point(54, 49);
            this.unitsInputNumericUpDown.Name = "unitsInputNumericUpDown";
            this.unitsInputNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.unitsInputNumericUpDown.TabIndex = 3;
            this.unitInputButtonToolTip.SetToolTip(this.unitsInputNumericUpDown, "How many units do you need?");
            // 
            // numberOfUnitsLabel
            // 
            this.numberOfUnitsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.numberOfUnitsLabel.AutoSize = true;
            this.numberOfUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfUnitsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numberOfUnitsLabel.Location = new System.Drawing.Point(59, 12);
            this.numberOfUnitsLabel.Name = "numberOfUnitsLabel";
            this.numberOfUnitsLabel.Size = new System.Drawing.Size(109, 20);
            this.numberOfUnitsLabel.TabIndex = 0;
            this.numberOfUnitsLabel.Text = "No. of Units";
            // 
            // suitSizeGroupBox
            // 
            this.suitSizeGroupBox.Controls.Add(this.suitSizeListBox);
            this.suitSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitSizeGroupBox.ForeColor = System.Drawing.Color.White;
            this.suitSizeGroupBox.Location = new System.Drawing.Point(244, 19);
            this.suitSizeGroupBox.Name = "suitSizeGroupBox";
            this.suitSizeGroupBox.Size = new System.Drawing.Size(220, 175);
            this.suitSizeGroupBox.TabIndex = 1;
            this.suitSizeGroupBox.TabStop = false;
            this.suitSizeGroupBox.Text = "Size(s)";
            // 
            // suitSizeListBox
            // 
            this.suitSizeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.suitSizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suitSizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitSizeListBox.ForeColor = System.Drawing.Color.White;
            this.suitSizeListBox.FormattingEnabled = true;
            this.suitSizeListBox.ItemHeight = 18;
            this.suitSizeListBox.Location = new System.Drawing.Point(6, 27);
            this.suitSizeListBox.Name = "suitSizeListBox";
            this.suitSizeListBox.Size = new System.Drawing.Size(208, 126);
            this.suitSizeListBox.TabIndex = 0;
            // 
            // suitBrandGroupBox
            // 
            this.suitBrandGroupBox.Controls.Add(this.suitBrandListBox);
            this.suitBrandGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suitBrandGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitBrandGroupBox.ForeColor = System.Drawing.Color.White;
            this.suitBrandGroupBox.Location = new System.Drawing.Point(26, 19);
            this.suitBrandGroupBox.Name = "suitBrandGroupBox";
            this.suitBrandGroupBox.Size = new System.Drawing.Size(200, 331);
            this.suitBrandGroupBox.TabIndex = 0;
            this.suitBrandGroupBox.TabStop = false;
            this.suitBrandGroupBox.Text = "Suit Brands";
            // 
            // suitBrandListBox
            // 
            this.suitBrandListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.suitBrandListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suitBrandListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitBrandListBox.ForeColor = System.Drawing.Color.White;
            this.suitBrandListBox.FormattingEnabled = true;
            this.suitBrandListBox.ItemHeight = 18;
            this.suitBrandListBox.Location = new System.Drawing.Point(7, 27);
            this.suitBrandListBox.Name = "suitBrandListBox";
            this.suitBrandListBox.Size = new System.Drawing.Size(187, 288);
            this.suitBrandListBox.TabIndex = 0;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(792, 255);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(134, 64);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "ADD TO CART\r\n";
            this.addToCartButtonToolTip.SetToolTip(this.addToCartButton, "Press to add the items to the cart");
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateReportButton);
            this.panel1.Controls.Add(this.searchOrdersButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.clearSelectionButton);
            this.panel1.Controls.Add(this.viewInventoryButton);
            this.panel1.Location = new System.Drawing.Point(13, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 364);
            this.panel1.TabIndex = 3;
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.generateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateReportButton.Location = new System.Drawing.Point(3, 214);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(205, 64);
            this.generateReportButton.TabIndex = 7;
            this.generateReportButton.Text = "REPORT";
            this.reportButtonToolTip.SetToolTip(this.generateReportButton, "Press to generate the daily sales report");
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // searchOrdersButton
            // 
            this.searchOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrdersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchOrdersButton.Location = new System.Drawing.Point(2, 74);
            this.searchOrdersButton.Name = "searchOrdersButton";
            this.searchOrdersButton.Size = new System.Drawing.Size(206, 64);
            this.searchOrdersButton.TabIndex = 6;
            this.searchOrdersButton.Text = "SEARCH";
            this.searchButtonToolTip.SetToolTip(this.searchOrdersButton, "Press to search for order details");
            this.searchOrdersButton.UseVisualStyleBackColor = false;
            this.searchOrdersButton.Click += new System.EventHandler(this.searchOrdersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(3, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(206, 64);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButtonToolTip.SetToolTip(this.exitButton, "Press to close the application");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelectionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearSelectionButton.Location = new System.Drawing.Point(2, 4);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(206, 64);
            this.clearSelectionButton.TabIndex = 4;
            this.clearSelectionButton.Text = "CLEAR";
            this.clearButtonToolTip.SetToolTip(this.clearSelectionButton, "Press to clear the form\r\n");
            this.clearSelectionButton.UseVisualStyleBackColor = false;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewInventoryButton.Location = new System.Drawing.Point(2, 144);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(206, 64);
            this.viewInventoryButton.TabIndex = 3;
            this.viewInventoryButton.Text = "VIEW INVENTORY";
            this.viewInventoryButtonToolTip.SetToolTip(this.viewInventoryButton, "Press to view product stocks in inventory");
            this.viewInventoryButton.UseVisualStyleBackColor = false;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // cartViewPanel
            // 
            this.cartViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cartViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartViewPanel.Controls.Add(this.cartCountLabel);
            this.cartViewPanel.Controls.Add(this.removeItemButton);
            this.cartViewPanel.Controls.Add(this.cartItemsDataGridView);
            this.cartViewPanel.Controls.Add(this.subTotalPanel);
            this.cartViewPanel.Controls.Add(this.orderIDPanel);
            this.cartViewPanel.Controls.Add(this.checkoutButton);
            this.cartViewPanel.Controls.Add(this.myCartLabel);
            this.cartViewPanel.Location = new System.Drawing.Point(244, 400);
            this.cartViewPanel.Name = "cartViewPanel";
            this.cartViewPanel.Size = new System.Drawing.Size(714, 393);
            this.cartViewPanel.TabIndex = 4;
            this.cartViewPanel.Visible = false;
            // 
            // cartCountLabel
            // 
            this.cartCountLabel.AutoSize = true;
            this.cartCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartCountLabel.Location = new System.Drawing.Point(95, 24);
            this.cartCountLabel.Name = "cartCountLabel";
            this.cartCountLabel.Size = new System.Drawing.Size(0, 20);
            this.cartCountLabel.TabIndex = 15;
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(418, 326);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(133, 47);
            this.removeItemButton.TabIndex = 14;
            this.removeItemButton.Text = "REMOVE";
            this.removeButtonToolTip.SetToolTip(this.removeItemButton, "Press to remove the item from the cart");
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // cartItemsDataGridView
            // 
            this.cartItemsDataGridView.AllowUserToAddRows = false;
            this.cartItemsDataGridView.AllowUserToDeleteRows = false;
            this.cartItemsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.cartItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuitBrand,
            this.Size,
            this.Units,
            this.TotalPrice});
            this.cartItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cartItemsDataGridView.Location = new System.Drawing.Point(17, 80);
            this.cartItemsDataGridView.Name = "cartItemsDataGridView";
            this.cartItemsDataGridView.ReadOnly = true;
            this.cartItemsDataGridView.RowTemplate.Height = 24;
            this.cartItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartItemsDataGridView.Size = new System.Drawing.Size(674, 219);
            this.cartItemsDataGridView.TabIndex = 13;
            // 
            // SuitBrand
            // 
            this.SuitBrand.HeaderText = "Suit Brand";
            this.SuitBrand.Name = "SuitBrand";
            this.SuitBrand.ReadOnly = true;
            this.SuitBrand.Width = 116;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 116;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 115;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 116;
            // 
            // subTotalPanel
            // 
            this.subTotalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.subTotalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalPanel.Controls.Add(this.subTotalLabel);
            this.subTotalPanel.Controls.Add(this.subTotalValueLabel);
            this.subTotalPanel.Location = new System.Drawing.Point(126, 326);
            this.subTotalPanel.Name = "subTotalPanel";
            this.subTotalPanel.Size = new System.Drawing.Size(286, 47);
            this.subTotalPanel.TabIndex = 12;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalLabel.Location = new System.Drawing.Point(7, 11);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(89, 20);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // subTotalValueLabel
            // 
            this.subTotalValueLabel.AutoSize = true;
            this.subTotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalValueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalValueLabel.Location = new System.Drawing.Point(113, 11);
            this.subTotalValueLabel.Name = "subTotalValueLabel";
            this.subTotalValueLabel.Size = new System.Drawing.Size(0, 20);
            this.subTotalValueLabel.TabIndex = 10;
            // 
            // orderIDPanel
            // 
            this.orderIDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderIDPanel.Controls.Add(this.orderIDLabel);
            this.orderIDPanel.Controls.Add(this.orderIDValueLabel);
            this.orderIDPanel.Location = new System.Drawing.Point(491, 10);
            this.orderIDPanel.Name = "orderIDPanel";
            this.orderIDPanel.Size = new System.Drawing.Size(200, 48);
            this.orderIDPanel.TabIndex = 11;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIDLabel.Location = new System.Drawing.Point(12, 13);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(72, 18);
            this.orderIDLabel.TabIndex = 7;
            this.orderIDLabel.Text = "Order ID";
            // 
            // orderIDValueLabel
            // 
            this.orderIDValueLabel.AutoSize = true;
            this.orderIDValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderIDValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDValueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIDValueLabel.Location = new System.Drawing.Point(97, 13);
            this.orderIDValueLabel.Name = "orderIDValueLabel";
            this.orderIDValueLabel.Size = new System.Drawing.Size(2, 20);
            this.orderIDValueLabel.TabIndex = 8;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.LimeGreen;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkoutButton.Location = new System.Drawing.Point(557, 326);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(134, 47);
            this.checkoutButton.TabIndex = 6;
            this.checkoutButton.Text = "CHECKOUT";
            this.checkoutButtonToolTip.SetToolTip(this.checkoutButton, "Press to checkout from the cart and place the order");
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // myCartLabel
            // 
            this.myCartLabel.AutoSize = true;
            this.myCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myCartLabel.Location = new System.Drawing.Point(13, 24);
            this.myCartLabel.Name = "myCartLabel";
            this.myCartLabel.Size = new System.Drawing.Size(75, 20);
            this.myCartLabel.TabIndex = 0;
            this.myCartLabel.Text = "My Cart";
            // 
            // specterSuitsLabel
            // 
            this.specterSuitsLabel.AutoSize = true;
            this.specterSuitsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.specterSuitsLabel.Font = new System.Drawing.Font("Pristina", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specterSuitsLabel.Location = new System.Drawing.Point(54, 21);
            this.specterSuitsLabel.Name = "specterSuitsLabel";
            this.specterSuitsLabel.Size = new System.Drawing.Size(146, 37);
            this.specterSuitsLabel.TabIndex = 5;
            this.specterSuitsLabel.Text = "Specter Suits";
            // 
            // totalPriceGroupBox
            // 
            this.totalPriceGroupBox.Controls.Add(this.priceLabel);
            this.totalPriceGroupBox.Enabled = false;
            this.totalPriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceGroupBox.ForeColor = System.Drawing.Color.White;
            this.totalPriceGroupBox.Location = new System.Drawing.Point(753, 59);
            this.totalPriceGroupBox.Name = "totalPriceGroupBox";
            this.totalPriceGroupBox.Size = new System.Drawing.Size(205, 100);
            this.totalPriceGroupBox.TabIndex = 4;
            this.totalPriceGroupBox.TabStop = false;
            this.totalPriceGroupBox.Text = "Total Price";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(26, 42);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(2, 22);
            this.priceLabel.TabIndex = 0;
            // 
            // specterSuitsLogoPictureBox
            // 
            this.specterSuitsLogoPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.specterSuitsLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specterSuitsLogoPictureBox.Image = global::EPOSApplication.Properties.Resources.businessman_graphic_icon_necktie_suit_260nw_1545519209;
            this.specterSuitsLogoPictureBox.Location = new System.Drawing.Point(16, 12);
            this.specterSuitsLogoPictureBox.Name = "specterSuitsLogoPictureBox";
            this.specterSuitsLogoPictureBox.Size = new System.Drawing.Size(212, 205);
            this.specterSuitsLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specterSuitsLogoPictureBox.TabIndex = 1;
            this.specterSuitsLogoPictureBox.TabStop = false;
            // 
            // clearButtonToolTip
            // 
            this.clearButtonToolTip.IsBalloon = true;
            this.clearButtonToolTip.Tag = "Press to clear form";
            // 
            // searchButtonToolTip
            // 
            this.searchButtonToolTip.IsBalloon = true;
            // 
            // viewInventoryButtonToolTip
            // 
            this.viewInventoryButtonToolTip.IsBalloon = true;
            // 
            // reportButtonToolTip
            // 
            this.reportButtonToolTip.IsBalloon = true;
            // 
            // addToCartButtonToolTip
            // 
            this.addToCartButtonToolTip.IsBalloon = true;
            // 
            // removeButtonToolTip
            // 
            this.removeButtonToolTip.IsBalloon = true;
            // 
            // checkoutButtonToolTip
            // 
            this.checkoutButtonToolTip.IsBalloon = true;
            // 
            // unitInputButtonToolTip
            // 
            this.unitInputButtonToolTip.IsBalloon = true;
            // 
            // exitButtonToolTip
            // 
            this.exitButtonToolTip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(985, 805);
            this.Controls.Add(this.totalPriceGroupBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.specterSuitsLabel);
            this.Controls.Add(this.cartViewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.specterSuitsLogoPictureBox);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "MainForm";
            this.Text = "Specter Suits";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.unitsInputPanel.ResumeLayout(false);
            this.unitsInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsInputNumericUpDown)).EndInit();
            this.suitSizeGroupBox.ResumeLayout(false);
            this.suitBrandGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cartViewPanel.ResumeLayout(false);
            this.cartViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemsDataGridView)).EndInit();
            this.subTotalPanel.ResumeLayout(false);
            this.subTotalPanel.PerformLayout();
            this.orderIDPanel.ResumeLayout(false);
            this.orderIDPanel.PerformLayout();
            this.totalPriceGroupBox.ResumeLayout(false);
            this.totalPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specterSuitsLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel unitsInputPanel;
        private System.Windows.Forms.NumericUpDown unitsInputNumericUpDown;
        private System.Windows.Forms.Label numberOfUnitsLabel;
        private System.Windows.Forms.GroupBox suitSizeGroupBox;
        private System.Windows.Forms.ListBox suitSizeListBox;
        private System.Windows.Forms.GroupBox suitBrandGroupBox;
        private System.Windows.Forms.ListBox suitBrandListBox;
        private System.Windows.Forms.PictureBox specterSuitsLogoPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchOrdersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Panel cartViewPanel;
        private System.Windows.Forms.Label specterSuitsLabel;
        private System.Windows.Forms.GroupBox totalPriceGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label orderIDValueLabel;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label myCartLabel;
        private System.Windows.Forms.Label subTotalValueLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Panel subTotalPanel;
        private System.Windows.Forms.Panel orderIDPanel;
        private System.Windows.Forms.DataGridView cartItemsDataGridView;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuitBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label cartCountLabel;
        private System.Windows.Forms.ToolTip clearButtonToolTip;
        private System.Windows.Forms.ToolTip unitInputButtonToolTip;
        private System.Windows.Forms.ToolTip addToCartButtonToolTip;
        private System.Windows.Forms.ToolTip reportButtonToolTip;
        private System.Windows.Forms.ToolTip searchButtonToolTip;
        private System.Windows.Forms.ToolTip viewInventoryButtonToolTip;
        private System.Windows.Forms.ToolTip removeButtonToolTip;
        private System.Windows.Forms.ToolTip checkoutButtonToolTip;
        private System.Windows.Forms.ToolTip exitButtonToolTip;
    }
}

