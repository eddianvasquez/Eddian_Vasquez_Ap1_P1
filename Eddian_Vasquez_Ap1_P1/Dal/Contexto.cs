using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_P1.models;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aporte> Aportes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aporte>()
                .Property(a => a.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Aporte>()
                .Property(a => a.Nombre)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<Aporte>()
                .Property(a => a.Monto)
                .HasPrecision(18, 2);
        }
    }
}