namespace Design_Patterns.Structural.Decorator
{
    public abstract class NotifierDecorator : Notifier
    {
        protected readonly Notifier notifier;

        public NotifierDecorator(Notifier notifier)
        {
            this.notifier = notifier;
        }
    }

    public class SmsNotifier : NotifierDecorator
    {
        private string phone;

        public SmsNotifier(Notifier notifier, string phoneNumber) : base(notifier)
        {
            phone = phoneNumber;
        }

        public override void Send()
        {
            notifier.Send();
            Console.WriteLine("\tSending SMS to: " + phone);
        }
    }
}