using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Collections.Specialized;
using StaffBooking.ServiceReference;
using Component_A_ClassLibrary;
using System.Drawing;

namespace StaffBooking
{
    public partial class _Default : Page
    {
        LoginComponent lc = new LoginComponent();        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Valid appropriate input has been entered
            if (txtStaffID.Text != string.Empty && txtPassword.Text != string.Empty && int.TryParse(txtStaffID.Text, out int a))
            {
                lc.StaffID = int.Parse(txtStaffID.Text);
                lc.Password = txtPassword.Text;

                if (lc.Verification("Staff"))
                {
                    // If successful set the sessions and redirect to Staff Home Page
                    Session["staffID"] = txtStaffID.Text;
                    Session["loggedin"] = "true";
                    Response.Redirect("StaffHomePage.aspx");
                }
                else
                {
                    txtStaffID.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    txtStaffID.BorderColor = Color.Red;
                    txtPassword.BorderColor = Color.Red;
                } 
            }                       
               
        }
    }
}