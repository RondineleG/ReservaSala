using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaSala.App.Models;

namespace ReservaSala.App.EntityConfig
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> aluno)
        {
            aluno.ToTable("Aluno");

            aluno.HasKey(x => x.AlunoId);

            aluno.Property(x => x.AlunoId)
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            aluno.Property(x => x.Nome)
                 .IsRequired()
                 .HasMaxLength(100)
                 .HasColumnType("varchar")
                 .HasColumnName("Nome");

            aluno.Property(x => x.Email)
                 .IsRequired()
                 .HasMaxLength(100)
                 .HasColumnType("varchar")
                 .HasColumnName("Email");

            aluno.Property(x => x.RA)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .HasColumnName("Ra"); 

        }
    }
}
