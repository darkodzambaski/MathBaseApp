using Microsoft.AspNetCore.Mvc;

namespace MathBase.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Algebra()
        {
            return View();
        }

        public IActionResult Trigonometry()
        {
            return View();
        }

        public IActionResult Calculus()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
