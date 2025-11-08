using System;
using System.Windows.Forms;
using restaurante.DataAccess;
using restaurante.Models;

namespace restaurante.Forms
{
    public partial class FormGestionMenus : Form
    {
        private DBHelper db = new DBHelper();

        public FormGestionMenus()
        {
            InitializeComponent();
        }

        private void FormGestionMenus_Load(object sender, EventArgs e)
        {
            dataGridViewMenus.DataSource = db.GetMenusTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            restaurante.Models.Menu nuevo = new restaurante.Models.Menu
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtDescripcion.Text),
                Disponible = chkActivo.Checked
            };

            db.InsertMenu(nuevo);
            dataGridViewMenus.DataSource = db.GetMenusTable();
            MessageBox.Show("✅ Menú agregado correctamente.");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}