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
    public partial class LoginForm : Form
    {
        Form1 form1;
        private string loginUsername;
        private string loginPass;

        public LoginForm()
        {
            form1 = new Form1();
            InitializeComponent();
        }

        public string LoginUsername
        {
            get { return this.loginUsername; }
            set { loginUsername = value; }
        }

        public string LoginPass
        {
            get { return this.loginPass; }
            set { loginPass = value; }
        }

        public void btnLogIn_Click_1(object sender, EventArgs e)
        {
            LoginUsername = tbUsername.Text;
            LoginPass = tbPassword.Text;
            form1.Login(LoginUsername, LoginPass);
            form1.Show();
            this.Hide();
        }
    }
}
