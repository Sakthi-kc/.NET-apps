using Microsoft.AspNetCore.Mvc;
using salary_calculator.Models;


namespace salary_calculator.Controllers
{
    public class GetSalaryController : Controller
    {
        public IActionResult Index(EmployeeModel employee)
        {
            return View(employee);
        }
    }
}
