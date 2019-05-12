using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExpenseEntryService;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpenseEntryAPI.Controllers
{
    [Route("api/[controller]")]
    public class ExpenseEntryController : Controller
    {
        IExpenseEntryService service;

        public ExpenseEntryController(IExpenseEntryService service)
        {
            this.service =service;
        }

        [HttpGet("{empid}/configuration")]
        public async Task<ExpenseEntryConfiguration> Get(string empid)
    {
            return await this.service.GetExpenseEntryConfiguration  (empid)
        ;

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}