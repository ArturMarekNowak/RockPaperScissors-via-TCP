using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsTCP.ViewModel;
using System.Windows.Input;

namespace RockPaperScissorsTCP.Commands
{
    class RockPaperScissorsCommand : ICommand
    {
        public RockPaperScissorsCommand(GameViewModel gameViewModel)
        {
            _gameViewModel = gameViewModel;
        }

        private GameViewModel _gameViewModel;



        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _gameViewModel.CanRockPaperScissors;
        }

        public void Execute(object parameter)
        {
            _gameViewModel.SaveRSPButtonChanges(parameter);
        }

        #endregion
    }
}
