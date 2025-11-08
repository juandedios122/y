using System;

namespace restaurante.Models
{
    public class Recordatorio
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public int? EntidadID { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Destinatario { get; set; }
        public string Mensaje { get; set; }
        public int ReservaID { get; internal set; }
        public string Estado { get; internal set; }
    }
}
