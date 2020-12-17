namespace TrabajoPracticoFinal
{
    partial class FormConfiguration
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
            this.lblAdminName = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.lblRecuperateLink = new System.Windows.Forms.Label();
            this.lblCreateLink = new System.Windows.Forms.Label();
            this.tabUserManager = new System.Windows.Forms.TabControl();
            this.tabCreateUser = new System.Windows.Forms.TabPage();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCreatedFailed = new System.Windows.Forms.Label();
            this.lblCreatedSucesfully = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewUserPass = new System.Windows.Forms.Label();
            this.lblNewUserPassConfirm = new System.Windows.Forms.Label();
            this.bttnNewUserCreate = new System.Windows.Forms.Button();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewUserPass = new System.Windows.Forms.TextBox();
            this.txtNewUserPassConfirm = new System.Windows.Forms.TextBox();
            this.tabRecuperateUser = new System.Windows.Forms.TabPage();
            this.bttnRecuperate = new System.Windows.Forms.Button();
            this.txtRecPassword = new System.Windows.Forms.TextBox();
            this.lblRecPassword = new System.Windows.Forms.Label();
            this.txtRecAnswer = new System.Windows.Forms.TextBox();
            this.lblRecAnswer = new System.Windows.Forms.Label();
            this.cmbRecQuestion = new System.Windows.Forms.ComboBox();
            this.cmbRecUser = new System.Windows.Forms.ComboBox();
            this.lblRecUser = new System.Windows.Forms.Label();
            this.lblRecQuestion = new System.Windows.Forms.Label();
            this.lblIncorrectAdmin = new System.Windows.Forms.Label();
            this.lblAdvise = new System.Windows.Forms.Label();
            this.bttnLogInAdmin = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.tabUserManager.SuspendLayout();
            this.tabCreateUser.SuspendLayout();
            this.tabRecuperateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(12, 46);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(73, 13);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Administrador:";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(15, 62);
            this.txtAdminName.MaxLength = 16;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(100, 20);
            this.txtAdminName.TabIndex = 1;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(12, 90);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(64, 13);
            this.lblAdminPass.TabIndex = 2;
            this.lblAdminPass.Text = "Contraseña:";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(15, 104);
            this.txtAdminPass.MaxLength = 16;
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPass.TabIndex = 2;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // lblRecuperateLink
            // 
            this.lblRecuperateLink.AutoSize = true;
            this.lblRecuperateLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperateLink.Location = new System.Drawing.Point(158, 90);
            this.lblRecuperateLink.Name = "lblRecuperateLink";
            this.lblRecuperateLink.Size = new System.Drawing.Size(94, 13);
            this.lblRecuperateLink.TabIndex = 16;
            this.lblRecuperateLink.Text = "Recuperar usuario";
            this.lblRecuperateLink.Click += new System.EventHandler(this.lblDeleteLink_Click);
            this.lblRecuperateLink.MouseLeave += new System.EventHandler(this.lblDeleteLink_MouseLeave);
            this.lblRecuperateLink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDeleteLink_MouseMove);
            // 
            // lblCreateLink
            // 
            this.lblCreateLink.AutoSize = true;
            this.lblCreateLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateLink.Location = new System.Drawing.Point(158, 65);
            this.lblCreateLink.Name = "lblCreateLink";
            this.lblCreateLink.Size = new System.Drawing.Size(117, 13);
            this.lblCreateLink.TabIndex = 15;
            this.lblCreateLink.Text = "Crear un nuevo usuario";
            this.lblCreateLink.Click += new System.EventHandler(this.lblCreateLink_Click);
            this.lblCreateLink.MouseLeave += new System.EventHandler(this.lblCreateLink_MouseLeave);
            this.lblCreateLink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCreateLink_MouseMove);
            // 
            // tabUserManager
            // 
            this.tabUserManager.Controls.Add(this.tabCreateUser);
            this.tabUserManager.Controls.Add(this.tabRecuperateUser);
            this.tabUserManager.Location = new System.Drawing.Point(277, -22);
            this.tabUserManager.Name = "tabUserManager";
            this.tabUserManager.SelectedIndex = 0;
            this.tabUserManager.Size = new System.Drawing.Size(391, 313);
            this.tabUserManager.TabIndex = 14;
            // 
            // tabCreateUser
            // 
            this.tabCreateUser.Controls.Add(this.txtAnswer);
            this.tabCreateUser.Controls.Add(this.cmbQuestion);
            this.tabCreateUser.Controls.Add(this.lblAnswer);
            this.tabCreateUser.Controls.Add(this.lblQuestion);
            this.tabCreateUser.Controls.Add(this.lblCreatedFailed);
            this.tabCreateUser.Controls.Add(this.lblCreatedSucesfully);
            this.tabCreateUser.Controls.Add(this.lblNewUserName);
            this.tabCreateUser.Controls.Add(this.lblNewUserPass);
            this.tabCreateUser.Controls.Add(this.lblNewUserPassConfirm);
            this.tabCreateUser.Controls.Add(this.bttnNewUserCreate);
            this.tabCreateUser.Controls.Add(this.txtNewUserName);
            this.tabCreateUser.Controls.Add(this.txtNewUserPass);
            this.tabCreateUser.Controls.Add(this.txtNewUserPassConfirm);
            this.tabCreateUser.Location = new System.Drawing.Point(4, 22);
            this.tabCreateUser.Name = "tabCreateUser";
            this.tabCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateUser.Size = new System.Drawing.Size(383, 264);
            this.tabCreateUser.TabIndex = 0;
            this.tabCreateUser.Text = "Create";
            this.tabCreateUser.UseVisualStyleBackColor = true;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(196, 82);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(121, 20);
            this.txtAnswer.TabIndex = 17;
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.FormattingEnabled = true;
            this.cmbQuestion.Items.AddRange(new object[] {
            "Name of your first pet?",
            "Name of your best friend in high school?",
            "City where you lived in your childhood?"});
            this.cmbQuestion.Location = new System.Drawing.Point(155, 34);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(222, 21);
            this.cmbQuestion.TabIndex = 16;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(226, 68);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(61, 13);
            this.lblAnswer.TabIndex = 15;
            this.lblAnswer.Text = "Respuesta:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(184, 18);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(163, 13);
            this.lblQuestion.TabIndex = 14;
            this.lblQuestion.Text = "Elige una pregunta de seguridad:";
            // 
            // lblCreatedFailed
            // 
            this.lblCreatedFailed.AutoSize = true;
            this.lblCreatedFailed.ForeColor = System.Drawing.Color.Red;
            this.lblCreatedFailed.Location = new System.Drawing.Point(101, 183);
            this.lblCreatedFailed.Name = "lblCreatedFailed";
            this.lblCreatedFailed.Size = new System.Drawing.Size(175, 13);
            this.lblCreatedFailed.TabIndex = 13;
            this.lblCreatedFailed.Text = "¡Algunos espacios están en blanco!";
            this.lblCreatedFailed.Visible = false;
            // 
            // lblCreatedSucesfully
            // 
            this.lblCreatedSucesfully.AutoSize = true;
            this.lblCreatedSucesfully.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCreatedSucesfully.Location = new System.Drawing.Point(101, 183);
            this.lblCreatedSucesfully.Name = "lblCreatedSucesfully";
            this.lblCreatedSucesfully.Size = new System.Drawing.Size(125, 13);
            this.lblCreatedSucesfully.TabIndex = 12;
            this.lblCreatedSucesfully.Text = "User created sucessfully!";
            this.lblCreatedSucesfully.Visible = false;
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(6, 3);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(134, 13);
            this.lblNewUserName.TabIndex = 4;
            this.lblNewUserName.Text = "Nombre del nuevo usuario:";
            // 
            // lblNewUserPass
            // 
            this.lblNewUserPass.AutoSize = true;
            this.lblNewUserPass.Location = new System.Drawing.Point(6, 44);
            this.lblNewUserPass.Name = "lblNewUserPass";
            this.lblNewUserPass.Size = new System.Drawing.Size(64, 13);
            this.lblNewUserPass.TabIndex = 5;
            this.lblNewUserPass.Text = "Contraseña:";
            // 
            // lblNewUserPassConfirm
            // 
            this.lblNewUserPassConfirm.AutoSize = true;
            this.lblNewUserPassConfirm.Location = new System.Drawing.Point(6, 85);
            this.lblNewUserPassConfirm.Name = "lblNewUserPassConfirm";
            this.lblNewUserPassConfirm.Size = new System.Drawing.Size(108, 13);
            this.lblNewUserPassConfirm.TabIndex = 6;
            this.lblNewUserPassConfirm.Text = "Repita la contraseña:";
            // 
            // bttnNewUserCreate
            // 
            this.bttnNewUserCreate.Location = new System.Drawing.Point(131, 155);
            this.bttnNewUserCreate.Name = "bttnNewUserCreate";
            this.bttnNewUserCreate.Size = new System.Drawing.Size(111, 23);
            this.bttnNewUserCreate.TabIndex = 11;
            this.bttnNewUserCreate.Text = "Crear nuevo usuario";
            this.bttnNewUserCreate.UseVisualStyleBackColor = true;
            this.bttnNewUserCreate.Click += new System.EventHandler(this.BttnNewUserCreate_Click);
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(9, 20);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserName.TabIndex = 7;
            // 
            // txtNewUserPass
            // 
            this.txtNewUserPass.Location = new System.Drawing.Point(9, 61);
            this.txtNewUserPass.Name = "txtNewUserPass";
            this.txtNewUserPass.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserPass.TabIndex = 8;
            // 
            // txtNewUserPassConfirm
            // 
            this.txtNewUserPassConfirm.Location = new System.Drawing.Point(9, 102);
            this.txtNewUserPassConfirm.Name = "txtNewUserPassConfirm";
            this.txtNewUserPassConfirm.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserPassConfirm.TabIndex = 9;
            // 
            // tabRecuperateUser
            // 
            this.tabRecuperateUser.Controls.Add(this.bttnRecuperate);
            this.tabRecuperateUser.Controls.Add(this.txtRecPassword);
            this.tabRecuperateUser.Controls.Add(this.lblRecPassword);
            this.tabRecuperateUser.Controls.Add(this.txtRecAnswer);
            this.tabRecuperateUser.Controls.Add(this.lblRecAnswer);
            this.tabRecuperateUser.Controls.Add(this.cmbRecQuestion);
            this.tabRecuperateUser.Controls.Add(this.cmbRecUser);
            this.tabRecuperateUser.Controls.Add(this.lblRecUser);
            this.tabRecuperateUser.Controls.Add(this.lblRecQuestion);
            this.tabRecuperateUser.Location = new System.Drawing.Point(4, 22);
            this.tabRecuperateUser.Name = "tabRecuperateUser";
            this.tabRecuperateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecuperateUser.Size = new System.Drawing.Size(383, 287);
            this.tabRecuperateUser.TabIndex = 1;
            this.tabRecuperateUser.Text = "Recuperate";
            this.tabRecuperateUser.UseVisualStyleBackColor = true;
            // 
            // bttnRecuperate
            // 
            this.bttnRecuperate.Location = new System.Drawing.Point(167, 196);
            this.bttnRecuperate.Name = "bttnRecuperate";
            this.bttnRecuperate.Size = new System.Drawing.Size(75, 23);
            this.bttnRecuperate.TabIndex = 8;
            this.bttnRecuperate.Text = "Recuperar";
            this.bttnRecuperate.UseVisualStyleBackColor = true;
            this.bttnRecuperate.Click += new System.EventHandler(this.BttnRecuperate_Click);
            // 
            // txtRecPassword
            // 
            this.txtRecPassword.Location = new System.Drawing.Point(10, 163);
            this.txtRecPassword.Name = "txtRecPassword";
            this.txtRecPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRecPassword.TabIndex = 7;
            // 
            // lblRecPassword
            // 
            this.lblRecPassword.AutoSize = true;
            this.lblRecPassword.Location = new System.Drawing.Point(7, 146);
            this.lblRecPassword.Name = "lblRecPassword";
            this.lblRecPassword.Size = new System.Drawing.Size(98, 13);
            this.lblRecPassword.TabIndex = 6;
            this.lblRecPassword.Text = "Nueva contraseña:";
            // 
            // txtRecAnswer
            // 
            this.txtRecAnswer.Location = new System.Drawing.Point(10, 116);
            this.txtRecAnswer.Name = "txtRecAnswer";
            this.txtRecAnswer.Size = new System.Drawing.Size(140, 20);
            this.txtRecAnswer.TabIndex = 5;
            // 
            // lblRecAnswer
            // 
            this.lblRecAnswer.AutoSize = true;
            this.lblRecAnswer.Location = new System.Drawing.Point(7, 100);
            this.lblRecAnswer.Name = "lblRecAnswer";
            this.lblRecAnswer.Size = new System.Drawing.Size(61, 13);
            this.lblRecAnswer.TabIndex = 4;
            this.lblRecAnswer.Text = "Respuesta:";
            // 
            // cmbRecQuestion
            // 
            this.cmbRecQuestion.FormattingEnabled = true;
            this.cmbRecQuestion.Items.AddRange(new object[] {
            "Name of your first pet?",
            "Name of your best friend in high school?",
            "City where you lived in your childhood?"});
            this.cmbRecQuestion.Location = new System.Drawing.Point(10, 67);
            this.cmbRecQuestion.Name = "cmbRecQuestion";
            this.cmbRecQuestion.Size = new System.Drawing.Size(222, 21);
            this.cmbRecQuestion.TabIndex = 3;
            // 
            // cmbRecUser
            // 
            this.cmbRecUser.FormattingEnabled = true;
            this.cmbRecUser.Location = new System.Drawing.Point(10, 23);
            this.cmbRecUser.Name = "cmbRecUser";
            this.cmbRecUser.Size = new System.Drawing.Size(121, 21);
            this.cmbRecUser.TabIndex = 2;
            // 
            // lblRecUser
            // 
            this.lblRecUser.AutoSize = true;
            this.lblRecUser.Location = new System.Drawing.Point(7, 7);
            this.lblRecUser.Name = "lblRecUser";
            this.lblRecUser.Size = new System.Drawing.Size(134, 13);
            this.lblRecUser.TabIndex = 1;
            this.lblRecUser.Text = "Elija el usuario a recuperar:";
            // 
            // lblRecQuestion
            // 
            this.lblRecQuestion.AutoSize = true;
            this.lblRecQuestion.Location = new System.Drawing.Point(7, 51);
            this.lblRecQuestion.Name = "lblRecQuestion";
            this.lblRecQuestion.Size = new System.Drawing.Size(161, 13);
            this.lblRecQuestion.TabIndex = 0;
            this.lblRecQuestion.Text = "Seleccione la pregunta correcta:";
            // 
            // lblIncorrectAdmin
            // 
            this.lblIncorrectAdmin.AutoSize = true;
            this.lblIncorrectAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrectAdmin.Location = new System.Drawing.Point(12, 166);
            this.lblIncorrectAdmin.Name = "lblIncorrectAdmin";
            this.lblIncorrectAdmin.Size = new System.Drawing.Size(203, 13);
            this.lblIncorrectAdmin.TabIndex = 13;
            this.lblIncorrectAdmin.Text = "¡Nombre o contraseña incorrectos!";
            this.lblIncorrectAdmin.Visible = false;
            // 
            // lblAdvise
            // 
            this.lblAdvise.AutoSize = true;
            this.lblAdvise.Location = new System.Drawing.Point(91, 9);
            this.lblAdvise.Name = "lblAdvise";
            this.lblAdvise.Size = new System.Drawing.Size(100, 13);
            this.lblAdvise.TabIndex = 12;
            this.lblAdvise.Text = "¡Bienvenido, admin!";
            // 
            // bttnLogInAdmin
            // 
            this.bttnLogInAdmin.Location = new System.Drawing.Point(15, 133);
            this.bttnLogInAdmin.Name = "bttnLogInAdmin";
            this.bttnLogInAdmin.Size = new System.Drawing.Size(91, 23);
            this.bttnLogInAdmin.TabIndex = 3;
            this.bttnLogInAdmin.Text = "Iniciar sesión";
            this.bttnLogInAdmin.UseVisualStyleBackColor = true;
            this.bttnLogInAdmin.Click += new System.EventHandler(this.BttnLogInAdmin_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(15, 215);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(91, 23);
            this.bttnExit.TabIndex = 4;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 286);
            this.ControlBox = false;
            this.Controls.Add(this.tabUserManager);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.lblRecuperateLink);
            this.Controls.Add(this.lblAdvise);
            this.Controls.Add(this.lblCreateLink);
            this.Controls.Add(this.lblAdminPass);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblIncorrectAdmin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.bttnLogInAdmin);
            this.Name = "FormConfiguration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.tabUserManager.ResumeLayout(false);
            this.tabCreateUser.ResumeLayout(false);
            this.tabCreateUser.PerformLayout();
            this.tabRecuperateUser.ResumeLayout(false);
            this.tabRecuperateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label lblAdvise;
        private System.Windows.Forms.Button bttnNewUserCreate;
        private System.Windows.Forms.Button bttnLogInAdmin;
        private System.Windows.Forms.TextBox txtNewUserPassConfirm;
        private System.Windows.Forms.TextBox txtNewUserPass;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label lblNewUserPassConfirm;
        private System.Windows.Forms.Label lblNewUserPass;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label lblIncorrectAdmin;
        private System.Windows.Forms.TabControl tabUserManager;
        private System.Windows.Forms.TabPage tabCreateUser;
        private System.Windows.Forms.TabPage tabRecuperateUser;
        private System.Windows.Forms.Label lblCreatedFailed;
        private System.Windows.Forms.Label lblCreatedSucesfully;
        private System.Windows.Forms.Label lblCreateLink;
        private System.Windows.Forms.Label lblRecuperateLink;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button bttnRecuperate;
        private System.Windows.Forms.TextBox txtRecPassword;
        private System.Windows.Forms.Label lblRecPassword;
        private System.Windows.Forms.TextBox txtRecAnswer;
        private System.Windows.Forms.Label lblRecAnswer;
        private System.Windows.Forms.ComboBox cmbRecQuestion;
        private System.Windows.Forms.ComboBox cmbRecUser;
        private System.Windows.Forms.Label lblRecUser;
        private System.Windows.Forms.Label lblRecQuestion;
    }
}