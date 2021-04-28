using System.Windows;

namespace Chapter_10_Sloppy_Joe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MenuMaker menuMaker = new MenuMaker();
        
        public MainWindow()
        {
            InitializeComponent();
            mainGrid.DataContext = menuMaker;
        }

        private void newMenu_Click(object sender, RoutedEventArgs e)
        {
            menuMaker.UpdateMenu();
        }
    }
}
