namespace Design_Patterns.Structural.Adapter
{
    public class LegacyApi
    {
        public static ILegacyCustomer GetCustomer()
        {
            return new LegacyCustomer()
            {
                FirstName = "Kiran",
                LastName = "Bobade",
                Email = "kiranbobade@gmail.com",
                Phone = "9503679587",
                Flat = "A604",
                AddressLine1 = "LINE 1",
                AddressLine2 = "LINE 2"
            };
        }
    }
}
