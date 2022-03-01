namespace design_patterns.Behavioral.COR
{
    public abstract class Middleware: IMiddleware
    {
        protected IMiddleware? NextHandler = null;
        public abstract IMiddleware Handle(IRequest request);
        public void SetNextHandler(IMiddleware handler)
        {
            NextHandler = handler;
        }
    }
}
