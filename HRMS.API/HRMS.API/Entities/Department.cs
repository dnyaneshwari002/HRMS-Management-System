namespace HRMS.API.Entities
{
    public class Department :BaseEntity
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;

        public string DepartmentCode { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
