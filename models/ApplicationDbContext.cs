using Microsoft.EntityFrameworkCore;

namespace Crud.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumnos{ get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
