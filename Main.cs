using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Web;
using System.IO;
using System.Drawing.Printing;

namespace JobTrakker
{
    public partial class Main : Form
    {
        // create a literal string with the connection string for the database
        private readonly String connString = @"Data Source=LAPTOP-KKSCK99N;Initial Catalog=dbJobTrakker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlDataAdapter dataAdapter;     // this is used to build connection between program and database
        private System.Data.DataTable table;                // table to hold info for dataGridView1
        private SqlCommandBuilder commandBuilder;
        private SqlConnection conn;
        private readonly string selectStatement = "Select * from tblJobTrakker";
        private int idSelected = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JobStatusCbo.SelectedIndex = 0;             // set index to 1st item in job status combo box
            dataGridView1.DataSource = bindingSource1;  // sets the source of the data to be displayed

            // set following columns invisible
            dataGridView1.Columns[0].ReadOnly = true;       // prevents ID field from being changed.   
            dataGridView1.Columns[0].Visible = false;
            for (int idx = 12; idx < 21; idx++)
            {
                dataGridView1.Columns[idx].Visible = false;
            }

            // update dataGridView from database table
            GetDataFromTable(selectStatement, true);
        }

        // refresh data: update data adapter from database table and clear entry boxes
        // pass in sort flag to determine whether or not to sort dataGridView
        private void RefreshData(bool sort)
        {
            GetDataFromTable(selectStatement, sort);
            dataGridView1.Update();
            ClearBoxes();
        }

        // get data from database table and load into dataGridView adapter
        private void GetDataFromTable(string selectCommand, bool sort)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new System.Data.DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                if (sort)
                {
                    dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
                }
            }
            catch (SqlException ex)
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
//            RefreshData();
        }

        // save entry to database and clear entry
        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            saveEntry();
            RefreshData(true);
        }

        // update entry by saving data to database, keeping entry displayed
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            saveEntry();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();

            try
            {
                bindingSource1.EndEdit();
                dataAdapter.Update(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
            string value = row.Cells["ID"].Value.ToString();            // grab the ID value
            string companyName = row.Cells["Company"].Value.ToString(); // grab the CompanyName value
            string jobTitle = row.Cells["JobTitle"].Value.ToString(); // grab the JobTitle value
            DialogResult result = 
                MessageBox.Show("Do you really want to delete " + jobTitle + " at " + companyName + ", record " + value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteStatement = @"Delete from tblJobTrakker where id = '" + value + "'";     // this is sql record to be deleted

            if(result == DialogResult.Yes)
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(deleteStatement, conn);
                        comm.ExecuteNonQuery();             // causes delete statement command to run
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                RefreshData(true);
            }
        }

        //------------------------------------------------------
        // display/load selected table row in entry boxes/fields
        //------------------------------------------------------
         private void DisplayEntryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
                idSelected = (int)row.Cells["ID"].Value;            // grab the ID value
                CompanyNameBox.Text = row.Cells["Company"].Value.ToString(); // grab the CompanyName value
                StaffingFirmBox.Text = row.Cells["StaffingFirm"].Value.ToString(); // grab the CompanyName value

                string statusValue = row.Cells["Status"].Value.ToString();
                JobStatusCbo.SelectedIndex = JobStatusCbo.FindString(statusValue.Trim());
                if(JobStatusCbo.SelectedIndex.Equals(-1))
                {
                    JobStatusCbo.SelectedIndex = 0;
                }

                string activeState = row.Cells["ApplicationStatus"].Value.ToString();
                ActiveStateCbo.SelectedIndex = ActiveStateCbo.FindString(activeState.Trim());
                if(ActiveStateCbo.SelectedIndex.Equals(-1))
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
                if(JobBoardCbo.SelectedIndex.Equals(-1))
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
                if(JobTypeCbo.SelectedIndex.Equals(-1))
                {
                    JobTypeCbo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            ContactDatePkr.Value = DateTime.Today;
            ActiveStateCbo.Text = "Active";
            JobTypeCbo.Text = "Software";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        
        //-----------------------------------------------------
        // process search using selection and search criteria
        //-----------------------------------------------------
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool sort = true;
            string searchSubject = SelectSearchCbo.SelectedItem.ToString();
            switch (searchSubject.Trim()) { 
                // no selection made, get entire table
                case "No Selection":
                    GetDataFromTable(selectStatement, sort);
                break;
                // get all jobs with entered job title
                case "Job Title":
                    GetDataFromTable("Select * from tblJobTrakker where lower(JobTitle) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs with entered company name
                case "Company Name":
                    GetDataFromTable("Select * from tblJobTrakker where lower(Company) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs with entered Staffing Firm name
                case "Staffing Firm Name":
                    GetDataFromTable("Select * from tblJobTrakker where lower(StaffingFirm) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs with entered job status
                case "Job Status":
                    GetDataFromTable("Select * from tblJobTrakker where lower(Status) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs with entered active state
                case "Application Status":
                    GetDataFromTable("Select * from tblJobTrakker where lower(ApplicationStatus) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs with entered active state
                case "Job Type":
                    GetDataFromTable("Select * from tblJobTrakker where lower(JobType) like '%" + SearchBox.Text.ToLower() + "%'", sort);
                    break;
                // get all jobs that are not closed
                case "Not Closed":
                    GetDataFromTable("Select * from tblJobTrakker where lower(ApplicationStatus) not like '%closed%'", sort);
                    break;

                default:
                    break;
            }
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            SelectSearchCbo.SelectedIndex = 0;
        }

        //-------------------------------
        // save content to text file
        //-------------------------------
        private void SaveTextBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // get each row
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sw.WriteLine("**************************************");
                        // go through each cell in row
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex != 0)
                            {
                                sw.WriteLine(dataGridView1.Columns[cell.ColumnIndex].Name + ": " + cell.Value);
                            }
                        }
                        sw.WriteLine();             // put blank line between entries
                    }
                }
                Process.Start("notepad.exe", saveFileDialog1.FileName);
            }
        }

        //---------------------------------------------
        // set up for exporting excel
        //---------------------------------------------
        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessID);
        private void ExportOpenBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks bk = app.Workbooks;
            _Workbook workbook = bk.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Job Trakker";
                for(int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // get each row
                for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // get each column within selected row
                    for(int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if(dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                 }               // end of for each row
                if (saveFileDialog1.ShowDialog() == DialogResult.OK
                    && Type.GetTypeFromProgID("Excel.Application") != null)
                {
                    
                    app.ActiveWorkbook.SaveAs(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }                   // end of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                app.Quit();
                GetWindowThreadProcessId(app.Hwnd, out int id);
                Process.GetProcessById(id).Kill();
            }
        }

        private void PrintCurrentRow()
        {
            List<string> lists = new List<string>();
            List<string> entryList = lists;

            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
                idSelected = (int)row.Cells["ID"].Value;            // grab the ID value
                entryList.Add("\nJOB APPLICATION INFORMATION\n+++++++++++++++++++++++++++++++++++++++++++++++++++\n");
                entryList.Add("Company Name: " + row.Cells["Company"].Value.ToString() + "\n");
                entryList.Add("Staffing Firm Name: " + row.Cells["StaffingFirm"].Value.ToString() + "\n");
                //                CompanyNameBox.Text = row.Cells["Company"].Value.ToString(); // grab the CompanyName value

                string statusValue = row.Cells["Status"].Value.ToString();
                entryList.Add("Job Status: " + statusValue + "\n");

                entryList.Add("Date of Application/Contact: " + row.Cells["ContactDate"].Value.ToString() + "\n");
                InterviewDateTimeBox.Text = row.Cells["InterviewDateTime"].Value.ToString();
                entryList.Add("Interview Date & Time: " + row.Cells["InterviewDateTime"].Value.ToString() + "\n");

                entryList.Add("Job Title: " + row.Cells["JobTitle"].Value.ToString() + "\n");
                entryList.Add("Job ID: " + row.Cells["JobID"].Value.ToString() + "\n");
                entryList.Add("Job Board: " + row.Cells["JobBoard"].Value.ToString() + "\n");
                entryList.Add("Contact Name: " + row.Cells["Contact"].Value.ToString() + "\n");
                entryList.Add("Contact's Title: " + row.Cells["Title"].Value.ToString() + "\n");
                entryList.Add("Contact's Phone Number: " + row.Cells["Phone"].Value.ToString() + "\n");
                entryList.Add("Contact's Email: " + row.Cells["Email"].Value.ToString() + "\n");
                entryList.Add("Recruiter/Staffing Agency: " + (row.Cells["RecruiterFlag"].Value.Equals(1) ? "Yes" : "No") + "\n");
                entryList.Add("Company Address: " + row.Cells["Address"].Value.ToString() + "\n");
                entryList.Add("Job Location: " + row.Cells["JobLocation"].Value.ToString() + "\n");
                entryList.Add("Company's Phone Number: " + row.Cells["CompanyPhone"].Value.ToString() + "\n");
                entryList.Add("Company's Web Site: " + row.Cells["WebSite"].Value.ToString() + "\n");
                entryList.Add("Comments: " + row.Cells["Comments"].Value.ToString() + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintEntryBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented yet.");

            /*
             * 
             * 
            try
            {
                PrintCurrentRow();

                PrintDocument pd = new PrintDocument();
                
                pd.PrinterSettings.PrinterName = printDialog1.ShowDialog().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }                       // end of class Main
}
    