
using PatternsOfDesign.structure_patterns.Bridge.Devices;

namespace PatternsOfDesign.structure_patterns.Bridge.Remotes
{
    class AdvancedRemote:Remote
    {
        private readonly IDevice _device;
        public AdvancedRemote(IDevice device) : base(device)
        {
            _device = device;
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}
