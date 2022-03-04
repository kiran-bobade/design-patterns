namespace design_patterns.Structural.Bridge
{
    public abstract class Television : ITelevision
    {
        protected readonly string Name;
        protected readonly int MaxChannelCount = 10;
        protected int CurrentChannel { get; set; } = 0;
        protected int CurrentVolume { get; set; } = 1;
        public Television(string name)
        {
            Name = name;
        }

        public Television(string name, int maxChannelCount)
        {
            Name = name;
            MaxChannelCount = maxChannelCount;
        }
        public virtual void ChangeChannel(int channelNumner)
        {
            if (channelNumner > MaxChannelCount)
            {
                throw new Exception($"Channel# {channelNumner} is not available");
            }
            Console.WriteLine($"Current Channel: {channelNumner}");
        }

        public virtual void ChannelMinus()
        {
            if (CurrentChannel - 1 <= 1)
            {
                CurrentChannel = MaxChannelCount - 1;
            }
            Console.WriteLine($"Current Channel: {CurrentChannel - 1}");
        }
        public virtual void ChannelPlus()
        {
            if (CurrentChannel + 1 > MaxChannelCount)
            {
                CurrentChannel = 0;
            }
            Console.WriteLine($"Current Channel: {CurrentChannel + 1}");
        }
        public abstract void TurnOff();
        public abstract void TurnOn();
        public abstract void VolumeMinus();
        public abstract void VolumePlus();

    }
}
