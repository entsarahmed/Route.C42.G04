using Microsoft.AspNetCore.Mvc;
using Route.C42.G04.BLL.Interfaces;
using Route.C42.G04.BLL.Repositories;
using Route.C42.G04.DAL.Models;

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


        //Department/Create
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid) //Server Side Validation
            { 
          var count=  _departmentsRepo.Add(department);
                if (count > 0)
                    return RedirectToAction(nameof(Index));
            
            }
            return View(department);
        }

    }
}
