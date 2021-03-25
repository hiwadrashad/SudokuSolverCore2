using Logic.Algorithms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            _repo.InitializeTestboard();
            var board =_repo.GetSudoku(2);
            return View(board);
        }
        [Route("/Sudoku/Sudoku/{id}")]
        public IActionResult Sudoku(int id)
        {
            //_repo.InitializeTestboard();
            //_repo.SolveSudokuLogical2(_repo.GetSudoku());
            var board = _repo.GetSudoku(id);
            SudokuMainSolver.SolveSudokuLogical2(board);
            return View(board);
        }
    }
}
