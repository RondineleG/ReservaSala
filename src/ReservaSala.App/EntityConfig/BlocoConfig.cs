using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaSala.App.Models;

namespace ReservaSala.App.EntityConfig
{
    public class BlocoConfig : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> bloco)
        {
            bloco.ToTable("Bloco");

            bloco.HasKey(x => x.BlocoId);

            bloco.Property(x => x.BlocoId)
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            bloco.Property(x => x.Nome)
                 .IsRequired()
                 .HasMaxLength(100)
                 .HasColumnType("varchar")
                 .HasColumnName("Nome");

            bloco.Property(x => x.Descricao)
                 .IsRequired()
                 .HasMaxLength(50)
                 .HasColumnType("varchar")
                 .HasColumnName("Email");

        }
    }
}
