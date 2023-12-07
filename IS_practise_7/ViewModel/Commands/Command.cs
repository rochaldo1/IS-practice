using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IS_practise_7.ViewModel.Commands
{
    class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action action;
        public Command(Action action) 
        {
            this.action = action;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }


        //private Command(EventHandler? eventHandler) => CanExecuteChanged += eventHandler;

        //public static Command CreateEvent(EventHandler? eventHandler) => new(eventHandler);
        //public bool CanExecute(object? parameter)
        //{
        //    return CanExecute == null || CanExecute(parameter);
        //}

        //public void Execute(object? parameter)
        //{
        //    Execute(parameter);
        //}
    }
}
