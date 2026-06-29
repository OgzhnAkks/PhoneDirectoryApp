using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Entity.Services.Models.Dto
{
    public class UpdateContactInfoDto
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public string? Location { get; set; }
    }
}
