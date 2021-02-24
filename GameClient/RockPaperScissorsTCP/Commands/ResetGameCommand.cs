using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RockPaperScissorsTCP.ViewModel;

namespace RockPaperScissorsTCP.Commands
{
    class ResetGameCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the ResetGameCommand class
        /// </summary>
        public ResetGameCommand(GameViewModel gameViewModel)
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
            return _gameViewModel.CanMakeAction;
        }

        public void Execute(object parameter)
        {
            _gameViewModel.SaveResetChanges();
        }

        #endregion
    }
}
