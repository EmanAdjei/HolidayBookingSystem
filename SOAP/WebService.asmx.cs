using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows.Forms;
using Component_A_ClassLibrary;
using Component_B_ClassLibrary.Functionality_B;
using Component_B_ClassLibrary.Functionality_C;
using Component_B_ClassLibrary.Functionality_E;

namespace SOAP
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://localhost:63341/WebService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private readonly LoginComponent lc = new LoginComponent();
        private GetAccountDetails gad = new GetAccountDetails();
        private StaffHolidays sh = new StaffHolidays();
        private AlternativeDateComponent adc = new AlternativeDateComponent();
        private ConstraintChecker cc = new ConstraintChecker();


        [WebMethod]
        public bool LoginStaff(string staffId, string password)
        {
            //Takes in the StaffID and the Password and checks if the details and 
            //credientials are correct for the staff login
            lc.StaffID = int.Parse(staffId);
            lc.Password = password;

            return lc.Verification("Staff");
        }

        [WebMethod]
        public List<string> UserDetails(string staffID)
        {
            // Role has to broken down into List<string> to be serilised and sent to the mobile app
            role user= gad.UserDetails(staffID);
            List<string> details = new List<string>
            {
                user.employee.FirstName,
                user.employee.LastName,
                user.employee.StaffID.ToString(),
                user.employee.EmailAddress,
                user.department.DeptName,
                user.RoleType,
                user.employee.DateJoined.ToShortDateString()
            };

            return details;
        }

        [WebMethod]
        public void MakeRequest(string staffID, DateTime start, DateTime end)
        {
            // Takes the StaffID, Start and End Date and makes a request
            sh.MakeRequest(staffID, start, end);

            // Check if both dates are selected and the start date is not after the end date
            if ((start == DateTime.MinValue.Date || end == DateTime.MinValue.Date)
                || (DateTime.Compare(start, end) != -1)
                || (start < DateTime.Today)
                || (end < DateTime.Today))
            {
                MessageBox.Show("Please Select a valid start and end date");
            }
            else
            {
                // Suggest Alternate Dates to user if in peak times
                if (adc.SuggestedDates(start, end, cc.PeakTimeEaster).Any())
                {
                    TestPeakTimes(staffID, start, end, cc.PeakTimeEaster);
                }
                else if (adc.SuggestedDates(start, end, cc.PeakTimeSummer).Any())
                {
                    TestPeakTimes(staffID, start, end, cc.PeakTimeSummer);
                }
                else if (adc.SuggestedDates(start, end, cc.PeakTimeChristmas).Any())
                {
                    TestPeakTimes(staffID, start, end, cc.PeakTimeChristmas);
                }
                else
                {
                    sh.MakeRequest(staffID, start, end);

                    MessageBox.Show("Request Submitted");
                }
            }
        }

        [WebMethod]
        public List<string[]> ViewAllRequests(string staffID)
        {
            // Holidays has to broken down into List<string[]> to be serilised and sent to the mobile app
            List<string[]> details = new List<string[]>();
            foreach (var item in sh.ViewAllRequests(staffID))
            {
                details.Add(new string[] {
                    item.HolidayID.ToString(),
                    item.StartDate.ToShortDateString(),
                    item.EndDate.ToShortDateString(),
                    item.Status
                } );
            }
            
            return details;
        }

        private void TestPeakTimes(string staffID, DateTime startDate, DateTime endDate, List<DateTime> peakTime)
        {
            // Make new dates
            DateTime start = adc.SuggestedDates(startDate, endDate, peakTime).First();
            DateTime end = adc.SuggestedDates(startDate, endDate, peakTime).Last();

            if ((MessageBox.Show($"Start Date : {start.ToShortDateString()} \n" +
                $"End Date : {end.ToShortDateString()}",
                "Avoid Peak Times?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                //Make request with new dates
                sh.MakeRequest(staffID, start, end);
                MessageBox.Show("Alternate Request Submitted");
            }
            else
            {
                // keep original dates
                sh.MakeRequest(staffID, startDate, endDate);
                MessageBox.Show("Original Request Submitted");
            }

        }



    }
}
