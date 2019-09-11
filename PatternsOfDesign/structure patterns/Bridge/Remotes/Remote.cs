
using PatternsOfDesign.structure_patterns.Bridge.Devices;

namespace PatternsOfDesign.structure_patterns.Bridge.Remotes
{
    class Remote
    {
        private readonly IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TooglePower()
        {
            if (!_device.IsEnabled())
            {
                _device.Enable();
            }
            else
            {
                _device.Disable();
            }
        }

        public void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        public void ChannelDown()
        {
            _device.SetChanel(_device.GetChannel() - 1);
        }

        public void ChannelUp()
        {

            _device.SetChanel(_device.GetChannel() + 1);
        }
    }
}
