
namespace PatternsOfDesign.Builder
{
    interface IBuilder
    {
        void Reset();
        void SetSeats(int count);
        void SetEngine(double capacity);
        void SetGps();
        void SetMonitor();
    }
}
