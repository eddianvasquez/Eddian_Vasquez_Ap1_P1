namespace Eddian_Vasquez_Ap1_P1.models
{
    public class Aporte
    {
        public int AporteId { get; set; }
        public string Persona { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
    }
