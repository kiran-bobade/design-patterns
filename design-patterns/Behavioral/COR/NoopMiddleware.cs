namespace Design_Patterns.Behavioral.COR
{
    internal class NoopMiddleware : Middleware
    {
        public override IMiddleware? Handle(IRequest request) => null;
    }
}
