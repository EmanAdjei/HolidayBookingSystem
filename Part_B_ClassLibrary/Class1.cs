using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_B_ClassLibrary
{
    public class Class1
    {
        private void A() { }

        //Functionality A(10%)
        //Extend the functionality implemented as a group to add the following
        //functionality for an admin user:
        //• View a list of outstanding holiday requests
        //• Accept/reject a request
        //• View a list of all holiday bookings and filter them by employee
        //• Select a date and show all employees working that day and those
        //on leave that day.
        //When a holiday request is accepted or rejected it should be removed from
        //the list of outstanding requests.

        private void B() { }

        //Functionality B(10%)
        //To facilitate the data entry of phone numbers, you should implement a Phone Textbox.Implement a component which inherits from the Textbox control.It should only allow numbers to be entered.Further, it should display the numbers that are entered into it in red if there are more than 11. The Phone Textbox component should be integrated into the application so it is used instead of a normal textbox when entering a phone number for a driver.
        //Create a web application using ASP.NET which allows employees to:
        //• Log in
        //• Submit a holiday request
        //• View a list of existing holiday requests, which also shows whether they were approved/rejected

        private void C() { }

        //Functionality C(10%)
        //You should extend the system by including a component which applies constraint checking.
        //When an employee submits a holiday request, the system should use the component to automatically check whether all constraints are satisfied.
        //The list of outstanding requests shown to the admin user should be split into two, 
        //those which don’t break any of the constraints and those which do and can't be accepted.
        //For requests which break constraints, the system should specify which constraint is being broken.
        //There could be more than one, in which case they should all be listed.

        private void D() { }

        // Functionality D(10%)
        //Create a Web Service(SOAP or REST) which exposes functionality for employee log in and make holiday request submissions.
        //This web service will be called from the employee app.
        //The prototype of the employee app should also be created, as a desktop application (or mobile app) 
        //and it must be possible for an employee to log in and to submit a holiday booking request.
        //The employee app should not connect directly to the database, 
        //but all communication must be via the Web Service
        //(remember that the company is planning to replace the desktop application with a mobile app at a later stage).

        private void E() { }

        //Add more functionality to the web application.
        //Create a prioritisation component which prioritises requests based on the number of days already approved and the number of days requested 
        //during the peak times.The prioritisation should determine the order in which outstanding requests are listed.
        //Implement a component which suggests alternative dates(where possible) for requests which break constraints.

        private void F() { }

        //Create a visualisation component which makes it possible to visually 
        //depict a calendar which highlights the days on which an employee has booked leave.



        // Taling about alroithmss
        // Talk about prioritsation algorithm, constraints algotihm and recommending the dates


    }
}
