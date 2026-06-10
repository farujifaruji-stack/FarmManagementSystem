namespace FarmManagement.Models.Reports
{
    public class WorkerReportItem
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Report item specific
        public string WorkerGovId { get; set; }
        public int WorkerAccountantNumber { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public double Salary { get; set; }
        public string PaycheckId { get; set; }
    }
}
