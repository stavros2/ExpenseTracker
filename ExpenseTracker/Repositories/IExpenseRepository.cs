using ExpenseTracker.Models;

namespace ExpenseTracker.Repositories
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllExpensesAsync();
        Task<Expense?> GetExpenseByIdAsync(int id);
        Task AddExpenseAsync(Expense expense);
        Task UpdateExpenseAsync(int id, Expense expense);
        Task DeleteExpenseAsync(int id);
    }
}
