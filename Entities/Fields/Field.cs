namespace FarmManagement.Models.Fields
{ 
    public class Field
    {
        //Generic
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Field specific
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Area { get; set; }
        public string? Location { get; set; }
        public string? Notes { get; set; }
    }
}
