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

namespace Chapter_10_Go_Fish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game = new Game();

        public MainWindow()
        {
            InitializeComponent();
            mainGrid.DataContext = game;
        }
        
        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            game.StartGame();
        }

        private void AskForCard_OnClick(object sender, RoutedEventArgs e)
        {
            if (playerHand.SelectedIndex >= 0)
                game.PlayOneRound(playerHand.SelectedIndex);
            else game.PlayOneRound(0);
        }

        private void PlayerHand_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AskForCard_OnClick(sender, e);
        }
    }
}
