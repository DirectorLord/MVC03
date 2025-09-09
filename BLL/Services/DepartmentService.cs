using DAL.Reporsitories;

namespace BLL.Services;

public class IDepartmentService
{
    private IdepartmentRepository _departmentRepository;
    public IDepartmentService(IdepartmentRepository deparmentRepository)
    {
        _departmentRepository = deparmentRepository;
    }
}
