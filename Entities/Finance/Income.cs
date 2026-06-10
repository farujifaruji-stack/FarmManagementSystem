namespace FarmManagement.Models.Finance
{
    public class Income
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Income specific
        public string IncomeCategoryId { get; set; }
        public string IncomeName { get; set; }
        public string IncomeSource { get; set; }
        public double IncomeAmount { get; set; }
        public DateTime IncomeDate { get; set; }
        public string? Notes { get; set; }
    }
}
