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
    public partial class AgencyForm : Form
    {
        Administration administration;
        Agency agent = new Agency();
        Login login = new Login();

        public AgencyForm()
        {
            InitializeComponent();
        }

        public AgencyForm(Administration administration, string username, string password)
        {
            InitializeComponent();
            this.administration = administration;
            login = new Login(username, password);

            agent = new Agency(login.LoginUsername, login.LoginPassword);

            lblLogedAgent.Text = agent.AgencyUsername;
            tcAdminAccount.SelectedTab = tabAdminComplaints;
            DisplayComplaintsFromStudents();
        }

        public void DisplayComplaintsFromStudents()
        {
            lbAdminComplaints.Items.Clear();
            for (int i = 0; i < administration.ComplaintsToAgency.Count; i++)
            {
                lbAdminComplaints.Items.Add(administration.ComplaintsToAgency[i]);
            }
        }

        private void DisplayRules()
        {
            lbAdminRules.Items.Clear();
            for (int i = 0; i < administration.Rules.Count; i++)
            {
                lbAdminRules.Items.Add(administration.Rules[i]);
            }
        }

        private void DisplayAccounts()
        {
            lbAccountsList.Items.Clear();
            foreach (Tenant tenant in administration.TenantList)
            {
                lbAccountsList.Items.Add($"username: {tenant.TenantName} password: {tenant.TenantPassword} house: {tenant.HouseNumber}");
            }
        }

        private void btnAddRule_Click_1(object sender, EventArgs e)
        {
            if (rtbAddRule.Text != string.Empty)
            {
                administration.AddRule(rtbAddRule.Text);
                DisplayRules();
                rtbAddRule.Text = "";
            }
        }

        private void btnUpdateRule_Click_1(object sender, EventArgs e)
        {
            if (lbAdminRules.SelectedIndex != -1)
            {
                administration.Rules[lbAdminRules.SelectedIndex] = rtbAddRule.Text;
                DisplayRules();
                rtbAddRule.Text = "";
            }
        }

        private void btnRemoveRule_Click_1(object sender, EventArgs e)
        {
            if (lbAdminRules.SelectedIndex != -1)
            {
                administration.RemoveRule(lbAdminRules.SelectedIndex);
                DisplayRules();
            }
        }

        private void btnEditPassword_Click_1(object sender, EventArgs e)
        {
            if (lbAccountsList.SelectedIndex != -1)
            {
                administration.TenantList[lbAccountsList.SelectedIndex].TenantPassword = tbCreateAccPassword.Text;
            }
            DisplayAccounts();
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            if (tbCreateAccUsername.Text != "" && tbCreateAccPassword.Text != "" && comCreateAccHouseNum.Text != "")
            {
                administration.AddTenant(tbCreateAccUsername.Text, tbCreateAccPassword.Text, comCreateAccHouseNum.SelectedItem.ToString());
                DisplayAccounts();
                tbCreateAccUsername.Text = "";
                tbCreateAccPassword.Text = "";
            }
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            if (lbAccountsList.SelectedIndex != -1)
            {
                administration.RemoveTenant(lbAccountsList.SelectedIndex);
                DisplayAccounts();
            }
        }

        private void btnSendMessage_Click_1(object sender, EventArgs e)
        {
            if (rtbSendMessage.Text != "" && comSendMessageToTenants.SelectedItem != null)
            {
                string house = comSendMessageToTenants.SelectedItem.ToString();
                administration.SendMessageToTenants(house, rtbSendMessage.Text);
                rtbSendMessage.Text = "";
            }
        }

        private void btnLogOutAgency_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcAdminAccount_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tcAdminAccount.SelectedIndex == 1)
            {
                DisplayRules();
            }
            else if (tcAdminAccount.SelectedIndex == 2)
            {
                lbAccountsList.Items.Clear();
                DisplayAccounts();
            }
            else if (tcAdminAccount.SelectedIndex == 0)
            {
                DisplayComplaintsFromStudents();
            }
        }
    }
}
