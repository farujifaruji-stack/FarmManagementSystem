namespace FarmManagement.Models.Equipments
{
    public class Equipment
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Equipment specific
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Notes { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
    }
}
