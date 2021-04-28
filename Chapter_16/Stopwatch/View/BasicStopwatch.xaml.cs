using System.Windows;
using System.Windows.Controls;
using Stopwatch.ViewModel;

namespace Stopwatch.View
{
    public partial class BasicStopwatch : UserControl
    {
        private StopwatchViewModel _viewModel;
        
        public BasicStopwatch()
        {
            InitializeComponent();
            _viewModel = FindResource("ViewModel") as StopwatchViewModel;
        }

        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Start();
        }

        private void StopButton_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Stop();
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Reset();
        }

        private void LapButton_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Lap();
        }
    }
}