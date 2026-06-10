namespace FarmManagement.Models.Equipment.Equipment_Events
{
    public class EquipmentAudit
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
