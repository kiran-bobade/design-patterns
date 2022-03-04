namespace design_patterns.Structural.Bridge
{
    public abstract class RemoteController : IRemoteController
    {
        protected readonly ITelevision _television;
        public RemoteController(ITelevision tv)
        {
            _television = tv;
        }

        public abstract void ChangeChannel(int number);
        public abstract void ChannelDown();
        public abstract void ChannelUp();
        public abstract void SwithOff();
        public abstract void SwithOn();
        public abstract void VolumeDown();
        public abstract void VolumeUp();
    }
}
