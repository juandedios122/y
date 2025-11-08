using System;

namespace restaurante.Models
{
    public class Promocion
    {
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public bool Exclusiva { get; set; }

        public bool Activo { get; set; }
        public string Nombre { get; internal set; }
        public decimal Descuento { get; internal set; }
    }
}
