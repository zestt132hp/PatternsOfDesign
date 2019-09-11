
namespace PatternsOfDesign.Builder.Manuals
{
    class CarManualBuilder:IBuilder
    {
        private readonly Manual _manual;

        public CarManualBuilder()
        {
            _manual = new Manual();
        }

        public void Reset()
        {
            _manual.Reset();
        }

        public void SetSeats(int count)
        {
            _manual.SetSeats(count);
        }

        public void SetEngine(double capacity)
        {
           _manual.SetEngine();
        }

        public void SetGps()
        {
            _manual.SetGps();
        }

        public void SetMonitor()
        {
            _manual.SetMonitor();
        }

        public Manual GetResult()
        {
            return _manual;
        }
    }
}
