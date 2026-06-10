namespace FarmManagement.Models.Workers
{
    public class WorkerAbsence
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }

        //Worker Absence specific
        public string WorkerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsApproved { get; set; }=false;
        public AbsenceType AbsenceType { get; set; }
        public bool IsWholeDay { get; set; }
        public bool IsRequestSent { get; set; }
        public string? Reason { get; set; }
        public string ApprovedByUserId { get; set; }
    }
}
