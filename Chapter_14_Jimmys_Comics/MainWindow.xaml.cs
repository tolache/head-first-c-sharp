using System.Windows;

namespace Chapter_14_Jimmys_Comics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new MainPage();
        }
    }
}
