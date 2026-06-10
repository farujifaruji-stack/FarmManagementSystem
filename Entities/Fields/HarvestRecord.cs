using FarmManagement.Models.Products;
  
namespace FarmManagement.Models.Fields
{
    public class HarvestRecord
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Harvest specific
        public string FieldId { get; set; }
        public string ProductId { get; set; }
        public DateTime HarvestDate { get; set; }
        public double Quantity { get; set; }
        public UnitType UnitType { get; set; }
        public string? Notes { get; set; }
    }
}
