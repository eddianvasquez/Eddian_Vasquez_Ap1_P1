using Microsoft.EntityFrameworkCore;
using Repaso.models;
using DAL;
using Eddian_Vasquez_Ap1_P1.Dal;


namespace repaso.Services
{
    public class AportesService
    {
        private readonly Contexto _contexto;

        public AportesService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Aporte>> ObtenerAportesAsync()
        {
            return await _contexto.Aportes.ToListAsync();
        }

        public async Task<Aporte> ObtenerAportePorIdAsync(int id)
        {
            return await _contexto.Aportes.FindAsync(id);
        }

        public async Task CrearAporteAsync(Aporte aporte)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Aporte> entityEntry = _contexto.Aportes.Add(aporte);
            await _contexto.SaveChangesAsync();
        }

        public async Task EditarAporteAsync(Aporte aporte)
        {
            _contexto.Entry(aporte).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAporteAsync(int id)
        {
            var aporte = await _contexto.Aportes.FindAsync(id);
            if (aporte != null)
            {
                _contexto.Aportes.Remove(aporte);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}