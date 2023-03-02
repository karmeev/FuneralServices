using Microsoft.EntityFrameworkCore;

namespace Funeral.Infrastructure.Persistance
{
    public class FuneralDbContext : DbContext
    {
        public FuneralDbContext(DbContextOptions<FuneralDbContext> options) :
        base (options)
        {
        }

        //public DbSet<Worker> Workers {get; set;} = null!;
    }
}