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

namespace RockPaperScissors
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RockPaperScissorButton(object sender, RoutedEventArgs e)
        {
            string playersChoice = null;

            if (sender == Rock)
                playersChoice = "Rock";
            if (sender == Paper)
                playersChoice = "Paper";
            if (sender == Scissors)
                playersChoice = "Scissors";

            if (ResultPlayer.Content.ToString() == "0")
            {
                ResultPlayer.Content = $"-";
            }
            else
            {
                ResultPlayer.Content = $"{ResultPlayer.Content}{playersChoice}";
            }
        }

        private void ResetButton(object sender, RoutedEventArgs e)
        {
            //foo
        }
    }
}
