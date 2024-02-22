namespace AMBUser
{
    partial class AMBUser
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
            btnAddUser = new Button();
            textName = new TextBox();
            textLastName = new TextBox();
            textUserName = new TextBox();
            textPass = new TextBox();
            textMail = new TextBox();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(96, 332);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(141, 52);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // textName
            // 
            textName.Location = new Point(36, 32);
            textName.Name = "textName";
            textName.PlaceholderText = "Nombre";
            textName.Size = new Size(294, 31);
            textName.TabIndex = 1;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(36, 86);
            textLastName.Name = "textLastName";
            textLastName.PlaceholderText = "Apellido";
            textLastName.Size = new Size(294, 31);
            textLastName.TabIndex = 2;
            // 
            // textUserName
            // 
            textUserName.Location = new Point(36, 149);
            textUserName.Name = "textUserName";
            textUserName.PlaceholderText = "Nombre de usuario";
            textUserName.Size = new Size(294, 31);
            textUserName.TabIndex = 3;
            // 
            // textPass
            // 
            textPass.Location = new Point(36, 201);
            textPass.Name = "textPass";
            textPass.PlaceholderText = "Contraseña";
            textPass.Size = new Size(294, 31);
            textPass.TabIndex = 4;
            // 
            // textMail
            // 
            textMail.Location = new Point(36, 260);
            textMail.Name = "textMail";
            textMail.PlaceholderText = "Correo";
            textMail.Size = new Size(294, 31);
            textMail.TabIndex = 5;
            // 
            // AMBUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 450);
            Controls.Add(textMail);
            Controls.Add(textPass);
            Controls.Add(textUserName);
            Controls.Add(textLastName);
            Controls.Add(textName);
            Controls.Add(btnAddUser);
            Name = "AMBUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del nuevo usuario";
            Load += AMBUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private TextBox textName;
        private TextBox textLastName;
        private TextBox textUserName;
        private TextBox textPass;
        private TextBox textMail;
    }
}
