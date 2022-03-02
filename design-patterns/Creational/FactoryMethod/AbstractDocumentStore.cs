namespace Design_Patterns.Creational.FactoryMethod
{
    public abstract class AbstractDocumentStore
    {
        public T GetDocument<T>() where T : IDocument, new()
        {
            var document = GenerateDocument<T>();
            return (T)document;
        }

        protected abstract IDocument GenerateDocument<T>() where T : IDocument, new();
    }
}
