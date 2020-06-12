using Microsoft.EntityFrameworkCore;
using ReservaSala.App.EntityConfig;
using ReservaSala.App.Models;

namespace ReservaSala.App.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Bloco> Bloco { get; set; }
        public DbSet<Models.Reserva> Reserva { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AlunoConfig());
            //modelBuilder.ApplyConfiguration(new BlocoConfig());
            //modelBuilder.ApplyConfiguration(new SalaConfig());
        }
    }
}
