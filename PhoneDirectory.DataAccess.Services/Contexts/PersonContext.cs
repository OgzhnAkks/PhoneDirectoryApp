using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Entity.Services.Models.Entity;

namespace PhoneDirectory.DataAccess.Services.Contexts
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=StudentDemo; TrustServerCertificate=True; Trusted_Connection=True;");
            }
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}
