namespace design_patterns.Structural.Bridge
{
    public class SamsungRemote : RemoteController
    {
        public SamsungRemote() : base(new SamsungTv())
        {

        }

        public override void ChangeChannel(int number)
        {
            _television.ChangeChannel(number);
        }

        public override void ChannelDown()
        {
            _television.ChannelMinus();
        }

        public override void ChannelUp()
        {
            _television.ChannelPlus();
        }

        public override void SwithOff()
        {
            _television.TurnOff();
        }

        public override void SwithOn()
        {
            _television.TurnOn();
        }

        public override void VolumeDown()
        {
            _television.VolumeMinus();
        }

        public override void VolumeUp()
        {
            _television.VolumeMinus();
        }
    }
}
