using System;
using System.Windows.Input;

namespace Warehouse.Core
{
    public class ReplayCommand : ICommand
    {
        #region Fields
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        #endregion

        #region Ctor
        public ReplayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute; 
        }
        #endregion

        #region Methods
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
        #endregion
    }
}
