using Component_A_ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_B_ClassLibrary.Functionality_B
{
    public class GetAccountDetails
    {
        private readonly DataClasses1DataContext db;
        public GetAccountDetails()
        {
            db = new DataClasses1DataContext();
        }

        public role UserDetails(string staffID)
        {
            // Gets the Details of the user
            role varQueryName = (from a in db.roles
                                where a.employee.StaffID == int.Parse(staffID)
                                select a).Single();

            return varQueryName;
        }
    }
}
