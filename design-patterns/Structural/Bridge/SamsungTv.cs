namespace design_patterns.Structural.Bridge
{
    public class SamsungTv : Television
    {
        public SamsungTv() : base("Samsung Curved+ TV", 4)
        {

        }

        public override void ChangeChannel(int channelNumner)
        {
            try
            {
                base.ChangeChannel(channelNumner);
                CurrentChannel = channelNumner;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void ChannelMinus()
        {
            base.ChannelMinus();
            CurrentChannel--;
        }

        public override void ChannelPlus()
        {
            base.ChannelPlus();
            CurrentChannel++;
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Turning Off {Name}");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Turning On {Name}");
        }

        public override void VolumeMinus()
        {
            CurrentVolume--;
        }

        public override void VolumePlus()
        {
            CurrentVolume++;
        }
    }
}
