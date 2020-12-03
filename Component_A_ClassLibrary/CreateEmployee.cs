using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Component_A_ClassLibrary
{
    public partial class CreateEmployee : Component
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();

        public CreateEmployee()
        {
            InitializeComponent();
        }

        public CreateEmployee(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void AddToDB(string firstNa, string lastNa, string telnumber, string email, string street,
                            string city, string county, string postcode, string typeDept, string typeRole)
        {
            try
            {
                // Query to find matching staffid and password in DB
                var verQuery = from a in db.employees
                               where a.FirstName == firstNa  && a.LastName == lastNa
                               select a;

                if (verQuery.Any())
                {
                    MessageBox.Show("Employee Already Exists In DB");
                }
                else
                {
                    // Create a new employee object
                    employee addedEmployee = new employee
                    {
                        FirstName = firstNa,
                        LastName = lastNa,
                        Password = firstNa,
                        Telephone = telnumber,
                        EmailAddress = email,
                        Address = (street + "-" + city + "-" + county + "-" + postcode),
                        DateJoined = DateTime.Today.Date,
                        StaffID = IDcreation()
                    };

                    // Create a new Department object
                    department addedDept = new department
                    {
                        DeptName = typeDept
                    };

                    // Create a new role object and add the employee and department
                    role addedRole = new role
                    {
                        RoleType = typeRole,
                        employee = addedEmployee,
                        department = addedDept
                    };

                    //Save changes to Database
                    db.roles.InsertOnSubmit(addedRole);
                    
                    db.SubmitChanges();

                    MessageBox.Show("Employee Details Added To Database.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }  
        }

        private long IDcreation()
        {
            // Creates a 6 digit staffID number which has not been used before
            long verifiedID;
            Random random = new Random();
            verifiedID = random.Next(100000, 999999);

            var verQuery = from a in db.employees
                               where a.StaffID == verifiedID
                               select a;

            // If the StaffID existed create a new one
            if (verQuery.Any())
            {
                IDcreation();
            }

            return verifiedID;
        }

        public bool ValidEmail(string email)
        {
            // Checks the email entered is legit
            try
            {
                MailAddress correctEmail = new MailAddress(email);
                return correctEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
