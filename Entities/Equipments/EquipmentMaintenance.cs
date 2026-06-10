namespace FarmManagement.Models.Equipments
{
    public class EquipmentMaintenance
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Equipment Maintenance specific
        public string EquipmentId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string? Notes { get; set; }
        public string MaintenanceType { get; set; }
        public double Cost { get; set; }
        public string? PerformedBy { get; set; }
    }
}
