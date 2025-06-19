using API_Day2.DTOs;

namespace API_Day2.Repository
{
    public interface IDepartmentRepository
    {
        Task<List<DepartmentDto>> GetDepartmentsAsync();
    }
}
