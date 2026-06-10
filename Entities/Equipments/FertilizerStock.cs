using FarmManagement.Models.Products;

namespace FarmManagement.Models.Equipments
{
    public class FertilizerStock
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        // FertilizerStock specific
        public string FertilizerName { get; set; }
        public double Quantity { get; set; }
        public UnitType UnitType { get; set; }
        public string? Notes { get; set; }
        public string FertilizerId { get; set; }
    }
}
