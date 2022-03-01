namespace design_patterns.Behavioral.COR
{
    internal class CorsMiddleware : Middleware
    {
        public override IMiddleware Handle(IRequest request)
        {
            Console.WriteLine("CORS Middleware Handler START");

            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("AllowOrigin", "*");

            Console.WriteLine(request.ToString());

            Console.WriteLine("CORS Middleware Handler END");

            return NextHandler ?? new NoopMiddleware();
        }
    }
}