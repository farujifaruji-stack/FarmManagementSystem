namespace FarmManagement.Models.Finance
{
    public class ExpensesCategory
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //ExpensesCategory specific
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
