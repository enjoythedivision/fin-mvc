using System;
using FinanceApp.Data.Services;
using FinanceApp.Models;

namespace FinanceApp.Data.Services;

public class ExpensesService : IExpensesService
{
    public Task Add(Expense expense)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Expense>> GetAll()
    {
        throw new NotImplementedException();
    }
}
