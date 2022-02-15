using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Adapter
{
    public interface ICustomer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Contact? Contact { get; set; }
        public Address? Address { get; set; }
    }

    public class Contact
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }

    public class Address
    {
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Flat { get; set; }
    }
}
