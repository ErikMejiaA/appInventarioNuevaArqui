
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Migrations.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Paises");

        builder.Property(p => p.IdCodigo)
        .IsRequired()
        .HasMaxLength(3);

        builder.Property(p => p.NombrePais)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex(p => p.NombrePais)
        .IsUnique();
    }
}
