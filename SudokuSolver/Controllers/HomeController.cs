using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SudokuSolver.Models;

namespace SudokuSolver.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index(string? difficulty)
        {
            var model = new SudokuViewModel();

            if (!string.IsNullOrEmpty(difficulty))
            {
                var repository = new SudokuRepository();
                model.Grid = repository.GetSudoku(difficulty);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Index([FromForm]SudokuViewModel model)
        {

            var solver = new SudokuSolverService();

            bool isSolved = solver.Solve(model.Grid);

            if (!isSolved)
            {
                ViewData["ErrorMessage"] = "Impossibile risolvere! Il Sudoku inserito non ha una soluzione valida.";
            }
            else
            {
                ViewData["SuccessMessage"] = "Sudoku risolto con successo!";
            }

            ModelState.Clear();

            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
