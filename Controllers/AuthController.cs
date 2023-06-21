using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Signup()
        {
            return View();
        }
    }
}
