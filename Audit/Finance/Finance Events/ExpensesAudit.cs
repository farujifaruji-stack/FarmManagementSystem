namespace FarmManagement.Models.Finance.Finance_Events
{
    public class ExpensesAudit
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
