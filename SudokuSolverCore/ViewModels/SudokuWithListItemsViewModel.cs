using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuSolverCore.ViewModels
{
    public class SudokuWithListItemsViewModel
    {
        public SudokuModel Model { get; set; }
        public IEnumerable<string> DropDownOptions { get; set; }
    }
}
