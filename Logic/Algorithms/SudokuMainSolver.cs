using Logic.GeneralFunctions;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Algorithms
{
    public class SudokuMainSolver
    {
        public static SudokuModel SolveSudoku(int id,SudokuModel model)
        {
           
                switch (id)
                {
                    case 5:
                        SolveSudokuLogical2(model);
                        break;
                    case 6:
                        SolveSudokuGuessing(model);
                        break;
                    default:
                        break;
                }

                return model;
            
        }

        public static bool SolveSudokuLogical2(SudokuModel model)
        {
            for (int i = 0; i < model.Sudoku.Count; i++)
            {
                for (int j = 0; j < model.Sudoku[0].Count; j++)
                {
                    if (model.Sudoku[i][j].value == 0)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if (SudokuSolvingSubroutines.CheckConstraints(model, i, j, c))
                            {
                                model.Sudoku[i][j].value = c;
                                
                                if (SolveSudokuLogical2(model))
                                    return true;
                                else
                                    model.Sudoku[i][j].value = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool SolveSudokuGuessing(SudokuModel model)
        {
            List<CellModel> PreviousChosenRandomNumbers = new List<CellModel>();

            goto GuessNumber;

            GuessNumber:

            Random rnd = new Random();
            SudokuSolvingSubroutines.CalculateListOfOptions(model);
            for (int i = 0; i < model.Sudoku.Count; i++)
            {
                for (int j = 0; j < model.Sudoku[0].Count; j++)
                {
                    if (model.Sudoku[i][j].value == 0)
                    {
                        if (model.Sudoku[i][j].amountofoptions == 1)
                        {
                            var randomnumber = rnd.Next(1, 10);
                            do
                            {
                                if (SudokuSolvingSubroutines.CheckConstraints(model, i, j, randomnumber))
                                {
                                    if (!PreviousChosenRandomNumbers.Contains(model.Sudoku[i][j]))
                                    {

                                        model.Sudoku[i][j].value = randomnumber;
                                        PreviousChosenRandomNumbers.Add(model.Sudoku[i][j]);
                                        goto SolveSudoku;
                                    }
                                }
                            }
                            while (SudokuSolvingSubroutines.CheckConstraints(model, i, j, randomnumber) == false);
                            for (int c = 1; c <= 9; c++)
                            {
                                if (SudokuSolvingSubroutines.CheckConstraints(model, i, j, c))
                                {
                                    model.Sudoku[i][j].value = c;
                                    goto SolveSudoku;
                                }
                            }
                        }
                    }
                }
            }

            SolveSudoku:


            for (int i = 0; i < model.Sudoku.Count; i++)
            {
                for (int j = 0; j < model.Sudoku[0].Count; j++)
                {
                    if (model.Sudoku[i][j].value == 0)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if (SudokuSolvingSubroutines.CheckConstraints(model, i, j, c))
                            {

                                model.Sudoku[i][j].value = c;

                                if (SolveSudokuGuessing(model))
                                    return true;
                                else
                                    model.Sudoku[i][j].value = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public static SudokuModel SolveSudokuLayeredVariations(SudokuModel model)
        {
            SudokuModel returnmodel = new SudokuModel();
            for (int i = 0; i < 9; i++)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (model.Sudoku[i][a].value == 0)
                    {
                        returnmodel = SudokuSolvingSubroutines.SolveCell(model.Sudoku[i][a], model);
                        //if (returnmodel.FaultyBoard == true)
                        //{
                        //    return returnmodel;
                        //}
                    }
                    if (i == 8 && a == 8)
                    {
                        return returnmodel;
                    }
                }
            }
            return returnmodel;
        }
        public static SudokuModel SolveSudokuLogical(SudokuModel model)
        {
            SudokuModel returnmodel = new SudokuModel();
            for (int i = 0; i < 9; i++)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (model.Sudoku[i][a].value == 0)
                    {
                        returnmodel = SudokuSolvingSubroutines.SolveCell(model.Sudoku[i][a], model);
                        //if (returnmodel.FaultyBoard == true)
                        //{
                        //    return returnmodel;
                        //}
                    }
                    if (i == 8 && a == 8)
                    {
                        return returnmodel;
                    }
                }
            }
            return returnmodel;
        }
        public static SudokuModel SolveSudokuHierArchical(SudokuModel model)
        {
            var hierarchy = SudokuSolvingSubroutines.GenerateSudokuCellsHierarchical(model);

            for (int a = 1; a < 10; a++)
            {

                List<CellModel> ascendingoptionscellvalues = hierarchy.Where(x => x.amountofoptions == a).ToList();
                if (ascendingoptionscellvalues.Any())
                {
                    for (int x = 0; x < ascendingoptionscellvalues.Count; x++)
                    {
                        SudokuSolvingSubroutines.SolveCell(ascendingoptionscellvalues[x], model);
                    }
                }
            }
            return model;
        }

      
    }
}
