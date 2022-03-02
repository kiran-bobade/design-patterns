using Design_Patterns.Behavioral.COR;
using Design_Patterns.Behavioral.TemplateMethod;
using Design_Patterns.Creational.FactoryMethod;
using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Decorator;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTitle("Adapter");
            IAdapter<ICustomer> adapter = new CustomerAdapter(LegacyApi.GetCustomer());
            ICustomer customer = adapter.Adapt();
            Console.WriteLine($"{customer}");

            ShowTitle("Decorator");
            Notifier notifier = new EmailNotifier("kiranbobde2607@gmail.com");
            notifier = new SmsNotifier(notifier, "9503678957");
            notifier.Send();

            ShowTitle("Template Method");
            Component userDetails = new UserDetailComponent();
            userDetails.Render();

            ShowTitle("Chain of Responsibility");
            Pipeline pipeline = new Pipeline();
            pipeline.Use(new CorsMiddleware());
            pipeline.Use(new AuthenticationMiddleware());
            pipeline.Execute();

            ShowTitle("Factory Method");
            var documentStore = new DocumentStore();
            var invoice  = documentStore.GetDocument<Invoice>();
            invoice.Print();
            var estimate = documentStore.GetDocument<Estimate>();
            estimate.Print();


            Console.ReadLine();
        }

        static void ShowTitle(string Title)
        {
            Console.WriteLine();
            Console.WriteLine($"{Title} Example:");
            Console.WriteLine("-----------------------");
        }
    }
}





