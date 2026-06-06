namespace ContactosPlus
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario.Length > 0)
            {
                if (password.Length > 0)
                {
                    if (usuario == "Elviejo" && password == "6969")
                    {
                        // abre la siguiente venmtada(directorio)
                        FrmDirectorioTelefonico obj = new FrmDirectorioTelefonico();

                        this.Hide(); //Ocultar


                        obj.Show(); //mostrar

                        obj.FormClosed += (s, args) => this.Show();

                    }
                    else
                    {
                        MisFunciones.MensajeAlerta("Verificatus funciones");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MisFunciones.MensajeAlerta("Escribe tu contraseña");
                    txtPassword.Focus();
                }
            }
            else
            {
                MisFunciones.MensajeAlerta("Agrega tu usuario");
                txtUsuario.Focus();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
