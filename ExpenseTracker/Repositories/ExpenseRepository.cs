using ExpenseTracker.Models;

namespace ExpenseTracker.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        public async Task AddExpenseAsync(Models.Expense expense)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteExpenseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Expense?> GetExpenseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateExpenseAsync(int id, Expense expense)
        {
            throw new NotImplementedException();
        }

        pu
    }
}
