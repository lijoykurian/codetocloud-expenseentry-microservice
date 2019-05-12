using System;
using Microsoft.Extensions.Configuration;
using ExpenseEntryService.Client;
using System.Threading.Tasks;

namespace ExpenseEntryService
{
    public class ExpenseEntryService:IExpenseEntryService
    {
        private IConfiguration config;

        public ExpenseEntryService(IConfiguration config){
            this.config = config;
        }
        public async Task<ExpenseEntryConfiguration> GetExpenseEntryConfiguration(string empid){
            OrganizationClient client = new OrganizationClient(config.GetSection("ClientURLs")["organization"]);
            EmployeeInfo emp = await client.GetEmployeeInformation(empid);
            var empInfo =  new ExpenseEntryConfiguration() {  };
            empInfo.EmpId = emp.EmpId;
            empInfo.EmpName = emp.EmpName;
            empInfo.EmpEmail = emp.EmpEmail;
            empInfo.Organization = emp.Organization;
            empInfo.AllowedExpenses = emp.AllowedExpenses;
            return empInfo;
        }
    }
}
