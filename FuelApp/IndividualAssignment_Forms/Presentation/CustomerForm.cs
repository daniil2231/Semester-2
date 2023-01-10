using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualAssignment_Forms
{
    public partial class CustomerForm : Form
    {
        AccountManager accountManager;
        FuelManager fuelManager;
        Customer customer;

        IFuelRepository realFuelRepo = new FuelRepository();
        IAccountRepository realAccRepo = new AccountRepository();

        public CustomerForm()
        {
            InitializeComponent();
            tcCustomer.SelectedTab = tabBuyFuel;
            btnBuyFuelRedir.Enabled = false;
            accountManager = new AccountManager(realAccRepo);
            fuelManager = new FuelManager(realFuelRepo);
        }

        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            tcCustomer.SelectedTab = tabBuyFuel;
            btnBuyFuelRedir.Enabled = false;
            accountManager = new AccountManager(realAccRepo);
            fuelManager = new FuelManager(realFuelRepo);
            this.customer = customer;

            tbUsername.Text = customer.Username;
            tbUsername.Enabled = false;
            tbPassword.Text = customer.Password;
            tbCardNumber.Text = customer.CardNumber.ToString();
            dtpCardValidThru.Value = customer.CardValidThru;
            tbCardCVC.Text = customer.CardCVC.ToString();
            tbZipCode.Text = customer.ZipCode;
            tbPhoneNumber.Text = customer.PhoneNumber.ToString();

            SetDiesel();
            SetCNG();
        }

        private void btnMyProfileRedir_Click(object sender, EventArgs e)
        {
            tcCustomer.SelectedTab = tabMyProfile;
            btnMyProfileRedirect.Enabled = false;
        }

        private void btnBuyFuelRedirect_Click(object sender, EventArgs e)
        {
            tcCustomer.SelectedTab = tabBuyFuel;
        }

        public void SetCNG()
        {
            try
            {
                GroupBox[] groupBoxes = new GroupBox[fuelManager.GetCNGs().Count];
                Label[] prices = new Label[fuelManager.GetCNGs().Count];
                Label[] purities = new Label[fuelManager.GetCNGs().Count];
                Label[] airflowResistances = new Label[fuelManager.GetCNGs().Count];
                Label[] suitabilities = new Label[fuelManager.GetCNGs().Count];
                TextBox[] literTextBoxes = new TextBox[fuelManager.GetCNGs().Count];
                Button[] buyButtons = new Button[fuelManager.GetCNGs().Count];
                Label[] fillTimes = new Label[fuelManager.GetCNGs().Count];

                for (int i = 0; i < fuelManager.GetCNGs().Count; i++)
                {
                    string fuelName = fuelManager.GetCNGs()[i].FuelName;
                    groupBoxes[i] = new GroupBox();
                    groupBoxes[i].Name = "gbCNG" + i;
                    groupBoxes[i].Text = fuelName;
                    groupBoxes[i].Size = new Size(250, 345);

                    prices[i] = new Label();
                    prices[i].Name = "lblCNGPrice" + i;
                    prices[i].Text = $"${fuelManager.GetCNGs()[i].PricePerLiter:f2}/L";
                    prices[i].Dock = DockStyle.Top;
                    double price = fuelManager.GetCNGs()[i].PricePerLiter;

                    purities[i] = new Label();
                    purities[i].Name = "lblCNGPurity" + i;
                    purities[i].Text = $"Purity: {fuelManager.GetCNGs()[i].Purity}%";
                    purities[i].Dock = DockStyle.Top;

                    airflowResistances[i] = new Label();
                    airflowResistances[i].Name = "lblCNGViscosity" + i;
                    airflowResistances[i].Text = $"Viscosity: {fuelManager.GetCNGs()[i].AirflowResistance:f2}";
                    airflowResistances[i].Dock = DockStyle.Top;

                    suitabilities[i] = new Label();
                    suitabilities[i].Name = "lblCNGSuitability" + i;
                    suitabilities[i].Text = $"Suitable for: {fuelManager.GetCNGs()[i].Suitability:f2}";
                    suitabilities[i].Dock = DockStyle.Top;

                    literTextBoxes[i] = new TextBox();
                    literTextBoxes[i].Name = "tbCNGLitersToBuy" + i;
                    literTextBoxes[i].PlaceholderText = "Liters..."; ;
                    literTextBoxes[i].Dock = DockStyle.Bottom;
                    TextBox litersTextBox = literTextBoxes[i];


                    fillTimes[i] = new Label();
                    fillTimes[i].Name = "lblCNGFillTime" + i;
                    fillTimes[i].Text = "";
                    fillTimes[i].Dock = DockStyle.Bottom;
                    Label fillTime = fillTimes[i];

                    buyButtons[i] = new Button();
                    buyButtons[i].Name = "btnCNGBuy" + i;
                    buyButtons[i].Text = "Buy";
                    buyButtons[i].Dock = DockStyle.Bottom;
                    buyButtons[i].Click += (s, e) =>
                    {
                        if (Convert.ToDouble(litersTextBox.Text) > 0)
                        {
                            fuelManager.BuyFuel(fuelManager.FindCNG(fuelName), customer, Convert.ToDouble(litersTextBox.Text));
                            fillTime.Text = $"Fill time: {fuelManager.FindCNG(fuelName).CalculateFillUpTime(Convert.ToDouble(litersTextBox.Text)):f2} seconds";
                        }
                        else
                        {
                            MessageBox.Show("Please state a valid number of liters");
                        }
                    };
                }

                for (int i = 0; i < fuelManager.GetCNGs().Count; i++)
                {
                    flowBuyFuel.Controls.Add(groupBoxes[i]);

                    groupBoxes[i].Controls.Add(suitabilities[i]);
                    groupBoxes[i].Controls.Add(airflowResistances[i]);
                    groupBoxes[i].Controls.Add(purities[i]);
                    groupBoxes[i].Controls.Add(prices[i]);
                    groupBoxes[i].Controls.Add(literTextBoxes[i]);
                    groupBoxes[i].Controls.Add(buyButtons[i]);
                    groupBoxes[i].Controls.Add(fillTimes[i]);
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with displaying Diesel");
            }
        }

        public void SetDiesel()
        {
            try
            {
                GroupBox[] groupBoxes = new GroupBox[fuelManager.GetDiesels().Count];
                Label[] prices = new Label[fuelManager.GetDiesels().Count];
                Label[] purities = new Label[fuelManager.GetDiesels().Count];
                Label[] viscosities = new Label[fuelManager.GetDiesels().Count];
                Label[] suitabilities = new Label[fuelManager.GetDiesels().Count];
                TextBox[] literTextBoxes = new TextBox[fuelManager.GetDiesels().Count];
                Button[] buyButtons = new Button[fuelManager.GetDiesels().Count];
                Label[] fillTimes = new Label[fuelManager.GetDiesels().Count];

                for (int i = 0; i < fuelManager.GetDiesels().Count; i++)
                {
                    string fuelName = fuelManager.GetDiesels()[i].FuelName;
                    groupBoxes[i] = new GroupBox();
                    groupBoxes[i].Name = "gbFuel" + i;
                    groupBoxes[i].Text = fuelName;
                    groupBoxes[i].Size = new Size(250, 345);

                    prices[i] = new Label();
                    prices[i].Name = "lblDieselPrice" + i;
                    prices[i].Text = $"${fuelManager.GetDiesels()[i].PricePerLiter:f2}/L";
                    prices[i].Dock = DockStyle.Top;
                    double price = fuelManager.GetDiesels()[i].PricePerLiter;

                    purities[i] = new Label();
                    purities[i].Name = "lblDieselPurity" + i;
                    purities[i].Text = $"Purity: {fuelManager.GetDiesels()[i].Purity}%";
                    purities[i].Dock = DockStyle.Top;

                    viscosities[i] = new Label();
                    viscosities[i].Name = "lblDieselViscosity" + i;
                    viscosities[i].Text = $"Viscosity: {fuelManager.GetDiesels()[i].Viscosity:f2}";
                    viscosities[i].Dock = DockStyle.Top;

                    suitabilities[i] = new Label();
                    suitabilities[i].Name = "lblDieselSuitability" + i;
                    suitabilities[i].Text = $"Suitable for: {fuelManager.GetDiesels()[i].Suitability:f2}";
                    suitabilities[i].Dock = DockStyle.Top;

                    literTextBoxes[i] = new TextBox();
                    literTextBoxes[i].Name = "tbDieselLitersToBuy" + i;
                    literTextBoxes[i].PlaceholderText = "Liters..."; ;
                    literTextBoxes[i].Dock = DockStyle.Bottom;
                    TextBox litersTextBox = literTextBoxes[i];


                    fillTimes[i] = new Label();
                    fillTimes[i].Name = "lblDieselFillTime" + i;
                    fillTimes[i].Text = "";
                    fillTimes[i].Dock = DockStyle.Bottom;
                    Label fillTime = fillTimes[i];

                    buyButtons[i] = new Button();
                    buyButtons[i].Name = "btnDieselBuy" + i;
                    buyButtons[i].Text = "Buy";
                    buyButtons[i].Dock = DockStyle.Bottom;
                    buyButtons[i].Click += (s, e) =>
                    {
                        if (Convert.ToDouble(litersTextBox.Text) > 0)
                        {
                            fuelManager.BuyFuel(fuelManager.FindDiesel(fuelName), customer, Convert.ToDouble(litersTextBox.Text));
                            fillTime.Text = $"Fill time: {fuelManager.FindDiesel(fuelName).CalculateFillUpTime(Convert.ToDouble(litersTextBox.Text)):f2} seconds";
                        }
                        else
                        {
                            MessageBox.Show("Please state a valid number of liters");
                        }
                    };
                }

                for (int i = 0; i < fuelManager.GetDiesels().Count; i++)
                {
                    flowBuyFuel.Controls.Add(groupBoxes[i]);

                    groupBoxes[i].Controls.Add(suitabilities[i]);
                    groupBoxes[i].Controls.Add(viscosities[i]);
                    groupBoxes[i].Controls.Add(purities[i]);
                    groupBoxes[i].Controls.Add(prices[i]);
                    groupBoxes[i].Controls.Add(literTextBoxes[i]);
                    groupBoxes[i].Controls.Add(buyButtons[i]);
                    groupBoxes[i].Controls.Add(fillTimes[i]);
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with displaying Diesel");
            }
        }

        private void btnUpdateAccInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                customer.Password = tbPassword.Text;

                ValidationContext context = new ValidationContext(customer, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(customer, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
                else
                {
                    accountManager.UpdateAccountInfo(customer);
                    MessageBox.Show("Account information successfully updated");
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with displaying Diesel");
            }
        }

        private void btnUpdatePaymentInfo_Click(object sender, EventArgs e)
        {
            try
            {
                customer.Password = tbPassword.Text;
                customer.CardNumber = Convert.ToInt64(tbCardNumber.Text);
                customer.CardValidThru = dtpCardValidThru.Value;
                customer.CardCVC = Convert.ToInt32(tbCardCVC.Text);
                customer.ZipCode = tbZipCode.Text;
                customer.PhoneNumber = Convert.ToInt64(tbPhoneNumber.Text);

                ValidationContext context = new ValidationContext(customer, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(customer, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
                else
                {
                    accountManager.UpdatePaymentInfo(customer);
                    MessageBox.Show("Payment/address information successfully updated");
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with displaying Diesel");
            }
        }
    }
}
