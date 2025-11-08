using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Forms
{
    public partial class FormGestionPromociones : Form
    {
        private readonly DBHelper db = new DBHelper();

        public FormGestionPromociones()
        {
            InitializeComponent();
        }

        private void FormGestionPromociones_Load(object sender, EventArgs e)
        {
            CargarPromociones();
        }

        private void CargarPromociones()
        {
            dataGridViewPromociones.DataSource = db.GetPromocionesTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Por favor ingresa un título para la promoción.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Promocion nueva = new Promocion
            {
                Titulo = txtTitulo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                FechaInicio = (DateTime?)dtpFechaInicio.Value,
                FechaFin = (DateTime?)dtpFechaFin.Value,
                Exclusiva = chkExclusiva.Checked,
                Activo = chkActivo.Checked
            };

            db.InsertPromocion(nueva);
            CargarPromociones();
            MessageBox.Show("✅ Promoción agregada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
