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
    public partial class FormMenu : Form
    {
        private GarageCollection garageCollection = new GarageCollection();
        private MovementCollection movementCollection = new MovementCollection();
        private RentalCollection rentalCollection = new RentalCollection();
        private List<RentalMonth> alerts = new List<RentalMonth>();
        private CashCountCollection cashCountCollection = new CashCountCollection();
        private CashCount cashCount = new CashCount();
        private User user = new User();

        private XMLRentals xmlRentals = new XMLRentals();
        private XMLMovements xmlMovements = new XMLMovements();
        private XMLCashCount xmlCashCounts = new XMLCashCount();

        public FormMenu(User user)
        {
            InitializeComponent();
            this.user = user;
            cashCount.User = user;
            bttnManager.Enabled = true;
            bttnDisplay.Enabled = true;
            bttnMakePayment.Enabled = true;
            bttnMakeCashCount.Enabled = true;
        }

        private void bttnManager_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            BindData();
        }

        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
            BindData();
        }

        private void bttnRegister_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
            BindData();
        }

        private void bttnCashCount_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
            BindData();
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void bttnMakePayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(movementCollection, user);
            formPayment.Owner = this;
            formPayment.ShowDialog();
        }

        private void bttnMakeCashCount_Click(object sender, EventArgs e)
        {

            double Income = 0;
            double Outcome = 0;

            foreach (Movement movement in movementCollection.GetItsIncome())
            {
                Income += movement.Amount;
            }

            foreach (Movement movement in movementCollection.GetItsOutcome())
            {
                Outcome += movement.Amount;
            }

            lblBalance.Text = Convert.ToString(Income - Outcome);
            cashCount.Date = DateTime.Now;
            cashCountCollection.Add(cashCount);

            foreach (Movement movement in movementCollection.GetAll())
            {
                if (movement.CashCount == null)
                {
                    movement.CashCount = cashCount;
                }
            }

            xmlMovements.GenerateXMLMovements(movementCollection.GetAll());
            xmlCashCounts.GenerateXMLCashCounts(cashCountCollection.GetAll());

            BindData();
        }

        public void BindData()
        {
            dgvIncomes.DataSource = movementCollection.GetItsIncome();
            dgvOutcomes.DataSource = movementCollection.GetItsOutcome();
            dgvCashCount.DataSource = cashCountCollection.GetAll();
            dgvExpire.DataSource = alerts;
        }

        private void bttnAny_Click(object sender, EventArgs e)
        {
            Button clickedBttn = sender as Button;
            FormAddVehicle formAddVehcle = new FormAddVehicle(garageCollection, rentalCollection, movementCollection, user, clickedBttn);
            formAddVehcle.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                cashCountCollection.AddCashCountList(xmlCashCounts.GetCashCounts());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            xmlCashCounts.GenerateXMLCashCounts(cashCountCollection.GetAll());

            try
            {
                rentalCollection.AddRentalsList(xmlRentals.GetRentals());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            xmlRentals.GenerateXMLRentals(rentalCollection.GetAll());

            try
            {
                movementCollection.AddMovementsList(xmlMovements.GetMovements());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            xmlMovements.GenerateXMLMovements(movementCollection.GetAll());

            int amountAlerts = 0;
            BindData();
            DataGridViewColumn Column = dgvIncomes.Columns[3];
            Column.Visible = false;
            Column = dgvOutcomes.Columns[3];
            Column.Visible = false;
            


            try
            {
                foreach (Rental rental in xmlRentals.GetRentals())
                {
                    if (rental.Garage.State == false)
                    {
                        garageCollection.Add(rental.Garage);
                        if (rental is RentalMonth)
                        {
                            RentalMonth rentalMonth = (RentalMonth)rental;
                            TimeSpan dateAux = rentalMonth.DueDate - DateTime.Today;
                            if (dateAux.TotalDays <= 5)
                            {
                                alerts.Add(rentalMonth);
                                amountAlerts = amountAlerts + 1;
                            }
                        }
                    }
                }
                
                foreach (Button button in groupGarages.Controls)
                {
                    Rental rental = rentalCollection.SearchRentByNumber(Convert.ToInt16(button.Text));

                    if (rental != null)
                    {
                        if (rental.Garage.State == false)
                        {
                            button.BackColor = Color.Red;
                            if (rental is RentalHour)
                            {
                                button.Text = button.Text + " HOUR\n" + rental.Garage.Vehicle.TypeVehicle.Description + " \n" + rental.Garage.Vehicle.Domain;
                            }
                            else
                            {
                                button.Text = button.Text + " MONTH\n" + rental.Garage.Vehicle.TypeVehicle.Description + " \n" + rental.Garage.Vehicle.Domain;
                            }
                            rental = null;
                        }
                    }
                } 

                if (amountAlerts > 0)
                {
                    MessageBox.Show("¡ " + amountAlerts + " alquileres a punto de terminar! Revisar ¡Alertas! para más información.");
                }
            }
            catch
            {
                MessageBox.Show("¡Error cargando cocheras. Avisar a administrador! (Error 001 - XML)");
            }
        }

        private void dgvCashCount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIncomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
