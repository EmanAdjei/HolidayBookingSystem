using Component_A_ClassLibrary;
using Component_B_ClassLibrary.Functionality_A;
using Component_B_ClassLibrary.Functionality_B;
using Component_B_ClassLibrary.Functionality_C;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ManageForm : Form
    {
        // Class which handles the holidays in the admin application
        private HolidayManagement hm = new HolidayManagement();

        private ManageForm()
        {
            InitializeComponent();
            ArrangePanels();
            HOMEToolStripMenuItem_Click(new object(), new EventArgs());
        }

        #region ManageFrom Singleton

        // Allows only one instance the Admin program to be made at a time
        private static readonly object locker = new object();
        private static ManageForm instance = null;

        public static ManageForm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ManageForm();
                    }
                    return instance;
                }
            }
        }

        #endregion


        #region Panel and toolbar button settings
        private void ArrangePanels()
        {
            // Make the panels the same size and stack them ontop of eachother
            pnlCreate.Location = new Point(0, 37);
            pnlEdit.Location = new Point(0, 37);
            pnlRequested.Location = new Point(0, 37);
            pnlTaken.Location = new Point(0, 37);
            pnlHome.Location = new Point(0, 37);
            pnlCompanyPolicies.Location = new Point(0, 37);

            pnlCreate.Size = new Size(851, 443);
            pnlEdit.Size = new Size(851, 443);
            pnlRequested.Size = new Size(851, 443);
            pnlTaken.Size = new Size(851, 443);
            pnlHome.Size = new Size(851, 443);
            pnlCompanyPolicies.Size = new Size(851, 443);

            // Set search to by name
            rdName.Checked = true;
            chbxDetails.Checked = false;

            cbConstraints.Checked = false;

            // Make combobox hold values from db
            cbxDept.DataSource = constraintChecker1.DeptType;
            cbxEDept.DataSource = constraintChecker1.DeptType;

            cbxRole.DataSource = constraintChecker1.RoleType;
            cbxERole.DataSource = constraintChecker1.RoleType;

            cbRelaxedMonth.DataSource = constraintChecker1.MonthNames;

            // Only allow delete/edit when an employee has been selected
            SwitchButtons();
            //SetEditableFields(pnlEdit);
            SetEditableFields(false);

            btnReq_Approve.Enabled = false;
            btnReq_Reject.Enabled = false;
        }

        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make create panel visable and the rest hidden
            pnlHome.Visible = false;
            pnlTaken.Visible = false;
            pnlRequested.Visible = false;
            pnlEdit.Visible = false;
            pnlCreate.Visible = true;
            pnlCompanyPolicies.Visible = false;
        }

        private void EDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make edit panel and button visable and the rest hidden
            pnlHome.Visible = false;
            pnlTaken.Visible = false;
            pnlRequested.Visible = false;
            pnlEdit.Visible = true;
            pnlCreate.Visible = false;
            pnlCompanyPolicies.Visible = false;

            btnEditEmploy.Show();
            btnDeleteEmploy.Hide();
        }

        private void DELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make create panel and delete button visable and the rest hidden
            pnlHome.Visible = false;
            pnlTaken.Visible = false;
            pnlRequested.Visible = false;
            pnlEdit.Visible = true;
            pnlCreate.Visible = false;
            pnlCompanyPolicies.Visible = false;

            btnEditEmploy.Hide();
            btnDeleteEmploy.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes the admin form and shows the login form instead
            if ((MessageBox.Show("Log Out", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void REQUESTEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make Requested panel visable and the rest hidden
            // Populates DGV with Relevant Holiday Requests
            pnlHome.Visible = false;
            pnlTaken.Visible = false;
            pnlRequested.Visible = true;
            pnlEdit.Visible = false;
            pnlCreate.Visible = false;
            pnlCompanyPolicies.Visible = false;

            hm.RequestedHolidayList(dgvRequested, !cbConstraints.Checked);            
        }

        private void TAKENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make Taken panel visable and the rest hidden
            // Binds the serachboxes list to serach suggestions
            pnlHome.Visible = false;
            pnlTaken.Visible = true;
            pnlRequested.Visible = false;
            pnlEdit.Visible = false;
            pnlCreate.Visible = false;
            pnlCompanyPolicies.Visible = false;

            hm.BindComboBox(cmbxTaken_search);
        }

        private void HOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make Home panel visable and the rest hidden
            // Shows whose on leave and working for today
            pnlHome.Visible = true;
            pnlTaken.Visible = false;
            pnlRequested.Visible = false;
            pnlEdit.Visible = false;
            pnlCreate.Visible = false;
            pnlCompanyPolicies.Visible = false;

            hm.WhoseOnLeave(mcDate.TodayDate, dgvHome_working, dgvHome_leave);
        }

        private void CompanySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make Settings panel visable and the rest hidden
            // Gets the right setting to display to the admin
            pnlCompanyPolicies.Visible = true;
            pnlHome.Visible = false;
            pnlTaken.Visible = false;
            pnlRequested.Visible = false;
            pnlEdit.Visible = false;
            pnlCreate.Visible = false;

            GetRightSettings();
        }

        #endregion


        #region Action Button Functions

        private void BtnCreateEmploy_Click(object sender, EventArgs e)
        {
            if (!FieldsEntered(pnlCreate))
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else if (!createEmployee1.ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email");
            }
            else
            {
                // Add to DB
                createEmployee1.AddToDB(txtName.Text, txtSurname.Text, txtComPhoneNumber.Text, txtEmail.Text, txtStreet.Text, 
                                        txtCity.Text, txtCounty.Text, txtPostcode.Text, cbxDept.Text, cbxRole.Text);

                // Rest fields to enter another employee
                ClearFields(pnlCreate);
                cbxDept.SelectedIndex = 0;
                cbxRole.SelectedIndex = 0;
            } 

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Populate the table grid view with results that match the search
            editEmployee1.SearchEmployee(dgvEdit, txtSearch.Text, rdName);

            //Clear fields
            ClearFields(pnlEdit);

            //Disable buttons
            btnEditEmploy.Enabled = false;
            btnEditEmploy.BackColor = Color.DarkGray;
            btnDeleteEmploy.Enabled = false;
            btnDeleteEmploy.BackColor = Color.DarkGray;

        }

        private void BtnDeleteEmploy_Click(object sender, EventArgs e)
        {
            if (dgvEdit.SelectedRows.Count > 0)
            {
                // Get the TargetID from the table and delete the coresponding employ from the database
                string targetID = dgvEdit[0, dgvEdit.SelectedRows[0].Index].Value.ToString();
                deleteEmployee1.DeleteStaff(targetID);

                // Deactive the selected row to prevent unwanted deletion 
                dgvEdit.CurrentRow.Selected = false;


                // Clear the field and recall the search function                            
                BtnSearch_Click(sender, e);
                ClearFields(pnlEdit);


                RefreshGrid();
                SwitchButtons();
                //SetEditableFields(pnlEdit);
                SetEditableFields(false);
                chbxDetails.Checked = false;
            }
        }              

        private void BtnEditEmploy_Click(object sender, EventArgs e)
        {
            // Change the values of the currently selected employee with values entered by the admin
            editEmployee1.EditDetails(dgvEdit, txtEFirst.Text, txtELast.Text, txtEComPhoneNumber.Text,
                                    txtEEmail.Text, txtEPassword.Text, txtEStreet.Text, txtECity.Text,
                                    txtECounty.Text, txtEPost.Text, cbxEDept.Text, cbxERole.Text);

            // Deactivate the row selected and clear the textboxes
            dgvEdit.CurrentRow.Selected = false;

            BtnSearch_Click(sender, e);
            ClearFields(pnlEdit);
            
            RefreshGrid();
            SwitchButtons();
            //SetEditableFields(pnlEdit);
            SetEditableFields(false);
            chbxDetails.Checked = false;

        }

        private void BtnReq_Approve_Click(object sender, EventArgs e)
        {
            // Call the HolidayApproval method and pass approved as a string
            HandleApproval("Approved");
            hm.RequestedHolidayList(dgvRequested, !cbConstraints.Checked);
        }

        private void BtnReq_Reject_Click(object sender, EventArgs e)
        {
            // Call the HolidayApproval method and pass rejected as a string
            HandleApproval("Rejected");
            hm.RequestedHolidayList(dgvRequested, !cbConstraints.Checked);
        }

        private void BtnTAK_alltaken_Click(object sender, EventArgs e)
        {
            // Populate the DGV with all the approved holidays as a list
            hm.SearchBooking(dgvTaken, string.Empty);
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            // Closes the admin form and shows the login form instead
            if ((MessageBox.Show("Save Changes to the Company Policies", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                // Write new settings to the db

                // Call the right settings
                SetRightSettings();
            }
            else
            {
                // Revert changes made
                GetRightSettings();
            }
        }

        #endregion


        #region UI Methods
        private void DgvEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore row and column header
                if (e.RowIndex == -1)
                {
                    return;
                }
                else if (dgvEdit.CurrentCell.Value != null)
                {
                    // Fills the text boxes with the relevant information
                    //SetEditableFields(pnlEdit);
                    SetEditableFields(true);
                    PopulateTxtBox(e);
                    chbxDetails.Checked = false;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentOutOfRangeException("Index parameter is out of range.", ex);
            }
        }

        private void DgvRequested_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore header row and any column
                if (e.RowIndex == -1)
                {
                    return;
                }
                else if (dgvRequested.CurrentCell.Value != null)
                {
                    // deselect current row
                    dgvRequested.CurrentRow.Selected = true;

                    // Store the Holiday and staff ID
                    string holidayID = dgvRequested[0, dgvRequested.SelectedRows[0].Index].Value.ToString();
                    string staffID = dgvRequested[1, dgvRequested.SelectedRows[0].Index].Value.ToString();


                    // Show the broken constraints as a list for the specific holiday
                    if (constraintChecker1.CheckConstraints(int.Parse(holidayID), staffID).Any())
                    {
                        var message = string.Join(Environment.NewLine, constraintChecker1.CheckConstraints(int.Parse(holidayID), staffID));
                        MessageBox.Show(message, "Constraints Broken");
                    }

                    // Enable the button to handle the selected holiday
                    btnReq_Approve.Enabled = true;
                    btnReq_Reject.Enabled = true;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentOutOfRangeException("Index parameter is out of range.", ex);
            }
        }

        private void PopulateTxtBox(DataGridViewCellEventArgs e)
        {
            // select the current row
            dgvEdit.CurrentRow.Selected = true;

            // Populate all the values that are show and hidden on the DGV to the relavant input controls 
            txtEFirst.Text = dgvEdit.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
            txtELast.Text = dgvEdit.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
            txtEComPhoneNumber.Text = dgvEdit.Rows[e.RowIndex].Cells["Telephone"].FormattedValue.ToString();
            txtEEmail.Text = dgvEdit.Rows[e.RowIndex].Cells["EmailAddress"].FormattedValue.ToString();
            txtEStreet.Text = Split(dgvEdit.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 0);
            txtECity.Text = Split(dgvEdit.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 1);
            txtECounty.Text = Split(dgvEdit.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 2);
            txtEPost.Text = Split(dgvEdit.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 3);

            cbxEDept.SelectedIndex = cbxEDept.FindString(dgvEdit.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString());
            cbxERole.SelectedIndex = cbxERole.FindString(dgvEdit.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString());

            txtEPassword.Text = dgvEdit.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
            txtEDateJoined.Text = dgvEdit.Rows[e.RowIndex].Cells["DateJoined"].FormattedValue.ToString();


            // Enable the Edit and Delete Buttons
            btnEditEmploy.Enabled = true;
            btnEditEmploy.BackColor = Color.White;
            btnDeleteEmploy.Enabled = true;
            btnDeleteEmploy.BackColor = Color.White;
        }

        private string Split(string address, int index)
        {
            try
            {
                // split the string in to an array by the '-' character
                string[] words = address.Split('-');
                return words[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        private void ClearFields(Panel panel)
        {
            // Clear textbox fields in a specified Panel 
            foreach (Control x in panel.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }

        private void RefreshGrid()
        {
            // Refreshes the DGV
            dgvEdit.Update();
            dgvEdit.Refresh();
        }

        private void SwitchButtons()
        {

            // Switches the enabled property of the edit and delete button
            if (btnDeleteEmploy.Enabled == true)
            {
                btnEditEmploy.Enabled = false;
                btnEditEmploy.BackColor = Color.DarkGray;
                btnDeleteEmploy.Enabled = false;
                btnDeleteEmploy.BackColor = Color.DarkGray;
            }
            else
            {
                btnEditEmploy.Enabled = true;
                btnEditEmploy.BackColor = Color.White;
                btnDeleteEmploy.Enabled = true;
                btnDeleteEmploy.BackColor = Color.White;
            }
        }

        private void ChbxDetails_CheckedChanged(object sender, EventArgs e)
        {
            // Change the dept, role and password fields accessiblity
            if (chbxDetails.Checked)
            {
                cbxEDept.Enabled = true;
                cbxEDept.ForeColor = Color.Red;
                label21.ForeColor = Color.Red;
                cbxERole.Enabled = true;
                cbxERole.ForeColor = Color.Red;
                label22.ForeColor = Color.Red;
                txtEPassword.Enabled = true;
                txtEPassword.ForeColor = Color.Red;
                label18.ForeColor = Color.Red;
            }
            else
            {
                cbxEDept.Enabled = false;
                cbxEDept.ForeColor = Color.Black;
                label21.ForeColor = Color.White;
                cbxERole.Enabled = false;
                cbxERole.ForeColor = Color.Black;
                label22.ForeColor = Color.White;
                txtEPassword.Enabled = false;
                txtEPassword.ForeColor = Color.Black;
                label18.ForeColor = Color.White;
            }
        }

        private bool FieldsEntered(Panel createPanel)
        {
            // Checks if all fields in a panel are holding a value and are not null
            bool correctFields = true;
            foreach (Control x in createPanel.Controls)
            {
                if (x is TextBox && ((TextBox)x).Text == String.Empty)
                {                   
                    correctFields = false;
                }
                else
                {
                    correctFields = true;
                }
            }
            return correctFields;
        }
                
        private void SetEditableFields(bool state)
        {
            List<Control> fields = new List<Control>();
            // sets the textboxes in a pannel to enabled being true or false;
            foreach (Control x in pnlEdit.Controls)
            {
                if (x is TextBox)
                {
                    fields.Add(x);
                }                
            }

            fields.Remove(txtSearch);
            fields.Remove(txtEDateJoined);
            fields.Remove(txtEPassword);

            foreach (var item in fields)
            {
                item.Enabled = state;
            }
        }
        
        private void CmbxTaken_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make the search according to the selected employee id 
            if (cmbxTaken_search.Text != string.Empty)
            {
                hm.SearchBooking(dgvTaken, cmbxTaken_search.Text);
            }
        }

        private void McDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Make two DGV display whose working and on leave on the day that is selected
            hm.WhoseOnLeave(mcDate.SelectionStart, dgvHome_working, dgvHome_leave);
        }

        private void HandleApproval(string choice)
        {  
            // Get the holidayID
            string request = dgvRequested[0, dgvRequested.SelectedRows[0].Index].Value.ToString();            

            // Submit the holidayid and the choice made to the request handler
            hm.HandleHolidayRequest(request, choice);

            // deselect the row
            dgvRequested.CurrentRow.Selected = false;

            // Disable the buttons
            btnReq_Approve.Enabled = false;
            btnReq_Reject.Enabled = false;

            //hm.RequestedHolidayList(dgvRequested);
            // Refresh the the DGV
            dgvRequested.Refresh();
        }

        private void GetRightSettings()
        {
            //  Set Holiday Constraints from cc1 properties
            numEntitlement.Value = constraintChecker1.StaffsEntitledDays;
            cbHeadOrDeputy.Checked = constraintChecker1.HeadOrDeputy;
            cbManagerOrSenior.Checked = constraintChecker1.ManagerOrSenior;
            numOnDuty.Value = constraintChecker1.MustBeOnDuty;
            cbRelaxedMonth.SelectedIndex = cbRelaxedMonth.FindString(constraintChecker1.RelaxedMonth);
            numOnDutyRelaxed.Value = constraintChecker1.MustBeOnDutyRelaxed;


            // Set Peak Times from cc1 properties
            dtpSummerStart.Value = constraintChecker1.PeakTimeSummer.First();
            dtpSummerEnd.Value = constraintChecker1.PeakTimeSummer.Last();

            dtpChristmasStart.Value = constraintChecker1.PeakTimeChristmas.First();
            dtpChristmasEnd.Value = constraintChecker1.PeakTimeChristmas.Last();

            dtpEasterStart.Value = constraintChecker1.PeakTimeEaster.First();
            dtpEasterEnd.Value = constraintChecker1.PeakTimeEaster.Last();

        }

        private void SetRightSettings()
        {
            // Set cc1 properties to new Holiday Constraints
            constraintChecker1.StaffsEntitledDays = (int)numEntitlement.Value;
            constraintChecker1.HeadOrDeputy = cbHeadOrDeputy.Checked;
            constraintChecker1.ManagerOrSenior = cbManagerOrSenior.Checked;
            constraintChecker1.MustBeOnDuty = (int)numOnDuty.Value;
            constraintChecker1.RelaxedMonth = cbRelaxedMonth.SelectedText;
            constraintChecker1.MustBeOnDutyRelaxed = (int)numOnDutyRelaxed.Value;


            // Set cc1 properties to new Peak Times            
            constraintChecker1.PeakTimeSummer = new List<DateTime> { dtpSummerStart.Value, dtpSummerEnd.Value };

            constraintChecker1.PeakTimeChristmas = new List<DateTime> { dtpChristmasStart.Value, dtpChristmasEnd.Value };

            constraintChecker1.PeakTimeEaster = new List<DateTime> { dtpEasterStart.Value, dtpEasterEnd.Value };

            // Save Changes to the DB
            constraintChecker1.SetContraints();
            constraintChecker1.SetPeakTimes();            
        }

        private void CbConstraints_Click(object sender, EventArgs e)
        {
            // Refresh the DGV with constraints value wanted
            hm.RequestedHolidayList(dgvRequested, !cbConstraints.Checked);

            // Change the background of the peaktime request
            foreach (DataGridViewRow row in dgvRequested.Rows)
            {
                if (row.Index >= (dgvRequested.Rows.Count - hm.pc.RequestsAtPeak))
                {
                    row.DefaultCellStyle.BackColor = Color.PeachPuff;
                }
            }
        }

        private void DgvHome_leave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore row and any column header
                if (e.RowIndex == -1)
                {
                    return;
                }
                else if (dgvHome_leave.CurrentCell.Value != null)
                {
                    // Select the current row
                    dgvHome_leave.CurrentRow.Selected = true;

                    // Get the holiday Id and set the start and end date for the calendar component
                    int holidayID = int.Parse(dgvHome_leave[3, dgvHome_leave.SelectedRows[0].Index].Value.ToString());

                    string employeeName = dgvHome_leave[1, dgvHome_leave.SelectedRows[0].Index].Value.ToString();

                    onLeaveCalendarComponent1.ShowHoliday(employeeName, constraintChecker1.GetCurrentHoliday(holidayID).StartDate,
                                                                                constraintChecker1.GetCurrentHoliday(holidayID).EndDate);
                    
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentOutOfRangeException("Index parameter is out of range.", ex);
            }
        }


        #endregion        
    }
}
