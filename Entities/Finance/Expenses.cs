namespace FarmManagement.Models.Finance
{
    public class Expenses
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Expenses specific
        public string ExpensesCategoryId { get; set; }
        public string ExpensesName { get; set; }
        public string ExpensesSource { get; set; }
        public double ExpensesAmount { get; set; }
        public DateTime ExpensesDate { get; set; }
        public string? FieldId { get; set; }
        public string? Notes { get; set; }
    }
}
