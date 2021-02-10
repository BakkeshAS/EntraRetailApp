namespace EntraRetailApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.DailyReportButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ManagementReportButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ShoppingGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.QuantityStockPriceListBox = new System.Windows.Forms.ListBox();
            this.StockItemsListBox = new System.Windows.Forms.ListBox();
            this.CartListView = new System.Windows.Forms.ListView();
            this.SlNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotaLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchDateLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SearchItemLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchDatesLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionIDRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchNowButton = new System.Windows.Forms.Button();
            this.TransactionLabel = new System.Windows.Forms.Label();
            this.TransactionIDsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OrderPanel.SuspendLayout();
            this.ShoppingGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPanel.Controls.Add(this.DailyReportButton);
            this.OrderPanel.Controls.Add(this.SearchButton);
            this.OrderPanel.Controls.Add(this.ClearButton);
            this.OrderPanel.Controls.Add(this.AddButton);
            this.OrderPanel.Controls.Add(this.ExitButton);
            this.OrderPanel.Controls.Add(this.ManagementReportButton);
            this.OrderPanel.Controls.Add(this.ConfirmButton);
            this.OrderPanel.Location = new System.Drawing.Point(615, 130);
            this.OrderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(203, 434);
            this.OrderPanel.TabIndex = 15;
            // 
            // DailyReportButton
            // 
            this.DailyReportButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DailyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyReportButton.Location = new System.Drawing.Point(24, 318);
            this.DailyReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DailyReportButton.Name = "DailyReportButton";
            this.DailyReportButton.Size = new System.Drawing.Size(156, 38);
            this.DailyReportButton.TabIndex = 6;
            this.DailyReportButton.Text = "&Daily Report";
            this.toolTip1.SetToolTip(this.DailyReportButton, "Press to generate Daily Sales Report");
            this.DailyReportButton.UseVisualStyleBackColor = false;
            this.DailyReportButton.Click += new System.EventHandler(this.DailyReportButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(24, 139);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 38);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to search the previous transactions");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(24, 198);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 38);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear the Form for next transaction");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddButton.Enabled = false;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(24, 19);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "&Add";
            this.toolTip1.SetToolTip(this.AddButton, "Ad item to the cart");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(24, 375);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 38);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to close the application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManagementReportButton
            // 
            this.ManagementReportButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ManagementReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementReportButton.Location = new System.Drawing.Point(24, 258);
            this.ManagementReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManagementReportButton.Name = "ManagementReportButton";
            this.ManagementReportButton.Size = new System.Drawing.Size(156, 38);
            this.ManagementReportButton.TabIndex = 5;
            this.ManagementReportButton.Text = "&Management Report";
            this.toolTip1.SetToolTip(this.ManagementReportButton, "Press to view the Management Stock Report");
            this.ManagementReportButton.UseVisualStyleBackColor = false;
            this.ManagementReportButton.Click += new System.EventHandler(this.ManagementReportButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(24, 79);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(156, 38);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "&Confirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to confirm the sale");
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ShoppingGroupBox
            // 
            this.ShoppingGroupBox.Controls.Add(this.label1);
            this.ShoppingGroupBox.Controls.Add(this.label16);
            this.ShoppingGroupBox.Controls.Add(this.QuantityStockPriceListBox);
            this.ShoppingGroupBox.Controls.Add(this.StockItemsListBox);
            this.ShoppingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShoppingGroupBox.Location = new System.Drawing.Point(12, 13);
            this.ShoppingGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingGroupBox.Name = "ShoppingGroupBox";
            this.ShoppingGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingGroupBox.Size = new System.Drawing.Size(586, 245);
            this.ShoppingGroupBox.TabIndex = 16;
            this.ShoppingGroupBox.TabStop = false;
            this.ShoppingGroupBox.Text = "Shopping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Size / In Stock / Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Item/s:";
            // 
            // QuantityStockPriceListBox
            // 
            this.QuantityStockPriceListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityStockPriceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityStockPriceListBox.FormattingEnabled = true;
            this.QuantityStockPriceListBox.ItemHeight = 18;
            this.QuantityStockPriceListBox.Location = new System.Drawing.Point(276, 58);
            this.QuantityStockPriceListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityStockPriceListBox.Name = "QuantityStockPriceListBox";
            this.QuantityStockPriceListBox.Size = new System.Drawing.Size(274, 148);
            this.QuantityStockPriceListBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.QuantityStockPriceListBox, "Select the size");
            this.QuantityStockPriceListBox.SelectedIndexChanged += new System.EventHandler(this.QuantityStockPriceListBox_SelectedIndexChanged);
            // 
            // StockItemsListBox
            // 
            this.StockItemsListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItemsListBox.FormattingEnabled = true;
            this.StockItemsListBox.ItemHeight = 18;
            this.StockItemsListBox.Location = new System.Drawing.Point(38, 58);
            this.StockItemsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockItemsListBox.Name = "StockItemsListBox";
            this.StockItemsListBox.Size = new System.Drawing.Size(209, 148);
            this.StockItemsListBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.StockItemsListBox, "Select the Item");
            this.StockItemsListBox.SelectedIndexChanged += new System.EventHandler(this.StockItemsListBox_SelectedIndexChanged);
            // 
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SlNo,
            this.Item,
            this.Size,
            this.Quantity,
            this.Price});
            this.CartListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CartListView.GridLines = true;
            this.CartListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(38, 35);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(512, 190);
            this.CartListView.TabIndex = 16;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
            // 
            // SlNo
            // 
            this.SlNo.Text = "Sl.No.";
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 207;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 102;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 79;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // TotaLabel
            // 
            this.TotaLabel.AutoSize = true;
            this.TotaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaLabel.Location = new System.Drawing.Point(376, 244);
            this.TotaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotaLabel.Name = "TotaLabel";
            this.TotaLabel.Size = new System.Drawing.Size(85, 20);
            this.TotaLabel.TabIndex = 17;
            this.TotaLabel.Text = "Total Cost:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(465, 244);
            this.TotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(85, 21);
            this.TotalCostLabel.TabIndex = 18;
            this.TotalCostLabel.Text = "€0.00";
            this.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchDateLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.SearchItemLabel);
            this.groupBox1.Controls.Add(this.CartListView);
            this.groupBox1.Controls.Add(this.TotalCostLabel);
            this.groupBox1.Controls.Add(this.TotaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 284);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // SearchDateLabel
            // 
            this.SearchDateLabel.AutoSize = true;
            this.SearchDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDateLabel.Location = new System.Drawing.Point(86, 245);
            this.SearchDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchDateLabel.Name = "SearchDateLabel";
            this.SearchDateLabel.Size = new System.Drawing.Size(48, 20);
            this.SearchDateLabel.TabIndex = 22;
            this.SearchDateLabel.Text = "Date:";
            this.SearchDateLabel.Visible = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(34, 245);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 20);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Date:";
            this.DateLabel.Visible = false;
            // 
            // SearchItemLabel
            // 
            this.SearchItemLabel.AutoSize = true;
            this.SearchItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchItemLabel.Location = new System.Drawing.Point(6, 1);
            this.SearchItemLabel.Name = "SearchItemLabel";
            this.SearchItemLabel.Size = new System.Drawing.Size(365, 18);
            this.SearchItemLabel.TabIndex = 20;
            this.SearchItemLabel.Text = "Search Items under the selected Transaction ID";
            this.SearchItemLabel.Visible = false;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchDateTimePicker);
            this.SearchGroupBox.Controls.Add(this.SearchDatesLabel);
            this.SearchGroupBox.Controls.Add(this.groupBox2);
            this.SearchGroupBox.Controls.Add(this.SearchNowButton);
            this.SearchGroupBox.Controls.Add(this.TransactionLabel);
            this.SearchGroupBox.Controls.Add(this.TransactionIDsListBox);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 13);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(586, 245);
            this.SearchGroupBox.TabIndex = 6;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            this.SearchGroupBox.Visible = false;
            // 
            // SearchDateTimePicker
            // 
            this.SearchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchDateTimePicker.Location = new System.Drawing.Point(356, 106);
            this.SearchDateTimePicker.Name = "SearchDateTimePicker";
            this.SearchDateTimePicker.Size = new System.Drawing.Size(121, 24);
            this.SearchDateTimePicker.TabIndex = 47;
            this.toolTip1.SetToolTip(this.SearchDateTimePicker, "Pick a date");
            this.SearchDateTimePicker.Value = new System.DateTime(2020, 12, 30, 0, 0, 0, 0);
            this.SearchDateTimePicker.Visible = false;
            // 
            // SearchDatesLabel
            // 
            this.SearchDatesLabel.AutoSize = true;
            this.SearchDatesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SearchDatesLabel.Location = new System.Drawing.Point(352, 77);
            this.SearchDatesLabel.Name = "SearchDatesLabel";
            this.SearchDatesLabel.Size = new System.Drawing.Size(48, 18);
            this.SearchDatesLabel.TabIndex = 46;
            this.SearchDatesLabel.Text = "Date:";
            this.SearchDatesLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateRadioButton);
            this.groupBox2.Controls.Add(this.TransactionIDRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(140, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 38);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By";
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(215, 12);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(61, 22);
            this.DateRadioButton.TabIndex = 1;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date";
            this.toolTip1.SetToolTip(this.DateRadioButton, "Search by Date");
            this.DateRadioButton.UseVisualStyleBackColor = true;
            this.DateRadioButton.CheckedChanged += new System.EventHandler(this.DateRadioButton_CheckedChanged);
            // 
            // TransactionIDRadioButton
            // 
            this.TransactionIDRadioButton.AutoSize = true;
            this.TransactionIDRadioButton.Checked = true;
            this.TransactionIDRadioButton.Location = new System.Drawing.Point(40, 12);
            this.TransactionIDRadioButton.Name = "TransactionIDRadioButton";
            this.TransactionIDRadioButton.Size = new System.Drawing.Size(136, 22);
            this.TransactionIDRadioButton.TabIndex = 0;
            this.TransactionIDRadioButton.TabStop = true;
            this.TransactionIDRadioButton.Text = "Transaction ID";
            this.toolTip1.SetToolTip(this.TransactionIDRadioButton, "Search by Membership ID");
            this.TransactionIDRadioButton.UseVisualStyleBackColor = true;
            this.TransactionIDRadioButton.CheckedChanged += new System.EventHandler(this.TransactionIDRadioButton_CheckedChanged);
            // 
            // SearchNowButton
            // 
            this.SearchNowButton.Location = new System.Drawing.Point(356, 144);
            this.SearchNowButton.Name = "SearchNowButton";
            this.SearchNowButton.Size = new System.Drawing.Size(75, 37);
            this.SearchNowButton.TabIndex = 49;
            this.SearchNowButton.Text = "Se&arch";
            this.toolTip1.SetToolTip(this.SearchNowButton, "Press to Search for Details");
            this.SearchNowButton.UseVisualStyleBackColor = true;
            this.SearchNowButton.Visible = false;
            this.SearchNowButton.Click += new System.EventHandler(this.SearchNowButton_Click);
            // 
            // TransactionLabel
            // 
            this.TransactionLabel.AutoSize = true;
            this.TransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionLabel.Location = new System.Drawing.Point(34, 76);
            this.TransactionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TransactionLabel.Name = "TransactionLabel";
            this.TransactionLabel.Size = new System.Drawing.Size(141, 20);
            this.TransactionLabel.TabIndex = 14;
            this.TransactionLabel.Text = "Transaction IDs:";
            // 
            // TransactionIDsListBox
            // 
            this.TransactionIDsListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionIDsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDsListBox.FormattingEnabled = true;
            this.TransactionIDsListBox.ItemHeight = 18;
            this.TransactionIDsListBox.Location = new System.Drawing.Point(38, 106);
            this.TransactionIDsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransactionIDsListBox.Name = "TransactionIDsListBox";
            this.TransactionIDsListBox.Size = new System.Drawing.Size(172, 112);
            this.TransactionIDsListBox.TabIndex = 3;
            this.TransactionIDsListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionIDsListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntraRetailApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(614, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 95);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ShoppingGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 618);
            this.MinimumSize = new System.Drawing.Size(848, 618);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entra - Shopping Made Easy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.OrderPanel.ResumeLayout(false);
            this.ShoppingGroupBox.ResumeLayout(false);
            this.ShoppingGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ManagementReportButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.GroupBox ShoppingGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox QuantityStockPriceListBox;
        private System.Windows.Forms.ListBox StockItemsListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader SlNo;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TotaLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label TransactionLabel;
        private System.Windows.Forms.ListBox TransactionIDsListBox;
        private System.Windows.Forms.Button DailyReportButton;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label SearchDateLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker SearchDateTimePicker;
        private System.Windows.Forms.Label SearchDatesLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.RadioButton TransactionIDRadioButton;
        private System.Windows.Forms.Button SearchNowButton;
    }
}

