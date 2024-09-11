using Microsoft.AspNetCore.Mvc;
using Route.C42.G04.BLL.Interfaces;
using Route.C42.G04.BLL.Repositories;

namespace Route.C42.G04.PL.Controllers
{
    //Inheritance : DepartmentController is Controller
    //Association -> Composition : DepartmentController has a DepartmentRepository

    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepos;


        public DepartmentController(IDepartmentRepository departmentRepos)  //Ask CLR for Creating an Object from Class Implementing IDepartmentRepository   
        {
            _departmentRepos=departmentRepos;
        }

        // Department/Index 
        public IActionResult Index()
        {
           // var departments = _departmentRepo.GetAll();
            return View();
        }
    }
}
