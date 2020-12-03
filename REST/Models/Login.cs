using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Component_A_ClassLibrary;

namespace REST.Models
{
    public class Login
    {
        private LoginComponent lc = new LoginComponent();

        public Login()
        {

        }

        public bool loginMethod()
        {
            lc.StaffID = 111111;
            lc.Password = "111111";

            return lc.Verification("Admin");
            
        }
    }
}