using Microsoft.EntityFrameworkCore;
using mi_aplicacion_web.Models;

namespace mi_aplicacion_web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Model1> Model1s { get; set; }
        public DbSet<Model2> Model2s { get; set; }
    }
}