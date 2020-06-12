using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaSala.App.Models;

namespace ReservaSala.App.EntityConfig
{
    public class SalaConfig : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> sala)
        {

            sala.ToTable("Sala");

            sala.HasKey(x => x.SalaId);

            sala.Property(x => x.SalaId)
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            sala.Property(x => x.Nome)
                 .IsRequired()
                 .HasMaxLength(100)
                 .HasColumnType("varchar")
                 .HasColumnName("Nome");
                          
                        




        }
    }
}
