using Microsoft.EntityFrameworkCore;

namespace WebApiEfCoreSqlServerStarter
{
    public class Context : DbContext
    {
        public DbSet<Entity> Entities { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
