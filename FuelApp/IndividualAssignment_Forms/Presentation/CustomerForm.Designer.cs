
namespace IndividualAssignment_Forms
{
    partial class CustomerForm
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
            this.tcCustomer = new System.Windows.Forms.TabControl();
            this.tabBuyFuel = new System.Windows.Forms.TabPage();
            this.flowBuyFuel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyProfileRedir = new System.Windows.Forms.Button();
            this.btnBuyFuelRedir = new System.Windows.Forms.Button();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.btnUpdatePaymentInfo = new System.Windows.Forms.Button();
            this.btnUpdateAccInfo = new System.Windows.Forms.Button();
            this.dtpCardValidThru = new System.Windows.Forms.DateTimePicker();
            this.lblPhoneNumberMyProfile = new System.Windows.Forms.Label();
            this.lblZipCodeMyProfile = new System.Windows.Forms.Label();
            this.lblCardCVCMyProfile = new System.Windows.Forms.Label();
            this.lblCardValidThruMyProfile = new System.Windows.Forms.Label();
            this.lblCardNumberMyProfile = new System.Windows.Forms.Label();
            this.lblPaymentDeliveryInfo = new System.Windows.Forms.Label();
            this.lblPasswordMyProfile = new System.Windows.Forms.Label();
            this.lblUsernameMyProfile = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbCardCVC = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.btnMyProfileRedirect = new System.Windows.Forms.Button();
            this.btnBuyFuelRedirect = new System.Windows.Forms.Button();
            this.tcCustomer.SuspendLayout();
            this.tabBuyFuel.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tabBuyFuel);
            this.tcCustomer.Controls.Add(this.tabMyProfile);
            this.tcCustomer.Location = new System.Drawing.Point(0, -30);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(1179, 772);
            this.tcCustomer.TabIndex = 0;
            // 
            // tabBuyFuel
            // 
            this.tabBuyFuel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabBuyFuel.Controls.Add(this.flowBuyFuel);
            this.tabBuyFuel.Controls.Add(this.btnMyProfileRedir);
            this.tabBuyFuel.Controls.Add(this.btnBuyFuelRedir);
            this.tabBuyFuel.Location = new System.Drawing.Point(4, 29);
            this.tabBuyFuel.Name = "tabBuyFuel";
            this.tabBuyFuel.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuyFuel.Size = new System.Drawing.Size(1171, 739);
            this.tabBuyFuel.TabIndex = 0;
            this.tabBuyFuel.Text = "BuyFuel";
            // 
            // flowBuyFuel
            // 
            this.flowBuyFuel.Location = new System.Drawing.Point(165, 7);
            this.flowBuyFuel.Name = "flowBuyFuel";
            this.flowBuyFuel.Size = new System.Drawing.Size(993, 701);
            this.flowBuyFuel.TabIndex = 8;
            // 
            // btnMyProfileRedir
            // 
            this.btnMyProfileRedir.Location = new System.Drawing.Point(9, 78);
            this.btnMyProfileRedir.Name = "btnMyProfileRedir";
            this.btnMyProfileRedir.Size = new System.Drawing.Size(150, 64);
            this.btnMyProfileRedir.TabIndex = 1;
            this.btnMyProfileRedir.Text = "My Profile";
            this.btnMyProfileRedir.UseVisualStyleBackColor = true;
            this.btnMyProfileRedir.Click += new System.EventHandler(this.btnMyProfileRedir_Click);
            // 
            // btnBuyFuelRedir
            // 
            this.btnBuyFuelRedir.Location = new System.Drawing.Point(9, 7);
            this.btnBuyFuelRedir.Name = "btnBuyFuelRedir";
            this.btnBuyFuelRedir.Size = new System.Drawing.Size(150, 64);
            this.btnBuyFuelRedir.TabIndex = 0;
            this.btnBuyFuelRedir.Text = "Buy Fuel";
            this.btnBuyFuelRedir.UseVisualStyleBackColor = true;
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabMyProfile.Controls.Add(this.btnUpdatePaymentInfo);
            this.tabMyProfile.Controls.Add(this.btnUpdateAccInfo);
            this.tabMyProfile.Controls.Add(this.dtpCardValidThru);
            this.tabMyProfile.Controls.Add(this.lblPhoneNumberMyProfile);
            this.tabMyProfile.Controls.Add(this.lblZipCodeMyProfile);
            this.tabMyProfile.Controls.Add(this.lblCardCVCMyProfile);
            this.tabMyProfile.Controls.Add(this.lblCardValidThruMyProfile);
            this.tabMyProfile.Controls.Add(this.lblCardNumberMyProfile);
            this.tabMyProfile.Controls.Add(this.lblPaymentDeliveryInfo);
            this.tabMyProfile.Controls.Add(this.lblPasswordMyProfile);
            this.tabMyProfile.Controls.Add(this.lblUsernameMyProfile);
            this.tabMyProfile.Controls.Add(this.tbPhoneNumber);
            this.tabMyProfile.Controls.Add(this.tbZipCode);
            this.tabMyProfile.Controls.Add(this.tbCardCVC);
            this.tabMyProfile.Controls.Add(this.tbCardNumber);
            this.tabMyProfile.Controls.Add(this.tbPassword);
            this.tabMyProfile.Controls.Add(this.tbUsername);
            this.tabMyProfile.Controls.Add(this.lblAccountInfo);
            this.tabMyProfile.Controls.Add(this.lblMyProfile);
            this.tabMyProfile.Controls.Add(this.btnMyProfileRedirect);
            this.tabMyProfile.Controls.Add(this.btnBuyFuelRedirect);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyProfile.Size = new System.Drawing.Size(1171, 739);
            this.tabMyProfile.TabIndex = 1;
            this.tabMyProfile.Text = "MyProfile";
            // 
            // btnUpdatePaymentInfo
            // 
            this.btnUpdatePaymentInfo.Location = new System.Drawing.Point(727, 419);
            this.btnUpdatePaymentInfo.Name = "btnUpdatePaymentInfo";
            this.btnUpdatePaymentInfo.Size = new System.Drawing.Size(217, 43);
            this.btnUpdatePaymentInfo.TabIndex = 22;
            this.btnUpdatePaymentInfo.Text = "Update payment/address info";
            this.btnUpdatePaymentInfo.UseVisualStyleBackColor = true;
            this.btnUpdatePaymentInfo.Click += new System.EventHandler(this.btnUpdatePaymentInfo_Click);
            // 
            // btnUpdateAccInfo
            // 
            this.btnUpdateAccInfo.Location = new System.Drawing.Point(313, 346);
            this.btnUpdateAccInfo.Name = "btnUpdateAccInfo";
            this.btnUpdateAccInfo.Size = new System.Drawing.Size(180, 43);
            this.btnUpdateAccInfo.TabIndex = 21;
            this.btnUpdateAccInfo.Text = "Update account info";
            this.btnUpdateAccInfo.UseVisualStyleBackColor = true;
            this.btnUpdateAccInfo.Click += new System.EventHandler(this.btnUpdateAccInfo_Click_1);
            // 
            // dtpCardValidThru
            // 
            this.dtpCardValidThru.Location = new System.Drawing.Point(710, 211);
            this.dtpCardValidThru.Name = "dtpCardValidThru";
            this.dtpCardValidThru.Size = new System.Drawing.Size(250, 27);
            this.dtpCardValidThru.TabIndex = 20;
            // 
            // lblPhoneNumberMyProfile
            // 
            this.lblPhoneNumberMyProfile.AutoSize = true;
            this.lblPhoneNumberMyProfile.Location = new System.Drawing.Point(711, 347);
            this.lblPhoneNumberMyProfile.Name = "lblPhoneNumberMyProfile";
            this.lblPhoneNumberMyProfile.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumberMyProfile.TabIndex = 19;
            this.lblPhoneNumberMyProfile.Text = "Phone number:";
            // 
            // lblZipCodeMyProfile
            // 
            this.lblZipCodeMyProfile.AutoSize = true;
            this.lblZipCodeMyProfile.Location = new System.Drawing.Point(708, 296);
            this.lblZipCodeMyProfile.Name = "lblZipCodeMyProfile";
            this.lblZipCodeMyProfile.Size = new System.Drawing.Size(70, 20);
            this.lblZipCodeMyProfile.TabIndex = 18;
            this.lblZipCodeMyProfile.Text = "ZIP code:";
            // 
            // lblCardCVCMyProfile
            // 
            this.lblCardCVCMyProfile.AutoSize = true;
            this.lblCardCVCMyProfile.Location = new System.Drawing.Point(708, 243);
            this.lblCardCVCMyProfile.Name = "lblCardCVCMyProfile";
            this.lblCardCVCMyProfile.Size = new System.Drawing.Size(74, 20);
            this.lblCardCVCMyProfile.TabIndex = 17;
            this.lblCardCVCMyProfile.Text = "Card CVC:";
            // 
            // lblCardValidThruMyProfile
            // 
            this.lblCardValidThruMyProfile.AutoSize = true;
            this.lblCardValidThruMyProfile.Location = new System.Drawing.Point(710, 188);
            this.lblCardValidThruMyProfile.Name = "lblCardValidThruMyProfile";
            this.lblCardValidThruMyProfile.Size = new System.Drawing.Size(109, 20);
            this.lblCardValidThruMyProfile.TabIndex = 16;
            this.lblCardValidThruMyProfile.Text = "Card valid thru:";
            // 
            // lblCardNumberMyProfile
            // 
            this.lblCardNumberMyProfile.AutoSize = true;
            this.lblCardNumberMyProfile.Location = new System.Drawing.Point(710, 135);
            this.lblCardNumberMyProfile.Name = "lblCardNumberMyProfile";
            this.lblCardNumberMyProfile.Size = new System.Drawing.Size(98, 20);
            this.lblCardNumberMyProfile.TabIndex = 15;
            this.lblCardNumberMyProfile.Text = "Card number:";
            // 
            // lblPaymentDeliveryInfo
            // 
            this.lblPaymentDeliveryInfo.AutoSize = true;
            this.lblPaymentDeliveryInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentDeliveryInfo.Location = new System.Drawing.Point(743, 98);
            this.lblPaymentDeliveryInfo.Name = "lblPaymentDeliveryInfo";
            this.lblPaymentDeliveryInfo.Size = new System.Drawing.Size(201, 28);
            this.lblPaymentDeliveryInfo.TabIndex = 14;
            this.lblPaymentDeliveryInfo.Text = "Payment/address info";
            // 
            // lblPasswordMyProfile
            // 
            this.lblPasswordMyProfile.AutoSize = true;
            this.lblPasswordMyProfile.Location = new System.Drawing.Point(283, 272);
            this.lblPasswordMyProfile.Name = "lblPasswordMyProfile";
            this.lblPasswordMyProfile.Size = new System.Drawing.Size(73, 20);
            this.lblPasswordMyProfile.TabIndex = 13;
            this.lblPasswordMyProfile.Text = "Password:";
            // 
            // lblUsernameMyProfile
            // 
            this.lblUsernameMyProfile.AutoSize = true;
            this.lblUsernameMyProfile.Location = new System.Drawing.Point(283, 213);
            this.lblUsernameMyProfile.Name = "lblUsernameMyProfile";
            this.lblUsernameMyProfile.Size = new System.Drawing.Size(78, 20);
            this.lblUsernameMyProfile.TabIndex = 12;
            this.lblUsernameMyProfile.Text = "Username:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(710, 370);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(250, 27);
            this.tbPhoneNumber.TabIndex = 10;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(710, 317);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(250, 27);
            this.tbZipCode.TabIndex = 9;
            // 
            // tbCardCVC
            // 
            this.tbCardCVC.Location = new System.Drawing.Point(710, 264);
            this.tbCardCVC.Name = "tbCardCVC";
            this.tbCardCVC.Size = new System.Drawing.Size(250, 27);
            this.tbCardCVC.TabIndex = 8;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(710, 158);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(250, 27);
            this.tbCardNumber.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(283, 295);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(250, 27);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(283, 236);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(250, 27);
            this.tbUsername.TabIndex = 4;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountInfo.Location = new System.Drawing.Point(353, 182);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(123, 28);
            this.lblAccountInfo.TabIndex = 3;
            this.lblAccountInfo.Text = "Account info";
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMyProfile.Location = new System.Drawing.Point(530, 7);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(152, 41);
            this.lblMyProfile.TabIndex = 2;
            this.lblMyProfile.Text = "My Profile";
            // 
            // btnMyProfileRedirect
            // 
            this.btnMyProfileRedirect.Location = new System.Drawing.Point(9, 81);
            this.btnMyProfileRedirect.Name = "btnMyProfileRedirect";
            this.btnMyProfileRedirect.Size = new System.Drawing.Size(178, 69);
            this.btnMyProfileRedirect.TabIndex = 1;
            this.btnMyProfileRedirect.Text = "My Profile";
            this.btnMyProfileRedirect.UseVisualStyleBackColor = true;
            // 
            // btnBuyFuelRedirect
            // 
            this.btnBuyFuelRedirect.Location = new System.Drawing.Point(9, 7);
            this.btnBuyFuelRedirect.Name = "btnBuyFuelRedirect";
            this.btnBuyFuelRedirect.Size = new System.Drawing.Size(178, 67);
            this.btnBuyFuelRedirect.TabIndex = 0;
            this.btnBuyFuelRedirect.Text = "Buy Fuel";
            this.btnBuyFuelRedirect.UseVisualStyleBackColor = true;
            this.btnBuyFuelRedirect.Click += new System.EventHandler(this.btnBuyFuelRedirect_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 741);
            this.Controls.Add(this.tcCustomer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.tcCustomer.ResumeLayout(false);
            this.tabBuyFuel.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.tabMyProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tabBuyFuel;
        private System.Windows.Forms.Button btnMyProfileRedir;
        private System.Windows.Forms.Button btnBuyFuelRedir;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Label lblPhoneNumberMyProfile;
        private System.Windows.Forms.Label lblZipCodeMyProfile;
        private System.Windows.Forms.Label lblCardCVCMyProfile;
        private System.Windows.Forms.Label lblCardValidThruMyProfile;
        private System.Windows.Forms.Label lblCardNumberMyProfile;
        private System.Windows.Forms.Label lblPaymentDeliveryInfo;
        private System.Windows.Forms.Label lblPasswordMyProfile;
        private System.Windows.Forms.Label lblUsernameMyProfile;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbCardCVC;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Button btnMyProfileRedirect;
        private System.Windows.Forms.Button btnBuyFuelRedirect;
        private System.Windows.Forms.DateTimePicker dtpCardValidThru;
        private System.Windows.Forms.FlowLayoutPanel flowBuyFuel;
        private System.Windows.Forms.Button btnUpdatePaymentInfo;
        private System.Windows.Forms.Button btnUpdateAccInfo;
    }
}