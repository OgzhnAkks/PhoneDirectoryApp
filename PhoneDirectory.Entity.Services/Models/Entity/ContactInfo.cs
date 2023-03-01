using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneDirectory.Entity.Services.Models.Entity
{
    [Table("ContactInfo", Schema = "contact")]
    public class ContactInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public char? Location { get; set; }
    }
}
