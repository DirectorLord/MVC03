using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVC03.Controllers;

public class DepartmentController : Controller
{
    private IDepartmentService _departmentService;
    public DepartmentController(IDepartmentService departmentService) => _departmentService = departmentService;
    public IActionResult Index()
    {
        _departmentService.GetAll();
        return View();
    }
}
