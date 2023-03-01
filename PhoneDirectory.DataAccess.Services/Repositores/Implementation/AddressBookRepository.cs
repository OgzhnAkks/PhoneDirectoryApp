using PhoneDirectory.DataAccess.Services.Contexts;
using PhoneDirectory.DataAccess.Services.Repositores.Abstract;
using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.DataAccess.Services.Repositores.Implementation
{
    public class AddressBookRepository : GenericRepository<Person>,IAddressBookRepository
    {
        private readonly PersonContext _personContext;

        public AddressBookRepository(PersonContext personContext) : base(personContext)
        {
            _personContext = personContext;
        }
    }
}
