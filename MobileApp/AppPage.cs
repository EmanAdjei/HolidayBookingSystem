using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileApp.SOAPServiceReference;

namespace MobileApp
{
    public partial class AppPage : Form
    {
        readonly WebServiceSoapClient soap = new WebServiceSoapClient();
        private string userStaffId;

        public AppPage()
        {
            InitializeComponent();
            ArrangePanels();
        }
        private void ArrangePanels()
        {
            // Arrange and stack all the panels on top of each other
            pnlLogin.Location = new Point(0, 0);
            pnlHome.Location = new Point(0, 0);
            pnlRequest.Location = new Point(0, 0);
            pnlAll.Location = new Point(0, 0);

            pnlLogin.Size = new Size(304, 533);
            pnlHome.Size = new Size(304, 496);
            pnlRequest.Size = new Size(304, 496);
            pnlAll.Size = new Size(304, 496);

            // Show login panel and hide the rest
            pnlLogin.Visible = true;
            pnlHome.Visible = false;
            pnlRequest.Visible = false;
            pnlAll.Visible = false;

            pnlNavigation.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Validation  for user details
            if ( string.IsNullOrWhiteSpace(txtstaffID.Text) || string.IsNullOrWhiteSpace(txtstaffID.Text))
            {
                MessageBox.Show("Please Enter Both Details");
            }
            else if (!int.TryParse(txtstaffID.Text, out int a))
            {
                MessageBox.Show("Please Enter Valid Staff ID");
            }
            else
            {
                if (soap.LoginStaff(txtstaffID.Text, txtpassword.Text))
                {
                    // If login successful use text field as staffID reference
                    userStaffId = txtstaffID.Text;

                    // Get the user details from webservice
                    List<string> user = soap.UserDetails(userStaffId);
                    SetUserValues(user);

                    // Load Home panel
                    pnlLogin.Visible = false;
                    pnlHome.Visible = true;
                    pnlRequest.Visible = false;
                    pnlAll.Visible = false;

                    pnlNavigation.Visible = true;
                }
            }

            // Empty textboxes for re-entry once logged out
            txtstaffID.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private void BtnNavHome_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlHome.Visible = true;
            pnlRequest.Visible = false;
            pnlAll.Visible = false;

            pnlNavigation.Visible = true;
        }

        private void BtnNavRequest_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlHome.Visible = false;
            pnlRequest.Visible = true;
            pnlAll.Visible = false;

            pnlNavigation.Visible = true;
        }

        private void BtnNavAll_Click(object sender, EventArgs e)
        {
            // Format the array of string sent by the webserive to more readable object
            var allquery = (from a in soap.ViewAllRequests(userStaffId)
                           select new
                           {
                               HolidayID = a[0],
                               Start = a[1],
                               End = a[2],
                               Status = a[3]
                           }).ToList();
            dgvAllRequests.DataSource = allquery;
            
            pnlLogin.Visible = false;
            pnlHome.Visible = false;
            pnlRequest.Visible = false;
            pnlAll.Visible = true;

            pnlNavigation.Visible = true;
        }

        private void SetUserValues(List<string> user)
        {
            // Produce the user details in labels
            lbFirstName.Text = "First Name: " + user[0];

            lbLastName.Text = "Last Name : " + user[1];

            lbStaffID.Text = "Staff ID : " + user[2];

            lbEmail.Text = "Email : " + user[3];

            lbDepartment.Text = "Department : " + user[4];

            lbRole.Text = "Role : " + user[5];

            lbDateJoined.Text = "Date Joined : " + user[6];
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            // Hides all panels except login panel
            pnlLogin.Visible = true;
            pnlHome.Visible = false;
            pnlRequest.Visible = false;
            pnlAll.Visible = false;

            pnlNavigation.Visible = false;
        }

        private void BtnSubmitRequest_Click(object sender, EventArgs e)
        {
            // Validates if both dates are selected and the start date is not after the end date
            if ((dtpStart.Value == DateTime.MinValue.Date || dtpEnd.Value == DateTime.MinValue.Date)
                || (DateTime.Compare(dtpStart.Value, dtpEnd.Value) != -1)
                || (dtpStart.Value < DateTime.Today)
                || (dtpEnd.Value < DateTime.Today))
            {
                MessageBox.Show("Please Select a valid start and end date");
            }
            else
            {
                // Send request through webservice
                soap.MakeRequest(userStaffId, dtpStart.Value, dtpEnd.Value);
            }

        }
    }
}
