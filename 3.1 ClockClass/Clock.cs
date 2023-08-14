using System;


namespace ClockClass
{
    public class Clock
    {

        private Counter _seconds;
        private Counter _minuties;
        private Counter _hours;

        public Clock()
        {
            _seconds = new Counter("seconds");
            _minuties = new Counter("minutes");
            _hours = new Counter("hours");


        }
        public void Ticks()
        {
            _seconds.Increment();
            if (_seconds.Ticks > 59)
            {
                _seconds.Reset();
                _minuties.Increment();
                if (_minuties.Ticks > 59)
                {
                    _minuties.Reset();
                    _hours.Increment();
                    if (_hours.Ticks > 23)
                    {

                        Reset();
                    }
                }
            }
        }
        public void Reset()
        {
            _hours.Reset();
            _minuties.Reset();
            _seconds.Reset();

        }
        public string GetTime()
        {
            string sec = _seconds.Ticks.ToString("D2");
            string min = _minuties.Ticks.ToString("D2");
            string hours = _hours.Ticks.ToString("D2");
            return hours + ":" + min + ":" + sec;
        }
    }
}
