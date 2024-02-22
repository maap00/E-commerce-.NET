namespace AMBUUser
{
    partial class FrmUser
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
            btnAcept = new Button();
            textName = new TextBox();
            textLastName = new TextBox();
            textUserName = new TextBox();
            textPass = new TextBox();
            textMail = new TextBox();
            SuspendLayout();
            // 
            // btnAcept
            // 
            btnAcept.Location = new Point(120, 341);
            btnAcept.Name = "btnAcept";
            btnAcept.Size = new Size(112, 34);
            btnAcept.TabIndex = 0;
            btnAcept.Text = "Aceptar";
            btnAcept.UseVisualStyleBackColor = true;
            btnAcept.Click += btnAcept_Click;
            // 
            // textName
            // 
            textName.Location = new Point(21, 24);
            textName.Name = "textName";
            textName.PlaceholderText = "Nombre";
            textName.Size = new Size(353, 31);
            textName.TabIndex = 1;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(21, 87);
            textLastName.Name = "textLastName";
            textLastName.PlaceholderText = "Apellido";
            textLastName.Size = new Size(353, 31);
            textLastName.TabIndex = 2;
            // 
            // textUserName
            // 
            textUserName.Location = new Point(21, 153);
            textUserName.Name = "textUserName";
            textUserName.PlaceholderText = "Nombre de usuario";
            textUserName.Size = new Size(353, 31);
            textUserName.TabIndex = 3;
            // 
            // textPass
            // 
            textPass.Location = new Point(22, 211);
            textPass.Name = "textPass";
            textPass.PlaceholderText = "Contraseña";
            textPass.Size = new Size(352, 31);
            textPass.TabIndex = 4;
            // 
            // textMail
            // 
            textMail.Location = new Point(21, 273);
            textMail.Name = "textMail";
            textMail.PlaceholderText = "Correo";
            textMail.Size = new Size(353, 31);
            textMail.TabIndex = 5;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 409);
            ControlBox = false;
            Controls.Add(textMail);
            Controls.Add(textPass);
            Controls.Add(textUserName);
            Controls.Add(textLastName);
            Controls.Add(textName);
            Controls.Add(btnAcept);
            Name = "FrmUser";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos de nuevo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcept;
        private TextBox textName;
        private TextBox textLastName;
        private TextBox textUserName;
        private TextBox textPass;
        private TextBox textMail;
    }
}
