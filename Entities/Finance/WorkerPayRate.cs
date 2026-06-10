using FarmManagement.Models.Workers;

namespace FarmManagement.Models.Finance
{
    public class WorkerPayRate
    {
        //Generic
  public string id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }

        //WorkerPayRate specific
        public bool IsPerHour { get; set; }
        public bool IsPerDay { get; set; }=false;
        public double PerUnit { get; set; } //How much the pay per Hour/day
        public string? Notes { get; set; }
        public WorkerType WorkerType { get; set; }
        public string Name { get; set; }
        public double OvertimeRate { get; set; }
    }
}
