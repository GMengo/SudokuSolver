using System.ComponentModel.DataAnnotations;

namespace SudokuSolver.Models
{
    public class SudokuViewModel
    {
        [Display(Name = "Griglia Sudoku")]
        public List<List<int?>> Grid { get; set; }

        public SudokuViewModel()
        {

            Grid = new List<List<int?>>();
            for (int i = 0; i < 9; i++)
            {
                var row = new List<int?>();
                for (int j = 0; j < 9; j++)
                {
                    row.Add(null);
                }
                Grid.Add(row);
            }
        }
    }
}
