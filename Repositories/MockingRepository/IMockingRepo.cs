using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.MockingRepository
{
    public interface IMockingRepo
    {
        SudokuModel GetSudoku(int SudokuId);
        SudokuModel SolveSudokuLayered(SudokuModel model);
        SudokuModel SolveSudokuHierarchical(SudokuModel model);
        SudokuModel SolveSudokuLogical(SudokuModel model);
        Task<SudokuModel> SolveSudokuLogical2(SudokuModel model);
        void EmptyBoard();
        void InitializeTestboard();
    }
}
