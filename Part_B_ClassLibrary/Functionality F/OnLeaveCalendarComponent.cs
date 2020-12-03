using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_B_ClassLibrary.Functionality_F
{
    public partial class OnLeaveCalendarComponent : MonthCalendar
    {
        private Label lbEmpolyeeName = new Label();

        public OnLeaveCalendarComponent()
        {
            InitializeComponent();
            MaxSelectionCount = 30;
            ShowTodayCircle = false;
            ShowToday = false;
            Enabled = false;           
        }

        public OnLeaveCalendarComponent(IContainer container)
        {
            // Add label and conmponent to container
            container.Add(lbEmpolyeeName);
            container.Add(this);
            
            LabelSettings();

            InitializeComponent();
        }

        protected override void OnDateSelected(DateRangeEventArgs drevent)
        {
            // override the event to hide todays date and show the holidays range
            SelectionRange = new SelectionRange(drevent.Start, drevent.End);
            base.OnDateSelected(drevent);
            ShowTodayCircle = false;
            ShowToday = false;
        }

        private void LabelSettings()
        {
            // Set the label to sit ontop of the calendar 
            lbEmpolyeeName.Visible = true;
            lbEmpolyeeName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            lbEmpolyeeName.ForeColor = Color.Black;
            lbEmpolyeeName.TextAlign = ContentAlignment.MiddleCenter;
            lbEmpolyeeName.Text = "";
            lbEmpolyeeName.Size = new Size(220, 20);
            lbEmpolyeeName.Location = new Point(0, 0);
            Controls.Add(lbEmpolyeeName);
        }

        public void ShowHoliday(string employName, DateTime start, DateTime end)
        {
            //Change the selction range and the contents of the label
            lbEmpolyeeName.Text = employName;
            SelectionRange = new SelectionRange(start, end);
        }

    }
}
