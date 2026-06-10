namespace FarmManagement.Models.Finance
{
    public class Paycheck
    {
        //generic
        public string id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        //Paycheck details
        public string AttendanceSheetId { get; set; }
        public string WorkerId { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public double RegularHours { get; set; }
        public double RegularPay { get; set; }
        public double OverTimeHours { get; set; }
        public double OverTimePay { get; set; }
        public double VacationDays { get; set; }
        public double VacationLeft { get; set; }
        public double SickDays { get; set; }
        public double SickLeft { get; set; }
        public double GrossPay { get; set; }
        public double TaxesAmount { get; set; }
        public List<string> OtherDeductions { get; set; }
        public double OtherDeductionsAmount { get; set; }
        public double NetPay { get; set; }
        public string? Notes { get; set; }
        //Save rate in case there is any changes in the future
        public double HourlyRateSnapshot { get; set; }
        public double OverTimeRateSnapshot { get; set; }

        //File
        public byte[]? PdfFile { get; set; }
        public string? PdfFileName { get; set; }
        public DateTime? PdfGeneratedAt { get; set; }
        public DateTime? PdfPrintedAt { get; set; } 


    }
}
