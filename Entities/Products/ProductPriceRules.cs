namespace FarmManagement.Models.Products
{
    // This class represents the pricing rules for a product based on quantity.
    public class ProductPriceRules
    {
        // Generic properties
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        //Product Price Rule specific properties
        public string ProductId { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public double Price { get; set; }

    }
}
