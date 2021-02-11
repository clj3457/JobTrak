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

namespace JobTrak
{
    public partial class Main : System.Windows.Forms.Form
    {
        private readonly String connString = @"Data Source=LAPTOP-KKSCK99N;Initial Catalog=dbJobTrakker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlDataAdapter dataAdapter;     // this is used to build connection between program and database
        private System.Data.DataTable table;                // table to hold info for dataGridView1
        private SqlCommandBuilder commandBuilder;
        private SqlConnection conn;
        private readonly string selectAllStatement = "Select * from tblJobTrakker";

        public Main()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;  // sets the source of the data to be displayed

            // set following columns invisible
            dataGridView1.Columns[0].ReadOnly = true;       // prevents ID field from being changed.   
            dataGridView1.Columns[0].Visible = false;
            for (int idx = 12; idx < 21; idx++)
            {
                dataGridView1.Columns[idx].Visible = false;
            }

            // update dataGridView from database table
            GetDataFromTable(selectAllStatement);
        }

        //-----------------------------------------------------------------
        // refresh data: update data adapter from database table
        //-----------------------------------------------------------------
        public void RefreshData()
        {
            GetDataFromTable(selectAllStatement);
            dataGridView1.Update();
        }

        //-----------------------------------------------------------------
        // tool strip refresh menu option selected
        // refresh dataGridView1 from table in database
        //-----------------------------------------------------------------
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        //-----------------------------------------------------------------
        // get data from database table and load into dataGridView adapter
        //-----------------------------------------------------------------
        private void GetDataFromTable(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new System.Data.DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-----------------------------------------------------------------------
        // CellEndEdit method for dataGridView1 - called when done editing a cell
        //-----------------------------------------------------------------------
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();

            try
            {
                bindingSource1.EndEdit();
                dataAdapter.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //--------------------------------------------
        // delete the selected row from the data table
        //--------------------------------------------
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
            string value = row.Cells["ID"].Value.ToString();            // grab the ID value
            string companyName = row.Cells["Company"].Value.ToString(); // grab the CompanyName value
            string jobTitle = row.Cells["JobTitle"].Value.ToString(); // grab the JobTitle value
            DialogResult result =
                MessageBox.Show("Do you really want to delete " + jobTitle + " at " + companyName + ", record " + value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteStatement = @"Delete from tblJobTrakker where id = '" + value + "'";     // this is sql record to be deleted

            if (result == DialogResult.Yes)
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
                RefreshData();
            }
        }

        //---------------------------------------------------------------------------------------
        // this is called when job entry form is closed and refreshes the table from the database
        //---------------------------------------------------------------------------------------
        public void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData();
        }

        //----------------------------------------------------------
        // New Entry item clicked
        // create new entry form and display
        //----------------------------------------------------------
        private void NewEntryItem_Click(object sender, EventArgs e)
        {
            frmJobEntry frm = new frmJobEntry();        // make a new entry form
            frm.SetConnString(connString);
            frm.FormClosed += new FormClosedEventHandler(EntryForm_FormClosed);
            frm.Show();
        }

        //----------------------------------------------------------
        // Tool strip option 'Display Entry' has been selected
        // display data from the selected row in Job Entry form
        //----------------------------------------------------------
        private void DisplayEntryItem_Click(object sender, EventArgs e)
        {
            frmJobEntry frm = new frmJobEntry();        // make a new entry form
            frm.DisplayTableData(dataGridView1);
            frm.SetConnString(connString);
            frm.FormClosed += new FormClosedEventHandler(EntryForm_FormClosed);
            frm.Show();
        }

        //----------------------------------------------------------
        // process search using field selection and search criteria
        //----------------------------------------------------------
        private void SearchItem_Click(object sender, EventArgs e)
        {
            string searchSubject = SelectSearchCbo.SelectedItem.ToString();
            switch (searchSubject.Trim())
            {
                // no selection made, get entire table
                case "No Selection":
                    GetDataFromTable(selectAllStatement);
                    break;
                // get all jobs with entered active state
                case "Application Status":
                    GetDataFromTable("Select * from tblJobTrakker where lower(ApplicationStatus) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                case "DWSFlag":
                    int dwsSearch = (SearchCriteriaBox.Text.ToLower().Equals("true") ? 1 : 0);
                    GetDataFromTable("Select * from tblJobTrakker where lower(DWSFlag) like '%" + dwsSearch + "%'");
                    break;
                // get all jobs with entered job title
                case "Job Title":
                    GetDataFromTable("Select * from tblJobTrakker where lower(JobTitle) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                // get all jobs with entered company name
                case "Company Name":
                    GetDataFromTable("Select * from tblJobTrakker where lower(Company) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                // get all jobs with entered Staffing Firm name
                case "Staffing Firm Name":
                    GetDataFromTable("Select * from tblJobTrakker where lower(StaffingFirm) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                // get all jobs with entered job status
                case "Job Status":
                    GetDataFromTable("Select * from tblJobTrakker where lower(Status) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                // get all jobs with entered active state
                case "Job Type":
                    GetDataFromTable("Select * from tblJobTrakker where lower(JobType) like '%" + SearchCriteriaBox.Text.ToLower() + "%'");
                    break;
                // get all jobs that are not closed
                case "Not Closed":
                    GetDataFromTable("Select * from tblJobTrakker where lower(ApplicationStatus) not like '%closed%'");
                    break;
                default:
                    break;
            }
        }

        //-----------------------------------------------------
        // clear search field selection and criteria
        //-----------------------------------------------------
        private void ClearSearchItem_Click(object sender, EventArgs e)
        {
            SearchCriteriaBox.Clear();
            SelectSearchCbo.SelectedIndex = 0;
        }

        //-----------------------------------------------------------------
        // save content to text file
        //-----------------------------------------------------------------
        private void SaveToText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
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

        private void Export2Excel_Click(object sender, EventArgs e)
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
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // get each row
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // get each column within selected row
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
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
            int idSelected = 0;

            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;  // grab a reference to the current row
                idSelected = (int)row.Cells["ID"].Value;            // grab the ID value
                entryList.Add("\nJOB APPLICATION INFORMATION\n+++++++++++++++++++++++++++++++++++++++++++++++++++\n");
                entryList.Add("Company Name: " + row.Cells["Company"].Value.ToString() + "\n");
                entryList.Add("Staffing Firm Name: " + row.Cells["StaffingFirm"].Value.ToString() + "\n");

                string statusValue = row.Cells["Status"].Value.ToString();
                entryList.Add("Job Status: " + statusValue + "\n");

                entryList.Add("Date of Application/Contact: " + row.Cells["ContactDate"].Value.ToString() + "\n");
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

        private void PrintSelected_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }                       // end of class Main
}
