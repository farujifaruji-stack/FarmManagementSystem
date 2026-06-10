namespace FarmManagement.Models.Finance
{
    public class IncomeCategory
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //IncomeCategory specific
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
