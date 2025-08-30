namespace SudokuSolver.Models
{
    public class SudokuSolverService
    {
        public bool Solve(List<List<int?>> grid)
        {
            if (!IsGrigliaValidaAllInizio(grid))
            {
                return false; 
            }

            return SolveRecursive(grid);
        }

        private bool IsGrigliaValidaAllInizio(List<List<int?>> grid)
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (grid[r][c] != null)
                    {
                        int numeroOriginale = grid[r][c].Value;

                        grid[r][c] = null;

                        bool isValid = IsNumeroValido(grid, r, c, numeroOriginale);

                        grid[r][c] = numeroOriginale;

                        if (!isValid)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool SolveRecursive(List<List<int?>> grid)
        {
            int riga = -1;
            int colonna = -1;
            bool trovataCellaVuota = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j] == null)
                    {
                        riga = i;
                        colonna = j;
                        trovataCellaVuota = true;
                        break;
                    }
                }
                if (trovataCellaVuota) break;
            }

            if (!trovataCellaVuota)
            {
                return true;
            }

            for (int num = 1; num <= 9; num++)
            {
                if (IsNumeroValido(grid, riga, colonna, num))
                {
                    grid[riga][colonna] = num;
                    if (SolveRecursive(grid))
                    {
                        return true;
                    }
                    grid[riga][colonna] = null;
                }
            }

            return false;
        }

        public bool IsNumeroValido(List<List<int?>> grid, int riga, int colonna, int numero)
        {
            for (int c = 0; c < 9; c++)
            {
                if (grid[riga][c] == numero) return false;
            }
            for (int r = 0; r < 9; r++)
            {
                if (grid[r][colonna] == numero) return false;
            }
            var startRiga = riga - riga % 3;
            var startColonna = colonna - colonna % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[startRiga + i][startColonna + j] == numero) return false;
                }
            }
            return true;
        }
    }
}
