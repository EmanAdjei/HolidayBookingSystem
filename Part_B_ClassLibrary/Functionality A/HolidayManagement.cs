using Component_A_ClassLibrary;
using Component_B_ClassLibrary.Functionality_C;
using Component_B_ClassLibrary.Functionality_E;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_B_ClassLibrary.Functionality_A
{
    public class HolidayManagement
    {
        private readonly DataClasses1DataContext db;
        private ConstraintChecker cc = new ConstraintChecker();
        public PrioritisationComponent pc = new PrioritisationComponent();

        public HolidayManagement()
        {
            db = new DataClasses1DataContext();
        }

        #region Requested
        public void RequestedHolidayList(DataGridView table, bool valid)
        {
            try
            {
                // Gte all pending holiday requests
                var requestedQuery = (from a in db.holidays
                                      where a.Status == "Pending"
                                      select a).ToList();


                if (requestedQuery.Any())
                {
                    foreach (var item in requestedQuery.ToList())
                    {
                        // Remove the requests which either match or break constraints
                        if (valid == cc.CheckConstraints(item.HolidayID, item.employee.StaffID.ToString()).Any())
                        {
                            requestedQuery.Remove(item);
                        }
                    }

                    // Sort the list if any request have been made in peak times
                    List<holiday> priortised = pc.Prioritise(requestedQuery, cc);

                    // Format the infomation
                    table.DataSource = (from a in priortised
                                        select new
                                        {
                                            a.HolidayID,
                                            a.employee.StaffID,
                                            a.employee.FirstName,
                                            a.employee.LastName,
                                            a.StartDate,
                                            a.EndDate
                                        }).ToList();
                }
                else
                {
                    //List<holiday> priortised = pc.Prioritise(requestedQuery, cc);


                    //table.DataSource = (from a in priortised
                    //                    select new
                    //                    {
                    //                        a.HolidayID,
                    //                        a.employee.StaffID,
                    //                        a.employee.FirstName,
                    //                        a.employee.LastName,
                    //                        a.StartDate,
                    //                        a.EndDate
                    //                    }).ToList();
                    MessageBox.Show("No Pending Holiday Requests");                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void HandleHolidayRequest(string holidayID, string newStatus)
        {
            try
            {
                // Find the holiday in question
                var requestedQuery = (from a in db.holidays
                                      where a.HolidayID == Convert.ToInt64(holidayID)
                                      select a).Single();

                // Set the new status and svae the changes in the database
                requestedQuery.Status = newStatus;

                db.SubmitChanges();

                // Give feedback to the admin user
                if (newStatus == "Approved")
                {
                    MessageBox.Show("Holiday Request Approved");
                }
                else
                {
                    MessageBox.Show("Holiday Request Rejected");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        #endregion

        #region Taken
        public void BindComboBox(ComboBox cmbx)
        {
            // Get all the StaffID that have an approved holiday
            var takenQuery = (from a in db.holidays
                              where a.Status == "Approved"
                              select a.employee.StaffID).ToList();

            // Remove repeated employees
            takenQuery = takenQuery.Distinct().ToList();

            // Set the comboxox data source as the list
            cmbx.DataSource = takenQuery;
            cmbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbx.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void SearchBooking(DataGridView table, string staffID)
        {
            // Get all the approved holidays for a speficied individual
            var takenQuery = (from a in db.holidays
                              where ((String.IsNullOrWhiteSpace(staffID) && a.employee.StaffID != 111111)
                              || (a.employee.StaffID.ToString().Contains(staffID.Trim()) && a.employee.StaffID != 111111))
                              && a.Status == "Approved"
                              select new
                              {
                                  a.HolidayID,
                                  a.employee.StaffID,
                                  a.employee.FirstName,
                                  a.employee.LastName,
                                  a.StartDate,
                                  a.EndDate
                              }).ToList();

            table.DataSource = takenQuery;
        }

        #endregion

        #region On Duty
        public void WhoseOnLeave(DateTime day, DataGridView working, DataGridView leave)
        {
            try
            {
                // Check holidays which overlap with a specified date
                var leaveQuery = (from a in db.holidays
                                  where (DateTime.Compare(a.StartDate, day) == -1 || DateTime.Compare(a.StartDate, day) == 0) &&
                                  (DateTime.Compare(a.EndDate, day) == 1 || DateTime.Compare(a.EndDate, day) == 0)
                                  && a.Status == "Approved"
                                  select new
                                  {
                                      a.employee.StaffID,
                                      a.employee.FirstName,
                                      a.employee.LastName,
                                      a.HolidayID
                                  }).ToList();

                // Get the list of employs on leave on that day
                var empIds = from a in leaveQuery
                             select a.StaffID;

                // Set list as datasource for DGV
                leave.DataSource = leaveQuery;

                // Find the rest who are not on the leave list and make them the datasource for the working list
                var workingQuery = (from a in db.employees
                                    where !empIds.Contains(a.StaffID) && a.StaffID != 111111
                                    select new
                                    {
                                        a.StaffID,
                                        a.FirstName,
                                        a.LastName
                                    }).ToList();

                working.DataSource = workingQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        #endregion

    }
}
