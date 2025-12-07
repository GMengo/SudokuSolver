namespace SudokuSolver.Models
{
    public class HintRequest
    {
        public List<List<SudokuCell>> Grid { get; set; }
        public int? TargetRow { get; set; } 
        public int? TargetCol { get; set; } 
    }
}
