using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAppDataBaseConnection.models;
using WebAppDataBaseConnection.service;

namespace FormTest
{
    public partial class FormAddModifUser : Form
    {
        public FormAddModifUser()
        {
            InitializeComponent();
        }

        public FormAddModifUser(Usuario newUser) :this()
        {
      
            this.textBoxName.Text = newUser.Nombre;
            this.textBoxLastName.Text = newUser.Apellido;
            this.textBoxUserName.Text = newUser.NombreUsuario;
            this.textBoxPass.Text = newUser.Contraseña;
            this.textBoxMail.Text = newUser.Mail;
        }

        public Usuario newUserAddModif {  get; private set; }

        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
         Usuario newUser = new Usuario(){
         Nombre = this.textBoxName.Text,
         Apellido = this.textBoxLastName.Text,
         NombreUsuario = this.textBoxUserName.Text,
         Contraseña = this.textBoxPass.Text,
         Mail = this.textBoxMail.Text
         };

         this.newUserAddModif = newUser;     

         this.Close();
        }
    }
}
