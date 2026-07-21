using HRMS.API.Entities;

namespace HRMS.API.Interfaces
{
  
        public interface IDepartmentRepository
        {
            Task<List<Department>> GetAllAsync();

            Task<Department?> GetByIdAsync(Guid id);

            Task<Department?> GetByCodeAsync(string departmentCode);

            Task AddAsync(Department department);

            Task UpdateAsync(Department department);

            Task DeleteAsync(Department department);

            Task SaveChangesAsync();
        }
}
