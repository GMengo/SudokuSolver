using System.ComponentModel.DataAnnotations;

namespace SudokuSolver.Models
{
    public class SudokuViewModel
    {
        [Display(Name = "Griglia Sudoku")]
        public List<List<SudokuCell?>> Grid { get; set; }

        public SudokuViewModel()
        {


            Grid = new List<List<SudokuCell>>();
            for (int i = 0; i < 9; i++)
            {
                var row = new List<SudokuCell>();
                for (int j = 0; j < 9; j++)
                {
                    row.Add(new SudokuCell());
                }
                Grid.Add(row);
            }
        }
    }
}
