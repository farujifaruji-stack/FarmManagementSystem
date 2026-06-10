namespace FarmManagement.Models.Workers.Workers_Tables_Events
{
    public class WorkerTypeAudit
    {
        public string id { get; set; }
        public string Actions { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string UserId { get; set; }
        public string RecordId { get; set; } // The id of the row in the original table
    }
}
