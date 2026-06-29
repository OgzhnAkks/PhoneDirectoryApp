using AutoMapper;
using PhoneDirectory.Entity.Services.Models.Dto;
using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.Business.Services.Utilities
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            //Person
            CreateMap<Person,PersonDto>().ReverseMap();
            CreateMap<Person, CreatePersonDto>().ReverseMap();
            CreateMap<Person, UpdatePersonDto>().ReverseMap();


            //ContactInfo
            CreateMap<ContactInfo,ContactInfoDto>().ReverseMap();
            CreateMap<ContactInfo, CreateContactInfoDto>().ReverseMap();
            CreateMap<ContactInfo, UpdateContactInfoDto>().ReverseMap();

        }
    }
}
