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
    public partial class FormPayment : Form
    {
        MovementCollection movementCollection = new MovementCollection();
        User user = new User();
        XMLMovements xmlMovements = new XMLMovements();

        public FormPayment(MovementCollection movementCollection, User user)
        {
            InitializeComponent();
            this.movementCollection = movementCollection;
            this.user = user;
            cmbService.Enabled = false;
            txtConcept.Enabled = false;
        }

        private void bttnCancelMakePayment_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void bttnPay_Click(object sender, EventArgs e)
        {
            if(numAmount.Value > 1)
            {
                Movement movement = new Movement();
                if (cmbPayment.SelectedIndex == 0)
                {
                    movement.Concept = Convert.ToString(cmbPayment.SelectedItem + " " + cmbService.SelectedItem);
                }
                else
                {
                    if (cmbPayment.SelectedIndex == 1)
                    {
                        movement.Concept = Convert.ToString(cmbPayment.SelectedItem);
                    }
                    else
                    {
                        movement.Concept = txtConcept.Text;
                    }
                }

                movement.Amount = Convert.ToDouble(numAmount.Value);
                movement.Date = DateTime.Now;
                movement.ItsIncome = false;
                movement.User = user;

                movementCollection.Add(movement);
                xmlMovements.GenerateXMLMovements(movementCollection.GetAll());
                txtConcept.Text = null;
                Hide();
            }
            else
            {
                MessageBox.Show("The value can't be negative nor equal to 1.");
            }  
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPayment.SelectedIndex == 0)
            {
                cmbService.Enabled = true;
                txtConcept.Text = null;
                txtConcept.Enabled = false;
            }
            else
            {
                if(cmbPayment.SelectedIndex == 1)
                {
                    txtConcept.Enabled = false;
                    cmbService.Enabled = false;
                }
                else
                {
                    if(cmbPayment.SelectedIndex == 2)
                    {
                        cmbService.Enabled = false;
                        txtConcept.Enabled = true;
                    }
                }
            }
        }

    }
}
