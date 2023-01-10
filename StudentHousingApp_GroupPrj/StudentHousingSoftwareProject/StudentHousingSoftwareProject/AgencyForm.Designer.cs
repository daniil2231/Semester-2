
namespace StudentHousingSoftwareProject
{
    partial class AgencyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOutAgency = new System.Windows.Forms.Button();
            this.lblLogedAgent = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tcAdminAccount = new System.Windows.Forms.TabControl();
            this.tabAdminComplaints = new System.Windows.Forms.TabPage();
            this.lbAdminComplaints = new System.Windows.Forms.ListBox();
            this.tabAdminRules = new System.Windows.Forms.TabPage();
            this.btnUpdateRule = new System.Windows.Forms.Button();
            this.btnRemoveRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.rtbAddRule = new System.Windows.Forms.RichTextBox();
            this.lbAdminRules = new System.Windows.Forms.ListBox();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.gbDeleteAccount = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.gbCreateAccount = new System.Windows.Forms.GroupBox();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.comCreateAccHouseNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblCreateUsername = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbCreateAccPassword = new System.Windows.Forms.TextBox();
            this.tbCreateAccUsername = new System.Windows.Forms.TextBox();
            this.lbAccountsList = new System.Windows.Forms.ListBox();
            this.tabSendMessage = new System.Windows.Forms.TabPage();
            this.comSendMessageToTenants = new System.Windows.Forms.ComboBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rtbSendMessage = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tcAdminAccount.SuspendLayout();
            this.tabAdminComplaints.SuspendLayout();
            this.tabAdminRules.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.gbDeleteAccount.SuspendLayout();
            this.gbCreateAccount.SuspendLayout();
            this.tabSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnLogOutAgency);
            this.panel1.Controls.Add(this.lblLogedAgent);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 654);
            this.panel1.TabIndex = 9;
            // 
            // btnLogOutAgency
            // 
            this.btnLogOutAgency.Location = new System.Drawing.Point(160, 131);
            this.btnLogOutAgency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOutAgency.Name = "btnLogOutAgency";
            this.btnLogOutAgency.Size = new System.Drawing.Size(92, 28);
            this.btnLogOutAgency.TabIndex = 3;
            this.btnLogOutAgency.Text = "Log out";
            this.btnLogOutAgency.UseVisualStyleBackColor = true;
            this.btnLogOutAgency.Click += new System.EventHandler(this.btnLogOutAgency_Click_1);
            // 
            // lblLogedAgent
            // 
            this.lblLogedAgent.AutoSize = true;
            this.lblLogedAgent.BackColor = System.Drawing.Color.SlateGray;
            this.lblLogedAgent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedAgent.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLogedAgent.Location = new System.Drawing.Point(16, 63);
            this.lblLogedAgent.Name = "lblLogedAgent";
            this.lblLogedAgent.Size = new System.Drawing.Size(236, 32);
            this.lblLogedAgent.TabIndex = 2;
            this.lblLogedAgent.Text = "/Logged in user/";
            this.lblLogedAgent.UseMnemonic = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudentHousingSoftwareProject.Properties.Resources.officeADMIN1;
            this.pictureBox4.Location = new System.Drawing.Point(-4, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1141, 654);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // tcAdminAccount
            // 
            this.tcAdminAccount.Controls.Add(this.tabAdminComplaints);
            this.tcAdminAccount.Controls.Add(this.tabAdminRules);
            this.tcAdminAccount.Controls.Add(this.tabAccounts);
            this.tcAdminAccount.Controls.Add(this.tabSendMessage);
            this.tcAdminAccount.Location = new System.Drawing.Point(307, 57);
            this.tcAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcAdminAccount.Name = "tcAdminAccount";
            this.tcAdminAccount.SelectedIndex = 0;
            this.tcAdminAccount.Size = new System.Drawing.Size(775, 442);
            this.tcAdminAccount.TabIndex = 10;
            this.tcAdminAccount.SelectedIndexChanged += new System.EventHandler(this.tcAdminAccount_SelectedIndexChanged_1);
            // 
            // tabAdminComplaints
            // 
            this.tabAdminComplaints.BackColor = System.Drawing.Color.AliceBlue;
            this.tabAdminComplaints.Controls.Add(this.lbAdminComplaints);
            this.tabAdminComplaints.Location = new System.Drawing.Point(4, 25);
            this.tabAdminComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminComplaints.Name = "tabAdminComplaints";
            this.tabAdminComplaints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminComplaints.Size = new System.Drawing.Size(767, 413);
            this.tabAdminComplaints.TabIndex = 0;
            this.tabAdminComplaints.Text = "Complaints";
            // 
            // lbAdminComplaints
            // 
            this.lbAdminComplaints.FormattingEnabled = true;
            this.lbAdminComplaints.ItemHeight = 16;
            this.lbAdminComplaints.Location = new System.Drawing.Point(83, 22);
            this.lbAdminComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdminComplaints.Name = "lbAdminComplaints";
            this.lbAdminComplaints.Size = new System.Drawing.Size(591, 340);
            this.lbAdminComplaints.TabIndex = 0;
            // 
            // tabAdminRules
            // 
            this.tabAdminRules.BackColor = System.Drawing.Color.AliceBlue;
            this.tabAdminRules.Controls.Add(this.btnUpdateRule);
            this.tabAdminRules.Controls.Add(this.btnRemoveRule);
            this.tabAdminRules.Controls.Add(this.btnAddRule);
            this.tabAdminRules.Controls.Add(this.rtbAddRule);
            this.tabAdminRules.Controls.Add(this.lbAdminRules);
            this.tabAdminRules.Location = new System.Drawing.Point(4, 25);
            this.tabAdminRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminRules.Name = "tabAdminRules";
            this.tabAdminRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminRules.Size = new System.Drawing.Size(767, 413);
            this.tabAdminRules.TabIndex = 1;
            this.tabAdminRules.Text = "Rules";
            // 
            // btnUpdateRule
            // 
            this.btnUpdateRule.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRule.Location = new System.Drawing.Point(505, 190);
            this.btnUpdateRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateRule.Name = "btnUpdateRule";
            this.btnUpdateRule.Size = new System.Drawing.Size(127, 38);
            this.btnUpdateRule.TabIndex = 4;
            this.btnUpdateRule.Text = "Update rule";
            this.btnUpdateRule.UseVisualStyleBackColor = true;
            this.btnUpdateRule.Click += new System.EventHandler(this.btnUpdateRule_Click_1);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveRule.Location = new System.Drawing.Point(505, 292);
            this.btnRemoveRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(127, 39);
            this.btnRemoveRule.TabIndex = 3;
            this.btnRemoveRule.Text = "Remove rule";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click_1);
            // 
            // btnAddRule
            // 
            this.btnAddRule.ForeColor = System.Drawing.Color.Black;
            this.btnAddRule.Location = new System.Drawing.Point(505, 136);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(127, 38);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click_1);
            // 
            // rtbAddRule
            // 
            this.rtbAddRule.Location = new System.Drawing.Point(412, 18);
            this.rtbAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAddRule.Name = "rtbAddRule";
            this.rtbAddRule.Size = new System.Drawing.Size(304, 103);
            this.rtbAddRule.TabIndex = 1;
            this.rtbAddRule.Text = "";
            // 
            // lbAdminRules
            // 
            this.lbAdminRules.FormattingEnabled = true;
            this.lbAdminRules.ItemHeight = 16;
            this.lbAdminRules.Location = new System.Drawing.Point(20, 18);
            this.lbAdminRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdminRules.Name = "lbAdminRules";
            this.lbAdminRules.Size = new System.Drawing.Size(348, 340);
            this.lbAdminRules.TabIndex = 0;
            // 
            // tabAccounts
            // 
            this.tabAccounts.BackColor = System.Drawing.Color.AliceBlue;
            this.tabAccounts.Controls.Add(this.gbDeleteAccount);
            this.tabAccounts.Controls.Add(this.gbCreateAccount);
            this.tabAccounts.Controls.Add(this.lbAccountsList);
            this.tabAccounts.Location = new System.Drawing.Point(4, 25);
            this.tabAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccounts.Size = new System.Drawing.Size(767, 413);
            this.tabAccounts.TabIndex = 2;
            this.tabAccounts.Text = "Accounts";
            // 
            // gbDeleteAccount
            // 
            this.gbDeleteAccount.Controls.Add(this.label2);
            this.gbDeleteAccount.Controls.Add(this.btnDeleteAccount);
            this.gbDeleteAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.gbDeleteAccount.Location = new System.Drawing.Point(405, 252);
            this.gbDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDeleteAccount.Name = "gbDeleteAccount";
            this.gbDeleteAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDeleteAccount.Size = new System.Drawing.Size(344, 148);
            this.gbDeleteAccount.TabIndex = 2;
            this.gbDeleteAccount.TabStop = false;
            this.gbDeleteAccount.Text = "Delete account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Select account from the box)";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(133, 58);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click_1);
            // 
            // gbCreateAccount
            // 
            this.gbCreateAccount.Controls.Add(this.btnEditPassword);
            this.gbCreateAccount.Controls.Add(this.comCreateAccHouseNum);
            this.gbCreateAccount.Controls.Add(this.label3);
            this.gbCreateAccount.Controls.Add(this.lblCreatePassword);
            this.gbCreateAccount.Controls.Add(this.lblCreateUsername);
            this.gbCreateAccount.Controls.Add(this.btnCreateAccount);
            this.gbCreateAccount.Controls.Add(this.tbCreateAccPassword);
            this.gbCreateAccount.Controls.Add(this.tbCreateAccUsername);
            this.gbCreateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.gbCreateAccount.Location = new System.Drawing.Point(405, 14);
            this.gbCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCreateAccount.Name = "gbCreateAccount";
            this.gbCreateAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCreateAccount.Size = new System.Drawing.Size(344, 234);
            this.gbCreateAccount.TabIndex = 1;
            this.gbCreateAccount.TabStop = false;
            this.gbCreateAccount.Text = "Create account or edit password of selected one";
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.Location = new System.Drawing.Point(258, 113);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(75, 26);
            this.btnEditPassword.TabIndex = 7;
            this.btnEditPassword.Text = "Edit";
            this.btnEditPassword.UseVisualStyleBackColor = true;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click_1);
            // 
            // comCreateAccHouseNum
            // 
            this.comCreateAccHouseNum.FormattingEnabled = true;
            this.comCreateAccHouseNum.Items.AddRange(new object[] {
            "KW2024",
            "OB2021"});
            this.comCreateAccHouseNum.Location = new System.Drawing.Point(124, 148);
            this.comCreateAccHouseNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comCreateAccHouseNum.Name = "comCreateAccHouseNum";
            this.comCreateAccHouseNum.Size = new System.Drawing.Size(121, 34);
            this.comCreateAccHouseNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "House Number";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePassword.Location = new System.Drawing.Point(11, 119);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(75, 16);
            this.lblCreatePassword.TabIndex = 4;
            this.lblCreatePassword.Text = "Password";
            // 
            // lblCreateUsername
            // 
            this.lblCreateUsername.AutoSize = true;
            this.lblCreateUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUsername.Location = new System.Drawing.Point(16, 79);
            this.lblCreateUsername.Name = "lblCreateUsername";
            this.lblCreateUsername.Size = new System.Drawing.Size(77, 16);
            this.lblCreateUsername.TabIndex = 3;
            this.lblCreateUsername.Text = "Username";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(145, 191);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(75, 30);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click_1);
            // 
            // tbCreateAccPassword
            // 
            this.tbCreateAccPassword.Location = new System.Drawing.Point(124, 111);
            this.tbCreateAccPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCreateAccPassword.Name = "tbCreateAccPassword";
            this.tbCreateAccPassword.Size = new System.Drawing.Size(121, 33);
            this.tbCreateAccPassword.TabIndex = 1;
            // 
            // tbCreateAccUsername
            // 
            this.tbCreateAccUsername.Location = new System.Drawing.Point(124, 72);
            this.tbCreateAccUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCreateAccUsername.Name = "tbCreateAccUsername";
            this.tbCreateAccUsername.Size = new System.Drawing.Size(121, 33);
            this.tbCreateAccUsername.TabIndex = 0;
            // 
            // lbAccountsList
            // 
            this.lbAccountsList.FormattingEnabled = true;
            this.lbAccountsList.ItemHeight = 16;
            this.lbAccountsList.Location = new System.Drawing.Point(19, 27);
            this.lbAccountsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAccountsList.Name = "lbAccountsList";
            this.lbAccountsList.Size = new System.Drawing.Size(368, 276);
            this.lbAccountsList.TabIndex = 0;
            // 
            // tabSendMessage
            // 
            this.tabSendMessage.BackColor = System.Drawing.Color.AliceBlue;
            this.tabSendMessage.Controls.Add(this.comSendMessageToTenants);
            this.tabSendMessage.Controls.Add(this.btnSendMessage);
            this.tabSendMessage.Controls.Add(this.rtbSendMessage);
            this.tabSendMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSendMessage.Location = new System.Drawing.Point(4, 25);
            this.tabSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSendMessage.Name = "tabSendMessage";
            this.tabSendMessage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSendMessage.Size = new System.Drawing.Size(767, 413);
            this.tabSendMessage.TabIndex = 3;
            this.tabSendMessage.Text = "Send message";
            // 
            // comSendMessageToTenants
            // 
            this.comSendMessageToTenants.FormattingEnabled = true;
            this.comSendMessageToTenants.Items.AddRange(new object[] {
            "KW2024",
            "OB2021"});
            this.comSendMessageToTenants.Location = new System.Drawing.Point(496, 58);
            this.comSendMessageToTenants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comSendMessageToTenants.Name = "comSendMessageToTenants";
            this.comSendMessageToTenants.Size = new System.Drawing.Size(183, 24);
            this.comSendMessageToTenants.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.ForeColor = System.Drawing.Color.Black;
            this.btnSendMessage.Location = new System.Drawing.Point(496, 97);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(181, 46);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send message to tenants";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click_1);
            // 
            // rtbSendMessage
            // 
            this.rtbSendMessage.Location = new System.Drawing.Point(67, 58);
            this.rtbSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSendMessage.Name = "rtbSendMessage";
            this.rtbSendMessage.Size = new System.Drawing.Size(363, 297);
            this.rtbSendMessage.TabIndex = 0;
            this.rtbSendMessage.Text = "";
            // 
            // AgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 647);
            this.Controls.Add(this.tcAdminAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "AgencyForm";
            this.Text = "AgencyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tcAdminAccount.ResumeLayout(false);
            this.tabAdminComplaints.ResumeLayout(false);
            this.tabAdminRules.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.gbDeleteAccount.ResumeLayout(false);
            this.gbDeleteAccount.PerformLayout();
            this.gbCreateAccount.ResumeLayout(false);
            this.gbCreateAccount.PerformLayout();
            this.tabSendMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogedAgent;
        private System.Windows.Forms.Button btnLogOutAgency;
        private System.Windows.Forms.TabControl tcAdminAccount;
        private System.Windows.Forms.TabPage tabAdminComplaints;
        private System.Windows.Forms.ListBox lbAdminComplaints;
        private System.Windows.Forms.TabPage tabAdminRules;
        private System.Windows.Forms.Button btnUpdateRule;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.RichTextBox rtbAddRule;
        private System.Windows.Forms.ListBox lbAdminRules;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.GroupBox gbDeleteAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.GroupBox gbCreateAccount;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.ComboBox comCreateAccHouseNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Label lblCreateUsername;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbCreateAccPassword;
        private System.Windows.Forms.TextBox tbCreateAccUsername;
        private System.Windows.Forms.ListBox lbAccountsList;
        private System.Windows.Forms.TabPage tabSendMessage;
        private System.Windows.Forms.ComboBox comSendMessageToTenants;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.RichTextBox rtbSendMessage;
    }
}