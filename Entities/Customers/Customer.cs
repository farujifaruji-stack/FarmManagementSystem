namespace FarmManagement.Models.Customers
{
    public class Customer
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Customer specific
        public string? GovId { get; set; }
        public string CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        
    }
}
