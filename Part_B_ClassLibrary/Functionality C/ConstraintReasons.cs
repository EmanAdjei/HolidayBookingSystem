using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_B_ClassLibrary.Functionality_C
{
    class ConstraintReasons
    {
        private List<string> reasons;
        public ConstraintReasons()
        {
            Reasons = new List<string>();
            AddReasons();
        }

        public List<string> Reasons { get => reasons; set => reasons = value; }

        private void AddReasons()
        {
            // 0
            reasons.Add("• No employee can exceed the number of days of holiday entitlement.");
            // 1
            reasons.Add("• Either the head or the deputy head of the department must be on duty.");
            // 2
            reasons.Add("• At least one manager and one senior staff member must be on duty.");
            // 3
            reasons.Add("• At least 60% of the department must be on duty.");
            // 4
            reasons.Add("• At least 40% of the department must be on duty.");           
        }
    }

}
