namespace FarmManagement.Models.Receipts
{
    public class ReceiptPaymentDetails
    {
        public string Id { get; set; }
        public string ReceiptId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Amount { get; set; }

        // General
        public string? PaymentReferenceNumber { get; set; }
        public string? BankName { get; set; }
        public string? BranchNumber { get; set; }

        // Credit Card
        public string? CardLast4Digits { get; set; }
        public string? CardHolderName { get; set; }

        // Check
        public string? CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? CheckBankName { get; set; }
        public double? CheckAmount { get; set; }

        // Bank Transfer
        public string? ClientBankAccountNumber { get; set; }
        public string? DestinationBankAccountNumber { get; set; }

        // Misc
        public string? Notes { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTimeOffset? DeletedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}