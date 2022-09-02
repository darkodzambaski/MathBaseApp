using Microsoft.AspNetCore.Mvc;

namespace MathBase.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Quiz()
        {
            return View();
        }
    }
}
