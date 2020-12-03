using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;

namespace Component_A_ClassLibrary
{
    public partial class LoginComponent : Component
    {
        private int staffID = 0;
        private string password = "";
        private long someQuery = 0;
        private string employeeLevel = "";

        // Connection to the DataBase and access to entity classes
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();    
                
        public LoginComponent()
        {
            InitializeComponent();
        }

        public LoginComponent(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public int StaffID { get => staffID; set => staffID = value; }
        public string Password { get => password; set => password = value; }
        public long SomeQuery { get => someQuery; set => someQuery = value; }
        public string EmployeeLevel { get => employeeLevel; set => employeeLevel = value; }

        public bool Verification(string employeeLevel)
        {
            try
            {
                // Query to find matching staffid and password in DB
                var verQuery = (from a in db.employees
                               where a.StaffID == StaffID && a.Password == Password
                               select a.EmployeeID).ToList();                              

                if (verQuery.Any())
                {
                    // If user entered details correctly call auth method
                    Console.WriteLine("User Exists in DB");
                    return Authentication(verQuery.First(), employeeLevel);              
                }
                else
                {
                    // Check the Staffid exists
                    var userQuery = from b in db.employees
                                     where b.StaffID == StaffID
                                     select b;

                    if (userQuery.Any())
                    {
                        Console.WriteLine("User Exists in DB, Wrong Password");
                        MessageBox.Show("Password Incorrect");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("User Does Not Exist in DB");
                        MessageBox.Show("User Does Not Exist, Please contact Admin");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }  
        }

        public bool Authentication(long employID, string employeeLevel)
        {
            // Checks the user has the right level for log in
            try
            {
                var joinQuery = (from r in db.roles
                                 where r.EmployeeID == employID
                                 select r).Single(); ;


                // For the admin desktop application
                if (joinQuery.RoleType == "Admin" && employeeLevel.Equals("Admin"))
                {                 
                    return true;
                }
                else if (joinQuery.RoleType != "Admin" && employeeLevel.Equals("Admin"))
                {
                    MessageBox.Show("Unauthorised Access Denied");
                    return false;
                }
                // For the Staff Web App
                else if (joinQuery.RoleType == "Admin" && employeeLevel != "Admin" )
                {
                    MessageBox.Show("Please Use the Admin Application");

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }    
        }

    }
}
