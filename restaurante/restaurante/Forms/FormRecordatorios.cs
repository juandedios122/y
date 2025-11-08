using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Forms
{
    public partial class FormRecordatorios : Form
    {
        private DBHelper db = new DBHelper();

        public FormRecordatorios()
        {
            InitializeComponent();
        }

        private void FormRecordatorios_Load(object sender, EventArgs e)
        {
            dataGridViewRecordatorios.DataSource = db.GetRecordatoriosTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Recordatorio nuevo = new Recordatorio
            {
                Tipo = txtTipo.Text,
                EntidadID = string.IsNullOrEmpty(txtEntidadID.Text) ? null : (int?)int.Parse(txtEntidadID.Text),
                FechaEnvio = dtpFechaEnvio.Value,
                Destinatario = txtDestinatario.Text,
                Mensaje = txtMensaje.Text
            };
            db.InsertRecordatorio(nuevo);
            dataGridViewRecordatorios.DataSource = db.GetRecordatoriosTable();
            MessageBox.Show("Recordatorio agregado.");
        }
    }
}