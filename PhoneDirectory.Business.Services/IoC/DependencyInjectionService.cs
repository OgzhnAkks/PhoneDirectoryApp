using PhoneDirectory.Business.Services.Utilities;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PhoneDirectory.Business.Services.Services.Abstract;
using PhoneDirectory.Business.Services.Services.Implementation;

namespace PhoneDirectory.Business.Services.IoC
{
    public static class DependencyInjectionService
    {
        public static void BusinessDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAddressBookService, AddressBookService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
