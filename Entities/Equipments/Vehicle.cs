namespace FarmManagement.Models.Equipments
{
    public class Vehicle
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Vehicle specific
        public string Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? LicensePlate { get; set; }
        public int? Year { get; set; }
        public double? CurrentMileage { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Notes { get; set; }
        public DateTime? LicenseExpirationDate { get; set; }
        public DateTime? NextTestDate { get; set; }
    }
}
