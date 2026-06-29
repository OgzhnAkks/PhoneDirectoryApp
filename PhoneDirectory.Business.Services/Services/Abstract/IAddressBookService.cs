using PhoneDirectory.Entity.Services.Models.Dto;

namespace PhoneDirectory.Business.Services.Services.Abstract
{
    public interface IAddressBookService
    {
        Task<PersonDto> AddPerson(CreatePersonDto personDto);
        Task<PersonDto> UpdatePerson(UpdatePersonDto personDto);
        Task DeletePerson(int id);
        Task<PersonDto> GetPerson(int id);
        Task<List<PersonDto>> GetPersons();
    }
}
