namespace Design_Patterns.Structural.Adapter
{
    public interface ILegacyCustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string Flat { get; set; }
    }
}
