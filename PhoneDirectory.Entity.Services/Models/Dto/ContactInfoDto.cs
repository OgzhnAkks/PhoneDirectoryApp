using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.Entity.Services.Models.Dto
{
    public class ContactInfoDto
    {
        public int Id { get; set; }
        public string PhoneNuber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public char? Location { get; set; }
    }
}
