using DAL.Reporsitories;

namespace BLL.Services;

public class DepartmentService : IDepartmentService
{
    private IdepartmentRepository _departmentRepository;
    public IDepartmentService departmentService;

    public DepartmentService(IdepartmentRepository idepartmentRepository)
    {
        _departmentRepository = idepartmentRepository;
    }
}
