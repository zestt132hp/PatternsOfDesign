
namespace PatternsOfDesign.structure_patterns.Bridge.Devices
{
    class Tv:IDevice
    {
        private bool _enabled;
        private int _channel;
        private int _volume;

        public bool IsEnabled() => _enabled;

        public void Enable() => _enabled = true;

        public void Disable() => _enabled = false;

        public int GetVolume() => _volume;

        public void SetVolume(int percent) => _volume = percent;


        public int GetChannel() => _channel;

        public void SetChanel(int channel) => _channel = channel;
    }
}
