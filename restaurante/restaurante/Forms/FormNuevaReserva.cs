using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;
using restaurante.Services;

namespace restaurante.Forms
{
    public partial class FormNuevaReserva : Form
    {
        private readonly Restaurante restaurante;
        private readonly DBHelper db;

        public FormNuevaReserva(Restaurante r, DBHelper d)
        {
            restaurante = r;
            db = d;
            InitializeComponent();
            dtpFechaHora.Value = DateTime.Now;
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                numPersonas.Value < 1)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            int clienteID = db.GetOrCreateCliente(txtNombre.Text, txtEmail.Text, txtTelefono.Text, txtPreferencias.Text);

            Reserva nueva = new Reserva
            {
                ClienteID = clienteID,
                NumeroPersonas = (int)numPersonas.Value,
                FechaReserva = dtpFechaHora.Value,
                HoraInicio = dtpFechaHora.Value,
                HoraFin = dtpFechaHora.Value.AddHours(1.5), // Ejemplo, ajusta si necesitas
                Observaciones = txtPreferencias.Text,
                Estado = "Pendiente"
            };

            if (restaurante.AsignarMesa(nueva))
            {
                restaurante.EnviarRecordatorio(nueva);
                db.InsertReserva(nueva); // Inserta en la DB
                MessageBox.Show("Reserva creada.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay mesas disponibles.");
            }
        }
    }
}