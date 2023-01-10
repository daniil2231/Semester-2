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
    public partial class AdminForm : Form
    {
        FuelManager fuelManager;
        IFuelRepository realRepo = new FuelRepository();

        public AdminForm()
        {
            InitializeComponent();
            tcAdminForm.SelectedTab = tabEditFuels;
            btnEditFuelsRedir.Enabled = false;
            fuelManager = new FuelManager(realRepo);

            ShowDiesels();
            ShowCNGs();
        }

        public void ShowCNGs()
        {
            try
            {
                GroupBox[] groupBoxes = new GroupBox[fuelManager.GetCNGs().Count];
                Label[] prices = new Label[fuelManager.GetCNGs().Count];
                Label[] purities = new Label[fuelManager.GetCNGs().Count];
                Label[] airflowResistances = new Label[fuelManager.GetCNGs().Count];
                Label[] suitabilities = new Label[fuelManager.GetCNGs().Count];
                TextBox[] newPriceTextBoxes = new TextBox[fuelManager.GetCNGs().Count];
                Button[] editButtons = new Button[fuelManager.GetCNGs().Count];
                Button[] removeButtons = new Button[fuelManager.GetCNGs().Count];

                for (int i = 0; i < fuelManager.GetCNGs().Count; i++)
                {
                    string fuelName = fuelManager.GetCNGs()[i].FuelName;
                    groupBoxes[i] = new GroupBox();
                    groupBoxes[i].Name = "gbCNG" + i;
                    groupBoxes[i].Text = fuelName;
                    groupBoxes[i].Size = new Size(250, 345);
                    GroupBox groupBox = groupBoxes[i];

                    prices[i] = new Label();
                    prices[i].Name = "lblCNGPrice" + i;
                    prices[i].Text = $"${fuelManager.GetCNGs()[i].PricePerLiter:f2}/L";
                    prices[i].Dock = DockStyle.Top;
                    Label price = prices[i];

                    purities[i] = new Label();
                    purities[i].Name = "lblCNGPurity" + i;
                    purities[i].Text = $"Purity: {fuelManager.GetCNGs()[i].Purity}%";
                    purities[i].Dock = DockStyle.Top;

                    airflowResistances[i] = new Label();
                    airflowResistances[i].Name = "lblCNGViscosity" + i;
                    airflowResistances[i].Text = $"Airflow resistance: {fuelManager.GetCNGs()[i].AirflowResistance:f2}";
                    airflowResistances[i].Dock = DockStyle.Top;

                    suitabilities[i] = new Label();
                    suitabilities[i].Name = "lblCNGSuitability" + i;
                    suitabilities[i].Text = $"Suitable for: {fuelManager.GetCNGs()[i].Suitability:f2}";
                    suitabilities[i].Dock = DockStyle.Top;

                    newPriceTextBoxes[i] = new TextBox();
                    newPriceTextBoxes[i].Name = "tbCNGLitersToBuy" + i;
                    newPriceTextBoxes[i].PlaceholderText = "New price..."; ;
                    newPriceTextBoxes[i].Dock = DockStyle.Bottom;
                    TextBox newPriceTextBox = newPriceTextBoxes[i];

                    editButtons[i] = new Button();
                    editButtons[i].Name = "btnCNGEdit" + i;
                    editButtons[i].Text = "Edit price";
                    editButtons[i].Dock = DockStyle.Bottom;
                    editButtons[i].Click += (s, e) =>
                    {
                        if (Convert.ToDouble(newPriceTextBox.Text) > 0)
                        {
                            fuelManager.EditCNGPrice(fuelManager.FindCNG(fuelName), Convert.ToDouble(newPriceTextBox.Text));
                            price.Text = $"${fuelManager.FindCNG(fuelName).PricePerLiter:f2}/L";
                        }
                        else
                        {
                            MessageBox.Show("Please state a valid new price");
                        }
                    };

                    removeButtons[i] = new Button();
                    removeButtons[i].Name = "btnCNGRemove" + i;
                    removeButtons[i].Text = "Remove fuel";
                    removeButtons[i].Dock = DockStyle.Bottom;
                    removeButtons[i].Click += (s, e) =>
                    {
                        fuelManager.RemoveCNG(fuelManager.FindCNG(fuelName));
                        groupBox.Visible = false;
                        MessageBox.Show("Fuel successfully removed");
                    };
                }

                for (int i = 0; i < fuelManager.GetCNGs().Count; i++)
                {
                    flowEdit.Controls.Add(groupBoxes[i]);

                    groupBoxes[i].Controls.Add(suitabilities[i]);
                    groupBoxes[i].Controls.Add(airflowResistances[i]);
                    groupBoxes[i].Controls.Add(purities[i]);
                    groupBoxes[i].Controls.Add(prices[i]);
                    groupBoxes[i].Controls.Add(newPriceTextBoxes[i]);
                    groupBoxes[i].Controls.Add(editButtons[i]);
                    groupBoxes[i].Controls.Add(removeButtons[i]);
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

        public void ShowDiesels()
        {
            try
            {
                GroupBox[] groupBoxes = new GroupBox[fuelManager.GetDiesels().Count];
                Label[] prices = new Label[fuelManager.GetDiesels().Count];
                Label[] purities = new Label[fuelManager.GetDiesels().Count];
                Label[] viscosities = new Label[fuelManager.GetDiesels().Count];
                Label[] suitabilities = new Label[fuelManager.GetDiesels().Count];
                TextBox[] newPriceTextBoxes = new TextBox[fuelManager.GetDiesels().Count];
                Button[] editButtons = new Button[fuelManager.GetDiesels().Count];
                Button[] removeButtons = new Button[fuelManager.GetDiesels().Count];

                for (int i = 0; i < fuelManager.GetDiesels().Count; i++)
                {
                    string fuelName = fuelManager.GetDiesels()[i].FuelName;
                    groupBoxes[i] = new GroupBox();
                    groupBoxes[i].Name = "gbDiesel" + i;
                    groupBoxes[i].Text = fuelName;
                    groupBoxes[i].Size = new Size(250, 345);
                    GroupBox groupBox = groupBoxes[i];

                    prices[i] = new Label();
                    prices[i].Name = "lblDieselPrice" + i;
                    prices[i].Text = $"${fuelManager.GetDiesels()[i].PricePerLiter:f2}/L";
                    prices[i].Dock = DockStyle.Top;
                    Label price = prices[i];

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

                    newPriceTextBoxes[i] = new TextBox();
                    newPriceTextBoxes[i].Name = "tbDieselLitersToBuy" + i;
                    newPriceTextBoxes[i].PlaceholderText = "New price..."; ;
                    newPriceTextBoxes[i].Dock = DockStyle.Bottom;
                    TextBox newPriceTextBox = newPriceTextBoxes[i];

                    editButtons[i] = new Button();
                    editButtons[i].Name = "btnDieselEdit" + i;
                    editButtons[i].Text = "Edit price";
                    editButtons[i].Dock = DockStyle.Bottom;
                    editButtons[i].Click += (s, e) =>
                    {
                        if (Convert.ToDouble(newPriceTextBox.Text) > 0)
                        {
                            fuelManager.EditDieselPrice(fuelManager.FindDiesel(fuelName), Convert.ToDouble(newPriceTextBox.Text));
                            price.Text = $"${fuelManager.FindDiesel(fuelName).PricePerLiter:f2}/L";
                        }
                        else
                        {
                            MessageBox.Show("Please state a valid new price");
                        }
                    };

                    removeButtons[i] = new Button();
                    removeButtons[i].Name = "btnDieselRemove" + i;
                    removeButtons[i].Text = "Remove fuel";
                    removeButtons[i].Dock = DockStyle.Bottom;
                    removeButtons[i].Click += (s, e) =>
                    {
                        fuelManager.RemoveDiesel(fuelManager.FindDiesel(fuelName));
                        groupBox.Visible = false;
                        MessageBox.Show("Fuel successfully removed");
                    };
                }

                for (int i = 0; i < fuelManager.GetDiesels().Count; i++)
                {
                    flowEdit.Controls.Add(groupBoxes[i]);

                    groupBoxes[i].Controls.Add(suitabilities[i]);
                    groupBoxes[i].Controls.Add(viscosities[i]);
                    groupBoxes[i].Controls.Add(purities[i]);
                    groupBoxes[i].Controls.Add(prices[i]);
                    groupBoxes[i].Controls.Add(newPriceTextBoxes[i]);
                    groupBoxes[i].Controls.Add(editButtons[i]);
                    groupBoxes[i].Controls.Add(removeButtons[i]);
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

        private void btnPurchaseHistoryRedir_Click(object sender, EventArgs e)
        {
            tcAdminForm.SelectedTab = tabPurchaseHistory;
            btnPurchaseHistoryRedirection.Enabled = false;
        }

        private void btnEditFuelsRedirection_Click(object sender, EventArgs e)
        {
            tcAdminForm.SelectedTab = tabEditFuels;
        }

        private void btnAddDiesel_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationResult> errors = new List<ValidationResult>();

                double pricePerLiter = 0;
                try
                {
                    pricePerLiter = Convert.ToDouble(tbDieselPrice.Text);
                }
                catch (Exception)
                {
                    tbDieselPrice.Text = "";
                }

                int purity = 0;
                try
                {
                    purity = Convert.ToInt32(tbDieselPurity.Text);
                }
                catch (Exception)
                {
                    tbDieselPurity.Text = "";
                }

                double viscosity = 0;
                try
                {
                    viscosity = Convert.ToDouble(tbDieselViscosity.Text);
                }
                catch (Exception)
                {
                    tbDieselViscosity.Text = "";
                }

                Diesel diesel = new Diesel(tbDieselType.Text, pricePerLiter, tbDieselSuitable.Text, purity, viscosity);

                ValidationContext context = new ValidationContext(diesel, null, null);

                if (!Validator.TryValidateObject(diesel, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
                else
                {
                    fuelManager.CreateDiesel(diesel);

                    tbDieselType.Text = "";
                    tbDieselPrice.Text = "";
                    tbDieselSuitable.Text = "";
                    tbDieselPurity.Text = "";
                    tbDieselViscosity.Text = "";

                    flowEdit.Controls.Clear();
                    ShowCNGs();
                    ShowDiesels();

                    MessageBox.Show("Diesel successfully added");
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
        }

        private void btnAddCNG_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationResult> errors = new List<ValidationResult>();

                double pricePerLiter = 0;
                try
                {
                    pricePerLiter = Convert.ToDouble(tbCNGPrice.Text);
                }
                catch (Exception)
                {
                    tbCNGPrice.Text = "";
                }

                int purity = 0;
                try
                {
                    purity = Convert.ToInt32(tbCNGPurity.Text);
                }
                catch (Exception)
                {
                    tbCNGPurity.Text = "";
                }

                double viscosity = 0;
                try
                {
                    viscosity = Convert.ToDouble(tbCNGAirflowRes.Text);
                }
                catch (Exception)
                {
                    tbCNGAirflowRes.Text = "";
                }

                CompressedNaturalGas cng = new CompressedNaturalGas(tbCNGType.Text, pricePerLiter, tbCNGSuitable.Text, purity, viscosity);

                ValidationContext context = new ValidationContext(cng, null, null);

                if (!Validator.TryValidateObject(cng, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
                else
                {
                    fuelManager.CreateCNG(cng);

                    tbCNGType.Text = "";
                    tbCNGPrice.Text = "";
                    tbCNGSuitable.Text = "";
                    tbCNGPurity.Text = "";
                    tbCNGAirflowRes.Text = "";

                    flowEdit.Controls.Clear();
                    ShowCNGs();
                    ShowDiesels();

                    MessageBox.Show("CNG successfully added");
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
        }

        private void tcAdminForm_Selected(object sender, TabControlEventArgs e)
        {
            if (tcAdminForm.SelectedTab == tabPurchaseHistory)
            {
                lbSalesHistory.Items.Clear();
                foreach (Purchases purchase in fuelManager.GetSalesHistory())
                {
                    lbSalesHistory.Items.Add(purchase.ToString());
                }
            }
        }
    }
}
