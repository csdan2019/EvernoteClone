﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class BoldCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public NotesVM VM { get; set; }
        public BoldCommand(NotesVM vm)
        {
            VM= vm;
        }
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
