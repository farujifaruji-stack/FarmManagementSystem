using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FarmManagement.Models.Reports
{
    public class WorkerAccountantReport
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Report specific
        public List<WorkerReportItem> WorkerReportItems { get; set; } = new List<WorkerReportItem>();
        public string ReportMonth { get; set; }
        public string ReportYear { get; set; }

        public byte[]? ReportFile { get; set; }
        public string? FileName { get; set; }

        public string AccountantId { get; set; }
        public string? AccountantEmailSnapshot { get; set; }

        public bool IsSentToAccountant { get; set; } = false;
        public DateTime? SentAt { get; set; }

        public string? SendErrorMessage { get; set; }
        public int SendAttempts { get; set; } = 0;

        public bool IsReportGenerated { get; set; } = false;
        public DateTime? ReportGeneratedAt { get; set; }

        public string? Notes { get; set; }

        
    }
}
