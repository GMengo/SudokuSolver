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
            foreach (var row in model.Grid)
            {
                foreach (var cell in row)
                {
                    if (cell.Value.HasValue)
                    {
                        cell.IsOriginal = cell.Value.HasValue;
                    }
                }
            }

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

        [HttpPost]
        public IActionResult GetHint([FromBody] HintRequest request)
        {
            var emptyCells = new List<(int Row, int Col)>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (request.Grid[i][j].Value == null)
                    {
                        emptyCells.Add((i, j));
                    }
                }
            }

            if (emptyCells.Count == 0)
            {
                return Json(new { success = false, message = "Il Sudoku è già completo!" });
            }

            var solver = new SudokuSolverService();
            bool isSolved = solver.Solve(request.Grid); 

            if (!isSolved)
            {
                return Json(new { success = false, message = "Impossibile dare un suggerimento: questo schema non ha soluzione!" });
            }

            int targetRow, targetCol;

            if (request.TargetRow.HasValue && request.TargetCol.HasValue)
            {
                targetRow = request.TargetRow.Value;
                targetCol = request.TargetCol.Value;

            }
            else
            {
                var rand = new Random();
                var randomCell = emptyCells[rand.Next(emptyCells.Count)];
                targetRow = randomCell.Row;
                targetCol = randomCell.Col;
            }

            return Json(new
            {
                success = true,
                rowIndex = targetRow,
                colIndex = targetCol,
                value = request.Grid[targetRow][targetCol].Value
            });
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
