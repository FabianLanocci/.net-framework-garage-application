using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoFinal
{
    public partial class FormConfiguration : Form
    {
        private UserCollection userCollection = new UserCollection();
        private XMLUsers xmlUsers = new XMLUsers();

        public FormConfiguration(UserCollection userCollection)
        {
            InitializeComponent();
            this.userCollection = userCollection;
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            tabUserManager.Visible = false;
            lblCreateLink.Visible = false;
            lblRecuperateLink.Visible = false;
            cmbQuestion.SelectedIndex = 0;
            cmbRecQuestion.SelectedIndex = 0;
            cmbRecUser.DataSource = userCollection.GetAll();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BttnLogInAdmin_Click(object sender, EventArgs e)
        {
            if((txtAdminName.Text == "admin") && (txtAdminPass.Text == "1234"))
            {
                //Setear ambos resultados de la creacion de un nuevo usuario en ocultos para evitar que aparezca
                //alguno ya seteado de antes sin querer
                lblCreatedSucesfully.Visible = false;
                lblCreatedFailed.Visible = false;

                lblCreateLink.Visible = true;
                lblRecuperateLink.Visible = true;
            }
            else
            {
                lblIncorrectAdmin.Visible = true;
            }
        }

        private void BttnNewUserCreate_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (!userCollection.SearchUserByName(txtNewUserName.Text))
            {
                if (txtNewUserPass.Text == txtNewUserPassConfirm.Text && txtNewUserName.Text != "" && txtNewUserPass.Text != "" && txtAnswer.Text != "")
                {
                    lblCreatedSucesfully.Visible = true;
                    lblCreatedFailed.Visible = false;
                    user.UserName = txtNewUserName.Text;
                    user.Password = txtNewUserPass.Text;
                    user.Question = cmbQuestion.SelectedItem.ToString();
                    user.Answer = txtAnswer.Text;
                    userCollection.Add(user);
                    xmlUsers.GenerateXMLUsers(userCollection.GetAll());
                }
                else
                {
                    lblCreatedSucesfully.Visible = false;
                    lblCreatedFailed.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Este usuario ya existe.");
            }
        }

        private void lblCreateLink_MouseMove(object sender, MouseEventArgs e)
        {
            lblCreateLink.ForeColor = Color.Blue;
        }

        private void lblCreateLink_MouseLeave(object sender, EventArgs e)
        {
            lblCreateLink.ForeColor = Color.Black;
        }

        private void lblDeleteLink_MouseMove(object sender, MouseEventArgs e)
        {
            lblRecuperateLink.ForeColor = Color.Blue;
        }

        private void lblDeleteLink_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperateLink.ForeColor = Color.Black;
        }

        private void lblCreateLink_Click(object sender, EventArgs e)
        {
            tabUserManager.Visible = true;
            tabUserManager.SelectedIndex = 0;
        }

        private void lblDeleteLink_Click(object sender, EventArgs e)
        {
            tabUserManager.Visible = true;
            tabUserManager.SelectedIndex = 1;
        }

        private void BttnRecuperate_Click(object sender, EventArgs e)
        {

            if (userCollection.Search(cmbRecUser.SelectedItem.ToString()).Question == cmbRecQuestion.SelectedItem.ToString())
            {
                if (userCollection.Search(cmbRecUser.SelectedItem.ToString()).Answer == txtRecAnswer.Text)
                {
                    if (txtRecPassword.Text != "")
                    {
                        userCollection.Search(cmbRecUser.SelectedItem.ToString()).Password = txtRecPassword.Text;
                        xmlUsers.GenerateXMLUsers(userCollection.GetAll());
                        MessageBox.Show("Contraseña restaurada correctamente. La nueva contraseña es: " + txtRecPassword.Text);
                    }
                    else
                    {
                        MessageBox.Show("No puedes crear un usuario sin contraseña.");
                    }
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectos.");
            }
        }
    }
}
