using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneDirectory.Entity.Services.Models.Entity
{
    [Table("ContactInfo", Schema = "contact")]
    public class ContactInfo : BaseEntity
    {
        public int PersonId { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public string? Location { get; set; }

        public Person Person { get; set; } = null!;
    }
}
