using PhoneDirectory.Business.Services.Utilities.Abstract;
using PhoneDirectory.Entity.Services.Models.Dto;

namespace PhoneDirectory.Business.Services.Utilities.Implementation
{
    public class AddressBookRepository : IAddressBookRepository
    {
        public Task<PersonDto> AddPerson(PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        public Task<PersonDto> DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonDto> GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonDto>> GetPersons()
        {
            throw new NotImplementedException();
        }

        public Task<PersonDto> UpdatePerson(PersonDto personDto)
        {
            throw new NotImplementedException();
        }
    }
}
