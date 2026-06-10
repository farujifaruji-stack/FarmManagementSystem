namespace FarmManagement.Models.Task___Reminder
{
    public class Reminder
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Reminder specific
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public bool IsRecurring { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string? RecurrencePattern { get; set; } // e.g., "Daily", "Weekly", "Monthly"
        public bool IsEmailNotificationEnabled { get; set; } = false;
        public bool IsSmsNotificationEnabled { get; set; } = false;
        public bool IsEmailSent { get; set; } = false;
        public bool IsSmsSent { get; set;} = false;
        public string UserId { get; set; }
        public string WorkerId { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
