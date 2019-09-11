
namespace PatternsOfDesign.Builder.Cars
{
    class CarBuilder:IBuilder
    {
        private readonly Car _car;
        public CarBuilder()
        {
            _car= new Car();
        }
        public void Reset()
        {
            _car.Reset();
        }

        public void SetSeats(int count)
        {
            _car.SetSeats(count);
        }

        public void SetEngine(double capacity)
        {
            _car.SetEngine(capacity);
        }

        public void SetGps()
        {
            _car.SetGps();
        }

        public void SetMonitor()
        {
            _car.SetMonitor();
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}
