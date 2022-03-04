namespace design_patterns.Structural.Bridge
{
    public interface ITelevision
    {
        void VolumePlus();
        void VolumeMinus();
        void ChannelPlus();
        void ChannelMinus();
        void ChangeChannel(int channelNumner);
        void TurnOn();
        void TurnOff();
    }
}
