namespace MoneyManager
{
    partial class FrmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxSubCat = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.coBoxCategory = new System.Windows.Forms.ComboBox();
            this.radioButSpecDate = new System.Windows.Forms.RadioButton();
            this.dtpSpecDate = new System.Windows.Forms.DateTimePicker();
            this.coBoxSubCat = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.coBoxMonth = new System.Windows.Forms.ComboBox();
            this.radioButMonth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHello = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.expenseToolStripMenuItem.Text = "Transaction";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProfileToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // manageProfileToolStripMenuItem
            // 
            this.manageProfileToolStripMenuItem.Name = "manageProfileToolStripMenuItem";
            this.manageProfileToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.manageProfileToolStripMenuItem.Text = "Manage Profile";
            this.manageProfileToolStripMenuItem.Click += new System.EventHandler(this.manageProfileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportGraphToolStripMenuItem,
            this.balanceChartToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reportGraphToolStripMenuItem
            // 
            this.reportGraphToolStripMenuItem.Name = "reportGraphToolStripMenuItem";
            this.reportGraphToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.reportGraphToolStripMenuItem.Text = "Income && Expense Report  (Graph)";
            this.reportGraphToolStripMenuItem.Click += new System.EventHandler(this.reportGraphToolStripMenuItem_Click);
            // 
            // balanceChartToolStripMenuItem
            // 
            this.balanceChartToolStripMenuItem.Name = "balanceChartToolStripMenuItem";
            this.balanceChartToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.balanceChartToolStripMenuItem.Text = "Balance Chart";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxSubCat);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCategory);
            this.splitContainer1.Panel1.Controls.Add(this.coBoxCategory);
            this.splitContainer1.Panel1.Controls.Add(this.radioButSpecDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpSpecDate);
            this.splitContainer1.Panel1.Controls.Add(this.coBoxSubCat);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogOut);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.coBoxMonth);
            this.splitContainer1.Panel1.Controls.Add(this.radioButMonth);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblExpense);
            this.splitContainer1.Panel1.Controls.Add(this.lblIncome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvData);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 836);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 1;
            // 
            // checkBoxSubCat
            // 
            this.checkBoxSubCat.AutoSize = true;
            this.checkBoxSubCat.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSubCat.Location = new System.Drawing.Point(533, 176);
            this.checkBoxSubCat.Name = "checkBoxSubCat";
            this.checkBoxSubCat.Size = new System.Drawing.Size(112, 21);
            this.checkBoxSubCat.TabIndex = 22;
            this.checkBoxSubCat.Text = "SubCategory";
            this.checkBoxSubCat.UseVisualStyleBackColor = true;
            this.checkBoxSubCat.CheckedChanged += new System.EventHandler(this.checkBoxSubCat_CheckedChanged);
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxCategory.Location = new System.Drawing.Point(533, 132);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(87, 21);
            this.checkBoxCategory.TabIndex = 21;
            this.checkBoxCategory.Text = "Category";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.checkBoxCategory_CheckedChanged);
            // 
            // coBoxCategory
            // 
            this.coBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCategory.Enabled = false;
            this.coBoxCategory.FormattingEnabled = true;
            this.coBoxCategory.Location = new System.Drawing.Point(651, 130);
            this.coBoxCategory.Name = "coBoxCategory";
            this.coBoxCategory.Size = new System.Drawing.Size(169, 24);
            this.coBoxCategory.TabIndex = 20;
            this.coBoxCategory.SelectedIndexChanged += new System.EventHandler(this.coBoxCategory_SelectedIndexChanged);
            // 
            // radioButSpecDate
            // 
            this.radioButSpecDate.ForeColor = System.Drawing.Color.Gray;
            this.radioButSpecDate.Location = new System.Drawing.Point(108, 173);
            this.radioButSpecDate.Name = "radioButSpecDate";
            this.radioButSpecDate.Size = new System.Drawing.Size(158, 24);
            this.radioButSpecDate.TabIndex = 18;
            this.radioButSpecDate.Text = "By Specified Date : ";
            this.radioButSpecDate.UseVisualStyleBackColor = true;
            this.radioButSpecDate.CheckedChanged += new System.EventHandler(this.radioButSpecDate_CheckedChanged);
            // 
            // dtpSpecDate
            // 
            this.dtpSpecDate.Enabled = false;
            this.dtpSpecDate.Location = new System.Drawing.Point(272, 176);
            this.dtpSpecDate.Name = "dtpSpecDate";
            this.dtpSpecDate.Size = new System.Drawing.Size(169, 22);
            this.dtpSpecDate.TabIndex = 17;
            // 
            // coBoxSubCat
            // 
            this.coBoxSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxSubCat.Enabled = false;
            this.coBoxSubCat.FormattingEnabled = true;
            this.coBoxSubCat.Location = new System.Drawing.Point(651, 174);
            this.coBoxSubCat.Name = "coBoxSubCat";
            this.coBoxSubCat.Size = new System.Drawing.Size(169, 24);
            this.coBoxSubCat.TabIndex = 14;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(1077, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(98, 36);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1077, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(973, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Row";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // coBoxMonth
            // 
            this.coBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxMonth.Enabled = false;
            this.coBoxMonth.FormattingEnabled = true;
            this.coBoxMonth.Items.AddRange(new object[] {
            "This Month",
            "Last Month",
            "Last 2 Months"});
            this.coBoxMonth.Location = new System.Drawing.Point(272, 129);
            this.coBoxMonth.Name = "coBoxMonth";
            this.coBoxMonth.Size = new System.Drawing.Size(169, 24);
            this.coBoxMonth.TabIndex = 10;
            // 
            // radioButMonth
            // 
            this.radioButMonth.ForeColor = System.Drawing.Color.Gray;
            this.radioButMonth.Location = new System.Drawing.Point(108, 129);
            this.radioButMonth.Name = "radioButMonth";
            this.radioButMonth.Size = new System.Drawing.Size(120, 24);
            this.radioButMonth.TabIndex = 9;
            this.radioButMonth.Text = "By Month     : ";
            this.radioButMonth.UseVisualStyleBackColor = true;
            this.radioButMonth.CheckedChanged += new System.EventHandler(this.radButMonth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1187, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter Methods : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(1187, 42);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Account Balance : ";
            // 
            // lblExpense
            // 
            this.lblExpense.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpense.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(0, 42);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(1187, 42);
            this.lblExpense.TabIndex = 2;
            this.lblExpense.Text = "Expense : ";
            // 
            // lblIncome
            // 
            this.lblIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncome.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(0, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(1187, 42);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Income     : ";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Category,
            this.SubCategory,
            this.Amount,
            this.Note});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1187, 616);
            this.dgvData.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // lblHello
            // 
            this.lblHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHello.BackColor = System.Drawing.Color.White;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(723, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(464, 28);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Hello, ";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 864);
            this.ControlBox = false;
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.Resize += new System.EventHandler(this.FrmMainMenu_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportGraphToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox coBoxMonth;
        private System.Windows.Forms.RadioButton radioButMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem balanceChartToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ComboBox coBoxSubCat;
        private System.Windows.Forms.RadioButton radioButSpecDate;
        private System.Windows.Forms.DateTimePicker dtpSpecDate;
        private System.Windows.Forms.ComboBox coBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxSubCat;
        private System.Windows.Forms.CheckBox checkBoxCategory;
    }
}