namespace Design_Patterns.Structural.Decorator
{
    public class EmailNotifier : Notifier
    {
        private string email;

        public EmailNotifier(string email)
        {
            this.email = email;
        }

        public override void Send()
        {
            Console.WriteLine("\tSending Email to: " + email);
        }
    }
}