﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ItViteaMorseCode
{
    /// <summary>
    /// RelayCommand class with overload. One which allows for methods with parameters and one which handles methods without parameters.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action _executeAction;
        private readonly Action<object> _executeActionObj;

        public RelayCommand(Action action)
        {
            _executeAction = action;
        }

        public RelayCommand(Action<object> action)
        {
            _executeActionObj = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute()
        {
            _executeAction();
        }

        public void Execute(object parameter)
        {
            _executeActionObj(parameter);
        }
    }
}
