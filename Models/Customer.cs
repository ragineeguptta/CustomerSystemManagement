namespace CustomerSystemManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Region { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public required string PhoneNumber { get; set; }
        public string Fax { get; set; } = String.Empty;
        public string VATNumber { get; set; } = String.Empty;
    }
}
