using System;
using System.Threading.Tasks;

namespace ExpenseEntryService
{
    public interface IExpenseEntryService
    {
         Task<ExpenseEntryConfiguration> GetExpenseEntryConfiguration(string empid);
    }
}
