namespace TrabajoPracticoFinal
{
    partial class FormLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttnLogIn = new System.Windows.Forms.Button();
            this.bttnConfiguration = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.pictureLogIn = new System.Windows.Forms.PictureBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 122);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Nombre de usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(41, 139);
            this.txtUser.MaxLength = 16;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(41, 199);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // bttnLogIn
            // 
            this.bttnLogIn.Location = new System.Drawing.Point(41, 264);
            this.bttnLogIn.Name = "bttnLogIn";
            this.bttnLogIn.Size = new System.Drawing.Size(145, 23);
            this.bttnLogIn.TabIndex = 2;
            this.bttnLogIn.Text = "Iniciar sesión";
            this.bttnLogIn.UseVisualStyleBackColor = true;
            this.bttnLogIn.Click += new System.EventHandler(this.BttnLogIn_Click);
            // 
            // bttnConfiguration
            // 
            this.bttnConfiguration.BackColor = System.Drawing.SystemColors.Control;
            this.bttnConfiguration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnConfiguration.Location = new System.Drawing.Point(41, 415);
            this.bttnConfiguration.Name = "bttnConfiguration";
            this.bttnConfiguration.Size = new System.Drawing.Size(145, 23);
            this.bttnConfiguration.TabIndex = 4;
            this.bttnConfiguration.Text = "Usuarios";
            this.bttnConfiguration.UseVisualStyleBackColor = false;
            this.bttnConfiguration.Click += new System.EventHandler(this.BttnConfiguration_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnExit.Location = new System.Drawing.Point(734, -1);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(58, 32);
            this.bttnExit.TabIndex = 5;
            this.bttnExit.Text = "X";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(21, 300);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(203, 13);
            this.lblIncorrect.TabIndex = 6;
            this.lblIncorrect.Text = "¡Nombre o contraseña incorrectos!";
            this.lblIncorrect.Visible = false;
            // 
            // pictureLogIn
            // 
            this.pictureLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogIn.Image")));
            this.pictureLogIn.Location = new System.Drawing.Point(263, -1);
            this.pictureLogIn.Name = "pictureLogIn";
            this.pictureLogIn.Size = new System.Drawing.Size(529, 500);
            this.pictureLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogIn.TabIndex = 7;
            this.pictureLogIn.TabStop = false;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChangePassword.Location = new System.Drawing.Point(38, 237);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(106, 13);
            this.lblChangePassword.TabIndex = 8;
            this.lblChangePassword.Text = "Olvidé mi contraseña";
            this.lblChangePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblChangePassword_MouseClick);
            this.lblChangePassword.MouseLeave += new System.EventHandler(this.lblChangePassword_MouseLeave);
            this.lblChangePassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblChangePassword_MouseMove);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.pictureLogIn);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnConfiguration);
            this.Controls.Add(this.bttnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttnLogIn;
        private System.Windows.Forms.Button bttnConfiguration;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.PictureBox pictureLogIn;
        private System.Windows.Forms.Label lblChangePassword;
    }
}

