using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;
using restaurante.Services;

namespace restaurante.Forms
{
    public partial class FormPrincipal : Form
    {
        private static readonly Restaurante restaurante1 = new Restaurante();
        private readonly Restaurante restaurante = restaurante1;
        private readonly DBHelper db = new DBHelper();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            restaurante.CargarDatos();
            dataGridViewReservas.DataSource = db.GetReservas();
            timerNoShow.Start();
        }

        private void TimerNoShow_Tick(object sender, EventArgs e)
        {
            restaurante.CargarDatos();
            foreach (var res in restaurante.Reservas)
            {
                restaurante.ManejarNoShow(res);
            }
            dataGridViewReservas.DataSource = db.GetReservas();
        }

        private void BtnGestionMesas_Click(object sender, EventArgs e)
        {
            new FormGestionMesas().ShowDialog();
        }

        private void BtnGestionMenus_Click(object sender, EventArgs e)
        {
            new FormGestionMenus().ShowDialog();
        }

        private void BtnGestionPromociones_Click(object sender, EventArgs e)
        {
            new FormGestionPromociones().ShowDialog();
        }

        private void BtnCelebraciones_Click(object sender, EventArgs e)
        {
            new FormCelebraciones().ShowDialog();
        }

        private void BtnRecordatorios_Click(object sender, EventArgs e)
        {
            new FormRecordatorios().ShowDialog();
        }

        private void BtnNuevaReservaMenu_Click(object sender, EventArgs e)
        {
            new FormNuevaReserva(restaurante, db).ShowDialog();
            dataGridViewReservas.DataSource = db.GetReservas();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementa edición o detalles si es necesario
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Gráficos personalizados si es necesario
        }
    }
}