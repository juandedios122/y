using System;

namespace restaurante.Models
{
    public class Celebracion
    {
        public int ID { get; set; }
        public int? ClienteID { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaHora { get; set; }
        public int? NumPersonas { get; set; }
        public string MesasAsignadas { get; set; }
        public string Notas { get; set; }
        public string Estado { get; set; }
        public int ReservaID { get; internal set; }
        public string Detalles { get; internal set; }
        public string Tipo { get; internal set; }
    }
}
