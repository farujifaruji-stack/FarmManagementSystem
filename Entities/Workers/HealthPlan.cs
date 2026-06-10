namespace FarmManagement.Models.Workers
{
    public class HealthPlan
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Health Plan specific
        public string WorkerId { get; set; }
        public string ProviderName { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public string? Notes { get; set; }
        //File
        public byte[]? HealthPlanFile { get; set; }
        public string? HealthPlanFileName { get; set; }
        public DateTime? UploadedAt { get; set; }
    }
}
