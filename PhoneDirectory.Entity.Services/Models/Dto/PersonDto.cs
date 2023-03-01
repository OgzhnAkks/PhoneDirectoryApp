using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.Entity.Services.Models.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Firm { get; set; } = string.Empty;
        public short Active { get; set; }
        public ContactInfo? ContactInfo { get; set; }
    }
}
