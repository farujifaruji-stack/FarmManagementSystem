namespace FarmManagement.Models.Users.Users_Events
{
    public class UserAudit
    {

        //Generic
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Id { get; set; }

        //All Audit
        public AuditAction Actions { get; set; }
        public string PropertyName { get; set; }
        public string PreValue { get; set; }
        public string NewValue { get; set; }
        public string UserId { get; set; }
        public string RecordId { get; set; } // The id of the row in the original table
    }
}
