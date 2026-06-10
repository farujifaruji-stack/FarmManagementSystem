namespace FarmManagement.Models.Workers
{
    public class Shift
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }

        //Shift specific
        public string WorkerId { get; set; }
        public string FieldId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TotalHours { get; set; }
        public double OvertimeHours { get; set; }
    }
}
