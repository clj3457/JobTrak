using System.Windows.Forms;

namespace JobTrakker
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
            this.JobStatusCbo = new System.Windows.Forms.ComboBox();
            this.CompanyNameLbl = new System.Windows.Forms.Label();
            this.CompanyNameBox = new System.Windows.Forms.TextBox();
            this.JobTitleBox = new System.Windows.Forms.TextBox();
            this.JobTitleLbl = new System.Windows.Forms.Label();
            this.ContactTitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactPhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ContactNameLbl = new System.Windows.Forms.Label();
            this.JobIDBox = new System.Windows.Forms.TextBox();
            this.JobIDLbl = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyWebsiteBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ContactDatePkr = new System.Windows.Forms.DateTimePicker();
            this.CompanyPhoneBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.CommentsBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContactEmailBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.JobStatusLbl = new System.Windows.Forms.Label();
            this.JobBoardLbl = new System.Windows.Forms.Label();
            this.DisplayEntryBtn = new System.Windows.Forms.Button();
            this.SelectSearchCbo = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SelectSearchLbl = new System.Windows.Forms.Label();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.ExportOpenBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.InterviewDateTimeBox = new System.Windows.Forms.TextBox();
            this.ClearSearchBtn = new System.Windows.Forms.Button();
            this.ActiveStateLbl = new System.Windows.Forms.Label();
            this.ActiveStateCbo = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveTextBtn = new System.Windows.Forms.Button();
            this.JobLocationBox = new System.Windows.Forms.TextBox();
            this.JobLocationLbl = new System.Windows.Forms.Label();
            this.PrintEntryBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.StaffingFirmBox = new System.Windows.Forms.TextBox();
            this.StaffingFirmLbl = new System.Windows.Forms.Label();
            this.JobBoardCbo = new System.Windows.Forms.ComboBox();
            this.RecruiterChk = new System.Windows.Forms.CheckBox();
            this.DWSChk = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.JobTypeCbo = new System.Windows.Forms.ComboBox();
            this.JobTypeLbl = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // JobStatusCbo
            // 
            this.JobStatusCbo.FormattingEnabled = true;
            this.JobStatusCbo.Items.AddRange(new object[] {
            "None",
            "No Response",
            "Connected",
            "Pending",
            "Interview",
            "Submitted",
            "Filled",
            "Not Selected",
            "Rejected",
            "Ghosted",
            "On Hold",
            "Canceled",
            "Closed",
            "Hired"});
            this.JobStatusCbo.Location = new System.Drawing.Point(153, 212);
            this.JobStatusCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobStatusCbo.Name = "JobStatusCbo";
            this.JobStatusCbo.Size = new System.Drawing.Size(175, 24);
            this.JobStatusCbo.TabIndex = 78;
            // 
            // CompanyNameLbl
            // 
            this.CompanyNameLbl.AutoSize = true;
            this.CompanyNameLbl.Location = new System.Drawing.Point(19, 31);
            this.CompanyNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyNameLbl.Name = "CompanyNameLbl";
            this.CompanyNameLbl.Size = new System.Drawing.Size(108, 17);
            this.CompanyNameLbl.TabIndex = 0;
            this.CompanyNameLbl.Text = "Company Name";
            this.CompanyNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyNameBox
            // 
            this.CompanyNameBox.Location = new System.Drawing.Point(153, 27);
            this.CompanyNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompanyNameBox.Name = "CompanyNameBox";
            this.CompanyNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyNameBox.Size = new System.Drawing.Size(175, 22);
            this.CompanyNameBox.TabIndex = 1;
            // 
            // JobTitleBox
            // 
            this.JobTitleBox.Location = new System.Drawing.Point(153, 59);
            this.JobTitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobTitleBox.Name = "JobTitleBox";
            this.JobTitleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobTitleBox.Size = new System.Drawing.Size(175, 22);
            this.JobTitleBox.TabIndex = 3;
            // 
            // JobTitleLbl
            // 
            this.JobTitleLbl.AutoSize = true;
            this.JobTitleLbl.Location = new System.Drawing.Point(19, 63);
            this.JobTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTitleLbl.Name = "JobTitleLbl";
            this.JobTitleLbl.Size = new System.Drawing.Size(62, 17);
            this.JobTitleLbl.TabIndex = 2;
            this.JobTitleLbl.Text = "Job Title";
            this.JobTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactTitleBox
            // 
            this.ContactTitleBox.Location = new System.Drawing.Point(153, 155);
            this.ContactTitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactTitleBox.Name = "ContactTitleBox";
            this.ContactTitleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactTitleBox.Size = new System.Drawing.Size(173, 22);
            this.ContactTitleBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactPhoneBox
            // 
            this.ContactPhoneBox.Location = new System.Drawing.Point(503, 183);
            this.ContactPhoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactPhoneBox.Name = "ContactPhoneBox";
            this.ContactPhoneBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.ContactPhoneBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(153, 123);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameBox.Size = new System.Drawing.Size(175, 22);
            this.NameBox.TabIndex = 9;
            // 
            // ContactNameLbl
            // 
            this.ContactNameLbl.AutoSize = true;
            this.ContactNameLbl.Location = new System.Drawing.Point(19, 127);
            this.ContactNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNameLbl.Name = "ContactNameLbl";
            this.ContactNameLbl.Size = new System.Drawing.Size(97, 17);
            this.ContactNameLbl.TabIndex = 8;
            this.ContactNameLbl.Text = "Contact Name";
            this.ContactNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobIDBox
            // 
            this.JobIDBox.Location = new System.Drawing.Point(153, 94);
            this.JobIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobIDBox.Name = "JobIDBox";
            this.JobIDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobIDBox.Size = new System.Drawing.Size(175, 22);
            this.JobIDBox.TabIndex = 11;
            // 
            // JobIDLbl
            // 
            this.JobIDLbl.AutoSize = true;
            this.JobIDLbl.Location = new System.Drawing.Point(19, 95);
            this.JobIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobIDLbl.Name = "JobIDLbl";
            this.JobIDLbl.Size = new System.Drawing.Size(46, 17);
            this.JobIDLbl.TabIndex = 10;
            this.JobIDLbl.Text = "Job Id";
            this.JobIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(503, 121);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressBox.Size = new System.Drawing.Size(173, 22);
            this.AddressBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Company Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyWebsiteBox
            // 
            this.CompanyWebsiteBox.Location = new System.Drawing.Point(503, 58);
            this.CompanyWebsiteBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompanyWebsiteBox.Name = "CompanyWebsiteBox";
            this.CompanyWebsiteBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyWebsiteBox.Size = new System.Drawing.Size(173, 22);
            this.CompanyWebsiteBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Company WebSite";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 188);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 17);
            this.label20.TabIndex = 24;
            this.label20.Text = "Contact Date";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactDatePkr
            // 
            this.ContactDatePkr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ContactDatePkr.Location = new System.Drawing.Point(153, 185);
            this.ContactDatePkr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactDatePkr.Name = "ContactDatePkr";
            this.ContactDatePkr.Size = new System.Drawing.Size(175, 22);
            this.ContactDatePkr.TabIndex = 49;
            this.ContactDatePkr.Value = new System.DateTime(2020, 11, 17, 13, 9, 57, 0);
            // 
            // CompanyPhoneBox
            // 
            this.CompanyPhoneBox.Location = new System.Drawing.Point(503, 89);
            this.CompanyPhoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompanyPhoneBox.Name = "CompanyPhoneBox";
            this.CompanyPhoneBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.CompanyPhoneBox.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "Company Phone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Location = new System.Drawing.Point(688, 5);
            this.CommentsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(74, 17);
            this.CommentsLbl.TabIndex = 54;
            this.CommentsLbl.Text = "Comments";
            this.CommentsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommentsBox
            // 
            this.CommentsBox.Location = new System.Drawing.Point(692, 27);
            this.CommentsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommentsBox.Multiline = true;
            this.CommentsBox.Name = "CommentsBox";
            this.CommentsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentsBox.Size = new System.Drawing.Size(1068, 303);
            this.CommentsBox.TabIndex = 55;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(133, 386);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 28);
            this.DeleteBtn.TabIndex = 57;
            this.DeleteBtn.Text = "Delete Row";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 422);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1739, 409);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ContactEmailBox
            // 
            this.ContactEmailBox.Location = new System.Drawing.Point(503, 150);
            this.ContactEmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactEmailBox.Name = "ContactEmailBox";
            this.ContactEmailBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactEmailBox.Size = new System.Drawing.Size(173, 22);
            this.ContactEmailBox.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Contact Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobStatusLbl
            // 
            this.JobStatusLbl.AutoSize = true;
            this.JobStatusLbl.Location = new System.Drawing.Point(19, 215);
            this.JobStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobStatusLbl.Name = "JobStatusLbl";
            this.JobStatusLbl.Size = new System.Drawing.Size(75, 17);
            this.JobStatusLbl.TabIndex = 65;
            this.JobStatusLbl.Text = "Job Status";
            this.JobStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobBoardLbl
            // 
            this.JobBoardLbl.AutoSize = true;
            this.JobBoardLbl.Location = new System.Drawing.Point(335, 277);
            this.JobBoardLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobBoardLbl.Name = "JobBoardLbl";
            this.JobBoardLbl.Size = new System.Drawing.Size(73, 17);
            this.JobBoardLbl.TabIndex = 75;
            this.JobBoardLbl.Text = "Job Board";
            this.JobBoardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayEntryBtn
            // 
            this.DisplayEntryBtn.Location = new System.Drawing.Point(21, 386);
            this.DisplayEntryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayEntryBtn.Name = "DisplayEntryBtn";
            this.DisplayEntryBtn.Size = new System.Drawing.Size(104, 28);
            this.DisplayEntryBtn.TabIndex = 82;
            this.DisplayEntryBtn.Text = "Edit Row";
            this.DisplayEntryBtn.UseCompatibleTextRendering = true;
            this.DisplayEntryBtn.UseVisualStyleBackColor = true;
            this.DisplayEntryBtn.Click += new System.EventHandler(this.DisplayEntryBtn_Click);
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
            this.SelectSearchCbo.Location = new System.Drawing.Point(683, 388);
            this.SelectSearchCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectSearchCbo.Name = "SelectSearchCbo";
            this.SelectSearchCbo.Size = new System.Drawing.Size(161, 24);
            this.SelectSearchCbo.TabIndex = 85;
            this.SelectSearchCbo.Tag = "";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(865, 390);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBox.Size = new System.Drawing.Size(313, 22);
            this.SearchBox.TabIndex = 86;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1207, 384);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(93, 28);
            this.SearchBtn.TabIndex = 87;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SelectSearchLbl
            // 
            this.SelectSearchLbl.AutoSize = true;
            this.SelectSearchLbl.Location = new System.Drawing.Point(679, 368);
            this.SelectSearchLbl.Name = "SelectSearchLbl";
            this.SelectSearchLbl.Size = new System.Drawing.Size(130, 17);
            this.SelectSearchLbl.TabIndex = 88;
            this.SelectSearchLbl.Text = "Select Search Field";
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(861, 369);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(140, 17);
            this.SearchLbl.TabIndex = 89;
            this.SearchLbl.Text = "Enter Search Criteria";
            // 
            // ExportOpenBtn
            // 
            this.ExportOpenBtn.Location = new System.Drawing.Point(479, 350);
            this.ExportOpenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportOpenBtn.Name = "ExportOpenBtn";
            this.ExportOpenBtn.Size = new System.Drawing.Size(173, 28);
            this.ExportOpenBtn.TabIndex = 90;
            this.ExportOpenBtn.Text = "Export/Open To Excel";
            this.ExportOpenBtn.UseVisualStyleBackColor = true;
            this.ExportOpenBtn.Visible = false;
            this.ExportOpenBtn.Click += new System.EventHandler(this.ExportOpenBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Interview Date/Time";
            // 
            // InterviewDateTimeBox
            // 
            this.InterviewDateTimeBox.Location = new System.Drawing.Point(503, 245);
            this.InterviewDateTimeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InterviewDateTimeBox.Name = "InterviewDateTimeBox";
            this.InterviewDateTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InterviewDateTimeBox.Size = new System.Drawing.Size(173, 22);
            this.InterviewDateTimeBox.TabIndex = 96;
            // 
            // ClearSearchBtn
            // 
            this.ClearSearchBtn.Location = new System.Drawing.Point(1308, 384);
            this.ClearSearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearSearchBtn.Name = "ClearSearchBtn";
            this.ClearSearchBtn.Size = new System.Drawing.Size(93, 28);
            this.ClearSearchBtn.TabIndex = 97;
            this.ClearSearchBtn.Text = "Clear Search";
            this.ClearSearchBtn.UseVisualStyleBackColor = true;
            this.ClearSearchBtn.Click += new System.EventHandler(this.ClearSearchBtn_Click);
            // 
            // ActiveStateLbl
            // 
            this.ActiveStateLbl.AutoSize = true;
            this.ActiveStateLbl.Location = new System.Drawing.Point(19, 249);
            this.ActiveStateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActiveStateLbl.Name = "ActiveStateLbl";
            this.ActiveStateLbl.Size = new System.Drawing.Size(121, 17);
            this.ActiveStateLbl.TabIndex = 98;
            this.ActiveStateLbl.Text = "Application Status";
            this.ActiveStateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActiveStateCbo
            // 
            this.ActiveStateCbo.FormattingEnabled = true;
            this.ActiveStateCbo.Items.AddRange(new object[] {
            "None",
            "Active",
            "Check Status",
            "Status Request",
            "Closed"});
            this.ActiveStateCbo.Location = new System.Drawing.Point(153, 245);
            this.ActiveStateCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveStateCbo.Name = "ActiveStateCbo";
            this.ActiveStateCbo.Size = new System.Drawing.Size(175, 24);
            this.ActiveStateCbo.TabIndex = 99;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt";
            // 
            // SaveTextBtn
            // 
            this.SaveTextBtn.Location = new System.Drawing.Point(364, 388);
            this.SaveTextBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveTextBtn.Name = "SaveTextBtn";
            this.SaveTextBtn.Size = new System.Drawing.Size(108, 28);
            this.SaveTextBtn.TabIndex = 100;
            this.SaveTextBtn.Text = "Save To Text";
            this.SaveTextBtn.UseVisualStyleBackColor = true;
            this.SaveTextBtn.Click += new System.EventHandler(this.SaveTextBtn_Click);
            // 
            // JobLocationBox
            // 
            this.JobLocationBox.Location = new System.Drawing.Point(503, 214);
            this.JobLocationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobLocationBox.Name = "JobLocationBox";
            this.JobLocationBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobLocationBox.Size = new System.Drawing.Size(173, 22);
            this.JobLocationBox.TabIndex = 104;
            // 
            // JobLocationLbl
            // 
            this.JobLocationLbl.AutoSize = true;
            this.JobLocationLbl.Location = new System.Drawing.Point(335, 218);
            this.JobLocationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobLocationLbl.Name = "JobLocationLbl";
            this.JobLocationLbl.Size = new System.Drawing.Size(89, 17);
            this.JobLocationLbl.TabIndex = 103;
            this.JobLocationLbl.Text = "Job Location";
            this.JobLocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrintEntryBtn
            // 
            this.PrintEntryBtn.Location = new System.Drawing.Point(479, 388);
            this.PrintEntryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintEntryBtn.Name = "PrintEntryBtn";
            this.PrintEntryBtn.Size = new System.Drawing.Size(173, 28);
            this.PrintEntryBtn.TabIndex = 105;
            this.PrintEntryBtn.Text = "Print Selected Entry";
            this.PrintEntryBtn.UseVisualStyleBackColor = true;
            this.PrintEntryBtn.Visible = false;
            this.PrintEntryBtn.Click += new System.EventHandler(this.PrintEntryBtn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // StaffingFirmBox
            // 
            this.StaffingFirmBox.Location = new System.Drawing.Point(503, 28);
            this.StaffingFirmBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffingFirmBox.Name = "StaffingFirmBox";
            this.StaffingFirmBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StaffingFirmBox.Size = new System.Drawing.Size(173, 22);
            this.StaffingFirmBox.TabIndex = 107;
            // 
            // StaffingFirmLbl
            // 
            this.StaffingFirmLbl.AutoSize = true;
            this.StaffingFirmLbl.Location = new System.Drawing.Point(335, 30);
            this.StaffingFirmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffingFirmLbl.Name = "StaffingFirmLbl";
            this.StaffingFirmLbl.Size = new System.Drawing.Size(155, 17);
            this.StaffingFirmLbl.TabIndex = 106;
            this.StaffingFirmLbl.Text = "Recruiting/Staffing Firm";
            this.StaffingFirmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobBoardCbo
            // 
            this.JobBoardCbo.FormattingEnabled = true;
            this.JobBoardCbo.Items.AddRange(new object[] {
            "None",
            "LinkedIn",
            "indeed",
            "Dice",
            "CyberCoders",
            "utah.jobs.gov",
            "Monster",
            "CareerBuilders",
            "ZipRecruiter",
            "Company Web Site",
            "Other"});
            this.JobBoardCbo.Location = new System.Drawing.Point(503, 276);
            this.JobBoardCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobBoardCbo.Name = "JobBoardCbo";
            this.JobBoardCbo.Size = new System.Drawing.Size(175, 24);
            this.JobBoardCbo.TabIndex = 108;
            // 
            // RecruiterChk
            // 
            this.RecruiterChk.AutoSize = true;
            this.RecruiterChk.Location = new System.Drawing.Point(21, 277);
            this.RecruiterChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecruiterChk.Name = "RecruiterChk";
            this.RecruiterChk.Size = new System.Drawing.Size(191, 21);
            this.RecruiterChk.TabIndex = 109;
            this.RecruiterChk.Text = "Recruiter/Staffing Agency";
            this.RecruiterChk.UseVisualStyleBackColor = true;
            // 
            // DWSChk
            // 
            this.DWSChk.AutoSize = true;
            this.DWSChk.Location = new System.Drawing.Point(21, 305);
            this.DWSChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DWSChk.Name = "DWSChk";
            this.DWSChk.Size = new System.Drawing.Size(143, 21);
            this.DWSChk.TabIndex = 110;
            this.DWSChk.Text = "Entered Into DWS";
            this.DWSChk.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(249, 350);
            this.btnNewEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(108, 28);
            this.btnNewEntry.TabIndex = 111;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.Location = new System.Drawing.Point(133, 350);
            this.btnSaveEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(108, 28);
            this.btnSaveEntry.TabIndex = 145;
            this.btnSaveEntry.Text = "Save Entry";
            this.btnSaveEntry.UseVisualStyleBackColor = true;
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(249, 387);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(108, 28);
            this.btnClearEntry.TabIndex = 146;
            this.btnClearEntry.Text = "Clear Entry";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // JobTypeCbo
            // 
            this.JobTypeCbo.FormattingEnabled = true;
            this.JobTypeCbo.Items.AddRange(new object[] {
            "None",
            "Software",
            "Tech Support",
            "Retail",
            "Other"});
            this.JobTypeCbo.Location = new System.Drawing.Point(503, 306);
            this.JobTypeCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobTypeCbo.Name = "JobTypeCbo";
            this.JobTypeCbo.Size = new System.Drawing.Size(175, 24);
            this.JobTypeCbo.TabIndex = 148;
            // 
            // JobTypeLbl
            // 
            this.JobTypeLbl.AutoSize = true;
            this.JobTypeLbl.Location = new System.Drawing.Point(335, 308);
            this.JobTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTypeLbl.Name = "JobTypeLbl";
            this.JobTypeLbl.Size = new System.Drawing.Size(67, 17);
            this.JobTypeLbl.TabIndex = 147;
            this.JobTypeLbl.Text = "Job Type";
            this.JobTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(23, 350);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 149;
            this.btnUpdate.Text = "Update Entry";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(JobTrakker.tblJobTrakker);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 857);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.JobTypeCbo);
            this.Controls.Add(this.JobTypeLbl);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnSaveEntry);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.DWSChk);
            this.Controls.Add(this.RecruiterChk);
            this.Controls.Add(this.JobBoardCbo);
            this.Controls.Add(this.StaffingFirmBox);
            this.Controls.Add(this.StaffingFirmLbl);
            this.Controls.Add(this.PrintEntryBtn);
            this.Controls.Add(this.JobLocationBox);
            this.Controls.Add(this.JobLocationLbl);
            this.Controls.Add(this.SaveTextBtn);
            this.Controls.Add(this.ActiveStateCbo);
            this.Controls.Add(this.ActiveStateLbl);
            this.Controls.Add(this.ClearSearchBtn);
            this.Controls.Add(this.InterviewDateTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExportOpenBtn);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SelectSearchLbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SelectSearchCbo);
            this.Controls.Add(this.DisplayEntryBtn);
            this.Controls.Add(this.JobStatusCbo);
            this.Controls.Add(this.JobBoardLbl);
            this.Controls.Add(this.JobStatusLbl);
            this.Controls.Add(this.ContactEmailBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CommentsBox);
            this.Controls.Add(this.CommentsLbl);
            this.Controls.Add(this.CompanyPhoneBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ContactDatePkr);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompanyWebsiteBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JobIDBox);
            this.Controls.Add(this.JobIDLbl);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ContactNameLbl);
            this.Controls.Add(this.ContactPhoneBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactTitleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JobTitleBox);
            this.Controls.Add(this.JobTitleLbl);
            this.Controls.Add(this.CompanyNameBox);
            this.Controls.Add(this.CompanyNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Job Trakker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLbl;
        private System.Windows.Forms.TextBox CompanyNameBox;
        private System.Windows.Forms.TextBox JobTitleBox;
        private System.Windows.Forms.Label JobTitleLbl;
        private System.Windows.Forms.TextBox ContactTitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContactPhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ContactNameLbl;
        private System.Windows.Forms.TextBox JobIDBox;
        private System.Windows.Forms.Label JobIDLbl;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyWebsiteBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker ContactDatePkr;
        private System.Windows.Forms.TextBox CompanyPhoneBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.TextBox CommentsBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ContactEmailBox;
        private System.Windows.Forms.Label label10;
        private Label JobStatusLbl;
        private Label JobBoardLbl;
        private ComboBox JobStatusCbo;
        private Button DisplayEntryBtn;
        private ComboBox SelectSearchCbo;
        private TextBox SearchBox;
        private Button SearchBtn;
        private Label SelectSearchLbl;
        private Label SearchLbl;
        private Button ExportOpenBtn;
        private Label label4;
        private TextBox InterviewDateTimeBox;
        private Button ClearSearchBtn;
        private Label ActiveStateLbl;
        private ComboBox ActiveStateCbo;
        private SaveFileDialog saveFileDialog1;
        private Button SaveTextBtn;
        private TextBox JobLocationBox;
        private Label JobLocationLbl;
        private Button PrintEntryBtn;
        private PrintDialog printDialog1;
        private TextBox StaffingFirmBox;
        private Label StaffingFirmLbl;
        private ComboBox JobBoardCbo;
        private CheckBox RecruiterChk;
        private CheckBox DWSChk;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Button btnNewEntry;
        private Button btnSaveEntry;
        private Button btnClearEntry;
        private ComboBox JobTypeCbo;
        private Label JobTypeLbl;
        private BindingSource bindingSource1;
        private Button btnUpdate;
    }
}

