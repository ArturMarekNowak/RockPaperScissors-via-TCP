using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RockPaperScissorsTCP.ViewModel;
using RockPaperScissorsTCP.Model;

namespace RockPaperScissorsTCP.View
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new GameViewModel();
        }


        /*
        private void RockPaperScissorsClick(object sender, RoutedEventArgs e)
        {
            if (sender == Rock)
            {
                ResultPlayer.Content = "Rock";
            }
            if (sender == Paper)
                ResultPlayer.Content = "Paper";
            if (sender == Scissors)
                ResultPlayer.Content = "Scissors";
        }
        */

        /*
        private void ResetClick(object sender, RoutedEventArgs e)
        {
            //GameViewModel.Game.scoreAI = 0;
        }
        */
        



    }
}
