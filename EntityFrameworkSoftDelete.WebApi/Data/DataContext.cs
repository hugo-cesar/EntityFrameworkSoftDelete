using EntityFrameworkSoftDelete.Data.Mappings;
using EntityFrameworkSoftDelete.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSoftDelete.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
                    : base(options)
        {
        }

        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChamadoMap());

            //modelBuilder.Entity<Chamado>().Property(item => item.Id);
            //modelBuilder.Entity<Chamado>().Property(item => item.Descricao);
        }
    }
}
