using Logic.GeneralFunctions;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Algorithms
{
    public static class SudokuSolvingSubroutines
    {
        public static bool CheckConstraints(SudokuModel model, int row, int col, int c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (model.Sudoku[i][col].value != 0 && model.Sudoku[i][col].value == c)
                    return false;
                if (model.Sudoku[row][i].value != 0 && model.Sudoku[row][i].value == c)
                    return false;
                if (model.Sudoku[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3].value != 0 && model.Sudoku[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3].value == c)
                    return false;
            }
            return true;
        }

        public static List<CellModel> GenerateSudokuCellsHierarchical(SudokuModel model)
        {
            SudokuModel returnmodel = new SudokuModel();
            List<CellModel> emptycells = new List<CellModel>();
            for (int i = 0; i < 9; i++)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (model.Sudoku[i][a].value == 0)
                    {
                        emptycells.Add(CountOptionsCellHierarchical(model.Sudoku[i][a], model));
                        //if (returnmodel.FaultyBoard == true)
                        //{
                        //    return returnmodel;
                        //}
                    }
                    //if (i == 8 && a == 8)
                    //{
                    //    return returnmodel;
                    //} 
                }
            }
            return emptycells;
        }

        public static CellModel CountOptionsCellHierarchical(CellModel cellmodel, SudokuModel sudokumodel)
        {
            var row = sudokumodel.Sudoku[cellmodel.row];
            List<CellModel> columns = new List<CellModel>();
            for (int i = 0; i < 9; i++)
            {
                columns.Add(DeepCloning.DeepCloner(sudokumodel.Sudoku[i][cellmodel.column]));
            }

            List<CellModel> square = new List<CellModel>();
            for (int x = 0; x < 9; x++)
            {
                List<CellModel> squarerow = sudokumodel.Sudoku[x].Where(a => a.square == cellmodel.square).ToList();
                square.AddRange(DeepCloning.DeepCloner(squarerow));
            }
            for (int ab = 1; ab < 10; ab++)
            {
                if (row.Where(a => a.value == ab).Any())
                {

                    continue;
                }
                if (columns.Where(a => a.value == ab).Any())
                {

                    continue;
                }
                if (square.Where(a => a.value == ab).Any())
                {

                    continue;
                }

                cellmodel.amountofoptions++;

            }
            //if (sudokumodel.Sudoku[cellmodel.row][cellmodel.column].value == 0)
            //{
            //    sudokumodel.FaultyBoard = true;
            //}
            return cellmodel;
        }

        public static SudokuModel SolveCell(CellModel cellmodel, SudokuModel sudokumodel)
        {
            var row = sudokumodel.Sudoku[cellmodel.row];
            List<CellModel> columns = new List<CellModel>();
            for (int i = 0; i < 9; i++)
            {
                columns.Add(DeepCloning.DeepCloner(sudokumodel.Sudoku[i][cellmodel.column]));
            }

            List<CellModel> square = new List<CellModel>();
            for (int x = 0; x < 9; x++)
            {
                List<CellModel> squarerow = sudokumodel.Sudoku[x].Where(a => a.square == cellmodel.square).ToList();
                square.AddRange(DeepCloning.DeepCloner(squarerow));
            }
            for (int ab = 1; ab < 10; ab++)
            {
                if (row.Where(a => a.value == ab).Any())
                {

                    continue;
                }
                if (columns.Where(a => a.value == ab).Any())
                {

                    continue;
                }
                if (square.Where(a => a.value == ab).Any())
                {

                    continue;
                }

                sudokumodel.Sudoku[cellmodel.row][cellmodel.column].value = ab;

            }
            if (sudokumodel.Sudoku[cellmodel.row][cellmodel.column].value == 0)
            {
                sudokumodel.FaultyBoard = true;
            }
            return sudokumodel;
        }
    }
}
