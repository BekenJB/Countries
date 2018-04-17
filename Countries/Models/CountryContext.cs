using Microsoft.EntityFrameworkCore;

namespace Countries.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options): base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
