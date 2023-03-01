using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneDirectory.Entity.Services.Models.Entity
{
    [Table("Person", Schema = "person")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Firm { get; set; } = string.Empty;
        public ContactInfo? ContactInfo { get; set; }
    }
}
