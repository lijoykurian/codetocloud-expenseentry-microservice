using System.Collections.Generic;

namespace ExpenseEntryService.Client
{
    public class EmployeeInfo
    {
        public string EmpName
        {
            get;
            set;
        }
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
        public List<string> AllowedExpenses { get;  set; }
        public string EmpEmail { get;  set; }
    }


}