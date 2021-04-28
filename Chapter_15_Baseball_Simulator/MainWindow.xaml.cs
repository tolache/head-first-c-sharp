using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chapter_15_Baseball_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseballSimulator baseballSimulator = new BaseballSimulator();
        private List<ListView> listViews;
        
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = baseballSimulator;
            listViews = new List<ListView>() {pitcherSaysBox, fanSaysBox};
        }

        private void playBall_OnClick(object sender, RoutedEventArgs e)
        {
            baseballSimulator.PlayBall();
            ScrollListBoxes();
        }

        private void ScrollListBoxes()
        {
            foreach (ListView listView in listViews)
            {
                if (VisualTreeHelper.GetChildrenCount(listView) > 0)
                {
                    Border border = (Border)VisualTreeHelper.GetChild(listView, 0);
                    ScrollViewer scrollViewer = (ScrollViewer)VisualTreeHelper.GetChild(border, 0);
                    scrollViewer.ScrollToBottom();
                }   
            }
        }
    }
}
