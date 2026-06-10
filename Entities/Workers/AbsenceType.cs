using System.ComponentModel.DataAnnotations;

namespace FarmManagement.Models.Workers
{
    public enum AbsenceType
    {
        [Display(Name = "יום מחלה")]
        SickDay = 1,

        [Display(Name = "יום חופשה")]
        VacationDay = 2
    }
}
