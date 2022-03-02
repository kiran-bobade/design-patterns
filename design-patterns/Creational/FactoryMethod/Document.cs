namespace Design_Patterns.Creational.FactoryMethod
{
    public abstract class Document : IDocument
    {
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> LineItems { get; set; } = new List<string>();

        protected Document(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Document: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Itmes:");
            foreach (var item in LineItems)
            {
                Console.WriteLine($"{item}");
            }
        }
    }


    public class Invoice : Document
    {
        public Invoice()
            : base("Invoice")
        {
            Description = "Invoice from 1/1/22 to 28/2/22";
            LineItems.Add("Line item 1");
            LineItems.Add("Line item 2");
            LineItems.Add("Line item 3");
            LineItems.Add("Line item 4");
        }
    }

    public class PurchaseOrder : Document
    {
        public PurchaseOrder()
            : base("Purchase Order")
        {
            Description = "PO# 45622JF5";
            LineItems.Add("Line item 1");
            LineItems.Add("Line item 2");
        }
    }

    public class Estimate : Document
    {
        public Estimate()
            : base("Estimate")
        {
            Description = "Estimate# 464DFG5";
            LineItems.Add("Line item 1");
            LineItems.Add("Line item 2");
            LineItems.Add("Line item 3");
            LineItems.Add("Line item 4");
            LineItems.Add("Line item 5");
        }
    }
}
