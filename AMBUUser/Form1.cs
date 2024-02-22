using WebAppDataBaseConnection.models;

namespace AMBUUser
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        public Usuario UserAdded { get; private set; }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario()
            {
                Nombre = this.textName.Text,
                Apellido = this.textLastName.Text,
                NombreUsuario = this.textUserName.Text,
                Contraseña = this.textPass.Text,
                Mail = this.textMail.Text
            };

            this.UserAdded = newUser;

            this.Close();
        }
    }
}
