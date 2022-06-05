using Microsoft.EntityFrameworkCore;

namespace Crud.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Curso> Curso { get, set; }
    }
}
