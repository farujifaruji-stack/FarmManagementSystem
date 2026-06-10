using FarmManagement.Models.Products;

namespace FarmManagement.Models.Equipments
{
    public class Fertilizer
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Fertilizer specific

        public string FieldId { get; set; }
        public string FertilizerName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public double Quantity { get; set; }
        public UnitType UnitType { get; set; }
        public double? Cost { get; set; }
        public string? Notes { get; set; }
    }
}
