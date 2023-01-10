using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingSoftwareProject
{
    public partial class Form1 : Form
    {
        Administration administration = new Administration();
        Agency agent = new Agency();
        Login login = new Login();
        TenantForm tenantForm;
        AgencyForm agencyForm;

        public Form1()
        {
            InitializeComponent();
            administration.SetRules();
            administration.SetTasks();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            login = new Login(tbUsername.Text, tbPassword.Text);

            string result = login.LoginCheck(administration.TenantList, administration.AdminList);

            if (result == "student")
            {
                string houseNumber = administration.ReturnHouseNumberOfTenant(login.LoginUsername);
                tenantForm = new TenantForm(administration, tbUsername.Text, tbPassword.Text);
                tenantForm.Show();
                lblErrorLoginMessage.Text = "";
            }

            else if (result == "admin")
            {
                agent = new Agency(login.LoginUsername, login.LoginPassword);
                agencyForm = new AgencyForm(administration, tbUsername.Text, tbPassword.Text);
                agencyForm.Show();
                lblErrorLoginMessage.Text = "";
            }
            else if (result == "error")
            {
                lblErrorLoginMessage.Text = "The username or password you entered is incorrect. Please, try again.";
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
            }

            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
