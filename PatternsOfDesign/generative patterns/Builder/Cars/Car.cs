using System;

namespace PatternsOfDesign.Builder.Cars
{
    class Car
    {
        private int _countSeats;
        private bool _gps;
        private bool _monitor;
        private double _engineCapacity;
        private string _color;

        public bool GetGps => _gps;
        public bool GetMonitor => _monitor;
        public Car() { }

        public Car(int engineCapacity, string color)
        {
            if (engineCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(engineCapacity));
            }

            if (string.IsNullOrEmpty(color))
            {
                throw new NullReferenceException(nameof(color));
            }
            _color = color;
        }

        public void SetSeats(int countSeats)
        {
            if(countSeats<1)
                throw new ArgumentOutOfRangeException(nameof(countSeats));
            _countSeats = countSeats;
        }

        public void SetEngine(double engineCapacity)
        {
            if(engineCapacity<1000)
                throw new ArgumentOutOfRangeException(nameof(engineCapacity));
            _engineCapacity = engineCapacity;
        }

        public void SetMonitor()
        {
            _monitor = true;
        }

        public void SetGps()
        {
            _gps = true;
        }

        public void Reset()
        {
            _countSeats = 0;
            _color = "Black";
            _gps = false;
            _monitor = false;
            _engineCapacity = 1000;
        }
    }
}
