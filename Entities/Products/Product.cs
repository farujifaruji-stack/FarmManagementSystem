namespace FarmManagement.Models.Products
{
    //Sold products
    public class Product
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        //Product Details
        public string Name { get; set; }
        public UnitType unitType { get; set; }// 0 for kg, 1 for liter, 2 for piece
        public string? Description { get; set; }
        public bool IsActive { get; set; } = false;
        public string? Notes { get; set; }


    }
}
