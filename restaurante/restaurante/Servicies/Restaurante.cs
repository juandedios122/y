using System;
using System.Collections.Generic;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Services
{
    public class Restaurante
    {
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        private static readonly DBHelper dBHelper = new DBHelper();
        private DBHelper db = dBHelper;

        public void CargarDatos()
        {
            Reservas = db.GetReservas();
        }

        public bool AsignarMesa(Reserva reserva)
        {
            // Lógica para asignar mesa (busca mesas disponibles en DB)
            var mesas = db.GetMesas();
            foreach (var mesa in mesas)
            {
                if (mesa.Disponible && mesa.Capacidad >= reserva.NumeroPersonas)
                {
                    reserva.MesaID = mesa.ID;
                    db.UpdateMesaDisponible(mesa.ID, false);
                    return true;
                }
            }
            return false;
        }

        public void ManejarNoShow(Reserva reserva)
        {
            // Lógica para no-show (e.g., si hora pasada, cambiar estado)
            if (reserva.HoraInicio < DateTime.Now && reserva.Estado == "Pendiente")
            {
                reserva.Estado = "No Show";
                db.UpdateReservaEstado(reserva.ID, "No Show");
            }
        }

        public void EnviarRecordatorio(Reserva reserva)
        {
            // Lógica para enviar recordatorio (stub, e.g., inserta en Recordatorios)
            var recordatorio = new Recordatorio
            {
                ReservaID = reserva.ID,
                FechaEnvio = DateTime.Now,
                Mensaje = "Recordatorio de reserva",
                Estado = "Enviado"
            };
            db.InsertRecordatorio(recordatorio);
        }
    }
}