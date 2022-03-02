namespace Design_Patterns.Creational.FactoryMethod
{
    public interface IDocument
    {
        string Name { get; set; }
        string Description { get; set; }
        List<string> LineItems { get; set; }
        void Print();
    }
}
