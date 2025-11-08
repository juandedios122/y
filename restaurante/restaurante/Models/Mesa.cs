using System;
using System.Collections.Generic;
using System.Linq;

namespace restaurante.Models
{
    public class Mesa
    {
        public int ID { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public bool Combinable { get; set; }
        public bool Disponible { get; set; } = true;

        public bool EstaDisponible(DateTime inicio, DateTime fin, List<Reserva> reservas)
        {
            return Disponible && !reservas.Any(r =>
                r.MesaID == this.ID &&
                r.Estado != "Completada" &&
                r.Estado != "Cancelada" &&
                (inicio < r.HoraFin && fin > r.HoraInicio));
        }
    }
}
