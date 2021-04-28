using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using Stopwatch.ViewModel;


namespace Stopwatch.View
{
    public partial class AnalogStopwatch : UserControl
    {
        private StopwatchViewModel _viewModel;
        
        public AnalogStopwatch()
        {
            InitializeComponent();
            _viewModel = FindResource("ViewModel") as StopwatchViewModel;
            AddMarkings();
            AddHands();
        }

        private void AddMarkings()
        {
            for (int i = 0; i < 360; i += 6)
            {
                Rectangle rectangle = new Rectangle
                {
                    Width = (i % 30 == 0) ? 3 : 1,
                    Height = 15,
                    Fill = new SolidColorBrush(Colors.Black),
                    RenderTransformOrigin = new Point(0.5, 0.5)
                };

                TransformGroup transforms = new TransformGroup();
                transforms.Children.Add(new TranslateTransform() {Y = -140});
                transforms.Children.Add(new RotateTransform() {Angle = i});
                rectangle.RenderTransform = transforms;
                baseGrid.Children.Add(rectangle);
            }
        }

        private void AddHands()
        {
            baseGrid.Children.Add(CreateSecondHand());
            baseGrid.Children.Add(CreateMinuteHand());
            baseGrid.Children.Add(CreateLapSecondHand());
            baseGrid.Children.Add(CreateLapMinuteHand());
        }

        private Rectangle CreateSecondHand()
        {
            Rectangle secondHand = new Rectangle
            {
                Width = 2,
                Height = 150,
                Fill = Brushes.Black,
                RenderTransformOrigin = new Point(0.5, 0.5),
            };
            Panel.SetZIndex(secondHand, 1);
            TransformGroup transforms = new TransformGroup();
            transforms.Children.Add(new TranslateTransform(0, -60));
            
            RotateTransform rotateTransform = new RotateTransform();
            Binding angleBinding = new Binding(nameof(_viewModel.Seconds))
            {
                Source = _viewModel,
                Converter = new AngleConverter(),
                ConverterParameter = nameof(_viewModel.Seconds),
            };
            BindingOperations.SetBinding(rotateTransform, RotateTransform.AngleProperty, angleBinding);
            
            transforms.Children.Add(rotateTransform);
            secondHand.RenderTransform = transforms;

            return secondHand;
        }

        private Rectangle CreateMinuteHand()
        {
            Rectangle minuteHand = new Rectangle
            {
                Width = 4,
                Height = 100,
                Fill = Brushes.Black,
                RenderTransformOrigin = new Point(0.5, 0.5),
            };
            Panel.SetZIndex(minuteHand, 1);
            TransformGroup transforms = new TransformGroup();
            transforms.Children.Add(new TranslateTransform(0, -50));
            
            RotateTransform rotateTransform = new RotateTransform();
            Binding angleBinding = new Binding(nameof(_viewModel.Minutes))
            {
                Source = _viewModel,
                Converter = new AngleConverter(),
                ConverterParameter = nameof(_viewModel.Minutes),
            };
            BindingOperations.SetBinding(rotateTransform, RotateTransform.AngleProperty, angleBinding);
            
            transforms.Children.Add(rotateTransform);
            minuteHand.RenderTransform = transforms;

            return minuteHand;
        }

        private Rectangle CreateLapSecondHand()
        {
            Rectangle lapSecondHand = new Rectangle()
            {
                Width = 2,
                Height = 150,
                Fill = Brushes.Yellow,
                RenderTransformOrigin = new Point(0.5,0.5),
            };
            TransformGroup transforms = new TransformGroup();
            transforms.Children.Add(new TranslateTransform(0,-60));
            
            RotateTransform rotateTransform = new RotateTransform();
            Binding angleBinding = new Binding(nameof(_viewModel.LapSeconds))
            {
                Source = _viewModel,
                Converter = new AngleConverter(),
                ConverterParameter = nameof(_viewModel.Seconds),
            };
            BindingOperations.SetBinding(rotateTransform, RotateTransform.AngleProperty, angleBinding);
            
            transforms.Children.Add(rotateTransform);
            lapSecondHand.RenderTransform = transforms;
            
            return lapSecondHand;
        }

        private Rectangle CreateLapMinuteHand()
        {
            Rectangle lapMinuteHand = new Rectangle()
            {
                Width = 4,
                Height = 100,
                Fill = Brushes.Yellow,
                RenderTransformOrigin = new Point(0.5,0.5),
            };
            TransformGroup transforms = new TransformGroup();
            transforms.Children.Add(new TranslateTransform(0,-50));
            
            RotateTransform rotateTransform = new RotateTransform();
            Binding angleBinding = new Binding(nameof(_viewModel.LapMinutes))
            {
                Source = _viewModel,
                Converter = new AngleConverter(),
                ConverterParameter = nameof(_viewModel.Minutes)
            };
            BindingOperations.SetBinding(rotateTransform, RotateTransform.AngleProperty, angleBinding);
            
            transforms.Children.Add(rotateTransform);
            lapMinuteHand.RenderTransform = transforms;

            return lapMinuteHand;
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