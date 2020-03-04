using EntityFrameworkSoftDelete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkSoftDelete.Data.Mappings
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("chamado", "dbo");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .HasColumnName("cd_chamado").ValueGeneratedOnAdd();

            builder.Property(u => u.Descricao)
              .HasColumnName("ds_chamado")
              .HasMaxLength(100);
        }
    }
}
