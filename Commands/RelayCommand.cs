using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_mvvm_first_look.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<object> Execute)
        {
            _execute = Execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
