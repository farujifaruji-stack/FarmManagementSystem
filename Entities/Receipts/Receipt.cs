namespace FarmManagement.Models.Receipts
{
    //Receipt for a purchase
    public class Receipt
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }


        //receipt specific
        public int ReceiptNumber { get; set; }
        
        public bool IsCanceled { get; set; } = false;
        public DateTime ReceiptDate { get; set; }
        public string? NameSnapshot { get; set; }
        public string? ClientIDSnapshot { get; set; }
        public string?  AddressSnapshot { get; set; }
        public string? PhoneNumberSnapshot { get; set; }
        public bool WasPrited { get; set; } = false;
        public bool WasEmailed { get; set; } = false;
        public string? EmailSnapshot { get; set; }
        public double TotalAmount { get; set; }
        public double TotalTax { get; set; }
        public double TotallToPay { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string? Notes { get; set; }
        public string? CustomerId { get; set; }
        public string? CreatedByUserId { get; set; }
        public List<ReceiptItem> Items { get; set; } = new();
        // PDF
        public byte[]? PdfFile { get; set; }
        public string? PdfFileName { get; set; }
        public DateTime? PdfGeneratedAt { get; set; }

        // Accountant reporting
        public bool IsReportedToAccountant { get; set; }
        public DateTime? ReportedToAccountantAt { get; set; }
        public string? AccountantReportBatchId { get; set; }
        public string? AccountantReportFilePath { get; set; }

        public List<ReceiptPaymentDetails> PaymentDetails { get; set; } = new();

        //actions in the form
        public DateTime? PrintedAt { get; set; }
        public DateTime? EmailedAt { get; set; }
        public DateTime? CanceledAt { get; set; }
        public string? CancelReason { get; set; }

    }
}