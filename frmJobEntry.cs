using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using namespace JobTrak;

namespace JobTrak
{
    public partial class JobEntry : Form
    {
        // use duplicate string for now, but later, use public method in main to get connString (TBD)
        //        private readonly String connString = @"Data Source=LAPTOP-KKSCK99N;Initial Catalog=dbJobTrakker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private String connString;
        private SqlConnection conn;
        /*
        private SqlDataAdapter dataAdapter;     // this is used to build connection between program and database
        private System.Data.DataTable table;                // table to hold info for dataGridView1
        private SqlCommandBuilder commandBuilder;
        private readonly string selectStatement = "Select * from tblJobTrakker";
        */
        private int idSelected = 0;

        public JobEntry()
        {
            InitializeComponent();
        }

        private void frmJobEntry_Load(object sender, EventArgs e)
        {
            // data is actually being loaded into form if needed in the parent
            //
        }

        // set the connection string
        public void SetConnString(String connectionString)
        {
            this.connString = connectionString;
        }

        //--------------------------------------------------
        // display entry data from table in frmJobEntry form
        public void SetDefaultCheckBoxes()
        {
            ContactDatePkr.Value = DateTime.Today;
            ActiveStateCbo.Text = "Active";
            JobTypeCbo.Text = "Software";
        }

        //--------------------------------------------------
        // display entry data from table in frmJobEntry form
        public void DisplayTableData(DataGridView dataGridView1)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
                idSelected = (int)row.Cells["ID"].Value;            // grab the ID value
                CompanyNameBox.Text = row.Cells["Company"].Value.ToString(); // grab the CompanyName value
                StaffingFirmBox.Text = row.Cells["StaffingFirm"].Value.ToString(); // grab the CompanyName value

                string statusValue = row.Cells["Status"].Value.ToString();
                JobStatusCbo.SelectedIndex = JobStatusCbo.FindString(statusValue.Trim());
                if (JobStatusCbo.SelectedIndex.Equals(-1))
                {
                    JobStatusCbo.SelectedIndex = 0;
                }

                string activeState = row.Cells["ApplicationStatus"].Value.ToString();
                ActiveStateCbo.SelectedIndex = ActiveStateCbo.FindString(activeState.Trim());
                if (ActiveStateCbo.SelectedIndex.Equals(-1))
                {
                    ActiveStateCbo.SelectedIndex = 0;
                }

                DWSChk.Checked = row.Cells["DWSFlag"].Value.Equals(true);
                RecruiterChk.Checked = row.Cells["RecruiterFlag"].Value.Equals(true);

                ContactDatePkr.Value = (DateTime)row.Cells["ContactDate"].Value;
                InterviewDateTimeBox.Text = row.Cells["InterviewDateTime"].Value.ToString();
                JobTitleBox.Text = row.Cells["JobTitle"].Value.ToString();
                JobIDBox.Text = row.Cells["JobID"].Value.ToString();

                string jobBoard = row.Cells["JobBoard"].Value.ToString();
                JobBoardCbo.SelectedIndex = JobBoardCbo.FindString(jobBoard.Trim());
                if (JobBoardCbo.SelectedIndex.Equals(-1))
                {
                    JobBoardCbo.SelectedIndex = 0;
                }

                NameBox.Text = row.Cells["Contact"].Value.ToString();
                ContactTitleBox.Text = row.Cells["Title"].Value.ToString();
                ContactPhoneBox.Text = row.Cells["Phone"].Value.ToString();
                ContactEmailBox.Text = row.Cells["Email"].Value.ToString();
                AddressBox.Text = row.Cells["Address"].Value.ToString();
                JobLocationBox.Text = row.Cells["JobLocation"].Value.ToString();
                CompanyPhoneBox.Text = row.Cells["CompanyPhone"].Value.ToString();
                CompanyWebsiteBox.Text = row.Cells["WebSite"].Value.ToString();
                CommentsBox.Text = row.Cells["Comments"].Value.ToString();

                string jobType = row.Cells["JobType"].Value.ToString();
                JobTypeCbo.SelectedIndex = JobTypeCbo.FindString(jobType.Trim());
                if (JobTypeCbo.SelectedIndex.Equals(-1))
                {
                    JobTypeCbo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // clear all entry boxes  
        private void ClearBoxes()
        {
            ActiveStateCbo.SelectedIndex = 0;
            CompanyNameBox.Clear();
            StaffingFirmBox.Clear();
            JobTitleBox.Clear();
            JobStatusCbo.SelectedIndex = 0;
            JobBoardCbo.SelectedIndex = 0;
            JobIDBox.Clear();
            NameBox.Clear();
            ContactTitleBox.Clear();
            ContactPhoneBox.Clear();
            ContactEmailBox.Clear();
            AddressBox.Clear();
            JobLocationBox.Clear();
            CompanyPhoneBox.Clear();
            CompanyWebsiteBox.Clear();
            CommentsBox.Clear();
            ContactDatePkr.Value = DateTime.Now;
            InterviewDateTimeBox.Clear();
            idSelected = 0;
            DWSChk.Checked = false;
            RecruiterChk.Checked = false;
            JobTypeCbo.SelectedIndex = 0;
        }

        // save entered data to database
        private void saveEntry()
        {
            SqlCommand command;
            string insert = @"insert into tblJobTrakker(ApplicationStatus, DWSFlag, Company, StaffingFirm, JobTitle, Status, ContactDate, InterviewDateTime, JobBoard, JobID, Contact, Title, Phone, Email, RecruiterFlag, Address, JobLocation, CompanyPhone, WebSite, Comments, JobType)
                            values(@ApplicationStatus, @DWSFlag, @Company, @StaffingFirm, @JobTitle, @Status, @ContactDate, @InterviewDateTime, @JobBoard, @JobID, @Contact, @Title, @Phone, @Email, @RecruiterFlag, @Address, @JobLocation, @CompanyPhone, @WebSite, @Comments, @JobType)";

            string update = @"UPDATE tblJobTrakker SET ApplicationStatus = @ApplicationStatus, DWSFlag = @DWSFlag, Company = @Company, StaffingFirm = @StaffingFirm, JobTitle = @JobTitle, Status = @Status, ContactDate = @ContactDate, InterviewDateTime = @InterviewDateTime, JobBoard = @JobBoard, JobID = @JobID, Contact = @Contact, Title = @Title, Phone = @Phone, Email = @Email, RecruiterFlag = @RecruiterFlag, Address = @Address, JobLocation = @JobLocation, CompanyPhone = @CompanyPhone, WebSite = @WebSite, Comments = @Comments, JobType = @JobType WHERE ID = " + idSelected.ToString();
            
            using (conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string cmdStatement = (idSelected.Equals(0) ? insert : update);
                    command = new SqlCommand(cmdStatement, conn);

                    string activeState = ActiveStateCbo.SelectedItem.ToString();
                    if (activeState.Equals(-1))
                    {
                        activeState = "Active";
                    }
                    command.Parameters.AddWithValue(@"ApplicationStatus", activeState);
                    command.Parameters.AddWithValue(@"DWSFlag", DWSChk.Checked);
                    command.Parameters.AddWithValue(@"Company", CompanyNameBox.Text);
                    command.Parameters.AddWithValue(@"StaffingFirm", StaffingFirmBox.Text);
                    command.Parameters.AddWithValue(@"JobTitle", JobTitleBox.Text);
                    command.Parameters.AddWithValue(@"Status", JobStatusCbo.SelectedItem.ToString());
                    command.Parameters.AddWithValue(@"ContactDate", ContactDatePkr.Value.Date);

                    string jobBoard = JobBoardCbo.SelectedItem.ToString();
                    if (jobBoard.Equals(-1))
                    {
                        jobBoard = "None";
                    }
                    command.Parameters.AddWithValue(@"JobBoard", jobBoard);
                    command.Parameters.AddWithValue(@"JobID", JobIDBox.Text);
                    command.Parameters.AddWithValue(@"Contact", NameBox.Text);
                    command.Parameters.AddWithValue(@"Title", ContactTitleBox.Text);
                    command.Parameters.AddWithValue(@"Phone", ContactPhoneBox.Text);
                    command.Parameters.AddWithValue(@"Email", ContactEmailBox.Text);
                    command.Parameters.AddWithValue(@"RecruiterFlag", RecruiterChk.Checked);
                    command.Parameters.AddWithValue(@"Address", AddressBox.Text);
                    command.Parameters.AddWithValue(@"JobLocation", JobLocationBox.Text);
                    command.Parameters.AddWithValue(@"CompanyPhone", CompanyPhoneBox.Text);
                    command.Parameters.AddWithValue(@"WebSite", CompanyWebsiteBox.Text);
                    command.Parameters.AddWithValue(@"InterviewDateTime", InterviewDateTimeBox.Text);
                    command.Parameters.AddWithValue(@"Comments", CommentsBox.Text);

                    string jobType = JobTypeCbo.SelectedItem.ToString();
                    if (jobType.Equals(-1))
                    {
                        jobType = "None";
                    }
                    command.Parameters.AddWithValue(@"JobType", jobType);

                    command.ExecuteNonQuery();  // push stuff into the table from the form
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }           // end of using statement
        }

        // update entry by saving data to database, keeping entry displayed
        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            saveEntry();
        }

        // save entry to database and clear entry
        private void SaveClearEntry_Click(object sender, EventArgs e)
        {
            saveEntry();
            ClearBoxes();
        }

        private void SaveAndStartNewEntry_Click(object sender, EventArgs e)
        {
            saveEntry();
            ClearBoxes();
            SetDefaultCheckBoxes();
        }

        private void SaveThenCloseForm_Click(object sender, EventArgs e)
        {
            saveEntry();
            ClearBoxes();
            this.Close();
        }

        //----------------------
        // clear all entry boxes
        //----------------------
        private void ClearEntry_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        //------------------------------------------------------
        // close the entry form to return to the main table form
        //------------------------------------------------------
        private void CloseEntryForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

