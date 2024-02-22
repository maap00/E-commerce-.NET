using WebAppDataBaseConnection.models;

namespace AMBUser
{
    public partial class AMBUser : Form
    {
        public AMBUser()
        {
            InitializeComponent();
        }
        public Usuario UserAdded { get; private set; }

        private void btnAddUser_Click(object sender, EventArgs e)
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

        private void AMBUser_Load(object sender, EventArgs e)
        {

        }
    }
}
