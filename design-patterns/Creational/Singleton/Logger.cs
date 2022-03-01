namespace Design_Patterns.Creational.Singleton
{
    public sealed class Logger
    {
        private Logger()
        {

        }

        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());


        public static Logger Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }
}
