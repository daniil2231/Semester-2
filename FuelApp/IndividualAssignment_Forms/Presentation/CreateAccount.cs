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

namespace IndividualAssignment_Forms.Presentation
{
    public partial class CreateAccount : Form
    {
        IAccountRepository realAccRepo = new AccountRepository();
        AccountManager accountManager;

        public CreateAccount()
        {
            InitializeComponent();
            accountManager = new AccountManager(realAccRepo);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                List<ValidationResult> errors = new List<ValidationResult>();
                Customer customer = new Customer();
                customer.Username = tbUsername.Text;
                customer.Password = tbPassword.Text;
                try
                {
                    customer.CardNumber = Convert.ToInt64(tbCardNumber.Text);
                }
                catch
                {
                    tbCardNumber.Text = "";
                    MessageBox.Show("Please supply a card number");
                }

                customer.CardValidThru = dtpCardValidThru.Value;

                try
                {
                    customer.CardCVC = Convert.ToInt32(tbCardCVC.Text);
                }
                catch
                {
                    tbCardCVC.Text = "";
                    MessageBox.Show("Please supply a card CVC");
                }

                customer.ZipCode = tbZipCode.Text;

                try
                {
                    customer.PhoneNumber = Convert.ToInt64(tbPhoneNumber.Text);
                }
                catch
                {
                    tbPhoneNumber.Text = "";
                }

                ValidationContext context = new ValidationContext(customer, null, null);

                if (!Validator.TryValidateObject(customer, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
                else
                {
                    try
                    {
                        accountManager.CreateAccount(tbUsername.Text, tbPassword.Text, Convert.ToInt64(tbCardNumber.Text), dtpCardValidThru.Value, Convert.ToInt32(tbCardCVC.Text), tbZipCode.Text, Convert.ToInt64(tbPhoneNumber.Text));
                        MessageBox.Show("Account created");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("An account with that username already exists");
                    }
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(ex.ExtraInfo);
            }
        }
    }
}
