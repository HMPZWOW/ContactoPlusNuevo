

namespace ContactosPlus
{
    public partial class FrmDirectorioTelefonico : Form
    {
        public FrmDirectorioTelefonico()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            if (nombre.Length > 0)
            {
                error.SetError(txtNombre, "");
            }
            else
            {
                error.SetError(txtNombre, "Ingresa tu nombre");
            }

            if (apellidos.Length > 0)
            {
                error.SetError(txtApellidos, "");
            }
            else
            {
                error.SetError(txtApellidos, "Ingresa tu apellidos");
            }
        }
         Directorio obj = new Directorio();
        int id =Convert.ToInt32(txtId.Text);
        obj.add(id,nombre,apellidos);
        obj.show()
            MessageBox.Show("texto")



        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Registro actualizado.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar el registro?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Registro eliminado.",
                    "Directorio Telefónico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Implementar búsqueda.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtExtension.Clear();
            txtCargo.Clear();
            txtEmpresa.Clear();
            txtCorreo.Clear();
            txtObservaciones.Clear();

            chkActivo.Checked = true;

            txtNombre.Focus();
        }
    }
}
