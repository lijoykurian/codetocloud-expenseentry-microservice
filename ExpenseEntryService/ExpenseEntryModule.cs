using System;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseEntryService
{
    public static class ExpenseEntryModule
    {
        public static  void AddExpenseEntryModule(this IServiceCollection services)
        {
            services.AddSingleton<IExpenseEntryService,ExpenseEntryService>();
        }
    }
}
