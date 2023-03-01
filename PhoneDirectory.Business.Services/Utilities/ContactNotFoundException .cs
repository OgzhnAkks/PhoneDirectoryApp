using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Business.Services.Utilities
{
    public class ContactNotFoundException : Exception
    {
        public ContactNotFoundException() { }

        public ContactNotFoundException(string message) : base(message) { }

        public ContactNotFoundException(string message, Exception exception) : base(message, exception) { }
    }
}
