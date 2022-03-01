namespace Design_Patterns.Behavioral.COR
{
    public interface IRequest
    {
        Dictionary<string, string> Headers { get; set; }
        Dictionary<string, string> Params { get; set; }
    }
}
