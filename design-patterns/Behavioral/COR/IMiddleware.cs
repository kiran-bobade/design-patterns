namespace design_patterns.Behavioral.COR
{
    public interface IMiddleware
    {
        IMiddleware Handle(IRequest request);
    }
}
