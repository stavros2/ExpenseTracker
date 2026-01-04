namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string Description { get; set; } = string.Empty;
        public DateTime ExpenseDate { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; } = string.Empty;

    }
}
