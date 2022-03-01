namespace Design_Patterns.Behavioral.COR
{
    public interface IMiddleware
    {
        IMiddleware Handle(IRequest request);
    }
}
