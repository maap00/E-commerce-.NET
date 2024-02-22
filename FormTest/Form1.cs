using WebAppDataBaseConnection.models;
using WebAppDataBaseConnection.service;


namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Usuario selectUser = new Usuario();
        Producto selectProduct = new Producto();


        //Usuarios

        public void btnList_Click(object sender, EventArgs e)
        {
            List<Usuario> userList = UserService.GetAllUserList();
            this.dataGridView1_Load(userList);
        }

        // dataGridView recibe un objeto como argumento por ende solo renderizara listas
        private void dataGridView1_Load(object obj)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = obj;
        }

        private void btnUserListID_Click(object sender, EventArgs e)
        {
            string idString = this.textBoxID.Text;

            if (!string.IsNullOrEmpty(idString))
            {

                int id = Convert.ToInt32(idString);

                Usuario userFoundforID = UserService.GetUserForID(id);

                //Se crea una lista para que lo tome el DataGrid
                List<Usuario> userFoundList = new List<Usuario>() { userFoundforID };
                this.dataGridView1_Load(userFoundList);

            }

            else
            {
                MessageBox.Show("Complete campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxID.Focus();
            }
        }


        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormAddModifUser forNewuser = new FormAddModifUser();
            forNewuser.ShowDialog();

            Usuario user = forNewuser.newUserAddModif;

            if (UserService.AddNewUser(user))
            {
                MessageBox.Show("Usuario Agregado", "Alta");
                List<Usuario> userList = UserService.GetAllUserList();

                this.dataGridView1_Load(userList);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Usuario selectUser = new Usuario();

            int id = this.selectUser.Id;

            if (this.selectUser.Id == 0)
            {
                MessageBox.Show("No ha seleccionado un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserService.DeleteUser(id);

                MessageBox.Show("usuario Eliminado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Usuario> userList = UserService.GetAllUserList();

                this.dataGridView1_Load(userList);

                this.selectUser.Id = 0;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

            Usuario selectUser = new Usuario();

            FormAddModifUser forNewModif = new FormAddModifUser(this.selectUser);

            int id = this.selectUser.Id;

            if (this.selectUser.Id == 0)
            {
                MessageBox.Show("No ha seleccionado un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                forNewModif.ShowDialog();

                Usuario userModified = forNewModif.newUserAddModif;

                UserService.UpdateUserForId(id, userModified);

                MessageBox.Show("usuario actializado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Usuario> userList = UserService.GetAllUserList();

                this.dataGridView1_Load(userList);

                this.selectUser.Id = 0;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var select = this.dataGridView1.SelectedRows;

            if (select.Count > 0)
            {
                object date = select[0].DataBoundItem;

                this.selectUser = date as Usuario;
                this.selectProduct = date as Producto;
            }
        }

        //Productos
        private void btnListProduct_Click(object sender, EventArgs e)
        {
            List<Producto> productsList = ProductServices.GetAllProductsList();
            this.dataGridView1_Load(productsList);
        }

        private void btnProductId_Click(object sender, EventArgs e)
        {
            string idString = this.textBoxID.Text;

            if (!string.IsNullOrEmpty(idString))
            {
                int id = Convert.ToInt32(idString);

                Producto productoFoundForID = ProductServices.GetProductForID(id);

                //Se crea una lista para que lo tome el DataGrid
                List<Producto> productFoundList = new List<Producto>() { productoFoundForID };
                this.dataGridView1_Load(productFoundList);
            }

            else
            {
                MessageBox.Show("Complete campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxID.Focus();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {


            FormAddModifProduct forNewProduct = new FormAddModifProduct();
            forNewProduct.ShowDialog();

            Producto product = forNewProduct.newProductAddModif;


            if (ProductServices.AddNewProduct(product))
            {
                MessageBox.Show("Producto Agregado", "Alta");

                List<Producto> productList = ProductServices.GetAllProductsList();
                this.dataGridView1_Load(productList);


            }
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {

            Producto selectProduct = new Producto();

            int id = this.selectProduct.Id;

            if (this.selectProduct.Id == 0)
            {
                MessageBox.Show("No ha seleccionado un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserService.DeleteUser(id);
                ProductServices.DeleteProduct(id);

                MessageBox.Show("Producto eliminado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Producto> productList = ProductServices.GetAllProductsList();

                this.dataGridView1_Load(productList);

                this.selectProduct.Id = 0;
            }

        }

        private void btnModifProduct_Click(object sender, EventArgs e)
        {
            Producto selectProduct = new Producto();

            FormAddModifProduct forNewProduct = new FormAddModifProduct(this.selectProduct);

            int id = this.selectProduct.Id;

            if (this.selectProduct.Id == 0)
            {
                MessageBox.Show("No ha seleccionado un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                forNewProduct.ShowDialog();

                Producto productModified = forNewProduct.newProductAddModif;

                ProductServices.UpdateProductForId(id, productModified);

                MessageBox.Show("Producto actializado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Producto> productList = ProductServices.GetAllProductsList();

                this.dataGridView1_Load(productList);

                this.selectProduct.Id = 0;
            }
        }
    }
}
