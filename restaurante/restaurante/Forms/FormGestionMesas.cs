using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Forms
{
    public partial class FormGestionMesas : Form
    {
        private readonly DBHelper db = new DBHelper();

        public FormGestionMesas()
        {
            InitializeComponent();
        }

        private void FormGestionMesas_Load(object sender, EventArgs e)
        {
            CargarMesas();
        }

        private void CargarMesas()
        {
            dataGridViewMesas.DataSource = db.GetMesasTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Por favor, ingresa una ubicación para la mesa.");
                return;
            }

            Mesa nueva = new Mesa
            {
                Capacidad = (int)numCapacidad.Value,
                Ubicacion = txtUbicacion.Text.Trim(),
                Combinable = chkCombinable.Checked,
                Disponible = true
            };

            db.InsertMesa(nueva);
            CargarMesas();
            MessageBox.Show("✅ Mesa agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
