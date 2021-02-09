using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RockPaperScissorsTCP.Model;
using System.Diagnostics;


namespace RockPaperScissorsTCP.ViewModel
{
    public class GameViewModel
    {
        private Game _Game;

        ///<summary>
        /// Initializes new instance of Game class
        ///</summary>
        public GameViewModel() {
            _Game = new Game(127, 0, 0, 1, 8080);
        }

        public Game Game
        {
            get
            {
                return _Game;
            }
        }

        /// <summary>
        /// Saves changes
        /// </summary>

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated", Game.scoreAI.ToString()));
        }
    }
}
