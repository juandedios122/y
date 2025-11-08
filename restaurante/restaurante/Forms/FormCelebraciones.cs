using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Forms
{
    public partial class FormCelebraciones : Form
    {
        private DBHelper db = new DBHelper();

        public FormCelebraciones()
        {
            InitializeComponent();
        }

        private void FormCelebraciones_Load(object sender, EventArgs e)
        {
            dataGridViewCelebraciones.DataSource = db.GetCelebracionesTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Celebracion nueva = new Celebracion
            {
                ClienteID = string.IsNullOrEmpty(txtClienteID.Text) ? null : (int?)int.Parse(txtClienteID.Text),
                NombreEvento = txtNombreEvento.Text,
                FechaHora = dtpFechaHora.Value,
                NumPersonas = (int)numPersonas.Value,
                Notas = txtNotas.Text,
                Estado = txtEstado.Text
            };
            db.InsertCelebracion(nueva);
            dataGridViewCelebraciones.DataSource = db.GetCelebracionesTable();
            MessageBox.Show("Celebración agregada.");
        }
    }
}