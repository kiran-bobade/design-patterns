namespace Design_Patterns.Creational.FactoryMethod
{
    public class DocumentStore : AbstractDocumentStore
    {
        protected override IDocument GenerateDocument<T>()
        {
            Console.WriteLine($"Generating document of tyepe: {typeof(T).Name}");
            return new T();
        }
    }
}
