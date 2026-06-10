namespace FarmManagement.Models.Products.Products_Events
{
    public class ProductStockAudit
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
