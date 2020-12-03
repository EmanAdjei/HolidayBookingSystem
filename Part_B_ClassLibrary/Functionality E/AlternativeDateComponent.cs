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
    public partial class AlternativeDateComponent : Component
    {
        public AlternativeDateComponent()
        {
            InitializeComponent();
        }

        public AlternativeDateComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<DateTime> SuggestedDates(DateTime startDate, DateTime endDate, 
                                                List<DateTime> peakTime)
        {
            // Create list to return
            List<DateTime> suggestedDates = new List<DateTime>();

            // If the requested holiday overlaps with the peaktime find alternative dates
            if ((startDate <= peakTime.Last() && peakTime.First() <= endDate))
            {
                // If the time span of the holiday start date and the peaktime end date is greater 
                if ((startDate - peakTime.Last()) < (endDate - peakTime.Last()))
                {
                    // Add the differnce to both dates to push it after the peak date
                    DateTime newStart = startDate.AddDays((endDate - peakTime.Last()).Days);
                    DateTime newEnd = endDate.AddDays((endDate - peakTime.Last()).Days);

                    suggestedDates.Add(newStart);
                    suggestedDates.Add(newEnd);
                }
                else
                {
                    // Subtract the differnce to bring the dates before the peak dates
                    DateTime newStart = startDate.AddDays(-(startDate - peakTime.Last()).Days);
                    DateTime newEnd = endDate.AddDays(-(startDate - peakTime.Last()).Days);

                    suggestedDates.Add(newStart);
                    suggestedDates.Add(newEnd);
                }
            }
            return suggestedDates;
        }
    }
}
