using PhoneDirectory.Entity.Services.Models.Dto;

namespace PhoneDirectory.Business.Services.Services.Abstract
{
    public interface IAddressBookRepository
    {
        Task<PersonDto> AddPerson(PersonDto personDto);
        Task<PersonDto> UpdatePerson(PersonDto personDto);
        Task DeletePerson(int id);
        Task<PersonDto> GetPerson(int id);
        Task<List<PersonDto>> GetPersons();
    }
}
