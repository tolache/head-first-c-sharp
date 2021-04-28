using System;
using System.ComponentModel;
using System.Windows.Threading;
using Stopwatch.Model;

namespace Stopwatch.ViewModel
{
    public class StopwatchViewModel : INotifyPropertyChanged
    {
        private static StopwatchModel _stopwatchModel = new StopwatchModel();
        private DispatcherTimer _timer = new DispatcherTimer();
        private bool _lastRunning;
        private int _lastHours;
        private int _lastMinutes;
        private decimal _lastSeconds;
        private int _lastLapHours;
        private int _lastLapMinutes;
        private decimal _lastLapSeconds;

        public bool Running => _stopwatchModel.Running; 
        public int Hours => _stopwatchModel.Elapsed?.Hours ?? 0;
        public int Minutes => _stopwatchModel.Elapsed?.Minutes ?? 0;
        public decimal Seconds => _stopwatchModel.Elapsed?.Seconds + _stopwatchModel.Elapsed?.Milliseconds * 0.001M ?? 0;
        public int LapHours => _stopwatchModel.LapTime?.Hours ?? 0;
        public int LapMinutes => _stopwatchModel.LapTime?.Minutes ?? 0;
        public decimal LapSeconds => _stopwatchModel.LapTime?.Seconds + _stopwatchModel.LapTime?.Milliseconds * 0.001M ?? 0;

        public StopwatchViewModel()
        {
            _timer.Interval = TimeSpan.FromMilliseconds(50);
            _timer.Tick += TimerTick;
            _timer.Start();

            _stopwatchModel.LapTimeUpdated += OnLapTimeUpdated;
        }

        public void Start()
        {
            _stopwatchModel.Start();
        }

        public void Stop()
        {
            _stopwatchModel.Stop();
        }

        public void Reset()
        {
            bool running = Running;
            _stopwatchModel.Reset();
            if (running)
            {
                _stopwatchModel.Start();
            }
        }

        public void Lap()
        {
            _stopwatchModel.Lap();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private void TimerTick(object sender, EventArgs e)
        {
            if (_lastRunning != Running)
            {
                _lastRunning = Running;
                OnPropertyChanged("Running");
            }
            
            if (_lastHours != Hours)
            {
                _lastHours = Hours;
                OnPropertyChanged("Hours");
            }
            if (_lastMinutes != Minutes)
            {
                _lastMinutes = Minutes;
                OnPropertyChanged("Minutes");
            }
            if (_lastSeconds != Seconds)
            {
                _lastSeconds = Seconds;
                OnPropertyChanged("Seconds");
            }
        }

        private void OnLapTimeUpdated(object sender, LapEventArgs e)
        {
            if (_lastLapHours != LapHours)
            {
                _lastLapHours = LapHours;
                OnPropertyChanged("LapHours");
            }
            if (_lastLapMinutes != LapMinutes)
            {
                _lastLapMinutes = LapMinutes;
                OnPropertyChanged("LapMinutes");
            }
            if (_lastLapSeconds != LapSeconds)
            {
                _lastLapSeconds = LapSeconds;
                OnPropertyChanged("LapSeconds");
            }
        }
    }
}