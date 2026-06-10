namespace FarmManagement.Models.Products
{
    public class ProductStock
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        //Product specific
        public string ProductId { get; set; }
        public double Quantity { get; set; } = 0;
    }
}
