using System.ComponentModel.DataAnnotations;

namespace FarmManagement.Models.Receipts
{
    public enum PaymentMethod
    {
        [Display(Name = "מזומן")]
        Cash = 1,

        [Display(Name = "צ'ק")]
        Check = 2,

        [Display(Name = "העברה בנקאית")]
        BankTransfer = 3,

        [Display(Name = "אשראי")]
        CreditCard = 4,

        [Display(Name = "אחר")]
        Other = 5
    }
}
