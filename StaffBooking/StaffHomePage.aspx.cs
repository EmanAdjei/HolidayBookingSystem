using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Component_B_ClassLibrary.Functionality_B;
using Component_B_ClassLibrary.Functionality_C;
using Component_B_ClassLibrary.Functionality_E;

namespace StaffBooking
{
    public partial class StaffHomePage : System.Web.UI.Page
    {
        GetAccountDetails gad = new GetAccountDetails();
        StaffHolidays sh = new StaffHolidays();
        ConstraintChecker cc = new ConstraintChecker();
        AlternativeDateComponent adc = new AlternativeDateComponent();

        protected void Page_Load(object sender, EventArgs e)
        {
            // If the session doesnt not say true send them to log in page
            if (Session["loggedin"].Equals("true"))
            {
                SetUserInfo(Session["staffID"].ToString());
            }
            else
            {
                Response.Write("<script>alert('Unauthorised Access Denied')</script>");
                Response.Redirect("Default.aspx");
            }                    
        }

        protected void SetUserInfo(string id)
        {
            // Sets the user details to labels
            var user = gad.UserDetails(id);

            lbWelcomeBack.Text = "Welcome Back  " + user.employee.FirstName;

            lbStaffID.Text = "Staff ID : " + user.employee.StaffID;

            lbEmail.Text= "Email : " + user.employee.EmailAddress;

            lbFirstName.Text = "First Name : " + user.employee.FirstName;

            lbLastName.Text = "Last Name : " + user.employee.LastName;

            lbDepartment.Text = "Department : " + user.department.DeptName;

            lbRole.Text = "Role : " + user.RoleType;

            lbDateJoined.Text = "Date Joined : " + user.employee.DateJoined.ToShortDateString();

            lbEntitlement.Text = "Entitlement Days Left : " + cc.EntitlementLeft(user.employee.StaffID.ToString());
        }

        protected void btnViewRequests_Click(object sender, EventArgs e)
        {
            // Gets requests from StaffHoliday class method
            var userRequests = (from a in sh.ViewAllRequests(Session["staffID"].ToString())
                               select new
                               {
                                   a.HolidayID,
                                   StartDate = a.StartDate.ToShortDateString(),
                                   EndDate = a.EndDate.ToShortDateString(),
                                   a.Status
                               }).ToList();

            gvAllRequests.DataSource = userRequests;
            gvAllRequests.DataBind();
        }

        protected void btnMakeRequest_Click(object sender, EventArgs e)
        {
            // Check if both dates are selected and the start date is not after the end date
            if ((calRequestStart.SelectedDate == DateTime.MinValue.Date || calRequestEnd.SelectedDate == DateTime.MinValue.Date)
                || (DateTime.Compare(calRequestStart.SelectedDate, calRequestEnd.SelectedDate) != -1)
                || (calRequestStart.SelectedDate < DateTime.Today)
                || (calRequestEnd.SelectedDate < DateTime.Today))
            {
                Response.Write("<script>alert('Please Select a valid start and end date')</script>");
            }
            else
            {
                // Suggest Alternate Dates to user if in peak times
                if (adc.SuggestedDates(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeEaster).Any())
                {
                    TestPeakTimes(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeEaster);
                }
                else if (adc.SuggestedDates(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeSummer).Any())
                {
                    TestPeakTimes(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeSummer);
                }
                else if (adc.SuggestedDates(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeChristmas).Any())
                {
                    TestPeakTimes(calRequestStart.SelectedDate, calRequestEnd.SelectedDate, cc.PeakTimeChristmas);
                }
                else
                {
                    sh.MakeRequest(Session["staffID"].ToString(), calRequestStart.SelectedDate, calRequestEnd.SelectedDate);

                    calRequestStart.SelectedDate = DateTime.MinValue.Date;
                    calRequestEnd.SelectedDate = DateTime.MinValue.Date;

                    Response.Write("<script>alert('Request Submitted')</script>");
                }                
            }            
        }

        protected void TestPeakTimes(DateTime startDate, DateTime endDate, List<DateTime> peakTime)
        {
            // Make new dates
            DateTime start = adc.SuggestedDates(startDate, endDate, peakTime).First();
            DateTime end = adc.SuggestedDates(startDate, endDate, peakTime).Last();

            if ((MessageBox.Show($"Start Date : {start.ToShortDateString()} \n" +
                $"End Date : {end.ToShortDateString()}",
                "Avoid Peak Times?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                //Make request with new dates
                sh.MakeRequest(Session["staffID"].ToString(), start, end);
                calRequestStart.SelectedDate = DateTime.MinValue.Date;
                calRequestEnd.SelectedDate = DateTime.MinValue.Date;

                Response.Write("<script>alert('Alternate Request Submitted')</script>");
            }
            else
            {
                // keep original dates
                sh.MakeRequest(Session["staffID"].ToString(), calRequestStart.SelectedDate, calRequestEnd.SelectedDate);

                calRequestStart.SelectedDate = DateTime.MinValue.Date;
                calRequestEnd.SelectedDate = DateTime.MinValue.Date;

                Response.Write("<script>alert('Original Request Submitted')</script>");
            }

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            // change loggin state and direct to log in page
            Session["loggedin"] = "false";
            Response.Redirect("Default.aspx");
        }
    }
}