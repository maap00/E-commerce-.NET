namespace FormTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnList = new Button();
            btnUserListID = new Button();
            textBoxID = new TextBox();
            btnNewUser = new Button();
            btnDelete = new Button();
            btnModif = new Button();
            btnListProduct = new Button();
            btnProductId = new Button();
            btnAddProduct = new Button();
            btnDeleteProd = new Button();
            btnModifProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1131, 488);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnList
            // 
            btnList.Location = new Point(39, 20);
            btnList.Name = "btnList";
            btnList.Size = new Size(144, 54);
            btnList.TabIndex = 1;
            btnList.Text = "Listar";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnUserListID
            // 
            btnUserListID.Location = new Point(446, 20);
            btnUserListID.Name = "btnUserListID";
            btnUserListID.Size = new Size(144, 31);
            btnUserListID.TabIndex = 2;
            btnUserListID.Text = "Usuario ID";
            btnUserListID.UseVisualStyleBackColor = true;
            btnUserListID.Click += btnUserListID_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(615, 57);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(58, 31);
            textBoxID.TabIndex = 3;
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(39, 95);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(144, 59);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "Nuevo usuarrio";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 67);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(39, 233);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(144, 58);
            btnModif.TabIndex = 6;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // btnListProduct
            // 
            btnListProduct.Location = new Point(225, 20);
            btnListProduct.Name = "btnListProduct";
            btnListProduct.Size = new Size(147, 58);
            btnListProduct.TabIndex = 7;
            btnListProduct.Text = "Lista de productos";
            btnListProduct.UseVisualStyleBackColor = true;
            btnListProduct.Click += btnListProduct_Click;
            // 
            // btnProductId
            // 
            btnProductId.Location = new Point(446, 57);
            btnProductId.Name = "btnProductId";
            btnProductId.Size = new Size(144, 31);
            btnProductId.TabIndex = 8;
            btnProductId.Text = "Producto ID";
            btnProductId.UseVisualStyleBackColor = true;
            btnProductId.Click += btnProductId_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(225, 95);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(147, 59);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Nuevo producto";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.Location = new Point(225, 160);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(147, 67);
            btnDeleteProd.TabIndex = 10;
            btnDeleteProd.Text = "Borrar producto";
            btnDeleteProd.UseVisualStyleBackColor = true;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // btnModifProduct
            // 
            btnModifProduct.Location = new Point(228, 233);
            btnModifProduct.Name = "btnModifProduct";
            btnModifProduct.Size = new Size(144, 58);
            btnModifProduct.TabIndex = 11;
            btnModifProduct.Text = "Modificar Producto";
            btnModifProduct.UseVisualStyleBackColor = true;
            btnModifProduct.Click += btnModifProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 861);
            Controls.Add(btnModifProduct);
            Controls.Add(btnDeleteProd);
            Controls.Add(btnAddProduct);
            Controls.Add(btnProductId);
            Controls.Add(btnListProduct);
            Controls.Add(btnModif);
            Controls.Add(btnDelete);
            Controls.Add(btnNewUser);
            Controls.Add(textBoxID);
            Controls.Add(btnUserListID);
            Controls.Add(btnList);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnList;
        private Button btnUserListID;
        private TextBox textBoxID;
        private Button btnNewUser;
        private Button btnDelete;
        private Button btnModif;
        private Button btnListProduct;
        private Button btnProductId;
        private Button btnAddProduct;
        private Button btnDeleteProd;
        private Button btnModifProduct;
    }
}
