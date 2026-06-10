namespace FarmManagement.Models.Task___Reminder.Task___Reminder_Events
{
    public class ReminderAudit
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
