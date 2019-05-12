using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpenseEntryService.Client
{
    public class OrganizationClient
    {
        private string organizationURL;

        public OrganizationClient(string organizationURL)
        {
            this.organizationURL = organizationURL;
        }
        public async Task<EmployeeInfo> GetEmployeeInformation(string empid)
        {
            HttpClient client = new HttpClient();
            return JsonConvert.DeserializeObject<EmployeeInfo>(await(await client.GetAsync(organizationURL+"/employee/"+empid)).Content.ReadAsStringAsync());
        }
    }
}
