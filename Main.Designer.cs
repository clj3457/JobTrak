using System.Windows.Forms;

namespace JobTrak
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectSearchCbo = new System.Windows.Forms.ComboBox();
            this.SearchCriteriaBox = new System.Windows.Forms.TextBox();
            this.lblSelectSearch = new System.Windows.Forms.Label();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewEntryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDisplayEntryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSearchOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClearSearchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1707, 625);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // SelectSearchCbo
            // 
            this.SelectSearchCbo.FormattingEnabled = true;
            this.SelectSearchCbo.Items.AddRange(new object[] {
            "No Selection",
            "Application Status",
            "DWSFlag",
            "Job Title",
            "Company Name",
            "Staffing Firm Name",
            "Job Status",
            "Job Type",
            "Not Closed"});
            this.SelectSearchCbo.Location = new System.Drawing.Point(429, 13);
            this.SelectSearchCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectSearchCbo.Name = "SelectSearchCbo";
            this.SelectSearchCbo.Size = new System.Drawing.Size(161, 24);
            this.SelectSearchCbo.TabIndex = 85;
            this.SelectSearchCbo.Tag = "";
            // 
            // SearchCriteriaBox
            // 
            this.SearchCriteriaBox.Location = new System.Drawing.Point(768, 14);
            this.SearchCriteriaBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCriteriaBox.Name = "SearchCriteriaBox";
            this.SearchCriteriaBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchCriteriaBox.Size = new System.Drawing.Size(313, 22);
            this.SearchCriteriaBox.TabIndex = 86;
            // 
            // lblSelectSearch
            // 
            this.lblSelectSearch.AutoSize = true;
            this.lblSelectSearch.Location = new System.Drawing.Point(288, 15);
            this.lblSelectSearch.Name = "lblSelectSearch";
            this.lblSelectSearch.Size = new System.Drawing.Size(130, 17);
            this.lblSelectSearch.TabIndex = 88;
            this.lblSelectSearch.Text = "Select Search Field";
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Location = new System.Drawing.Point(621, 15);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(140, 17);
            this.lblSearchCriteria.TabIndex = 89;
            this.lblSearchCriteria.Text = "Enter Search Criteria";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.fileOptionsToolStripMenuItem,
            this.tsSearchOptions});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Size = new System.Drawing.Size(1729, 28);
            this.menuStrip1.TabIndex = 150;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewEntryItem,
            this.tsDisplayEntryItem,
            this.deleteSelectedRowToolStripMenuItem,
            this.refreshTableToolStripMenuItem});
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.newEntryToolStripMenuItem.Text = "Entries";
            // 
            // tsNewEntryItem
            // 
            this.tsNewEntryItem.Name = "tsNewEntryItem";
            this.tsNewEntryItem.Size = new System.Drawing.Size(239, 26);
            this.tsNewEntryItem.Text = "Create New Entry";
            this.tsNewEntryItem.Click += new System.EventHandler(this.NewEntryItem_Click);
            // 
            // tsDisplayEntryItem
            // 
            this.tsDisplayEntryItem.Name = "tsDisplayEntryItem";
            this.tsDisplayEntryItem.Size = new System.Drawing.Size(239, 26);
            this.tsDisplayEntryItem.Text = "Display Selected Entry";
            this.tsDisplayEntryItem.Click += new System.EventHandler(this.DisplayEntryItem_Click);
            // 
            // deleteSelectedRowToolStripMenuItem
            // 
            this.deleteSelectedRowToolStripMenuItem.Name = "deleteSelectedRowToolStripMenuItem";
            this.deleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.deleteSelectedRowToolStripMenuItem.Text = "Delete Selected Row";
            this.deleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // fileOptionsToolStripMenuItem
            // 
            this.fileOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTextToolStripMenuItem,
            this.exportToExcelToolStripMenuItem,
            this.printSelectedEntryToolStripMenuItem});
            this.fileOptionsToolStripMenuItem.Name = "fileOptionsToolStripMenuItem";
            this.fileOptionsToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.fileOptionsToolStripMenuItem.Text = "File Options";
            // 
            // saveToTextToolStripMenuItem
            // 
            this.saveToTextToolStripMenuItem.Name = "saveToTextToolStripMenuItem";
            this.saveToTextToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.saveToTextToolStripMenuItem.Text = "Save To Text";
            this.saveToTextToolStripMenuItem.Click += new System.EventHandler(this.SaveToText_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.exportToExcelToolStripMenuItem.Text = "Export To Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.Export2Excel_Click);
            // 
            // printSelectedEntryToolStripMenuItem
            // 
            this.printSelectedEntryToolStripMenuItem.Enabled = false;
            this.printSelectedEntryToolStripMenuItem.Name = "printSelectedEntryToolStripMenuItem";
            this.printSelectedEntryToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.printSelectedEntryToolStripMenuItem.Text = "Print Selected Entry";
            this.printSelectedEntryToolStripMenuItem.Click += new System.EventHandler(this.PrintSelected_Click);
            // 
            // tsSearchOptions
            // 
            this.tsSearchOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSearchItem,
            this.tsClearSearchItem});
            this.tsSearchOptions.Name = "tsSearchOptions";
            this.tsSearchOptions.Size = new System.Drawing.Size(67, 26);
            this.tsSearchOptions.Text = "Search";
            // 
            // tsmSearchItem
            // 
            this.tsmSearchItem.Name = "tsmSearchItem";
            this.tsmSearchItem.Size = new System.Drawing.Size(251, 26);
            this.tsmSearchItem.Text = "Search";
            this.tsmSearchItem.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // tsClearSearchItem
            // 
            this.tsClearSearchItem.Name = "tsClearSearchItem";
            this.tsClearSearchItem.Size = new System.Drawing.Size(251, 26);
            this.tsClearSearchItem.Text = "Clear Search Parameters";
            this.tsClearSearchItem.Click += new System.EventHandler(this.ClearSearchItem_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(JobTrakker.tblJobTrakker);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1749, 857);
            this.Controls.Add(this.lblSearchCriteria);
            this.Controls.Add(this.lblSelectSearch);
            this.Controls.Add(this.SearchCriteriaBox);
            this.Controls.Add(this.SelectSearchCbo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Job Trak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComboBox SelectSearchCbo;
        private TextBox SearchCriteriaBox;
        private Label lblSelectSearch;
        private Label lblSearchCriteria;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newEntryToolStripMenuItem;
        private ToolStripMenuItem tsDisplayEntryItem;
        private ToolStripMenuItem tsNewEntryItem;
        private ToolStripMenuItem fileOptionsToolStripMenuItem;
        private ToolStripMenuItem saveToTextToolStripMenuItem;
        private ToolStripMenuItem exportToExcelToolStripMenuItem;
        private ToolStripMenuItem printSelectedEntryToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedRowToolStripMenuItem;
        private ToolStripMenuItem tsSearchOptions;
        private ToolStripMenuItem tsmSearchItem;
        private ToolStripMenuItem tsClearSearchItem;
        private ToolStripMenuItem refreshTableToolStripMenuItem;
    }
}

