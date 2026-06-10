namespace FarmManagement.Models.Task___Reminder
{
    public class FarmTask
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Task specific
        public string Name { get; set; }
        public string? Description { get; set; }

        public string Status { get; set; }
        public bool IsCompleted { get; set; } = false;

        public DateTime? DueDate { get; set; }
        public DateTime? CompletedAt { get; set; }

        public string? AssignedToUserId { get; set; }
        public string? AssignedToWorkerId { get; set; }

        public string? FieldId { get; set; }
        public string? EquipmentId { get; set; }

        public string? Notes { get; set; }

        public string UserId { get; set; }
        public string WorkerId { get; set; }

    }
}
