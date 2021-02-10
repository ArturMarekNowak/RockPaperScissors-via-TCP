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
using RockPaperScissorsTCP.Commands;
using System.Diagnostics;


namespace RockPaperScissorsTCP.ViewModel
{
    public class GameViewModel
    {
        private Game _game;

        ///<summary>
        /// Initializes new instance of Game class
        ///</summary>
        public GameViewModel() {
            _game = new Game(127, 0, 0, 1, 8080);
            ResetCommand = new ResetGameCommand(this);
            RockPaperScissorsCommand = new RockPaperScissorsCommand(this);
            
        }

        public Game Game
        {
            get
            {
                return _game;
            }
        }

        ////////////////////////RESET BUTTON////////////////////////

        /// <summary>
        /// Gets the Reset Command for ViewModel 
        /// </summary>
        public ICommand ResetCommand
        {
            get;
            private set;
        }

        //TO DO!!!!!!!!!!!!!!!
        public bool CanReset
        {
            get
            {
                if (Game == null)
                {
                    return false;
                }
                return true;
                //return !String.IsNullOrWhiteSpace(Game.lastResult);
            }
        }

        /// <summary>
        /// Saves changes
        /// </summary>
        public void SaveResetChanges()
        {
            Game.scoreAI = 0;
            Game.scorePlayer = 0;
            Game.lastResult = "-";
            //Debug.Assert(false, String.Format("{0} was updated", Game.scoreAI.ToString()));
        }


        ////////////////////////RSP BUTTON////////////////////////

        /// <summary>
        /// Gets the Reset Command for ViewModel 
        /// </summary>
        public ICommand RockPaperScissorsCommand
        {
            get;
            private set;
        }

        public bool CanRockPaperScissors
        {
            get
            {
                if (Game == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Saves changes
        /// </summary>
        public void SaveRSPButtonChanges(object parameter)
        {
            //Deug purposes
            //Console.WriteLine(parameter.ToString());

            switch(parameter.ToString())
            {
                case "Rock":
                    Game.playersChoice = "Rock";
                    break;
                case "Paper":
                    Game.playersChoice = "Paper";
                    break;
                case "Scissors":
                    Game.playersChoice = "Scissors";
                    break;
            }
        }
    }
}
