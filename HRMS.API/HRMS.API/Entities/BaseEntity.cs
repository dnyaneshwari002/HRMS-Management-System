namespace HRMS.API.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } 
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public  DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
