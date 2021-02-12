
namespace JobTrak
{
    partial class JobEntry
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
            this.JobTypeCbo = new System.Windows.Forms.ComboBox();
            this.JobTypeLbl = new System.Windows.Forms.Label();
            this.DWSChk = new System.Windows.Forms.CheckBox();
            this.RecruiterChk = new System.Windows.Forms.CheckBox();
            this.JobBoardCbo = new System.Windows.Forms.ComboBox();
            this.StaffingFirmBox = new System.Windows.Forms.TextBox();
            this.StaffingFirmLbl = new System.Windows.Forms.Label();
            this.JobLocationBox = new System.Windows.Forms.TextBox();
            this.JobLocationLbl = new System.Windows.Forms.Label();
            this.ActiveStateCbo = new System.Windows.Forms.ComboBox();
            this.ActiveStateLbl = new System.Windows.Forms.Label();
            this.InterviewDateTimeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JobStatusCbo = new System.Windows.Forms.ComboBox();
            this.JobBoardLbl = new System.Windows.Forms.Label();
            this.JobStatusLbl = new System.Windows.Forms.Label();
            this.ContactEmailBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CommentsBox = new System.Windows.Forms.TextBox();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.CompanyPhoneBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ContactDatePkr = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyWebsiteBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.JobIDBox = new System.Windows.Forms.TextBox();
            this.JobIDLbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ContactNameLbl = new System.Windows.Forms.Label();
            this.ContactPhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactTitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JobTitleBox = new System.Windows.Forms.TextBox();
            this.JobTitleLbl = new System.Windows.Forms.Label();
            this.CompanyNameBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveClearEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAndStartNewEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveThenCloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.JobTypeCbo.Location = new System.Drawing.Point(151, 191);
            this.JobTypeCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobTypeCbo.Name = "JobTypeCbo";
            this.JobTypeCbo.Size = new System.Drawing.Size(175, 24);
            this.JobTypeCbo.TabIndex = 188;
            // 
            // JobTypeLbl
            // 
            this.JobTypeLbl.AutoSize = true;
            this.JobTypeLbl.Location = new System.Drawing.Point(17, 191);
            this.JobTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTypeLbl.Name = "JobTypeLbl";
            this.JobTypeLbl.Size = new System.Drawing.Size(67, 17);
            this.JobTypeLbl.TabIndex = 187;
            this.JobTypeLbl.Text = "Job Type";
            this.JobTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DWSChk
            // 
            this.DWSChk.AutoSize = true;
            this.DWSChk.Location = new System.Drawing.Point(151, 223);
            this.DWSChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DWSChk.Name = "DWSChk";
            this.DWSChk.Size = new System.Drawing.Size(143, 21);
            this.DWSChk.TabIndex = 186;
            this.DWSChk.Text = "Entered Into DWS";
            this.DWSChk.UseVisualStyleBackColor = true;
            // 
            // RecruiterChk
            // 
            this.RecruiterChk.AutoSize = true;
            this.RecruiterChk.Location = new System.Drawing.Point(346, 223);
            this.RecruiterChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecruiterChk.Name = "RecruiterChk";
            this.RecruiterChk.Size = new System.Drawing.Size(191, 21);
            this.RecruiterChk.TabIndex = 185;
            this.RecruiterChk.Text = "Recruiter/Staffing Agency";
            this.RecruiterChk.UseVisualStyleBackColor = true;
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
            this.JobBoardCbo.Location = new System.Drawing.Point(511, 195);
            this.JobBoardCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobBoardCbo.Name = "JobBoardCbo";
            this.JobBoardCbo.Size = new System.Drawing.Size(175, 24);
            this.JobBoardCbo.TabIndex = 184;
            // 
            // StaffingFirmBox
            // 
            this.StaffingFirmBox.Location = new System.Drawing.Point(511, 166);
            this.StaffingFirmBox.Margin = new System.Windows.Forms.Padding(4);
            this.StaffingFirmBox.Name = "StaffingFirmBox";
            this.StaffingFirmBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StaffingFirmBox.Size = new System.Drawing.Size(173, 22);
            this.StaffingFirmBox.TabIndex = 183;
            // 
            // StaffingFirmLbl
            // 
            this.StaffingFirmLbl.AutoSize = true;
            this.StaffingFirmLbl.Location = new System.Drawing.Point(343, 168);
            this.StaffingFirmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffingFirmLbl.Name = "StaffingFirmLbl";
            this.StaffingFirmLbl.Size = new System.Drawing.Size(155, 17);
            this.StaffingFirmLbl.TabIndex = 182;
            this.StaffingFirmLbl.Text = "Recruiting/Staffing Firm";
            this.StaffingFirmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobLocationBox
            // 
            this.JobLocationBox.Location = new System.Drawing.Point(151, 103);
            this.JobLocationBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobLocationBox.Name = "JobLocationBox";
            this.JobLocationBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobLocationBox.Size = new System.Drawing.Size(173, 22);
            this.JobLocationBox.TabIndex = 181;
            // 
            // JobLocationLbl
            // 
            this.JobLocationLbl.AutoSize = true;
            this.JobLocationLbl.Location = new System.Drawing.Point(17, 103);
            this.JobLocationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobLocationLbl.Name = "JobLocationLbl";
            this.JobLocationLbl.Size = new System.Drawing.Size(89, 17);
            this.JobLocationLbl.TabIndex = 180;
            this.JobLocationLbl.Text = "Job Location";
            this.JobLocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ActiveStateCbo.Location = new System.Drawing.Point(151, 161);
            this.ActiveStateCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveStateCbo.Name = "ActiveStateCbo";
            this.ActiveStateCbo.Size = new System.Drawing.Size(175, 24);
            this.ActiveStateCbo.TabIndex = 179;
            // 
            // ActiveStateLbl
            // 
            this.ActiveStateLbl.AutoSize = true;
            this.ActiveStateLbl.Location = new System.Drawing.Point(16, 161);
            this.ActiveStateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActiveStateLbl.Name = "ActiveStateLbl";
            this.ActiveStateLbl.Size = new System.Drawing.Size(121, 17);
            this.ActiveStateLbl.TabIndex = 178;
            this.ActiveStateLbl.Text = "Application Status";
            this.ActiveStateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InterviewDateTimeBox
            // 
            this.InterviewDateTimeBox.Location = new System.Drawing.Point(850, 195);
            this.InterviewDateTimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.InterviewDateTimeBox.Name = "InterviewDateTimeBox";
            this.InterviewDateTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InterviewDateTimeBox.Size = new System.Drawing.Size(173, 22);
            this.InterviewDateTimeBox.TabIndex = 177;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 176;
            this.label4.Text = "Interview Date/Time";
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
            this.JobStatusCbo.Location = new System.Drawing.Point(151, 131);
            this.JobStatusCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobStatusCbo.Name = "JobStatusCbo";
            this.JobStatusCbo.Size = new System.Drawing.Size(175, 24);
            this.JobStatusCbo.TabIndex = 175;
            // 
            // JobBoardLbl
            // 
            this.JobBoardLbl.AutoSize = true;
            this.JobBoardLbl.Location = new System.Drawing.Point(343, 198);
            this.JobBoardLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobBoardLbl.Name = "JobBoardLbl";
            this.JobBoardLbl.Size = new System.Drawing.Size(73, 17);
            this.JobBoardLbl.TabIndex = 174;
            this.JobBoardLbl.Text = "Job Board";
            this.JobBoardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobStatusLbl
            // 
            this.JobStatusLbl.AutoSize = true;
            this.JobStatusLbl.Location = new System.Drawing.Point(17, 131);
            this.JobStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobStatusLbl.Name = "JobStatusLbl";
            this.JobStatusLbl.Size = new System.Drawing.Size(75, 17);
            this.JobStatusLbl.TabIndex = 173;
            this.JobStatusLbl.Text = "Job Status";
            this.JobStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactEmailBox
            // 
            this.ContactEmailBox.Location = new System.Drawing.Point(850, 136);
            this.ContactEmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactEmailBox.Name = "ContactEmailBox";
            this.ContactEmailBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactEmailBox.Size = new System.Drawing.Size(173, 22);
            this.ContactEmailBox.TabIndex = 172;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 171;
            this.label10.Text = "Contact Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommentsBox
            // 
            this.CommentsBox.Location = new System.Drawing.Point(20, 276);
            this.CommentsBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommentsBox.Multiline = true;
            this.CommentsBox.Name = "CommentsBox";
            this.CommentsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentsBox.Size = new System.Drawing.Size(1003, 284);
            this.CommentsBox.TabIndex = 170;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Location = new System.Drawing.Point(17, 255);
            this.CommentsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(74, 17);
            this.CommentsLbl.TabIndex = 169;
            this.CommentsLbl.Text = "Comments";
            this.CommentsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyPhoneBox
            // 
            this.CompanyPhoneBox.Location = new System.Drawing.Point(511, 104);
            this.CompanyPhoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyPhoneBox.Name = "CompanyPhoneBox";
            this.CompanyPhoneBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.CompanyPhoneBox.TabIndex = 168;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 167;
            this.label9.Text = "Company Phone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactDatePkr
            // 
            this.ContactDatePkr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ContactDatePkr.Location = new System.Drawing.Point(850, 106);
            this.ContactDatePkr.Margin = new System.Windows.Forms.Padding(4);
            this.ContactDatePkr.Name = "ContactDatePkr";
            this.ContactDatePkr.Size = new System.Drawing.Size(175, 22);
            this.ContactDatePkr.TabIndex = 166;
            this.ContactDatePkr.Value = new System.DateTime(2020, 11, 17, 13, 9, 57, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(708, 109);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 17);
            this.label20.TabIndex = 165;
            this.label20.Text = "Contact Date";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(511, 136);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressBox.Size = new System.Drawing.Size(173, 22);
            this.AddressBox.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 163;
            this.label1.Text = "Company Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyWebsiteBox
            // 
            this.CompanyWebsiteBox.Location = new System.Drawing.Point(511, 73);
            this.CompanyWebsiteBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyWebsiteBox.Name = "CompanyWebsiteBox";
            this.CompanyWebsiteBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyWebsiteBox.Size = new System.Drawing.Size(173, 22);
            this.CompanyWebsiteBox.TabIndex = 162;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 161;
            this.label8.Text = "Company WebSite";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobIDBox
            // 
            this.JobIDBox.Location = new System.Drawing.Point(151, 73);
            this.JobIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobIDBox.Name = "JobIDBox";
            this.JobIDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobIDBox.Size = new System.Drawing.Size(175, 22);
            this.JobIDBox.TabIndex = 160;
            // 
            // JobIDLbl
            // 
            this.JobIDLbl.AutoSize = true;
            this.JobIDLbl.Location = new System.Drawing.Point(17, 73);
            this.JobIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobIDLbl.Name = "JobIDLbl";
            this.JobIDLbl.Size = new System.Drawing.Size(46, 17);
            this.JobIDLbl.TabIndex = 159;
            this.JobIDLbl.Text = "Job Id";
            this.JobIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(850, 44);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameBox.Size = new System.Drawing.Size(175, 22);
            this.NameBox.TabIndex = 158;
            // 
            // ContactNameLbl
            // 
            this.ContactNameLbl.AutoSize = true;
            this.ContactNameLbl.Location = new System.Drawing.Point(708, 48);
            this.ContactNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNameLbl.Name = "ContactNameLbl";
            this.ContactNameLbl.Size = new System.Drawing.Size(97, 17);
            this.ContactNameLbl.TabIndex = 157;
            this.ContactNameLbl.Text = "Contact Name";
            this.ContactNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactPhoneBox
            // 
            this.ContactPhoneBox.Location = new System.Drawing.Point(850, 166);
            this.ContactPhoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactPhoneBox.Name = "ContactPhoneBox";
            this.ContactPhoneBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.ContactPhoneBox.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 155;
            this.label3.Text = "Contact Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactTitleBox
            // 
            this.ContactTitleBox.Location = new System.Drawing.Point(850, 76);
            this.ContactTitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactTitleBox.Name = "ContactTitleBox";
            this.ContactTitleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactTitleBox.Size = new System.Drawing.Size(173, 22);
            this.ContactTitleBox.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 153;
            this.label2.Text = "Contact Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobTitleBox
            // 
            this.JobTitleBox.Location = new System.Drawing.Point(151, 43);
            this.JobTitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobTitleBox.Name = "JobTitleBox";
            this.JobTitleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JobTitleBox.Size = new System.Drawing.Size(175, 22);
            this.JobTitleBox.TabIndex = 152;
            // 
            // JobTitleLbl
            // 
            this.JobTitleLbl.AutoSize = true;
            this.JobTitleLbl.Location = new System.Drawing.Point(17, 43);
            this.JobTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTitleLbl.Name = "JobTitleLbl";
            this.JobTitleLbl.Size = new System.Drawing.Size(62, 17);
            this.JobTitleLbl.TabIndex = 151;
            this.JobTitleLbl.Text = "Job Title";
            this.JobTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyNameBox
            // 
            this.CompanyNameBox.Location = new System.Drawing.Point(509, 44);
            this.CompanyNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyNameBox.Name = "CompanyNameBox";
            this.CompanyNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyNameBox.Size = new System.Drawing.Size(175, 22);
            this.CompanyNameBox.TabIndex = 150;
            // 
            // CompanyNameLbl
            // 
            this.CompanyNameLbl.AutoSize = true;
            this.CompanyNameLbl.Location = new System.Drawing.Point(343, 47);
            this.CompanyNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyNameLbl.Name = "CompanyNameLbl";
            this.CompanyNameLbl.Size = new System.Drawing.Size(108, 17);
            this.CompanyNameLbl.TabIndex = 149;
            this.CompanyNameLbl.Text = "Company Name";
            this.CompanyNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 194;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEntryToolStripMenuItem,
            this.tsSaveClearEntry,
            this.tsSaveAndStartNewEntry,
            this.tsSaveThenCloseForm,
            this.clearEntryToolStripMenuItem,
            this.closeEntryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // updateEntryToolStripMenuItem
            // 
            this.updateEntryToolStripMenuItem.Name = "updateEntryToolStripMenuItem";
            this.updateEntryToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.updateEntryToolStripMenuItem.Text = "Update Entry";
            this.updateEntryToolStripMenuItem.Click += new System.EventHandler(this.UpdateEntry_Click);
            // 
            // tsSaveClearEntry
            // 
            this.tsSaveClearEntry.Name = "tsSaveClearEntry";
            this.tsSaveClearEntry.Size = new System.Drawing.Size(236, 26);
            this.tsSaveClearEntry.Text = "Save: Clear Entry";
            this.tsSaveClearEntry.Click += new System.EventHandler(this.SaveClearEntry_Click);
            // 
            // clearEntryToolStripMenuItem
            // 
            this.clearEntryToolStripMenuItem.Name = "clearEntryToolStripMenuItem";
            this.clearEntryToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.clearEntryToolStripMenuItem.Text = "Clear Entry";
            this.clearEntryToolStripMenuItem.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // closeEntryToolStripMenuItem
            // 
            this.closeEntryToolStripMenuItem.Name = "closeEntryToolStripMenuItem";
            this.closeEntryToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.closeEntryToolStripMenuItem.Text = "Close Entry Form";
            this.closeEntryToolStripMenuItem.Click += new System.EventHandler(this.CloseEntryForm);
            // 
            // tsSaveAndStartNewEntry
            // 
            this.tsSaveAndStartNewEntry.Name = "tsSaveAndStartNewEntry";
            this.tsSaveAndStartNewEntry.Size = new System.Drawing.Size(236, 26);
            this.tsSaveAndStartNewEntry.Text = "Save: Start  New Entry";
            this.tsSaveAndStartNewEntry.Click += new System.EventHandler(this.SaveAndStartNewEntry_Click);
            // 
            // tsSaveThenCloseForm
            // 
            this.tsSaveThenCloseForm.Name = "tsSaveThenCloseForm";
            this.tsSaveThenCloseForm.Size = new System.Drawing.Size(236, 26);
            this.tsSaveThenCloseForm.Text = "Save: Close form";
            this.tsSaveThenCloseForm.Click += new System.EventHandler(this.SaveThenCloseForm_Click);
            // 
            // frmJobEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1050, 573);
            this.Controls.Add(this.JobTypeCbo);
            this.Controls.Add(this.JobTypeLbl);
            this.Controls.Add(this.DWSChk);
            this.Controls.Add(this.RecruiterChk);
            this.Controls.Add(this.JobBoardCbo);
            this.Controls.Add(this.StaffingFirmBox);
            this.Controls.Add(this.StaffingFirmLbl);
            this.Controls.Add(this.JobLocationBox);
            this.Controls.Add(this.JobLocationLbl);
            this.Controls.Add(this.ActiveStateCbo);
            this.Controls.Add(this.ActiveStateLbl);
            this.Controls.Add(this.InterviewDateTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JobStatusCbo);
            this.Controls.Add(this.JobBoardLbl);
            this.Controls.Add(this.JobStatusLbl);
            this.Controls.Add(this.ContactEmailBox);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJobEntry";
            this.Text = "frmJobEntry";
            this.Load += new System.EventHandler(this.frmJobEntry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox JobTypeCbo;
        private System.Windows.Forms.Label JobTypeLbl;
        private System.Windows.Forms.CheckBox DWSChk;
        private System.Windows.Forms.CheckBox RecruiterChk;
        private System.Windows.Forms.ComboBox JobBoardCbo;
        private System.Windows.Forms.TextBox StaffingFirmBox;
        private System.Windows.Forms.Label StaffingFirmLbl;
        private System.Windows.Forms.TextBox JobLocationBox;
        private System.Windows.Forms.Label JobLocationLbl;
        private System.Windows.Forms.ComboBox ActiveStateCbo;
        private System.Windows.Forms.Label ActiveStateLbl;
        private System.Windows.Forms.TextBox InterviewDateTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JobStatusCbo;
        private System.Windows.Forms.Label JobBoardLbl;
        private System.Windows.Forms.Label JobStatusLbl;
        private System.Windows.Forms.TextBox ContactEmailBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CommentsBox;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.TextBox CompanyPhoneBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ContactDatePkr;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyWebsiteBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox JobIDBox;
        private System.Windows.Forms.Label JobIDLbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ContactNameLbl;
        private System.Windows.Forms.TextBox ContactPhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactTitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JobTitleBox;
        private System.Windows.Forms.Label JobTitleLbl;
        private System.Windows.Forms.TextBox CompanyNameBox;
        private System.Windows.Forms.Label CompanyNameLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSaveClearEntry;
        private System.Windows.Forms.ToolStripMenuItem clearEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAndStartNewEntry;
        private System.Windows.Forms.ToolStripMenuItem tsSaveThenCloseForm;
    }
}