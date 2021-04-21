using System;

namespace Assingment
{
    public class Quiz2
    {

        public static void StopWatch()
        {
            private DateTime _startDate;
            private DateTime _endDate;
            private bool _isRunning;

            public void Start()
            {
                if (_isRunning)
                {
                    throw new InvalidOperationException("Stopwatch is already running");
                }
                _startDate = DateTime.Now;
                _isRunning = true;
            }
            
            public void Stop()
            {
                if (!_isRunning)
                {
                    throw new InvalidOperationException("Stopwatch is not running");
                }
                

                _endDate = DateTime.Now;
                _isRunning = false;
            }

            public TimeSpan GetDuration()
            {
                return _endDate - _startDate;
            }

        }
        
    }
}