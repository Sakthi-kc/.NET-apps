using Microsoft.AspNetCore.Mvc;


namespace enrollment_form.Controllers
{

    public class SubmitController : Controller
    {

        public IActionResult EnrollmentDetails(UserDetailModel studentdata)
        {
            return View(studentdata);
        }

        public IActionResult DisplayDetails(UserDetailModel studentdata)
        {
            return View(studentdata);
        }
    }
}
