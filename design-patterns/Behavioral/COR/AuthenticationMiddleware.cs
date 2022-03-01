namespace Design_Patterns.Behavioral.COR
{
    internal class AuthenticationMiddleware : Middleware
    {
        public override IMiddleware Handle(IRequest request)
        {
            Console.WriteLine("Authentication Middleware Handler START");

            request.Params.Add("Sample", "1");

            Console.WriteLine(request.ToString());

            Console.WriteLine("Authentication Middleware Handler END");
            return NextHandler ?? new NoopMiddleware();
        }
    }
}
