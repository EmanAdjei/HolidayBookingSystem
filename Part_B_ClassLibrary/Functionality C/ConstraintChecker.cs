using Component_A_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_B_ClassLibrary.Functionality_C
{
    public partial class ConstraintChecker : Component
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();

        private readonly ConstraintReasons cr = new ConstraintReasons();

        #region Constraint Properties

        // All the constraint values stored from the DataBase
        private List<string> monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.ToList();

        private string[] deptType;

        private string[] roleType;

        private bool headOrDeputy;

        private bool managerOrSenior;

        private int mustBeOnDuty;

        private int mustBeOnDutyRelaxed;

        private string relaxedMonth;

        private int staffsEntitledDays;


        private List<DateTime> exceptionDates = new List<DateTime>();

        private List<DateTime> peakTimeSummer = new List<DateTime>();

        private List<DateTime> peakTimeChristmas = new List<DateTime>();

        private List<DateTime> peakTimeEaster = new List<DateTime>();

        public List<string> MonthNames { get => monthNames; set => monthNames = value; }
        public string[] DeptType { get => deptType; set => deptType = value; }
        public string[] RoleType { get => roleType; set => roleType = value; }
        public bool HeadOrDeputy { get => headOrDeputy; set => headOrDeputy = value; }
        public bool ManagerOrSenior { get => managerOrSenior; set => managerOrSenior = value; }
        public int MustBeOnDuty { get => mustBeOnDuty; set => mustBeOnDuty = value; }
        public int MustBeOnDutyRelaxed { get => mustBeOnDutyRelaxed; set => mustBeOnDutyRelaxed = value; }
        public string RelaxedMonth { get => relaxedMonth; set => relaxedMonth = value; }
        public int StaffsEntitledDays { get => staffsEntitledDays; set => staffsEntitledDays = value; }
        public List<DateTime> ExceptionDates { get => exceptionDates; set => exceptionDates = value; }
        public List<DateTime> PeakTimeSummer { get => peakTimeSummer; set => peakTimeSummer = value; }
        public List<DateTime> PeakTimeChristmas { get => peakTimeChristmas; set => peakTimeChristmas = value; }
        public List<DateTime> PeakTimeEaster { get => peakTimeEaster; set => peakTimeEaster = value; }

        #endregion

        public ConstraintChecker()
        {
            InitializeComponent();
            GetDeptsandRoles();
            GetContraintValues();
            GetPeakTimes();
        }

        public ConstraintChecker(IContainer container)
        {
            container.Add(this);
            GetDeptsandRoles();
            GetContraintValues();
            GetPeakTimes();
            InitializeComponent();
        }

        #region Manage Constraint Infomation
                
        private role GetCurrentRole(string staffId)
        {
            // Get the role
            var personQuery = (from a in db.roles
                               where a.employee.StaffID == int.Parse(staffId)
                               select a).Single();

            return personQuery;
        }

        public holiday GetCurrentHoliday(int holidayID)
        {
            var holidayQuery = (from a in db.holidays
                                  where a.HolidayID == holidayID
                                  select a).Single();

            return holidayQuery;
        }

        private void GetDeptsandRoles()
        {
            // read database for values
            var constraintsQuery = (from a in db.constraints
                                    select a).Single();


            // set depts and roles
            DeptType = SplitToArray(constraintsQuery.AvailableDepartments);

            RoleType = SplitToArray(constraintsQuery.AvailableRoles);
        }

        public void GetContraintValues()
        {
            try
            {
                // read database for values
                var constraintsQuery = (from a in db.constraints
                                        select a).Single();
                
                HeadOrDeputy = (bool)constraintsQuery.HeadOrDeputy;

                ManagerOrSenior = (bool)constraintsQuery.ManagerOrSenior;

                MustBeOnDuty = (int)constraintsQuery.MustBeOnDuty;

                MustBeOnDutyRelaxed = (int)constraintsQuery.MustBeOnDutyRelaxed;

                RelaxedMonth = constraintsQuery.RelaxedMonth;

                StaffsEntitledDays = (int)constraintsQuery.HolidayEntitlement;

                ExceptionDates.Add(CurrentYearDate((DateTime)constraintsQuery.ExceptionStartDate));
                ExceptionDates.Add((CurrentYearDate((DateTime)constraintsQuery.ExceptionEndDate)).AddYears(1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void GetPeakTimes()
        {

            try
            {
                var peakTimesQuery = (from a in db.peaktimes
                                      orderby a.PeaktimesID
                                      select a).ToList();

                // Set Peak Times
                PeakTimeSummer.Add(CurrentYearDate((DateTime)peakTimesQuery[0].StartDate));
                PeakTimeSummer.Add(CurrentYearDate((DateTime)peakTimesQuery[0].EndDate));

                PeakTimeChristmas.Add(CurrentYearDate((DateTime)peakTimesQuery[1].StartDate));
                PeakTimeChristmas.Add(CurrentYearDate((DateTime)peakTimesQuery[1].EndDate));

                PeakTimeEaster.Add(EasterSunday(DateTime.Today.Year).AddDays(-7));
                PeakTimeEaster.Add(EasterSunday(DateTime.Today.Year).AddDays(7));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        public void SetContraints()
        {
            try
            {
                var newSettings = (from a in db.constraints
                                        select a).Single();

                // Set new information
                newSettings.HeadOrDeputy = HeadOrDeputy;
                newSettings.ManagerOrSenior = ManagerOrSenior;
                newSettings.MustBeOnDuty = MustBeOnDuty;
                newSettings.MustBeOnDutyRelaxed = MustBeOnDutyRelaxed;
                newSettings.RelaxedMonth = RelaxedMonth;
                newSettings.HolidayEntitlement = StaffsEntitledDays;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void SetPeakTimes()
        {
            try
            {
                var peakTimesQuery = (from a in db.peaktimes
                                      orderby a.PeaktimesID
                                      select a).ToList();

                // Set Peak Times
                peakTimesQuery[0].StartDate = PeakTimeSummer.First();
                peakTimesQuery[0].EndDate = PeakTimeSummer.Last();

                peakTimesQuery[1].StartDate = PeakTimeChristmas.First();
                peakTimesQuery[1].EndDate = PeakTimeChristmas.Last();

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public int EntitlementLeft(string staffID)
        {
            int standard = StaffsEntitledDays;

            // Get join date
            var datejoinedQuery = (from a in db.roles
                                        where a.employee.StaffID == int.Parse(staffID)
                                        select a.employee.DateJoined).Single();
                  
            // todays date
            DateTime todaysDate = DateTime.Today;

            // get how long they have worked at company
            int timespent = todaysDate.Year - datejoinedQuery.Year;

            if (datejoinedQuery.Date > todaysDate.AddYears(-timespent))
            {
                timespent--;
            }

            // divide by 5 and round down
            decimal addedDays = Math.Floor((decimal)((timespent) / 5));

            // Add extra days
            standard += (int)addedDays;

            // get the approved holidays as a list
            var takenDaysQuery = (from a in db.holidays
                                  where a.employee.StaffID == int.Parse(staffID) && a.Status == "Approved"
                                  && (a.StartDate.Year >= todaysDate.Year)
                                  select a).ToList();

            // days to take away
            int daysGranted = 0;

            foreach (var holiday in takenDaysQuery)
            {
                // for each holiday calculate the duration and add it to daysGranted
                TimeSpan daysOff = holiday.EndDate.Date - holiday.StartDate.Date;

                daysGranted += daysOff.Days;
            }


            // take away the holidays booked from entitled
            standard -= daysGranted;

            //standard -= DaysTaken(staffID);

            // return days
            return standard;
        }
        
        private string[] SplitToArray(string address)
        {
            // Format the string into an array
            try
            {
                string[] words = address.Split('-');
                return words;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

        }

        private DateTime CurrentYearDate(DateTime date)
        { 
            //Changes the date to match the current year
            if (!date.Year.Equals(DateTime.Today.Year))
            {

                int years = DateTime.Today.Year - date.Year;

                date = date.AddYears(years);
            }
            return date;
        }

        public DateTime EasterSunday(int year)
        {
            // Takes a year as input and outputs the day easter occurs
            int day = 0;
            int month = 0;

            int g = year % 19;
            int c = year / 100;
            int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
            int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));

            day = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        /*****************************************************************************************************************************************
        *       Title:              <Easter Sunday>
        *       Author:             <Contango, Hunter>
        *       Date:               <17/03/20>
        *       Code Version        <1.0>
        *       Availablity:        https://stackoverflow.com/questions/2510383/how-can-i-calculate-what-date-good-friday-falls-on-given-a-year  
        *
        *******************************************************************************************************************************************/


        #endregion


        #region Constraint Proofing

        public List<string> CheckConstraints(long holidayID, string staffID)
        {

            List<string> reasonsList = new List<string>();

            role requestor = GetCurrentRole(staffID);

            holiday requestedHoliday = GetCurrentHoliday((int)holidayID);


            if (!(requestedHoliday.StartDate <= exceptionDates.Last() && requestedHoliday.EndDate <= exceptionDates.First()))
            {

                if (!IsWithinEntitlement(holidayID, staffID))
                {
                    reasonsList.Add(cr.Reasons[0]);
                }

                if (IsHeadDeptOrSeniorManager(holidayID, staffID) &&
                    requestor.RoleType == "Head" || requestor.RoleType == "Deputy Head")
                {
                    reasonsList.Add(cr.Reasons[1]);
                }
                else if (IsHeadDeptOrSeniorManager(holidayID, staffID) &&
                    requestor.RoleType == "Manager" || requestor.RoleType == "Senior Staff")
                {
                    reasonsList.Add(cr.Reasons[2]);
                }

                if (IsOnDutyEnough(holidayID, staffID) &&
                    !(DateTime.Today.Month == monthNames.FindIndex(x => x == relaxedMonth)))
                {
                    reasonsList.Add(cr.Reasons[3]);
                }
                else if (IsOnDutyEnough(holidayID, staffID) &&
                    DateTime.Today.Month == monthNames.FindIndex(x => x == relaxedMonth))
                {
                    reasonsList.Add(cr.Reasons[4]);
                }
            }   

            return reasonsList;
        }
        public bool IsWithinEntitlement(long holidayID, string staffID)
        {
            int daysleft = EntitlementLeft(staffID);

            try
            {
                var allDaysQuery = (from a in db.holidays
                                    where a.HolidayID == holidayID
                                    select a).Single();

                TimeSpan dateSpan = allDaysQuery.EndDate.Date - allDaysQuery.StartDate.Date;

                return (daysleft - dateSpan.Days) >= 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public bool IsHeadOrDept(long holidayID, string staffID)
        {
            // determines if passed
            bool good = true;
            if (headOrDeputy)
            {
                string otherRole = "";
                try
                {
                    var roleQuery = (from a in db.roles
                                     where a.employee.StaffID == int.Parse(staffID)
                                     select a).Single();

                    var requestedQuery = (from a in db.holidays
                                          where a.HolidayID == holidayID
                                          select a).Single();


                    if (roleQuery.RoleType == "Head")
                    {
                        otherRole = "Deputy Head";
                    }
                    else if (roleQuery.RoleType == "Deputy Head")
                    {
                        otherRole = "Head";
                    }

                    if (!string.IsNullOrEmpty(otherRole))
                    {
                        var otherPersonHolidaysQuery = (from a in db.roles
                                                        join b in db.holidays on a.EmployeeID equals b.EmployeeID
                                                        where (a.department.DeptName == roleQuery.department.DeptName)
                                                        && (a.RoleType == otherRole) && (b.Status == "Approved")
                                                        select b).ToList();

                        foreach (var holi in otherPersonHolidaysQuery)
                        {

                            if (requestedQuery.StartDate < holi.EndDate && holi.StartDate < requestedQuery.EndDate)
                            {
                                good = false;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            return good;
        }

        //public bool IsManagerOrSenior(long holidayID, string staffID)
        //{
        //    bool good = true;
        //    if (managerOrSenior)
        //    {
        //        string otherRole = "";
        //        try
        //        {
        //            var roleQuery = (from a in db.roles
        //                             where a.employee.StaffID == int.Parse(staffID)
        //                             select a).Single();

        //            var requestedQuery = (from a in db.holidays
        //                                  where a.HolidayID == holidayID
        //                                  select a).Single();


        //            if (roleQuery.RoleType == "Manager")
        //            {
        //                otherRole = "Senior Member";
        //            }
        //            else if (roleQuery.RoleType == "Senior Member")
        //            {
        //                otherRole = "Manager";
        //            }

        //            if (!string.IsNullOrEmpty(otherRole))
        //            {
        //                var otherPersonHolidaysQuery = (from a in db.roles
        //                                                join b in db.holidays on a.EmployeeID equals b.EmployeeID
        //                                                where (a.department.DeptName == roleQuery.department.DeptName)
        //                                                && (a.RoleType == otherRole) && (b.Status == "Approved")
        //                                                select b).ToList();

        //                foreach (var holi in otherPersonHolidaysQuery)
        //                {

        //                    if (requestedQuery.StartDate < holi.EndDate && holi.StartDate < requestedQuery.EndDate)
        //                    {
        //                        good = false;
        //                    }
        //                }


        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            throw;
        //        }
        //    }
        //    return good;
        //}

        public bool IsHeadDeptOrSeniorManager(long holidayID, string staffID)
        {
            bool good = true;
            if (managerOrSenior)
            {
                string otherRole = "";
                try
                {
                    var roleQuery = (from a in db.roles
                                     where a.employee.StaffID == int.Parse(staffID)
                                     select a).Single();

                    var requestedQuery = (from a in db.holidays
                                          where a.HolidayID == holidayID
                                          select a).Single();


                    if (roleQuery.RoleType == "Manager")
                    {
                        otherRole = "Senior Member";
                    }
                    else if (roleQuery.RoleType == "Senior Member")
                    {
                        otherRole = "Manager";
                    }
                    else if (roleQuery.RoleType == "Head")
                    {
                        otherRole = "Deputy Head";
                    }
                    else if (roleQuery.RoleType == "Deputy Head")
                    {
                        otherRole = "Head";
                    }

                    if (!string.IsNullOrEmpty(otherRole))
                    {
                        var otherPersonHolidaysQuery = (from a in db.roles
                                                        join b in db.holidays on a.EmployeeID equals b.EmployeeID
                                                        where (a.department.DeptName == roleQuery.department.DeptName)
                                                        && (a.RoleType == otherRole) && (b.Status == "Approved")
                                                        select b).ToList();

                        foreach (var holi in otherPersonHolidaysQuery)
                        {

                            if (requestedQuery.StartDate < holi.EndDate && holi.StartDate < requestedQuery.EndDate)
                            {
                                good = false;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            return good;
        }

        public bool IsOnDutyEnough(long holidayID, string staffID)
        {
            // Needed for calculation
            int departmentSize;
            int onHolidaySize = 0;
            float neededPercentage;

            // Checks if current month is the same as the relaxed month
            if (DateTime.Today.Month == monthNames.FindIndex(x => x == relaxedMonth))
            {
                neededPercentage = MustBeOnDutyRelaxed / 100;
            }
            else
            {
                neededPercentage = MustBeOnDuty / 100;
            }

            try
            {
                var personQuery = (from a in db.roles
                                   where a.employee.StaffID == int.Parse(staffID)
                                   select a).Single();

                var requestedQuery = (from a in db.holidays
                                      where a.HolidayID == holidayID
                                      select a).Single();

                var departmemtWorkersQuery = (from a in db.roles
                                              where a.department.DeptName == personQuery.department.DeptName
                                              select a).ToList();

                var departmemtWorkersHolidaysQuery = (from a in db.roles
                                                      join b in db.holidays on a.EmployeeID equals b.EmployeeID
                                                      where (a.department.DeptName == personQuery.department.DeptName)
                                                      && (b.Status == "Approved")
                                                      select b).ToList();

                // Gets the department size
                departmentSize = departmemtWorkersQuery.Count();

                foreach (var item in departmemtWorkersHolidaysQuery)
                {
                    if (requestedQuery.StartDate < item.EndDate && item.StartDate < requestedQuery.EndDate)
                    {
                        // Add to people who are on holiday
                        onHolidaySize++;
                    }
                }

                // 100% - people on hoiday % = people that are on duty %
                float realPercentage = 1 - (onHolidaySize / departmentSize);


                // Return comparision
                return realPercentage > neededPercentage;
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
