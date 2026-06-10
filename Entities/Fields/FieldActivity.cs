namespace FarmManagement.Models.Fields
{
    public class FieldActivity
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //field Activity specific
        public string FieldId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityDate { get; set; }
        public string? Description { get; set; }
        public string WorkerId { get; set; }

    }
}
