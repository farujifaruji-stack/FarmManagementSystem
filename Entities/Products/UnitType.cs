using System.ComponentModel.DataAnnotations;

namespace FarmManagement.Models.Products
{
    public enum UnitType
    {
        [Display(Name = "קילו")]
        Kg = 1,

        [Display(Name = "ארגז")]
        Box = 2,

        [Display(Name = "מגש")]
        Tray = 3,

        [Display(Name = "שק")]
        Sack = 4,

        [Display(Name = "יחידה")]
        Unit = 5
    }
}