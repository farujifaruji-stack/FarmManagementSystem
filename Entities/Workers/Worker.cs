namespace FarmManagement.Models.Workers
{
    public class Worker
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }

        //Worker specific
        public string? GovId { get; set; }
        public string? GovFullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string AccountId { get; set; }
        public int WorkerType { get; set; } 
        public string PermitId { get; set; }
        public string HealthCardId { get; set; } = string.Empty;
        public string WorkerAccountantNumber { get; set; } = string.Empty;

    }
}
