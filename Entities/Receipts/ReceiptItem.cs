namespace FarmManagement.Models.Receipts
{
    //Each tem in the receipt and if it was on sale or not, quantity and prices
    public class ReceiptItem
    {
        //General
        public string Id { get; set; }       
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;        
        public DateTimeOffset? DeletedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }
        //Each row: Quantity, Product, UnitPrice, Total, if it was on sale or not
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
        public string ReceiptId { get; set; }
        public string ProductId { get; set; }
        public string? ProductNameSnapshot { get; set; }
        public string? DescriptionSnapshot { get; set; } //Save what is the product, price per unit

        //Rules that might change the total price of the item, for example if it was on sale or not
        public bool WasOnSale { get; set; } = false;
        public string? ProductPriceRuleId { get; set; } = string.Empty;

    }
}
