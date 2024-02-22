namespace FormTest
{
    partial class FormAddModifUser
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
            btnAddUser = new Button();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxUserName = new TextBox();
            textBoxPass = new TextBox();
            textBoxMail = new TextBox();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(147, 376);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(131, 46);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Aceptar";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(36, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Nombre";
            textBoxName.Size = new Size(366, 31);
            textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(36, 110);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Apellido";
            textBoxLastName.Size = new Size(360, 31);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(36, 172);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Nombre de usuario";
            textBoxUserName.Size = new Size(360, 31);
            textBoxUserName.TabIndex = 3;
            textBoxUserName.TabStop = false;
            // 
            // textBoxPass
            // 
            textBoxPass.AcceptsTab = true;
            textBoxPass.Location = new Point(36, 245);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Contraseña";
            textBoxPass.Size = new Size(360, 31);
            textBoxPass.TabIndex = 4;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(36, 310);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "Correo";
            textBoxMail.Size = new Size(360, 31);
            textBoxMail.TabIndex = 5;
            // 
            // FormAddModifUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(btnAddUser);
            Name = "FormAddModifUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos nuevo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxUserName;
        private TextBox textBoxPass;
        private TextBox textBoxMail;
    }
}