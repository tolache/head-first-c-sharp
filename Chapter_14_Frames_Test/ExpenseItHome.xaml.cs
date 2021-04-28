using System.Windows;
using System.Windows.Controls;

namespace Chapter_14_Frames_Test
{
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void ViewButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(typeof(ExpenseReportPage));
        }
    }
}