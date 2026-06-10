using Microsoft.AspNetCore.Identity;

namespace FarmManagement.Models.Login
{
    public class OtpCodes
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Code { get; set; }

        public DateTime ExpiresAt { get; set; }

        public bool IsUsed { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
