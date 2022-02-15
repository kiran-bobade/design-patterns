namespace Design_Patterns.Structural.Adapter
{
    public interface IAdapter<T>
    {
        T Adapt();
    }
    public class CustomerAdapter : IAdapter<ICustomer>
    {
        private readonly ILegacyCustomer legacyCustomer;

        public CustomerAdapter(ILegacyCustomer legacyCustomer)
        {
            this.legacyCustomer = legacyCustomer;
        }
        public ICustomer Adapt()
        {
            return new Customer()
            {
                FirstName = legacyCustomer.FirstName,
                LastName = legacyCustomer.LastName,
                Contact = new Contact
                {
                    Email = legacyCustomer.Email,
                    Phone = legacyCustomer.Phone,
                },
                Address = new Address
                {
                    AddressLine1 = legacyCustomer.AddressLine1,
                    AddressLine2 = legacyCustomer.AddressLine2,
                    Flat = legacyCustomer.Flat,
                }
            };
        }
    }
}
