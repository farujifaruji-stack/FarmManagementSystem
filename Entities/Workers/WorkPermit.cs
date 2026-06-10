namespace FarmManagement.Models.Workers
{
    public class WorkPermit
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //workPermit specific
        public string WorkerId { get; set; }

        public string PermitNumber { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        // File
        public byte[]? PermitFile { get; set; }

        public string? PermitFileName { get; set; }

        public DateTime? UploadedAt { get; set; }

        public string? Notes { get; set; }
    }
}
