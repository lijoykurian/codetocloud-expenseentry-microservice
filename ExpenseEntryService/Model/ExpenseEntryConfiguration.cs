using System.Collections.Generic;

namespace ExpenseEntryService
{
    public class ExpenseEntryConfiguration
    {
        public string EmpId
        {
            get;
            set;
        }
        public Organization Organization
        {
            get;
            set;
        }
        public string EmpName
        {
            get;
            set;
        }
        public List<string> FeaturesAllowed
        {
            get;
            set;
        }
        public List<string> AllowedExpenses { get; internal set; }
        public object EmpEmail { get; internal set; }
    }
}