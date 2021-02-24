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
using RockPaperScissorsTCP.Networking;
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
            _game = new Game(127, 0, 0, 1, 3000);
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

        public bool CanMakeAction
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

            switch (parameter.ToString())
            {
                case "Rock":
                    Game.playersChoice = RoPaSc.Rock;
                    //Console.WriteLine(Game.addresIpV4);
                    break;
                case "Paper":
                    Game.playersChoice = RoPaSc.Paper;
                    break;
                case "Scissors":
                    Game.playersChoice = RoPaSc.Scissors;
                    break;
            }

            string responseFromServer = AsynchronousClient.StartClient(Game.addresIpV4, Game.port);

            if(responseFromServer == "Rock")
                Game.aiChoice = RoPaSc.Rock;
            else if (responseFromServer == "Paper")
                Game.aiChoice = RoPaSc.Paper;
            else if (responseFromServer == "Scissors")
                Game.aiChoice = RoPaSc.Scissors;

            if (Game.playersChoice == Game.aiChoice)
                Game.lastResult = "Draw";
            else if (Game.playersChoice == RoPaSc.Rock && Game.aiChoice == RoPaSc.Paper)
            { 
                Game.lastResult = "AI wins";
                Game.scoreAI += 1;
            }
            else if (Game.playersChoice == RoPaSc.Rock && Game.aiChoice == RoPaSc.Scissors)
            {
                Game.lastResult = "You win";
                Game.scorePlayer += 1;
            }
            else if (Game.playersChoice == RoPaSc.Paper && Game.aiChoice == RoPaSc.Rock)
            {
                Game.lastResult = "You win";
                Game.scorePlayer += 1;
            }
            else if (Game.playersChoice == RoPaSc.Paper && Game.aiChoice == RoPaSc.Scissors)
            {
                Game.lastResult = "AI wins";
                Game.scoreAI += 1;
            }
            else if (Game.playersChoice == RoPaSc.Scissors && Game.aiChoice == RoPaSc.Rock)
            {
                Game.lastResult = "AI wins";
                Game.scoreAI += 1;
            }
            else if (Game.playersChoice == RoPaSc.Scissors && Game.aiChoice == RoPaSc.Paper)
            {
                Game.lastResult = "You win";
                Game.scorePlayer += 1;
            }
        }
    }
}