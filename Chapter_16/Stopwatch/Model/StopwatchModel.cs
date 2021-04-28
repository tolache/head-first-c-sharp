using System;

namespace Stopwatch.Model
{
    public class StopwatchModel
    {
        private DateTime? _started;
        private TimeSpan? _previousElapsed;

        public bool Running => _started.HasValue;
        public TimeSpan? LapTime { get; private set; }

        public TimeSpan? Elapsed
        {
            get
            {
                if (!Running)
                {
                    return _previousElapsed;
                }

                if (_previousElapsed.HasValue)
                {
                    return CalculateTimeElapsedSinceStarted() + _previousElapsed;
                }

                return CalculateTimeElapsedSinceStarted();
            }
        }

        public StopwatchModel()
        {
            Reset();
        }

        public void Start()
        {
            _started = DateTime.Now;
            _previousElapsed ??= TimeSpan.Zero;
        }

        public void Stop()
        {
            if (_started.HasValue)
            {
                _previousElapsed += DateTime.Now - _started;
            }

            _started = null;
        }

        public void Reset()
        {
            _previousElapsed = null;
            _started = null;
            LapTime = null;
        }

        public void Lap()
        {
            LapTime = Elapsed;
            OnLapTimeUpdated(LapTime);
        }

        public event EventHandler<LapEventArgs> LapTimeUpdated; 

        private void OnLapTimeUpdated(TimeSpan? lapTime)
        {
            EventHandler<LapEventArgs> lapTimeUpdated = LapTimeUpdated;
            lapTimeUpdated?.Invoke(this, new LapEventArgs(lapTime));
        }

        private TimeSpan CalculateTimeElapsedSinceStarted()
        {
            if (_started.HasValue) return DateTime.Now - _started.Value;
            return TimeSpan.Zero;
        }
    }
}