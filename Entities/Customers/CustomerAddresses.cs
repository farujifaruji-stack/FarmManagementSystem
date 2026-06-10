namespace FarmManagement.Models.Customers.Customers
{
    public class CustomerAddresses
    {
        //General
        public string id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        //Address Details
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        //Foreign Keys
        public string CustomerId { get; set; }

    }
}
