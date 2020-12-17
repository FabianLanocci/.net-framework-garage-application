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
    public partial class FormLogIn : Form
    {
        private UserCollection userCollection = new UserCollection();
        private XMLUsers xmlUsers = new XMLUsers();

        public FormLogIn()
        {
            InitializeComponent();
            bttnConfiguration.BringToFront();
            bttnExit.BringToFront();
        }

        private void BttnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "")
            {
                if(txtPassword.Text != "")
                {
                    if ((userCollection.Search(txtUser.Text).UserName == txtUser.Text && userCollection.Search(txtUser.Text).Password == txtPassword.Text) || (txtUser.Text == "admin" && txtPassword.Text == "1234"))
                    {
                        lblIncorrect.Visible = false;
                        userCollection.Search(txtUser.Text).LastAcess = DateTime.Now;
                        xmlUsers.GenerateXMLUsers(userCollection.GetAll());
                        FormMenu formMenu = new FormMenu(userCollection.Search(txtUser.Text));
                        formMenu.Show();
                        Hide();
                    }
                    else
                    {
                        lblIncorrect.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se ha ingresado ninguna contraseña.");
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún nombre de usuario.");
            }              
        }

        private void BttnConfiguration_Click(object sender, EventArgs e)
        {
            FormConfiguration formConfiguration = new FormConfiguration(userCollection);
            formConfiguration.ShowDialog();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                userCollection.AddUsersList(xmlUsers.GetUsers());
            }
            catch
            {
                MessageBox.Show("Error charging users from the xml.");
            }
            xmlUsers.GenerateXMLUsers(userCollection.GetAll());
        }

        private void lblChangePassword_MouseMove(object sender, MouseEventArgs e)
        {
            lblChangePassword.ForeColor = Color.Blue;
        }

        private void lblChangePassword_MouseLeave(object sender, EventArgs e)
        {
            lblChangePassword.ForeColor = Color.Black;
        }

        private void lblChangePassword_MouseClick(object sender, MouseEventArgs e)
        {
            FormConfiguration formConfiguration = new FormConfiguration(userCollection);
            formConfiguration.ShowDialog();
        }
    }
}
