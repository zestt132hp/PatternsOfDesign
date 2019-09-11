
namespace PatternsOfDesign.structure_patterns.Bridge.Devices
{
    class Radio:IDevice
    {
        private bool _enabled;
        private int _volume;
        private int _channel;
        public bool IsEnabled()
        {
            return _enabled;
        }

        public Radio()
        {
            _enabled = true;
            _volume = 15;
            _channel = 1;

        }
        public void Enable() => _enabled = true;

        public void Disable() => _enabled = false;

        public int GetVolume() => _volume;


        public void SetVolume(int percent) => _volume = percent;

        public int GetChannel() => _channel;

        public void SetChanel(int channel) => _channel = channel;
    }
}
