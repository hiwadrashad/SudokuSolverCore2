using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.MockingRepository
{
    public class MockingRepo : IMockingRepo
    {

        private SudokuModel Sudoku { get; set; }
        private static MockingRepo _mockingRepo;

        private MockingRepo()
        {

        }

        public static MockingRepo GetMockingRepo()
        {
            if (_mockingRepo == null)
            {
                _mockingRepo = new MockingRepo();
                _mockingRepo.InitData();
            }
            return _mockingRepo;
        }

        public void InitData()
        {
            Sudoku = new SudokuModel();
        }

        public SudokuModel GetSudoku(int sudokuId)
        {
            switch (sudokuId)
            {
                case 1:
                    InitializeLogicalBoard();
                    break;
                case 2:
                    InitializeGuessingBoard();
                    break;
                case 3:
                    EmptyBoard();
                    break;
                case 4:
                    InitializeHardestBoard();
                    break;
            default:
                    break;
            }
            
            return Sudoku;
        }

        public SudokuModel SolveSudokuLayered(SudokuModel model)
        {
            SolveSudokuLayered(model);
            return model;
        }
        public SudokuModel SolveSudokuHierarchical(SudokuModel model)
        {
            SolveSudokuHierarchical(model);
            return model;
        }
        public SudokuModel SolveSudokuLogical(SudokuModel model)
        {
            SolveSudokuLogical(model);
            return model;
        }
        public async Task<SudokuModel> SolveSudokuLogical2(SudokuModel model)
        {
            await SolveSudokuLogical2(model);
            return model;
        }

        public void EmptyBoard()
        {
            Sudoku = new SudokuModel()
            {
                Sudoku = new List<List<CellModel>>()
            {
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 0, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 0, square = 0  },
                    new CellModel { value = 0, column = 2, row = 0, square = 0  },
                    new CellModel { value = 0, column = 3, row = 0, square = 1  },
                    new CellModel { value = 0, column = 4, row = 0, square = 1  },
                    new CellModel { value = 0, column = 5, row = 0, square = 1  },
                    new CellModel { value = 0, column = 6, row = 0, square = 2  },
                    new CellModel { value = 0, column = 7, row = 0, square = 2  },
                    new CellModel { value = 0, column = 8, row = 0, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 1, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 1, square = 0  },
                    new CellModel { value = 0, column = 2, row = 1, square = 0  },
                    new CellModel { value = 0, column = 3, row = 1, square = 1  },
                    new CellModel { value = 0, column = 4, row = 1, square = 1  },
                    new CellModel { value = 0, column = 5, row = 1, square = 1  },
                    new CellModel { value = 0, column = 6, row = 1, square = 2  },
                    new CellModel { value = 0, column = 7, row = 1, square = 2  },
                    new CellModel { value = 0, column = 8, row = 1, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 2, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 2, square = 0  },
                    new CellModel { value = 0, column = 2, row = 2, square = 0  },
                    new CellModel { value = 0, column = 3, row = 2, square = 1  },
                    new CellModel { value = 0, column = 4, row = 2, square = 1  },
                    new CellModel { value = 0, column = 5, row = 2, square = 1  },
                    new CellModel { value = 0, column = 6, row = 2, square = 2  },
                    new CellModel { value = 0, column = 7, row = 2, square = 2  },
                    new CellModel { value = 0, column = 8, row = 2, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 3, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 3, square = 3  },
                    new CellModel { value = 0, column = 2, row = 3, square = 3  },
                    new CellModel { value = 0, column = 3, row = 3, square = 4  },
                    new CellModel { value = 0, column = 4, row = 3, square = 4 },
                    new CellModel { value = 0, column = 5, row = 3, square = 4  },
                    new CellModel { value = 0, column = 6, row = 3, square = 5  },
                    new CellModel { value = 0, column = 7, row = 3, square = 5  },
                    new CellModel { value = 0, column = 8, row = 3, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 4, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 4, square = 3  },
                    new CellModel { value = 0, column = 2, row = 4, square = 3  },
                    new CellModel { value = 0, column = 3, row = 4, square = 4  },
                    new CellModel { value = 0, column = 4, row = 4, square = 4  },
                    new CellModel { value = 0, column = 5, row = 4, square = 4  },
                    new CellModel { value = 0, column = 6, row = 4, square = 5  },
                    new CellModel { value = 0, column = 7, row = 4, square = 5  },
                    new CellModel { value = 0, column = 8, row = 4, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 5, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 5, square = 3  },
                    new CellModel { value = 0, column = 2, row = 5, square = 3  },
                    new CellModel { value = 0, column = 3, row = 5, square = 4  },
                    new CellModel { value = 0, column = 4, row = 5, square = 4  },
                    new CellModel { value = 0, column = 5, row = 5, square = 4  },
                    new CellModel { value = 0, column = 6, row = 5, square = 5  },
                    new CellModel { value = 0, column = 7, row = 5, square = 5  },
                    new CellModel { value = 0, column = 8, row = 5, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 6, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 6, square = 6  },
                    new CellModel { value = 0, column = 2, row = 6, square = 6  },
                    new CellModel { value = 0, column = 3, row = 6, square = 7  },
                    new CellModel { value = 0, column = 4, row = 6, square = 7  },
                    new CellModel { value = 0, column = 5, row = 6, square = 7  },
                    new CellModel { value = 0, column = 6, row = 6, square = 8  },
                    new CellModel { value = 0, column = 7, row = 6, square = 8  },
                    new CellModel { value = 0, column = 8, row = 6, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 7, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 7, square = 6  },
                    new CellModel { value = 0, column = 2, row = 7, square = 6  },
                    new CellModel { value = 0, column = 3, row = 7, square = 7  },
                    new CellModel { value = 0, column = 4, row = 7, square = 7  },
                    new CellModel { value = 0, column = 5, row = 7, square = 7  },
                    new CellModel { value = 0, column = 6, row = 7, square = 8  },
                    new CellModel { value = 0, column = 7, row = 7, square = 8  },
                    new CellModel { value = 0, column = 8, row = 7, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 8, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 8, square = 6  },
                    new CellModel { value = 0, column = 2, row = 8, square = 6  },
                    new CellModel { value = 0, column = 3, row = 8, square = 7  },
                    new CellModel { value = 0, column = 4, row = 8, square = 7  },
                    new CellModel { value = 0, column = 5, row = 8, square = 7  },
                    new CellModel { value = 0, column = 6, row = 8, square = 8  },
                    new CellModel { value = 0, column = 7, row = 8, square = 8  },
                    new CellModel { value = 0, column = 8, row = 8, square = 8  },
                } }

            };
        }
        public void InitializeGuessingBoard()
        {
            Sudoku = new SudokuModel()
            {
                Sudoku = new List<List<CellModel>>()
            {
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 0, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 0, square = 0  },
                    new CellModel { value = 0, column = 2, row = 0, square = 0  },
                    new CellModel { value = 0, column = 3, row = 0, square = 1  },
                    new CellModel { value = 0, column = 4, row = 0, square = 1  },
                    new CellModel { value = 0, column = 5, row = 0, square = 1  },
                    new CellModel { value = 0, column = 6, row = 0, square = 2  },
                    new CellModel { value = 0, column = 7, row = 0, square = 2  },
                    new CellModel { value = 0, column = 8, row = 0, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 1, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 1, square = 0  },
                    new CellModel { value = 0, column = 2, row = 1, square = 0  },
                    new CellModel { value = 0, column = 3, row = 1, square = 1  },
                    new CellModel { value = 0, column = 4, row = 1, square = 1  },
                    new CellModel { value = 0, column = 5, row = 1, square = 1  },
                    new CellModel { value = 0, column = 6, row = 1, square = 2  },
                    new CellModel { value = 0, column = 7, row = 1, square = 2  },
                    new CellModel { value = 0, column = 8, row = 1, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 2, square = 0  } ,
                    new CellModel { value = 9, column = 1, row = 2, square = 0  },
                    new CellModel { value = 8, column = 2, row = 2, square = 0  },
                    new CellModel { value = 0, column = 3, row = 2, square = 1  },
                    new CellModel { value = 0, column = 4, row = 2, square = 1  },
                    new CellModel { value = 0, column = 5, row = 2, square = 1  },
                    new CellModel { value = 0, column = 6, row = 2, square = 2  },
                    new CellModel { value = 6, column = 7, row = 2, square = 2  },
                    new CellModel { value = 0, column = 8, row = 2, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 8, column = 0, row = 3, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 3, square = 3  },
                    new CellModel { value = 0, column = 2, row = 3, square = 3  },
                    new CellModel { value = 0, column = 3, row = 3, square = 4  },
                    new CellModel { value = 6, column = 4, row = 3, square = 4 },
                    new CellModel { value = 0, column = 5, row = 3, square = 4  },
                    new CellModel { value = 0, column = 6, row = 3, square = 5  },
                    new CellModel { value = 0, column = 7, row = 3, square = 5  },
                    new CellModel { value = 0, column = 8, row = 3, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 4, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 4, square = 3  },
                    new CellModel { value = 0, column = 2, row = 4, square = 3  },
                    new CellModel { value = 8, column = 3, row = 4, square = 4  },
                    new CellModel { value = 0, column = 4, row = 4, square = 4  },
                    new CellModel { value = 0, column = 5, row = 4, square = 4  },
                    new CellModel { value = 0, column = 6, row = 4, square = 5  },
                    new CellModel { value = 0, column = 7, row = 4, square = 5  },
                    new CellModel { value = 0, column = 8, row = 4, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 7, column = 0, row = 5, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 5, square = 3  },
                    new CellModel { value = 0, column = 2, row = 5, square = 3  },
                    new CellModel { value = 0, column = 3, row = 5, square = 4  },
                    new CellModel { value = 2, column = 4, row = 5, square = 4  },
                    new CellModel { value = 0, column = 5, row = 5, square = 4  },
                    new CellModel { value = 0, column = 6, row = 5, square = 5  },
                    new CellModel { value = 0, column = 7, row = 5, square = 5  },
                    new CellModel { value = 0, column = 8, row = 5, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 6, square = 6  } ,
                    new CellModel { value = 6, column = 1, row = 6, square = 6  },
                    new CellModel { value = 0, column = 2, row = 6, square = 6  },
                    new CellModel { value = 0, column = 3, row = 6, square = 7  },
                    new CellModel { value = 0, column = 4, row = 6, square = 7  },
                    new CellModel { value = 0, column = 5, row = 6, square = 7  },
                    new CellModel { value = 0, column = 6, row = 6, square = 8  },
                    new CellModel { value = 0, column = 7, row = 6, square = 8  },
                    new CellModel { value = 0, column = 8, row = 6, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 7, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 7, square = 6  },
                    new CellModel { value = 0, column = 2, row = 7, square = 6  },
                    new CellModel { value = 4, column = 3, row = 7, square = 7  },
                    new CellModel { value = 1, column = 4, row = 7, square = 7  },
                    new CellModel { value = 9, column = 5, row = 7, square = 7  },
                    new CellModel { value = 0, column = 6, row = 7, square = 8  },
                    new CellModel { value = 0, column = 7, row = 7, square = 8  },
                    new CellModel { value = 0, column = 8, row = 7, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 8, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 8, square = 6  },
                    new CellModel { value = 0, column = 2, row = 8, square = 6  },
                    new CellModel { value = 0, column = 3, row = 8, square = 7  },
                    new CellModel { value = 8, column = 4, row = 8, square = 7  },
                    new CellModel { value = 0, column = 5, row = 8, square = 7  },
                    new CellModel { value = 0, column = 6, row = 8, square = 8  },
                    new CellModel { value = 0, column = 7, row = 8, square = 8  },
                    new CellModel { value = 0, column = 8, row = 8, square = 8  },
                } }

            };
        }

        public void InitializeHardestBoard()
        {
            Sudoku = new SudokuModel()
            {
                Sudoku = new List<List<CellModel>>()
            {
                new List<CellModel>
                {
                    new CellModel { value = 8, column = 0, row = 0, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 0, square = 0  },
                    new CellModel { value = 0, column = 2, row = 0, square = 0  },
                    new CellModel { value = 0, column = 3, row = 0, square = 1  },
                    new CellModel { value = 0, column = 4, row = 0, square = 1  },
                    new CellModel { value = 0, column = 5, row = 0, square = 1  },
                    new CellModel { value = 0, column = 6, row = 0, square = 2  },
                    new CellModel { value = 0, column = 7, row = 0, square = 2  },
                    new CellModel { value = 0, column = 8, row = 0, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 1, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 1, square = 0  },
                    new CellModel { value = 3, column = 2, row = 1, square = 0  },
                    new CellModel { value = 6, column = 3, row = 1, square = 1  },
                    new CellModel { value = 0, column = 4, row = 1, square = 1  },
                    new CellModel { value = 0, column = 5, row = 1, square = 1  },
                    new CellModel { value = 0, column = 6, row = 1, square = 2  },
                    new CellModel { value = 0, column = 7, row = 1, square = 2  },
                    new CellModel { value = 0, column = 8, row = 1, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 2, square = 0  } ,
                    new CellModel { value = 7, column = 1, row = 2, square = 0  },
                    new CellModel { value = 0, column = 2, row = 2, square = 0  },
                    new CellModel { value = 0, column = 3, row = 2, square = 1  },
                    new CellModel { value = 9, column = 4, row = 2, square = 1  },
                    new CellModel { value = 0, column = 5, row = 2, square = 1  },
                    new CellModel { value = 2, column = 6, row = 2, square = 2  },
                    new CellModel { value = 0, column = 7, row = 2, square = 2  },
                    new CellModel { value = 0, column = 8, row = 2, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 3, square = 3  } ,
                    new CellModel { value = 5, column = 1, row = 3, square = 3  },
                    new CellModel { value = 0, column = 2, row = 3, square = 3  },
                    new CellModel { value = 0, column = 3, row = 3, square = 4  },
                    new CellModel { value = 0, column = 4, row = 3, square = 4 },
                    new CellModel { value = 7, column = 5, row = 3, square = 4  },
                    new CellModel { value = 0, column = 6, row = 3, square = 5  },
                    new CellModel { value = 0, column = 7, row = 3, square = 5  },
                    new CellModel { value = 0, column = 8, row = 3, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 4, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 4, square = 3  },
                    new CellModel { value = 0, column = 2, row = 4, square = 3  },
                    new CellModel { value = 0, column = 3, row = 4, square = 4  },
                    new CellModel { value = 4, column = 4, row = 4, square = 4  },
                    new CellModel { value = 5, column = 5, row = 4, square = 4  },
                    new CellModel { value = 7, column = 6, row = 4, square = 5  },
                    new CellModel { value = 0, column = 7, row = 4, square = 5  },
                    new CellModel { value = 0, column = 8, row = 4, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 5, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 5, square = 3  },
                    new CellModel { value = 0, column = 2, row = 5, square = 3  },
                    new CellModel { value = 1, column = 3, row = 5, square = 4  },
                    new CellModel { value = 0, column = 4, row = 5, square = 4  },
                    new CellModel { value = 0, column = 5, row = 5, square = 4  },
                    new CellModel { value = 0, column = 6, row = 5, square = 5  },
                    new CellModel { value = 3, column = 7, row = 5, square = 5  },
                    new CellModel { value = 0, column = 8, row = 5, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 6, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 6, square = 6  },
                    new CellModel { value = 1, column = 2, row = 6, square = 6  },
                    new CellModel { value = 0, column = 3, row = 6, square = 7  },
                    new CellModel { value = 0, column = 4, row = 6, square = 7  },
                    new CellModel { value = 0, column = 5, row = 6, square = 7  },
                    new CellModel { value = 0, column = 6, row = 6, square = 8  },
                    new CellModel { value = 6, column = 7, row = 6, square = 8  },
                    new CellModel { value = 8, column = 8, row = 6, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 7, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 7, square = 6  },
                    new CellModel { value = 8, column = 2, row = 7, square = 6  },
                    new CellModel { value = 5, column = 3, row = 7, square = 7  },
                    new CellModel { value = 0, column = 4, row = 7, square = 7  },
                    new CellModel { value = 0, column = 5, row = 7, square = 7  },
                    new CellModel { value = 0, column = 6, row = 7, square = 8  },
                    new CellModel { value = 1, column = 7, row = 7, square = 8  },
                    new CellModel { value = 0, column = 8, row = 7, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 8, square = 6  } ,
                    new CellModel { value = 9, column = 1, row = 8, square = 6  },
                    new CellModel { value = 0, column = 2, row = 8, square = 6  },
                    new CellModel { value = 0, column = 3, row = 8, square = 7  },
                    new CellModel { value = 0, column = 4, row = 8, square = 7  },
                    new CellModel { value = 0, column = 5, row = 8, square = 7  },
                    new CellModel { value = 4, column = 6, row = 8, square = 8  },
                    new CellModel { value = 0, column = 7, row = 8, square = 8  },
                    new CellModel { value = 0, column = 8, row = 8, square = 8  },
                } }

            };
        }


        public void InitializeLogicalBoard()
        {
            Sudoku = new SudokuModel()
            {
                Sudoku = new List<List<CellModel>>()
            {
                new List<CellModel>
                {
                    new CellModel { value = 5, column = 0, row = 0, square = 0  } ,
                    new CellModel { value = 3, column = 1, row = 0, square = 0  },
                    new CellModel { value = 0, column = 2, row = 0, square = 0  },
                    new CellModel { value = 0, column = 3, row = 0, square = 1  },
                    new CellModel { value = 7, column = 4, row = 0, square = 1  },
                    new CellModel { value = 0, column = 5, row = 0, square = 1  },
                    new CellModel { value = 0, column = 6, row = 0, square = 2  },
                    new CellModel { value = 0, column = 7, row = 0, square = 2  },
                    new CellModel { value = 0, column = 8, row = 0, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 6, column = 0, row = 1, square = 0  } ,
                    new CellModel { value = 0, column = 1, row = 1, square = 0  },
                    new CellModel { value = 0, column = 2, row = 1, square = 0  },
                    new CellModel { value = 1, column = 3, row = 1, square = 1  },
                    new CellModel { value = 9, column = 4, row = 1, square = 1  },
                    new CellModel { value = 5, column = 5, row = 1, square = 1  },
                    new CellModel { value = 0, column = 6, row = 1, square = 2  },
                    new CellModel { value = 0, column = 7, row = 1, square = 2  },
                    new CellModel { value = 0, column = 8, row = 1, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 2, square = 0  } ,
                    new CellModel { value = 9, column = 1, row = 2, square = 0  },
                    new CellModel { value = 8, column = 2, row = 2, square = 0  },
                    new CellModel { value = 0, column = 3, row = 2, square = 1  },
                    new CellModel { value = 0, column = 4, row = 2, square = 1  },
                    new CellModel { value = 0, column = 5, row = 2, square = 1  },
                    new CellModel { value = 0, column = 6, row = 2, square = 2  },
                    new CellModel { value = 6, column = 7, row = 2, square = 2  },
                    new CellModel { value = 0, column = 8, row = 2, square = 2  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 8, column = 0, row = 3, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 3, square = 3  },
                    new CellModel { value = 0, column = 2, row = 3, square = 3  },
                    new CellModel { value = 0, column = 3, row = 3, square = 4  },
                    new CellModel { value = 6, column = 4, row = 3, square = 4 },
                    new CellModel { value = 0, column = 5, row = 3, square = 4  },
                    new CellModel { value = 0, column = 6, row = 3, square = 5  },
                    new CellModel { value = 0, column = 7, row = 3, square = 5  },
                    new CellModel { value = 3, column = 8, row = 3, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 4, column = 0, row = 4, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 4, square = 3  },
                    new CellModel { value = 0, column = 2, row = 4, square = 3  },
                    new CellModel { value = 8, column = 3, row = 4, square = 4  },
                    new CellModel { value = 0, column = 4, row = 4, square = 4  },
                    new CellModel { value = 3, column = 5, row = 4, square = 4  },
                    new CellModel { value = 0, column = 6, row = 4, square = 5  },
                    new CellModel { value = 0, column = 7, row = 4, square = 5  },
                    new CellModel { value = 1, column = 8, row = 4, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 7, column = 0, row = 5, square = 3  } ,
                    new CellModel { value = 0, column = 1, row = 5, square = 3  },
                    new CellModel { value = 0, column = 2, row = 5, square = 3  },
                    new CellModel { value = 0, column = 3, row = 5, square = 4  },
                    new CellModel { value = 2, column = 4, row = 5, square = 4  },
                    new CellModel { value = 0, column = 5, row = 5, square = 4  },
                    new CellModel { value = 0, column = 6, row = 5, square = 5  },
                    new CellModel { value = 0, column = 7, row = 5, square = 5  },
                    new CellModel { value = 6, column = 8, row = 5, square = 5  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 6, square = 6  } ,
                    new CellModel { value = 6, column = 1, row = 6, square = 6  },
                    new CellModel { value = 0, column = 2, row = 6, square = 6  },
                    new CellModel { value = 0, column = 3, row = 6, square = 7  },
                    new CellModel { value = 0, column = 4, row = 6, square = 7  },
                    new CellModel { value = 0, column = 5, row = 6, square = 7  },
                    new CellModel { value = 2, column = 6, row = 6, square = 8  },
                    new CellModel { value = 8, column = 7, row = 6, square = 8  },
                    new CellModel { value = 0, column = 8, row = 6, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 7, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 7, square = 6  },
                    new CellModel { value = 0, column = 2, row = 7, square = 6  },
                    new CellModel { value = 4, column = 3, row = 7, square = 7  },
                    new CellModel { value = 1, column = 4, row = 7, square = 7  },
                    new CellModel { value = 9, column = 5, row = 7, square = 7  },
                    new CellModel { value = 0, column = 6, row = 7, square = 8  },
                    new CellModel { value = 0, column = 7, row = 7, square = 8  },
                    new CellModel { value = 5, column = 8, row = 7, square = 8  },
                },
                new List<CellModel>
                {
                    new CellModel { value = 0, column = 0, row = 8, square = 6  } ,
                    new CellModel { value = 0, column = 1, row = 8, square = 6  },
                    new CellModel { value = 0, column = 2, row = 8, square = 6  },
                    new CellModel { value = 0, column = 3, row = 8, square = 7  },
                    new CellModel { value = 8, column = 4, row = 8, square = 7  },
                    new CellModel { value = 0, column = 5, row = 8, square = 7  },
                    new CellModel { value = 0, column = 6, row = 8, square = 8  },
                    new CellModel { value = 7, column = 7, row = 8, square = 8  },
                    new CellModel { value = 9, column = 8, row = 8, square = 8  },
                } }

            };
        }

    }
}
