namespace design_patterns.Structural.Bridge
{
    public interface IRemoteController
    {
        void VolumeUp();
        void VolumeDown();
        void ChannelUp();
        void ChannelDown();
        void SwithOn();
        void SwithOff();
        void ChangeChannel(int number);
    }
}
