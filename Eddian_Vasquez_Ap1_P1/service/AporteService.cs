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
        public async Task<List<Aportes>> obtenerAportesasync()
        {
            return await _contexto.Aportes.findAsync(int id)
                {
                public async Task CrearAporteAsync(Aporte aporte)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Aporte> entityEntry = _contexto.Aportes.Add(aporte);
            await _contexto.SaveChangesAsync();
        }
        
        public async Task EditarAportesasync(Aporte aporte)
        {
            _contexto.entry(aporte).state = EntityState.Modified;
            await _contexto.SaveChangesAsync();

        }
        public async Task EliminarAportesasync(int id)
        {
            var aportes = await _contexto.Aportes.findAsync(id);
            if (aportes != null)
            {
                _contexto.Aportes.Remove(aporte);
                await _contexto.SaveChangesAsync();
            }
        }
        }
    }
        
