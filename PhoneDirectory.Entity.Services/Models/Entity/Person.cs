using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneDirectory.Entity.Services.Models.Entity
{
    [Table("Person", Schema = "person")]
    public class Person : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Firm { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public ICollection<ContactInfo> ContactInfos { get; set; } = new List<ContactInfo>();
    }
}
