using AutoMapper;
using PhoneDirectory.Business.Services.Services.Abstract;
using DL = PhoneDirectory.DataAccess.Services.Repositores.Abstract;
using PhoneDirectory.Entity.Services.Models.Dto;
using PhoneDirectory.Entity.Services.Models.Entity;
using PhoneDirectory.Business.Services.Utilities;
using PhoneDirectory.DataAccess.Services.Repositores.Implementation;

namespace PhoneDirectory.Business.Services.Services.Implementation
{
    public class AddressBookService : IAddressBookService
    {
        private readonly DL::IAddressBookRepository _addressBookRepository;
        private readonly IMapper _mapper;


        // Depenctiy Injection
        public AddressBookService(DL::IAddressBookRepository addressBookRepository, IMapper mapper)
        {
            _addressBookRepository = addressBookRepository;
            _mapper = mapper;
        }

        public async Task<PersonDto> AddPerson(PersonDto personDto)
        {
            var personValue = await _addressBookRepository.Add(_mapper.Map<Person>(personDto));

            return _mapper.Map<PersonDto>(personValue);
        }

        public async Task DeletePerson(int id)
        {
            var person = await _addressBookRepository.Get(x => x.Id == id);

            if (person is null)
            {
                throw new ContactNotFoundException();
            }

            await _addressBookRepository.Delete(person);
        }

        public async Task<PersonDto> GetPerson(int id)
        {

            var person = await _addressBookRepository.Get(x => x.Id == id);

            if (person is null)
            {
                throw new ContactNotFoundException();
            }

            return _mapper.Map<PersonDto>(person);
        }

        public async Task<List<PersonDto>> GetPersons()
        {
            var persons = await _addressBookRepository.GetList();

            return _mapper.Map<List<PersonDto>>(persons);

        }

        public async Task<PersonDto> UpdatePerson(PersonDto personDto)
        {
            var person = await _addressBookRepository.Get(x => x.Id == personDto.Id);

            if (person is null)
            {
                throw new ContactNotFoundException();
            }

            return _mapper.Map<PersonDto>(await _addressBookRepository.Update(_mapper.Map<Person>(personDto)));
        }
    }
}
