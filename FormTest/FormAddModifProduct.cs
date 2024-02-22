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

namespace FormTest
{
    public partial class FormAddModifProduct : Form
    {
        public FormAddModifProduct()
        {
            InitializeComponent();
        }
        public FormAddModifProduct(Producto newProduct) : this()
        {
            this.textBoxDescription.Text = newProduct.Descripciones;
            this.textBoxPrice.Text = newProduct.Costo.ToString();
            this.textBoxPriceSale.Text = newProduct.PrecioVenta.ToString();
            this.textBoxStock.Text = newProduct.Stock.ToString();
            this.textBoxIdUser.Text = newProduct.IdUsuario.ToString();  
        }
        public Producto newProductAddModif { get; private set; }

        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {

            Producto newProduct = new Producto()
            {
                Descripciones = this.textBoxDescription.Text,
                Costo = decimal.Parse(this.textBoxPrice.Text), 
                PrecioVenta = decimal.Parse(this.textBoxPriceSale.Text),
                Stock = int.Parse(this.textBoxStock.Text),
                IdUsuario = int.Parse(this.textBoxIdUser.Text)         

            };

            this.newProductAddModif = newProduct;

            this.Close();

        }




    }
}
