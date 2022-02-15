namespace Design_Patterns.Structural.Adapter
{
    public class CustomerApi
    {
        public ICustomer GetCustomer()
        {
            return new Customer()
            {
                FirstName = "Kiran",
                LastName = "Bobade",
                Contact = new Contact
                {
                    Email = "kiranbobade@gmail.com",
                    Phone = "9503679587",
                },
                Address = new Address
                {
                    Flat = "A604",
                    AddressLine1 = "LINE 1",
                    AddressLine2 = "LINE 2"
                }
            };
        }
    }
}
