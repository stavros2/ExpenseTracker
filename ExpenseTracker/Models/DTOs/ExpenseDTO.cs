using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExpenseTracker.Models.DTOs
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExpenseCategory
    {
        Unknown = 0,
        Food,
        Transportation,
        Utilities,
        Entertainment,
        Healthcare,
        Other
    }


    public class ExpenseDTO
    {
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime ExpenseDate { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 6, ErrorMessage = "Invalid category.")]
        public ExpenseCategory Category { get; set; } = ExpenseCategory.Unknown;

    }
}
}
