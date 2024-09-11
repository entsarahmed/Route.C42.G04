using Microsoft.AspNetCore.Mvc;
using Route.C42.G04.BLL.Interfaces;
using Route.C42.G04.BLL.Repositories;

namespace Route.C42.G04.PL.Controllers
{
    //Inheritance : DepartmentController is Controller
    //Association -> Composition : DepartmentController has a DepartmentRepository

    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentsRepo;


        public DepartmentController(IDepartmentRepository departmentsRepo)  //Ask CLR for Creating an Object from Class Implementing IDepartmentRepository   
        {
            _departmentsRepo=departmentsRepo;
        }

        // Department/Index 
        public IActionResult Index()
        {
            var departments = _departmentsRepo.GetAll();
            return View(departments);
        }
    }
}
