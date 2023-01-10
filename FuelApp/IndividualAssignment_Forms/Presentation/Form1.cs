using IndividualAssignment_Forms.Presentation;
using IndividualAssignmentLibrary;
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
    public partial class Form1 : Form
    {
        LoginManager loginManager;
        AccountManager accountManager;

        IAccountRepository realAccRepo = new AccountRepository();

        public Form1()
        {
            InitializeComponent();
            loginManager = new LoginManager(realAccRepo);
            accountManager = new AccountManager(realAccRepo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbUsernameLogin.Text == string.Empty || tbPasswordLogin.Text == string.Empty)
            {
                MessageBox.Show("Please fill all information fields");
            }
            else if (loginManager.Login(tbUsernameLogin.Text, tbPasswordLogin.Text).Role == "Admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                tbUsernameLogin.Text = "";
                tbPasswordLogin.Text = "";
                this.Hide();
                adminForm.FormClosed += (s, e) =>
                {
                    this.Show();
                };
            }
            else if (loginManager.Login(tbUsernameLogin.Text, tbPasswordLogin.Text).Role == "Customer")
            {
                CustomerForm customerForm = new CustomerForm(accountManager.GetCustomerByUsername(tbUsernameLogin.Text));
                customerForm.Show();
                tbUsernameLogin.Text = "";
                tbPasswordLogin.Text = "";
                this.Hide();
                customerForm.FormClosed += (s, e) =>
                {
                    this.Show();
                };
            }
            else
            {
                MessageBox.Show("Invalid credentials");
                tbUsernameLogin.Text = "";
                tbPasswordLogin.Text = "";
            }
        }

        private void btnCreateAccountRedirect_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }
    }
}
