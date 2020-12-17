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
    public partial class FormAddVehicle : Form
    {
        private GarageCollection garageCollection = new GarageCollection();
        private RentalCollection rentalCollection = new RentalCollection();
        private MovementCollection movementCollection = new MovementCollection();
        private Button clickedBttn = new Button();
        private User user = new User();
        private XMLRentals xmlRentals = new XMLRentals();
        private XMLMovements xmlMovements = new XMLMovements();

        public FormAddVehicle(GarageCollection garageCollection, RentalCollection rentalCollection, MovementCollection movementCollection, User user, Button clickedBttn)
        {
            InitializeComponent();
            this.garageCollection = garageCollection;
            this.rentalCollection = rentalCollection;
            this.movementCollection = movementCollection;
            this.user = user;
            this.clickedBttn = clickedBttn;

            maskDomain.ReadOnly = false;
            txtBrand.ReadOnly = false;
            maskDomain.ReadOnly = false;
            txtModel.ReadOnly = false;
            cmbTypeOfVehicle.Enabled = true;

            bttnAdd.Enabled = true;

            lblMonth.Visible = false;
            numMonth.Visible = false;
            lblOwner.Visible = false;
            txtOwner.Visible = false;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Garage garage = new Garage();
                Vehicle vehicle = new Vehicle();
                TypeVehicle typeVehicle = new TypeVehicle();

                garage.Number = Convert.ToInt16(lblNumber.Text);
                garage.Ubication = lblUbication.Text;
                garage.State = false;
           
                vehicle.Domain = maskDomain.Text;
                vehicle.Brand = txtBrand.Text;
                vehicle.Model = txtModel.Text;
                garage.Vehicle = vehicle;

                switch (cmbTypeOfVehicle.SelectedIndex)
                {
                    case 0:
                        {
                            typeVehicle.Code = "1";
                            typeVehicle.Description = cmbTypeOfVehicle.SelectedItem.ToString();
                            break;
                        }
                    case 1:
                        {
                            typeVehicle.Code = "2";
                            typeVehicle.Description = cmbTypeOfVehicle.SelectedItem.ToString();
                            break;
                        }
                    case 2:
                        {
                            typeVehicle.Code = "3";
                            typeVehicle.Description = cmbTypeOfVehicle.SelectedItem.ToString();
                            break;
                        }
                }

                garage.Vehicle.TypeVehicle = typeVehicle;

            if (rentalCollection.IfDomainExists(maskDomain.Text))
            {
                MessageBox.Show("This domain already exists.");
            }
            else
            {
                if (radBttnHour.Checked == true)
                {
                    RentalHour rentalHour = new RentalHour();

                    rentalHour.Date = DateTime.Now;
                    rentalHour.Garage = garage;
                    rentalHour.Since = DateTime.Now;
                    rentalCollection.Add(rentalHour);
                    xmlRentals.GenerateXMLRentals(rentalCollection.GetAll());
                    clickedBttn.Text = clickedBttn.Text + " HOUR\n" + garage.Vehicle.TypeVehicle.Description + " \n" + garage.Vehicle.Domain;
                }
                else
                {
                    RentalMonth rentalMonth = new RentalMonth();
                    Movement movement = new Movement();

                    rentalMonth.Date = DateTime.Now;
                    rentalMonth.Garage = garage;
                    rentalMonth.Holder = txtOwner.Text;
                    rentalMonth.DueDate = rentalMonth.Date.AddMonths(Convert.ToInt16(numMonth.Value));
                    rentalCollection.Add(rentalMonth);
                    xmlRentals.GenerateXMLRentals(rentalCollection.GetAll());
                    movement.Concept = "MONTH: " + garage.Vehicle.TypeVehicle.Description + " " + garage.Vehicle.Domain;
                    movement.Amount = rentalMonth.CalculateAmount();
                    movement.Date = DateTime.Now;
                    movement.ItsIncome = true;
                    movement.User = user;
                    movement.CashCount = null;
                    movementCollection.Add(movement);
                    xmlMovements.GenerateXMLMovements(movementCollection.GetAll());
                    MessageBox.Show("You have to charge " + movement.Amount + " to your client.");
                    clickedBttn.Text = clickedBttn.Text + " MONTH\n" + garage.Vehicle.TypeVehicle.Description + " \n" + garage.Vehicle.Domain;
                }

                garageCollection.Add(garage);

                clickedBttn.BackColor = Color.Red;
                Close();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}


        private void Complete(Garage garage)
        {
            txtDomainComplete.Text = garage.Vehicle.Domain;
            txtBrand.Text = garage.Vehicle.Brand;
            txtModel.Text = garage.Vehicle.Model;

            switch(garage.Vehicle.TypeVehicle.Code)
            {
                case "1":
                    {
                        cmbTypeOfVehicle.SelectedIndex = 0;
                        break;
                    }
                case "2":
                    {
                        cmbTypeOfVehicle.SelectedIndex = 1;
                        break;
                    }
                case "3":
                    {
                        cmbTypeOfVehicle.SelectedIndex = 2;
                        break;
                    }
            }

            maskDomain.ReadOnly = true;
            txtBrand.ReadOnly = true;
            txtModel.ReadOnly = true;
            cmbTypeOfVehicle.Enabled = false;
        }

        private void FormAddVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                txtDomainComplete.Visible = false;
                txtDomainComplete.Enabled = false;
                numRenew.Visible = false;
                numRenew.Enabled = false;
                bttnEnd.Enabled = false;
                bttnEnd.Visible = false;
                maskDomain.Enabled = false;
                lblNumber.Text = Convert.ToString(GetButtonNumber(clickedBttn));
                lblUbication.Text = Ubication(GetButtonNumber(clickedBttn));
                bttnAdd.Enabled = true;
                bttnAdd.Visible = true;
                bttnRenew.Enabled = false;
                bttnRenew.Visible = false;
                lblChoose.Visible = true;
                panelChooseRental.Visible = true;

                if (clickedBttn.BackColor == Color.Red)
                {
                    if(clickedBttn.Text.Substring(2,5)=="MONTH" || clickedBttn.Text.Substring(3,5) == "MONTH")
                    {
                        bttnRenew.Enabled = true;
                        bttnRenew.Visible = true;
                        numRenew.Enabled = true;
                        numRenew.Visible = true;
                    }
                        bttnAdd.Enabled = false;
                        bttnAdd.Visible = false;
                        bttnEnd.Enabled = true;
                        bttnEnd.Visible = true;
                        txtDomainComplete.Visible = true;
                        txtDomainComplete.Enabled = true;
                        panelChooseRental.Visible = false;
                        Garage auxGarage = new Garage();
                        auxGarage = garageCollection.SearchByNumber(GetButtonNumber(clickedBttn));
                        Complete(auxGarage);
                        bttnAdd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string Ubication(int number)
        {
            if (number >= 1 && number <= 6)
            {
                return "A";
            }
            else
            {
                if (number > 6 && number <= 16)
                {
                    return "B";
                }
                else
                {
                    if (number > 16 && number <= 22)
                    {
                        return "C";
                    }
                    else
                    {
                        if (number > 22 && number <= 30)
                        {
                            return "D";
                        }
                    }
                }
                return null;
            }
        }


        private void bttnNew_Click(object sender, EventArgs e)
        {
            maskDomain.Enabled = true;
            switch(cmbTypeOfVehicle.SelectedIndex)
            {
                case 0:
                    {
                        maskDomain.Mask = "L00 0LLL";
                        break;
                    }
                case 1:
                    {
                        maskDomain.Mask = "LL 000 LL";
                        break;
                    }
                case 2:
                    {
                        maskDomain.Mask = "LL 000 LL";
                        break;
                    }
            }
        }

        private void bttnOld_Click(object sender, EventArgs e)
        {
            maskDomain.Enabled = true;
            switch (cmbTypeOfVehicle.SelectedIndex)
            {
                case 0:
                    {
                        maskDomain.Mask = "000 LLL";
                        break;
                    }
                case 1:
                    {
                        maskDomain.Mask = "LLL 000";
                        break;
                    }
                case 2:
                    {
                        maskDomain.Mask = "LLL 000";
                        break;
                    }
            }
        }

        private void radBttnMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radBttnMonth.Checked == true)
            {
                lblMonth.Visible = true;
                numMonth.Visible = true;
                lblOwner.Visible = true;
                txtOwner.Visible = true;
                radBttnHour.Checked = false;
            }
        }

        private void radBttnHour_CheckedChanged(object sender, EventArgs e)
        {
            if (radBttnHour.Checked == true)
            {
                lblMonth.Visible = false;
                numMonth.Visible = false;
                lblOwner.Visible = false;
                txtOwner.Visible = false;
                radBttnMonth.Checked = false;
            }
        }

        private int GetButtonNumber(Button button)
        {
            if (button.BackColor == Color.Red)
            {
                if (button.Text.Substring(1, 1) == " ")
                {
                    return Convert.ToInt16(button.Text.Substring(0, 1));
                }
                else if (button.Text.Substring(2, 1) == " ")
                {
                    return Convert.ToInt16(button.Text.Substring(0, 2));
                }
                return 0;
            }
            else
            {
                return Convert.ToInt32(button.Text);
            }
        }

        private void BttnRenew_Click(object sender, EventArgs e)
        {
            try
            {
                Movement movement = new Movement();
                movement.Concept = "MONTH: " + cmbTypeOfVehicle.SelectedItem.ToString() + " " + txtDomainComplete.Text;
                movement.Amount = Convert.ToInt32(numRenew.Value) * 1500;
                movement.Date = DateTime.Now;
                movement.ItsIncome = true;
                movement.User = user;
                movementCollection.Add(movement);
                xmlMovements.GenerateXMLMovements(movementCollection.GetAll());
                rentalCollection.SearchRentMonthByNumber(Convert.ToInt16(lblNumber.Text)).DueDate.AddMonths(Convert.ToInt32(numRenew.Value));
                rentalCollection.AddRentalsList(xmlRentals.GetRentals());
                MessageBox.Show("Charge your client " + Convert.ToInt32(numRenew.Value) * 1500 + " so he can renew his rent.");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (clickedBttn.Text.Substring(2, 5) == "MONTH" || clickedBttn.Text.Substring(3, 5) == "MONTH")
                {
                    clickedBttn.BackColor = Color.Chartreuse;
                    clickedBttn.Text = lblNumber.Text;
                    rentalCollection.SearchRentByNumber(Convert.ToInt16(lblNumber.Text)).Garage.State = true;
                    xmlRentals.GenerateXMLRentals(rentalCollection.GetAll());
                    Close();
                }
                else if (clickedBttn.Text.Substring(2, 4) == "HOUR" || clickedBttn.Text.Substring(3, 4) == "HOUR")
                {
                    Movement movement = new Movement();
                    Garage auxGarage = new Garage();

                    auxGarage = rentalCollection.SearchRentByNumber(Convert.ToInt16(lblNumber.Text)).Garage;

                    clickedBttn.BackColor = Color.Chartreuse;
                    clickedBttn.Text = lblNumber.Text;

                    rentalCollection.SearchRentByNumber(Convert.ToInt16(lblNumber.Text)).Garage.State = true;
                    xmlRentals.GenerateXMLRentals(rentalCollection.GetAll());
                    movement.Amount = rentalCollection.SearchRentByNumber(Convert.ToInt16(lblNumber.Text)).CalculateAmount();
                    movement.Concept = "HOUR: " + auxGarage.Vehicle.TypeVehicle.Description + " " + auxGarage.Vehicle.Domain;
                    movement.Date = DateTime.Now;
                    movement.ItsIncome = true;
                    movement.User = user;
                    movement.CashCount = null;
                    movementCollection.Add(movement);
                    xmlMovements.GenerateXMLMovements(movementCollection.GetAll());
                    garageCollection.Remove(garageCollection.SearchByNumber(Convert.ToInt16(lblNumber.Text)));
                    MessageBox.Show("You have to charge " + movement.Amount + " to your client.");
                    Close();
                }
                garageCollection.Remove(garageCollection.SearchByNumber(Convert.ToInt16(lblNumber.Text)));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
