using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component_A_ClassLibrary;

namespace Component_B_ClassLibrary.Functionality_B
{
    public class StaffHolidays
    {
        private readonly DataClasses1DataContext db;
        public StaffHolidays()
        {
            db = new DataClasses1DataContext();
        }

        public void MakeRequest(string staffID, DateTime start, DateTime end)
        {
            try
            {
                // Find the staff account in the db
                var employQuery = (from a in db.employees
                               where a.StaffID == int.Parse(staffID)
                               select a).Single();

                employee requestor = employQuery;

                // Make the holiday object and add the employee
                holiday wantedDays = new holiday
                {
                    employee = requestor,
                    StartDate = start,
                    EndDate = end,
                    Status = "Pending"
                };

                //Save changes to Database
                db.holidays.InsertOnSubmit(wantedDays);

                db.SubmitChanges();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public List<holiday> ViewAllRequests(string staffID)
        {
            try
            {
                // Find all holiday which a staff member has made
                var allDaysQuery = (from a in db.holidays
                                    where a.employee.StaffID == int.Parse(staffID)
                                    select a).ToList();


                List<holiday> holidays = allDaysQuery;

                // Format the date
                foreach (var item in holidays)
                {
                    item.StartDate.ToString("d");
                    item.EndDate.ToShortDateString();
                }

                return holidays;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }        

    }
}
