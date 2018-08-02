namespace MoneyManager
{
    partial class FrmGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.incomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.radioButSpecDate = new System.Windows.Forms.RadioButton();
            this.dtpSpecDate = new System.Windows.Forms.DateTimePicker();
            this.coBoxMonth = new System.Windows.Forms.ComboBox();
            this.radioButMonth = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.expenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.radioButSpecDate);
            this.splitContainer1.Panel2.Controls.Add(this.dtpSpecDate);
            this.splitContainer1.Panel2.Controls.Add(this.coBoxMonth);
            this.splitContainer1.Panel2.Controls.Add(this.radioButMonth);
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Size = new System.Drawing.Size(1145, 626);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.expenseChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.incomeChart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // incomeChart
            // 
            chartArea2.Name = "ChartArea1";
            this.incomeChart.ChartAreas.Add(chartArea2);
            this.incomeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.incomeChart.Legends.Add(legend2);
            this.incomeChart.Location = new System.Drawing.Point(3, 3);
            this.incomeChart.Name = "incomeChart";
            this.incomeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Income";
            this.incomeChart.Series.Add(series2);
            this.incomeChart.Size = new System.Drawing.Size(566, 560);
            this.incomeChart.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Location = new System.Drawing.Point(1070, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 56);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radioButSpecDate
            // 
            this.radioButSpecDate.ForeColor = System.Drawing.Color.Gray;
            this.radioButSpecDate.Location = new System.Drawing.Point(370, 12);
            this.radioButSpecDate.Name = "radioButSpecDate";
            this.radioButSpecDate.Size = new System.Drawing.Size(158, 24);
            this.radioButSpecDate.TabIndex = 22;
            this.radioButSpecDate.Text = "By Specified Date : ";
            this.radioButSpecDate.UseVisualStyleBackColor = true;
            this.radioButSpecDate.CheckedChanged += new System.EventHandler(this.radioButSpecDate_CheckedChanged);
            // 
            // dtpSpecDate
            // 
            this.dtpSpecDate.Enabled = false;
            this.dtpSpecDate.Location = new System.Drawing.Point(534, 14);
            this.dtpSpecDate.Name = "dtpSpecDate";
            this.dtpSpecDate.Size = new System.Drawing.Size(169, 22);
            this.dtpSpecDate.TabIndex = 21;
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
            this.coBoxMonth.Location = new System.Drawing.Point(138, 12);
            this.coBoxMonth.Name = "coBoxMonth";
            this.coBoxMonth.Size = new System.Drawing.Size(169, 24);
            this.coBoxMonth.TabIndex = 20;
            // 
            // radioButMonth
            // 
            this.radioButMonth.ForeColor = System.Drawing.Color.Gray;
            this.radioButMonth.Location = new System.Drawing.Point(12, 12);
            this.radioButMonth.Name = "radioButMonth";
            this.radioButMonth.Size = new System.Drawing.Size(120, 24);
            this.radioButMonth.TabIndex = 19;
            this.radioButMonth.Text = "By Month     : ";
            this.radioButMonth.UseVisualStyleBackColor = true;
            this.radioButMonth.CheckedChanged += new System.EventHandler(this.radioButMonth_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(995, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 56);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // expenseChart
            // 
            chartArea1.Name = "ChartArea1";
            this.expenseChart.ChartAreas.Add(chartArea1);
            this.expenseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.expenseChart.Legends.Add(legend1);
            this.expenseChart.Location = new System.Drawing.Point(575, 3);
            this.expenseChart.Name = "expenseChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Expense";
            this.expenseChart.Series.Add(series1);
            this.expenseChart.Size = new System.Drawing.Size(567, 560);
            this.expenseChart.TabIndex = 1;
            // 
            // FrmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 626);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense & Income Graph";
            this.Load += new System.EventHandler(this.FrmGraph_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart incomeChart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton radioButSpecDate;
        private System.Windows.Forms.DateTimePicker dtpSpecDate;
        private System.Windows.Forms.ComboBox coBoxMonth;
        private System.Windows.Forms.RadioButton radioButMonth;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart expenseChart;
    }
}