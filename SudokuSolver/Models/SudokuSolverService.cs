using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class SudokuSolverService
    {

        public bool Solve(List<List<SudokuCell>> grid)
        {

            if (!IsGrigliaValidaAllInizio(grid))
            {
                return false;
            }

            return SolveRecursive(grid);
        }

        private bool IsGrigliaValidaAllInizio(List<List<SudokuCell>> grid)
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (grid[r][c].Value != null)
                    {
                        int numeroOriginale = grid[r][c].Value.Value;

                        grid[r][c].Value = null; 

                        bool isValid = IsNumeroValido(grid, r, c, numeroOriginale);

                        grid[r][c].Value = numeroOriginale; 

                        if (!isValid)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool SolveRecursive(List<List<SudokuCell>> grid)
        {
            int riga = -1;
            int colonna = -1;
            bool trovataCellaVuota = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j].Value == null)
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

                    grid[riga][colonna].Value = num;

                    if (SolveRecursive(grid))
                    {
                        return true;
                    }

                    grid[riga][colonna].Value = null;
                }
            }

            return false;
        }

        public bool IsNumeroValido(List<List<SudokuCell>> grid, int riga, int colonna, int numero)
        {

            for (int c = 0; c < 9; c++)
            {
                if (grid[riga][c].Value == numero) return false;
            }

            for (int r = 0; r < 9; r++)
            {
                if (grid[r][colonna].Value == numero) return false;
            }

            var startRiga = riga - riga % 3;
            var startColonna = colonna - colonna % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[startRiga + i][startColonna + j].Value == numero) return false;
                }
            }

            return true;
        }
    }
}