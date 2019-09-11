
namespace PatternsOfDesign.structure_patterns.Bridge.Devices
{
    interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChanel(int channel);
    }
}
