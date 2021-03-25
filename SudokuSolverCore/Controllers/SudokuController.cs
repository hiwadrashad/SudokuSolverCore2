using Logic.Algorithms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SudokuSolverCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuSolverCore.Controllers
{
    [AllowAnonymous]
    public class SudokuController : Controller
    {
        public readonly Repositories.MockingRepository.IMockingRepo _repo = Repositories.MockingRepository.MockingRepo.GetMockingRepo();
        public IActionResult Sudoku()
        {
            var board =_repo.GetSudoku(1);
            Shared.StaticResources.StaticValues.CurrentSudokuTemplate = board;
            SudokuWithListItemsViewModel SudokuVM = new SudokuWithListItemsViewModel() { Model = board };
            return View(SudokuVM);
        }
        [Route("/Sudoku/Sudoku/{id}")]
        public IActionResult Sudoku(int id)
        {
            if (id < 5)
            {
                var board = _repo.GetSudoku(id);
                SudokuWithListItemsViewModel SudokuVM = new SudokuWithListItemsViewModel() { Model = board };
                return View(SudokuVM);
            }
            else
            {
                var board = SudokuMainSolver.SolveSudoku(id, Shared.StaticResources.StaticValues.CurrentSudokuTemplate);
                SudokuWithListItemsViewModel SudokuVM = new SudokuWithListItemsViewModel() { Model = board };
                return View(SudokuVM);
            }
        }
    }
}
