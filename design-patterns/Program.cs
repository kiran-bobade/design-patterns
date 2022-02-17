using design_patterns.Behavioral.TemplateMethod;
using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Decorator;


Console.WriteLine("Adapter Example:");
Console.WriteLine("-----------------------");
IAdapter<ICustomer> adapter = new CustomerAdapter(LegacyApi.GetCustomer());
ICustomer customer = adapter.Adapt();
Console.WriteLine($"{customer}");

Console.WriteLine("Decorator Example:");
Console.WriteLine("-----------------------");
Notifier notifier = new EmailNotifier("kiranbobde2607@gmail.com");
notifier = new SmsNotifier(notifier, "9503678957");
notifier.Send();

Console.WriteLine();
Console.WriteLine("Template Method Example:");
Console.WriteLine("-----------------------");
Component userDetails = new UserDetailComponent();
userDetails.Render();

Console.ReadLine();
