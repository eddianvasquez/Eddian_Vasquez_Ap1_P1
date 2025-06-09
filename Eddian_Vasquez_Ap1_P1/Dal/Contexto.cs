using Microsoft.EntityFrameworkCore;

namespace Eddian_Vasquez_Ap1_P1.Dal
{
    public class Contexto DbContext
    {
        public Dbset<aporte> Aportes { get; set; }

    public contexto(DbContextOptions<Contexto> options :base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<aporte>()Haskey(app => a.AporteId)
    }
    }
}
