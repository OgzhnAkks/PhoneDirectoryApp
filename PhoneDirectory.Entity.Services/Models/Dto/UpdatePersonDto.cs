using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Entity.Services.Models.Dto
{
    public class UpdatePersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Firm { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
