namespace SudokuSolver.Models
{
    public class SudokuCell
    {
        public int? Value { get; set; }
        public bool IsOriginal { get; set; } = false;
    }
}