using Microsoft.EntityFrameworkCore;
using Repaso.models;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aporte> Aportes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Puedes configurar reglas como claves, restricciones únicas, etc.
            modelBuilder.Entity<Aporte>().HasKey(a => a.AporteId);
        }
    }
}