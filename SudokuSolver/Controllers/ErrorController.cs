using Microsoft.AspNetCore.Mvc;

namespace SudokuSolver.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound()
        {
            return View("NotFound");
        }
    }
}
