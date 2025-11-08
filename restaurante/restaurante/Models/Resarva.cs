using System;

namespace restaurante.Models
{
    public class Reserva
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int? MesaID { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Estado { get; set; }
        public int NumeroPersonas { get; set; }
        public string Observaciones { get; set; }
    }
}