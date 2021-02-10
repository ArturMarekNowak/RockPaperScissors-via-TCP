using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RockPaperScissorsTCP.Model
{
    public class Game : INotifyPropertyChanged
    {
        private int _scoreAI = 0;
        private int _scorePlayer = 0;
        private string _lastResult = "-";
        private string _playersChoice = "-";
        private string _aiChoice = "-";
        private string _addresIpV4 = "127.0.0.1";
        private int _port = 3000;
        public int scoreAI
        {
            get
            {
                return _scoreAI;
            }
            set
            {
                _scoreAI = value;
                OnPropertyChanged("scoreAI");
            }
        }
 
        public int scorePlayer
        {
            get
            {
                return _scorePlayer;
            }
            set
            {
                _scorePlayer = value;
                OnPropertyChanged("scorePlayer");
            }
        }

        public string lastResult
        {
            get
            {
                return _lastResult;
            }
            set
            {
                _lastResult = value;
                OnPropertyChanged("lastResult");
            }
        }

        public string playersChoice
        {
            get
            {
                return _playersChoice;
            }
            set
            {
                _playersChoice = value;
                OnPropertyChanged("playersChoice");
            }
        }

        public string aiChoice
        {
            get
            {
                return _aiChoice;
            }
            set
            {
                _aiChoice = value;
                OnPropertyChanged("aiChoice");
            }
        }

        public string addresIpV4
        {
            get
            {
                return _addresIpV4;
            }
            set
            {
                _addresIpV4 = value;
                OnPropertyChanged("addresIpV4");
            }
        }

        public int port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
                OnPropertyChanged("port");
            }
        }

        /// <summary>
        /// Initializes new instance of Game class
        /// </summary>
        public Game(int o1, int o2, int o3, int o4, int port)
        {
            _scoreAI = 0;
            _scorePlayer = 0;
            _lastResult = "-";
            _playersChoice = "-";
            _addresIpV4 = o1.ToString() + "." + o2.ToString() + "." + o3.ToString() + "." + o4.ToString();
            _port = port;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
