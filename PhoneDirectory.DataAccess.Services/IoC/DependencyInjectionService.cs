using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhoneDirectory.DataAccess.Services.Contexts;
using PhoneDirectory.DataAccess.Services.Repositores.Abstract;
using PhoneDirectory.DataAccess.Services.Repositores.Implementation;

namespace PhoneDirectory.DataAccess.Services.IoC
{
    public static class DependencyInjectionService
    {
        public static void DataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PersonContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(configuration.GetConnectionString("LocalDbConnection"));
            });

            services.AddTransient<IAddressBookRepository, AddressBookRepository>();
        }
    }
}
