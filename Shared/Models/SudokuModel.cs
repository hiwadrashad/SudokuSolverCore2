﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class SudokuModel
    {
        public List<List<CellModel>> Sudoku { get; set; }
        public bool FaultyBoard { get; set; }
    }
}
