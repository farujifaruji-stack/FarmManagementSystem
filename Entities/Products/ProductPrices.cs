namespace FarmManagement.Models.Products
{
    //seasonale price changes, current price, future price, past price, quantity based price changes, stock availability
    public class ProductPrices
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        //product type specific
        public string ProductId { get; set; }
        public double price { get; set; }
        
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public string? Notes { get; set; }

    }
}
