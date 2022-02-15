using System.Text;

namespace Design_Patterns.Structural.Adapter
{
    public class Customer : ICustomer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Contact? Contact { get; set; }
        public Address? Address { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"\t{FirstName} {LastName}");
            sb.AppendLine($"\tPhone: {Contact?.Phone}");
            sb.AppendLine($"\tEmail: {Contact?.Email}");
            sb.AppendLine($"\tFlat: {Address?.Flat}");
            sb.AppendLine($"\tAddressLine1: {Address?.AddressLine1}");
            sb.AppendLine($"\tAddressLine2: {Address?.AddressLine2}");
            return sb.ToString();
        }
    }
}
