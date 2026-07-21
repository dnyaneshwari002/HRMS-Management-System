namespace HRMS.API.DTOs
{
    public class DepartmentDto
    {
        public class CreateDepartmentDto
        {
            public string DepartmentName { get; set; } = string.Empty;
            public string DepartmentCode { get; set; } = string.Empty;
            public string? Description { get; set; }
        }

        public class UpdateDepartmentDto
        {
            public Guid Id { get; set; }
            public string DepartmentName { get; set; } = string.Empty;
            public string DepartmentCode { get; set; } = string.Empty;
            public string? Description { get; set; }
        }

        public class DepartmentsDto
        {
            public Guid Id { get; set; }
            public string DepartmentName { get; set; } = string.Empty;
            public string DepartmentCode { get; set; } = string.Empty;
            public string? Description { get; set; }
        }
    }
}

