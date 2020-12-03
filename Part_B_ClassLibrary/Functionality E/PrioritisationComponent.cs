using Component_A_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_B_ClassLibrary.Functionality_C;

namespace Component_B_ClassLibrary.Functionality_E
{
    public partial class PrioritisationComponent : Component
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();
        private int requestsAtPeak;
        
        public PrioritisationComponent()
        {
            InitializeComponent();
        }

        public PrioritisationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int RequestsAtPeak { get => requestsAtPeak; set => requestsAtPeak = value; }

        public List<holiday> Prioritise(List<holiday> unsorted, ConstraintChecker cc)
        {
            // Create to lists
            List<holiday> sorted = new List<holiday>();
            List<holiday> standard = unsorted;

            foreach (var item in standard.ToList())
            {
                // If the hoilday overlaps with peaktimes remove from the standard list and add to list to be prioritised
                if ((item.StartDate >= cc.PeakTimeSummer.First() && item.EndDate <= cc.PeakTimeSummer.Last())
                    ||(item.StartDate >= cc.PeakTimeEaster.First() && item.EndDate <= cc.PeakTimeEaster.Last())
                    ||(item.StartDate >= cc.PeakTimeChristmas.First() && item.EndDate <= cc.PeakTimeChristmas.Last()))
                {
                    sorted.Add(item);
                    standard.Remove(item);
                }
            }

            // count how many hoildays are in peak times
            RequestsAtPeak = sorted.Count();

            // Add the sorted list to the end of the list of standard holidays which dont overlap in peak times
            standard.AddRange(BubbleSortAlgorithm(sorted));

            return standard;
        }

        // Lowest score should get priority
        public double RequestScore(holiday req)
        {
            // Score based on how many day they already have apporved and days they are asking for
            double score;

            int daysApproved = DaysTaken(req.employee.StaffID.ToString());

            TimeSpan holispan = req.EndDate.Date - req.StartDate.Date;

            int holidayDuration = holispan.Days;


            // Weight has been added to approves days such that it gets lees priority, 
            // people with extra days get less priority than those with standard entitlement 
            score = (1.25 * ( daysApproved / 30)) + (holidayDuration / 30);

            return score;
        }

        // Sorts lowest score first
        private List<holiday> BubbleSortAlgorithm(List<holiday> holidayRequests)
        {
            // Using a bubble sorting algorithm 
            // the list of hoildays are sorted based on their score
            // this returns a list with the score going from lowest to highest
            List<holiday> standard = holidayRequests;
            holiday replaceHoliday;

            Console.WriteLine("The Array is : ");
            for (int i = 0; i < standard.Count; i++)
            {
                Console.WriteLine(standard[i]);
            }

            for (int j = 0; j <= standard.Count - 2; j++)
            {
                for (int i = 0; i <= standard.Count - 2; i++)
                {
                    if (RequestScore(standard[i]) > RequestScore(standard[i + 1]))
                    {
                        replaceHoliday = standard[i + 1];
                        standard[i + 1] = standard[i];
                        standard[i] = replaceHoliday;
                    }
                }
            }

            return standard;
        }

        public int DaysTaken(string staffID)
        {
            // get the approved holidays as a list
            var takenDaysQuery = (from a in db.holidays
                                  where a.employee.StaffID == int.Parse(staffID) && a.Status == "Approved"
                                  && (a.StartDate.Year >= DateTime.Today.Year)
                                  select a).ToList();

            // Gets the days granted to an individual
            int daysGranted = 0;

            foreach (var holiday in takenDaysQuery)
            {
                // for each holiday calculate the duration and add it to daysGranted
                TimeSpan daysOff = holiday.EndDate.Date - holiday.StartDate.Date;

                daysGranted += daysOff.Days;
            }

            return daysGranted;
        }
    }
}
