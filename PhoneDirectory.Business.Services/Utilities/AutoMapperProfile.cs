using AutoMapper;
using PhoneDirectory.Entity.Services.Models.Dto;
using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.Business.Services.Utilities
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Person,PersonDto>().ReverseMap();
            CreateMap<ContactInfo,ContactInfoDto>().ReverseMap();
        }
    }
}
