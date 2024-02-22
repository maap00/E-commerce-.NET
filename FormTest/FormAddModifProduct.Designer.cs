namespace FormTest
{
    partial class FormAddModifProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxDescription = new TextBox();
            textBoxPrice = new TextBox();
            textBoxPriceSale = new TextBox();
            textBoxStock = new TextBox();
            textBoxIdUser = new TextBox();
            btnAcceptProduct = new Button();
            SuspendLayout();
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(69, 51);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Descripcion";
            textBoxDescription.Size = new Size(212, 31);
            textBoxDescription.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(69, 108);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Costo";
            textBoxPrice.Size = new Size(212, 31);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxPriceSale
            // 
            textBoxPriceSale.Location = new Point(69, 176);
            textBoxPriceSale.Name = "textBoxPriceSale";
            textBoxPriceSale.PlaceholderText = "Precio Venta";
            textBoxPriceSale.Size = new Size(212, 31);
            textBoxPriceSale.TabIndex = 2;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(69, 233);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.PlaceholderText = "Stock";
            textBoxStock.Size = new Size(212, 31);
            textBoxStock.TabIndex = 3;
            // 
            // textBoxIdUser
            // 
            textBoxIdUser.Location = new Point(69, 288);
            textBoxIdUser.Name = "textBoxIdUser";
            textBoxIdUser.PlaceholderText = "ID Usuario";
            textBoxIdUser.Size = new Size(212, 31);
            textBoxIdUser.TabIndex = 4;
            // 
            // btnAcceptProduct
            // 
            btnAcceptProduct.Location = new Point(106, 366);
            btnAcceptProduct.Name = "btnAcceptProduct";
            btnAcceptProduct.Size = new Size(112, 34);
            btnAcceptProduct.TabIndex = 5;
            btnAcceptProduct.Text = "Aceptar";
            btnAcceptProduct.UseVisualStyleBackColor = true;
            btnAcceptProduct.Click += btnAcceptProduct_Click;
            // 
            // FormAddModifProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 450);
            Controls.Add(btnAcceptProduct);
            Controls.Add(textBoxIdUser);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPriceSale);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescription);
            Name = "FormAddModifProduct";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescription;
        private TextBox textBoxPrice;
        private TextBox textBoxPriceSale;
        private TextBox textBoxStock;
        private TextBox textBoxIdUser;
        private Button btnAcceptProduct;
    }
}