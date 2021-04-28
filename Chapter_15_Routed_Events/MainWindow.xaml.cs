using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Chapter_15_Routed_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> outputItems = new ObservableCollection<string>();
        
        public MainWindow()
        {
            InitializeComponent();
            Output.ItemsSource = outputItems;
        }

        private void Ellipse_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The ellipse was pressed");
            if (EllipseSetsHandled.IsChecked != null && (bool) EllipseSetsHandled.IsChecked) e.Handled = true;
        }

        private void GrayRectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The rectangle was pressed");
            if (RectangleSetsHandled.IsChecked != null && (bool) RectangleSetsHandled.IsChecked) e.Handled = true;
        }

        private void Grid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The grid was pressed");
            if (GridSetsHandled.IsChecked != null && (bool) GridSetsHandled.IsChecked) e.Handled = true;
        }

        private void Border_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The border was pressed");
            if (BorderSetsHandled.IsChecked != null && (bool) BorderSetsHandled.IsChecked) e.Handled = true;
        }

        private void Panel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The stack panel was pressed");
        }

        private void UpdateHitTestVisibleButton_OnClick(object sender, RoutedEventArgs e)
        {
            GrayRectangle.IsHitTestVisible = (bool) NewHitTestVisibleValue.IsChecked;
        }
    }
}
