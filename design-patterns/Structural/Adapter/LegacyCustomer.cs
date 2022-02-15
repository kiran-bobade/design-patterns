namespace Design_Patterns.Structural.Adapter
{
    public class LegacyCustomer : ILegacyCustomer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Flat { get; set; }
    }
}
