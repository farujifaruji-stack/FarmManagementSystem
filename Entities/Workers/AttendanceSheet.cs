using FarmManagement.Models.Customers;
using Microsoft.Identity.Client;

namespace FarmManagement.Models.Workers
{
    public class AttendanceSheet
    {
       //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Attendance Sheet specific
        public string Month { get; set; }
        public string Year { get; set; }
        public string WorkerId { get; set; }
        public List<Shift>? Shifts { get; set; }
        public List<WorkerAbsence>? WorkerAbsences { get; set; }
        public double TotalHours { get; set; }
        public double TotalOvertimeHours { get; set; }
        public int TotalAbsenceDays { get; set; }
        public string? Notes { get; set; }

        //File
        public byte[]? PdfFile { get; set; }
        public string? PdfFileName { get; set; }
        public DateTime? PdfGeneratedAt { get; set; }
        public bool IsEmailedToWorker { get; set; } = false;


    }
}
