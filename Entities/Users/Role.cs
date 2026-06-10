namespace FarmManagement.Models.Users
{
    public class Role
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Role specific
        public string RoleName { get; set; }
        public string RoleDiscription { get; set; }
        public bool CanManageWorkers { get; set; }
        public bool CanManageFinance { get; set; }
        public bool CanManageCustomers { get; set; }
        public bool CanManageReports { get; set; }
        public bool CanViewWorkers { get; set; }
        public bool CanViewFinance { get; set; }
        public bool CanViewCustomers { get; set; }
        public bool CanViewReports { get; set; }
    }
}
