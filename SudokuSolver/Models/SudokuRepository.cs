using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Models
{
    public class SudokuRepository
    {

        private readonly List<int[,]> _easyPuzzles;
        private readonly List<int[,]> _mediumPuzzles;
        private readonly List<int[,]> _hardPuzzles;


        public SudokuRepository()
        {
            _easyPuzzles = new List<int[,]>
            {

                new int[,] {
                    { 5, 3, 0, 0, 7, 0, 0, 0, 0 }, { 6, 0, 0, 1, 9, 5, 0, 0, 0 }, { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                    { 8, 0, 0, 0, 6, 0, 0, 0, 3 }, { 4, 0, 0, 8, 0, 3, 0, 0, 1 }, { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                    { 0, 6, 0, 0, 0, 0, 2, 8, 0 }, { 0, 0, 0, 4, 1, 9, 0, 0, 5 }, { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
                },

                new int[,] {
                    { 0, 0, 0, 2, 6, 0, 7, 0, 1 }, { 6, 8, 0, 0, 7, 0, 0, 9, 0 }, { 1, 9, 0, 0, 0, 4, 5, 0, 0 },
                    { 8, 2, 0, 1, 0, 0, 0, 4, 0 }, { 0, 0, 4, 6, 0, 2, 9, 0, 0 }, { 0, 5, 0, 0, 0, 3, 0, 2, 8 },
                    { 0, 0, 9, 3, 0, 0, 0, 7, 4 }, { 0, 4, 0, 0, 5, 0, 0, 3, 6 }, { 7, 0, 3, 0, 1, 8, 0, 0, 0 }
                },

                new int[,] {
                    { 0, 2, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 6, 0, 0, 0, 0, 3 }, { 0, 7, 4, 0, 8, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 3, 0, 0, 2 }, { 0, 8, 0, 0, 4, 0, 0, 1, 0 }, { 6, 0, 0, 5, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0, 7, 8, 0 }, { 5, 0, 0, 0, 0, 9, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 4, 0 }
                }
            };

            _mediumPuzzles = new List<int[,]>
            {
                new int[,] {
                    { 0, 0, 0, 6, 0, 0, 4, 0, 0 }, { 7, 0, 0, 0, 0, 3, 6, 0, 0 }, { 0, 0, 0, 0, 9, 1, 0, 8, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 5, 0, 1, 8, 0, 0, 0, 3 }, { 0, 0, 0, 3, 0, 6, 0, 4, 5 },
                    { 0, 4, 0, 2, 0, 0, 0, 6, 0 }, { 9, 0, 3, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 0, 0, 0, 1, 0, 0 }
                },

                new int[,] {
                    { 2, 0, 0, 3, 0, 0, 0, 0, 0 }, { 8, 0, 4, 0, 6, 2, 0, 0, 3 }, { 0, 1, 3, 8, 0, 0, 2, 0, 0 },
                    { 0, 0, 0, 0, 2, 0, 3, 9, 0 }, { 5, 0, 7, 0, 0, 0, 6, 2, 1 }, { 0, 3, 2, 0, 0, 6, 0, 0, 0 },
                    { 0, 2, 0, 0, 0, 9, 1, 4, 0 }, { 6, 0, 1, 2, 5, 0, 8, 0, 9 }, { 0, 0, 0, 0, 0, 1, 0, 0, 2 }
                },

                new int[,] {
                    { 0, 0, 6, 0, 0, 0, 0, 0, 1 }, { 0, 7, 0, 0, 6, 0, 0, 5, 0 }, { 8, 0, 0, 0, 0, 1, 6, 0, 0 },
                    { 0, 0, 0, 7, 0, 0, 2, 0, 0 }, { 0, 4, 9, 0, 0, 0, 8, 1, 0 }, { 0, 0, 7, 0, 0, 8, 0, 0, 0 },
                    { 0, 0, 2, 1, 0, 0, 0, 0, 3 }, { 0, 9, 0, 0, 3, 0, 0, 2, 0 }, { 3, 0, 0, 0, 0, 0, 7, 0, 0 }
                }
            };

            _hardPuzzles = new List<int[,]>
            {
                new int[,] {
                    { 0, 0, 0, 0, 0, 6, 0, 0, 0 }, { 0, 5, 9, 0, 0, 0, 0, 0, 8 }, { 2, 0, 0, 0, 0, 8, 0, 0, 0 },
                    { 0, 4, 5, 0, 0, 0, 0, 0, 0 }, { 0, 0, 3, 0, 0, 0, 0, 0, 0 }, { 0, 0, 6, 0, 0, 3, 0, 5, 4 },
                    { 0, 0, 0, 3, 2, 5, 0, 0, 6 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },

                new int[,] {
                    { 8, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 3, 6, 0, 0, 0, 0, 0 }, { 0, 7, 0, 0, 9, 0, 2, 0, 0 },
                    { 0, 5, 0, 0, 0, 7, 0, 0, 0 }, { 0, 0, 0, 0, 4, 5, 7, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0, 3, 0 },
                    { 0, 0, 1, 0, 0, 0, 0, 6, 8 }, { 0, 0, 8, 5, 0, 0, 0, 1, 0 }, { 0, 9, 0, 0, 0, 0, 4, 0, 0 }
                },

                new int[,] {
                    { 8, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 3, 6, 0, 0, 0, 0, 0 }, { 0, 7, 0, 0, 9, 0, 2, 0, 0 },
                    { 0, 5, 0, 0, 0, 7, 0, 0, 0 }, { 0, 0, 0, 0, 4, 5, 7, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0, 3, 0 },
                    { 0, 0, 1, 0, 0, 0, 0, 6, 8 }, { 0, 0, 8, 5, 0, 0, 0, 1, 0 }, { 0, 9, 0, 0, 0, 0, 4, 0, 0 }
                }
            };
        }

        public List<List<SudokuCell?>> GetSudoku(string difficulty)
        {
            var rand = new Random();
            List<int[,]> puzzleListToChooseFrom;

            switch (difficulty.ToLower())
            {
                case "medio":
                    puzzleListToChooseFrom = _mediumPuzzles;
                    break;
                case "difficile":
                    puzzleListToChooseFrom = _hardPuzzles;
                    break;
                case "facile":
                default:
                    puzzleListToChooseFrom = _easyPuzzles;
                    break;
            }

            int randomIndex = rand.Next(puzzleListToChooseFrom.Count);
            int[,] puzzleArray = puzzleListToChooseFrom[randomIndex];

            var grid = new List<List<SudokuCell>>();

            for (int i = 0; i < 9; i++)
            {
                var row = new List<SudokuCell>();
                for (int j = 0; j < 9; j++)
                {
                    int number = puzzleArray[i, j];

                    var cell = new SudokuCell();

                    if (number == 0)
                    {
                        cell.Value = null;
                        cell.IsOriginal = false;
                    }
                    else
                    {
                        cell.Value = number;
                        cell.IsOriginal = true; 
                    }

                    row.Add(cell);
                }
                grid.Add(row);
            }

            return grid;
        }
    }
}