
namespace IndividualAssignment_Forms
{
    partial class AdminForm
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
            this.tcAdminForm = new System.Windows.Forms.TabControl();
            this.tabEditFuels = new System.Windows.Forms.TabPage();
            this.gbAddDiesel = new System.Windows.Forms.GroupBox();
            this.lblDieselSuitable = new System.Windows.Forms.Label();
            this.lblDieselViscosity = new System.Windows.Forms.Label();
            this.lblDieselPurity = new System.Windows.Forms.Label();
            this.lblDieselPrice = new System.Windows.Forms.Label();
            this.lblDieselName = new System.Windows.Forms.Label();
            this.btnAddDiesel = new System.Windows.Forms.Button();
            this.tbDieselSuitable = new System.Windows.Forms.TextBox();
            this.tbDieselViscosity = new System.Windows.Forms.TextBox();
            this.tbDieselPurity = new System.Windows.Forms.TextBox();
            this.tbDieselPrice = new System.Windows.Forms.TextBox();
            this.tbDieselType = new System.Windows.Forms.TextBox();
            this.gbAddCNG = new System.Windows.Forms.GroupBox();
            this.lblCNGSuitable = new System.Windows.Forms.Label();
            this.lblCNGAirflowRes = new System.Windows.Forms.Label();
            this.lblCNGPurity = new System.Windows.Forms.Label();
            this.lblCNGPrice = new System.Windows.Forms.Label();
            this.lblCNGType = new System.Windows.Forms.Label();
            this.btnAddCNG = new System.Windows.Forms.Button();
            this.tbCNGSuitable = new System.Windows.Forms.TextBox();
            this.tbCNGAirflowRes = new System.Windows.Forms.TextBox();
            this.tbCNGPurity = new System.Windows.Forms.TextBox();
            this.tbCNGPrice = new System.Windows.Forms.TextBox();
            this.tbCNGType = new System.Windows.Forms.TextBox();
            this.flowEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPurchaseHistoryRedir = new System.Windows.Forms.Button();
            this.btnEditFuelsRedir = new System.Windows.Forms.Button();
            this.tabPurchaseHistory = new System.Windows.Forms.TabPage();
            this.lbSalesHistory = new System.Windows.Forms.ListBox();
            this.btnPurchaseHistoryRedirection = new System.Windows.Forms.Button();
            this.btnEditFuelsRedirection = new System.Windows.Forms.Button();
            this.tcAdminForm.SuspendLayout();
            this.tabEditFuels.SuspendLayout();
            this.gbAddDiesel.SuspendLayout();
            this.gbAddCNG.SuspendLayout();
            this.tabPurchaseHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdminForm
            // 
            this.tcAdminForm.Controls.Add(this.tabEditFuels);
            this.tcAdminForm.Controls.Add(this.tabPurchaseHistory);
            this.tcAdminForm.Location = new System.Drawing.Point(1, -30);
            this.tcAdminForm.Name = "tcAdminForm";
            this.tcAdminForm.SelectedIndex = 0;
            this.tcAdminForm.Size = new System.Drawing.Size(1163, 1049);
            this.tcAdminForm.TabIndex = 0;
            this.tcAdminForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcAdminForm_Selected);
            // 
            // tabEditFuels
            // 
            this.tabEditFuels.BackColor = System.Drawing.Color.LightGray;
            this.tabEditFuels.Controls.Add(this.gbAddDiesel);
            this.tabEditFuels.Controls.Add(this.gbAddCNG);
            this.tabEditFuels.Controls.Add(this.flowEdit);
            this.tabEditFuels.Controls.Add(this.btnPurchaseHistoryRedir);
            this.tabEditFuels.Controls.Add(this.btnEditFuelsRedir);
            this.tabEditFuels.Location = new System.Drawing.Point(4, 29);
            this.tabEditFuels.Name = "tabEditFuels";
            this.tabEditFuels.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditFuels.Size = new System.Drawing.Size(1155, 1016);
            this.tabEditFuels.TabIndex = 0;
            this.tabEditFuels.Text = "EditFuels";
            // 
            // gbAddDiesel
            // 
            this.gbAddDiesel.Controls.Add(this.lblDieselSuitable);
            this.gbAddDiesel.Controls.Add(this.lblDieselViscosity);
            this.gbAddDiesel.Controls.Add(this.lblDieselPurity);
            this.gbAddDiesel.Controls.Add(this.lblDieselPrice);
            this.gbAddDiesel.Controls.Add(this.lblDieselName);
            this.gbAddDiesel.Controls.Add(this.btnAddDiesel);
            this.gbAddDiesel.Controls.Add(this.tbDieselSuitable);
            this.gbAddDiesel.Controls.Add(this.tbDieselViscosity);
            this.gbAddDiesel.Controls.Add(this.tbDieselPurity);
            this.gbAddDiesel.Controls.Add(this.tbDieselPrice);
            this.gbAddDiesel.Controls.Add(this.tbDieselType);
            this.gbAddDiesel.Location = new System.Drawing.Point(178, 6);
            this.gbAddDiesel.Name = "gbAddDiesel";
            this.gbAddDiesel.Size = new System.Drawing.Size(865, 86);
            this.gbAddDiesel.TabIndex = 2;
            this.gbAddDiesel.TabStop = false;
            this.gbAddDiesel.Text = "Add diesel";
            // 
            // lblDieselSuitable
            // 
            this.lblDieselSuitable.AutoSize = true;
            this.lblDieselSuitable.Location = new System.Drawing.Point(531, 22);
            this.lblDieselSuitable.Name = "lblDieselSuitable";
            this.lblDieselSuitable.Size = new System.Drawing.Size(89, 20);
            this.lblDieselSuitable.TabIndex = 10;
            this.lblDieselSuitable.Text = "Suitable for:";
            // 
            // lblDieselViscosity
            // 
            this.lblDieselViscosity.AutoSize = true;
            this.lblDieselViscosity.Location = new System.Drawing.Point(400, 23);
            this.lblDieselViscosity.Name = "lblDieselViscosity";
            this.lblDieselViscosity.Size = new System.Drawing.Size(69, 20);
            this.lblDieselViscosity.TabIndex = 9;
            this.lblDieselViscosity.Text = "Viscosity:";
            // 
            // lblDieselPurity
            // 
            this.lblDieselPurity.AutoSize = true;
            this.lblDieselPurity.Location = new System.Drawing.Point(269, 24);
            this.lblDieselPurity.Name = "lblDieselPurity";
            this.lblDieselPurity.Size = new System.Drawing.Size(49, 20);
            this.lblDieselPurity.TabIndex = 8;
            this.lblDieselPurity.Text = "Purity:";
            // 
            // lblDieselPrice
            // 
            this.lblDieselPrice.AutoSize = true;
            this.lblDieselPrice.Location = new System.Drawing.Point(138, 24);
            this.lblDieselPrice.Name = "lblDieselPrice";
            this.lblDieselPrice.Size = new System.Drawing.Size(44, 20);
            this.lblDieselPrice.TabIndex = 7;
            this.lblDieselPrice.Text = "Price:";
            // 
            // lblDieselName
            // 
            this.lblDieselName.AutoSize = true;
            this.lblDieselName.Location = new System.Drawing.Point(7, 22);
            this.lblDieselName.Name = "lblDieselName";
            this.lblDieselName.Size = new System.Drawing.Size(86, 20);
            this.lblDieselName.TabIndex = 6;
            this.lblDieselName.Text = "Diesel type:";
            // 
            // btnAddDiesel
            // 
            this.btnAddDiesel.Location = new System.Drawing.Point(662, 43);
            this.btnAddDiesel.Name = "btnAddDiesel";
            this.btnAddDiesel.Size = new System.Drawing.Size(197, 29);
            this.btnAddDiesel.TabIndex = 5;
            this.btnAddDiesel.Text = "Add";
            this.btnAddDiesel.UseVisualStyleBackColor = true;
            this.btnAddDiesel.Click += new System.EventHandler(this.btnAddDiesel_Click);
            // 
            // tbDieselSuitable
            // 
            this.tbDieselSuitable.Location = new System.Drawing.Point(531, 45);
            this.tbDieselSuitable.Name = "tbDieselSuitable";
            this.tbDieselSuitable.Size = new System.Drawing.Size(125, 27);
            this.tbDieselSuitable.TabIndex = 4;
            // 
            // tbDieselViscosity
            // 
            this.tbDieselViscosity.Location = new System.Drawing.Point(400, 46);
            this.tbDieselViscosity.Name = "tbDieselViscosity";
            this.tbDieselViscosity.Size = new System.Drawing.Size(125, 27);
            this.tbDieselViscosity.TabIndex = 3;
            // 
            // tbDieselPurity
            // 
            this.tbDieselPurity.Location = new System.Drawing.Point(269, 45);
            this.tbDieselPurity.Name = "tbDieselPurity";
            this.tbDieselPurity.Size = new System.Drawing.Size(125, 27);
            this.tbDieselPurity.TabIndex = 2;
            // 
            // tbDieselPrice
            // 
            this.tbDieselPrice.Location = new System.Drawing.Point(138, 45);
            this.tbDieselPrice.Name = "tbDieselPrice";
            this.tbDieselPrice.Size = new System.Drawing.Size(125, 27);
            this.tbDieselPrice.TabIndex = 1;
            // 
            // tbDieselType
            // 
            this.tbDieselType.Location = new System.Drawing.Point(7, 45);
            this.tbDieselType.Name = "tbDieselType";
            this.tbDieselType.Size = new System.Drawing.Size(125, 27);
            this.tbDieselType.TabIndex = 0;
            // 
            // gbAddCNG
            // 
            this.gbAddCNG.Controls.Add(this.lblCNGSuitable);
            this.gbAddCNG.Controls.Add(this.lblCNGAirflowRes);
            this.gbAddCNG.Controls.Add(this.lblCNGPurity);
            this.gbAddCNG.Controls.Add(this.lblCNGPrice);
            this.gbAddCNG.Controls.Add(this.lblCNGType);
            this.gbAddCNG.Controls.Add(this.btnAddCNG);
            this.gbAddCNG.Controls.Add(this.tbCNGSuitable);
            this.gbAddCNG.Controls.Add(this.tbCNGAirflowRes);
            this.gbAddCNG.Controls.Add(this.tbCNGPurity);
            this.gbAddCNG.Controls.Add(this.tbCNGPrice);
            this.gbAddCNG.Controls.Add(this.tbCNGType);
            this.gbAddCNG.Location = new System.Drawing.Point(178, 98);
            this.gbAddCNG.Name = "gbAddCNG";
            this.gbAddCNG.Size = new System.Drawing.Size(865, 92);
            this.gbAddCNG.TabIndex = 11;
            this.gbAddCNG.TabStop = false;
            this.gbAddCNG.Text = "Add CNG";
            // 
            // lblCNGSuitable
            // 
            this.lblCNGSuitable.AutoSize = true;
            this.lblCNGSuitable.Location = new System.Drawing.Point(531, 24);
            this.lblCNGSuitable.Name = "lblCNGSuitable";
            this.lblCNGSuitable.Size = new System.Drawing.Size(89, 20);
            this.lblCNGSuitable.TabIndex = 10;
            this.lblCNGSuitable.Text = "Suitable for:";
            // 
            // lblCNGAirflowRes
            // 
            this.lblCNGAirflowRes.AutoSize = true;
            this.lblCNGAirflowRes.Location = new System.Drawing.Point(396, 24);
            this.lblCNGAirflowRes.Name = "lblCNGAirflowRes";
            this.lblCNGAirflowRes.Size = new System.Drawing.Size(129, 20);
            this.lblCNGAirflowRes.TabIndex = 9;
            this.lblCNGAirflowRes.Text = "Airflow resistance:";
            // 
            // lblCNGPurity
            // 
            this.lblCNGPurity.AutoSize = true;
            this.lblCNGPurity.Location = new System.Drawing.Point(269, 26);
            this.lblCNGPurity.Name = "lblCNGPurity";
            this.lblCNGPurity.Size = new System.Drawing.Size(49, 20);
            this.lblCNGPurity.TabIndex = 8;
            this.lblCNGPurity.Text = "Purity:";
            // 
            // lblCNGPrice
            // 
            this.lblCNGPrice.AutoSize = true;
            this.lblCNGPrice.Location = new System.Drawing.Point(138, 26);
            this.lblCNGPrice.Name = "lblCNGPrice";
            this.lblCNGPrice.Size = new System.Drawing.Size(44, 20);
            this.lblCNGPrice.TabIndex = 7;
            this.lblCNGPrice.Text = "Price:";
            // 
            // lblCNGType
            // 
            this.lblCNGType.AutoSize = true;
            this.lblCNGType.Location = new System.Drawing.Point(7, 24);
            this.lblCNGType.Name = "lblCNGType";
            this.lblCNGType.Size = new System.Drawing.Size(75, 20);
            this.lblCNGType.TabIndex = 6;
            this.lblCNGType.Text = "CNG type:";
            // 
            // btnAddCNG
            // 
            this.btnAddCNG.Location = new System.Drawing.Point(662, 45);
            this.btnAddCNG.Name = "btnAddCNG";
            this.btnAddCNG.Size = new System.Drawing.Size(197, 29);
            this.btnAddCNG.TabIndex = 5;
            this.btnAddCNG.Text = "Add";
            this.btnAddCNG.UseVisualStyleBackColor = true;
            this.btnAddCNG.Click += new System.EventHandler(this.btnAddCNG_Click);
            // 
            // tbCNGSuitable
            // 
            this.tbCNGSuitable.Location = new System.Drawing.Point(531, 47);
            this.tbCNGSuitable.Name = "tbCNGSuitable";
            this.tbCNGSuitable.Size = new System.Drawing.Size(125, 27);
            this.tbCNGSuitable.TabIndex = 4;
            // 
            // tbCNGAirflowRes
            // 
            this.tbCNGAirflowRes.Location = new System.Drawing.Point(400, 47);
            this.tbCNGAirflowRes.Name = "tbCNGAirflowRes";
            this.tbCNGAirflowRes.Size = new System.Drawing.Size(125, 27);
            this.tbCNGAirflowRes.TabIndex = 3;
            // 
            // tbCNGPurity
            // 
            this.tbCNGPurity.Location = new System.Drawing.Point(269, 47);
            this.tbCNGPurity.Name = "tbCNGPurity";
            this.tbCNGPurity.Size = new System.Drawing.Size(125, 27);
            this.tbCNGPurity.TabIndex = 2;
            // 
            // tbCNGPrice
            // 
            this.tbCNGPrice.Location = new System.Drawing.Point(138, 47);
            this.tbCNGPrice.Name = "tbCNGPrice";
            this.tbCNGPrice.Size = new System.Drawing.Size(125, 27);
            this.tbCNGPrice.TabIndex = 1;
            // 
            // tbCNGType
            // 
            this.tbCNGType.Location = new System.Drawing.Point(7, 47);
            this.tbCNGType.Name = "tbCNGType";
            this.tbCNGType.Size = new System.Drawing.Size(125, 27);
            this.tbCNGType.TabIndex = 0;
            // 
            // flowEdit
            // 
            this.flowEdit.Location = new System.Drawing.Point(164, 196);
            this.flowEdit.Name = "flowEdit";
            this.flowEdit.Size = new System.Drawing.Size(879, 788);
            this.flowEdit.TabIndex = 14;
            // 
            // btnPurchaseHistoryRedir
            // 
            this.btnPurchaseHistoryRedir.Location = new System.Drawing.Point(7, 98);
            this.btnPurchaseHistoryRedir.Name = "btnPurchaseHistoryRedir";
            this.btnPurchaseHistoryRedir.Size = new System.Drawing.Size(151, 92);
            this.btnPurchaseHistoryRedir.TabIndex = 1;
            this.btnPurchaseHistoryRedir.Text = "Purchase history";
            this.btnPurchaseHistoryRedir.UseVisualStyleBackColor = true;
            this.btnPurchaseHistoryRedir.Click += new System.EventHandler(this.btnPurchaseHistoryRedir_Click);
            // 
            // btnEditFuelsRedir
            // 
            this.btnEditFuelsRedir.Location = new System.Drawing.Point(6, 6);
            this.btnEditFuelsRedir.Name = "btnEditFuelsRedir";
            this.btnEditFuelsRedir.Size = new System.Drawing.Size(151, 86);
            this.btnEditFuelsRedir.TabIndex = 0;
            this.btnEditFuelsRedir.Text = "Edit fuels";
            this.btnEditFuelsRedir.UseVisualStyleBackColor = true;
            // 
            // tabPurchaseHistory
            // 
            this.tabPurchaseHistory.BackColor = System.Drawing.Color.LightGray;
            this.tabPurchaseHistory.Controls.Add(this.lbSalesHistory);
            this.tabPurchaseHistory.Controls.Add(this.btnPurchaseHistoryRedirection);
            this.tabPurchaseHistory.Controls.Add(this.btnEditFuelsRedirection);
            this.tabPurchaseHistory.Location = new System.Drawing.Point(4, 29);
            this.tabPurchaseHistory.Name = "tabPurchaseHistory";
            this.tabPurchaseHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchaseHistory.Size = new System.Drawing.Size(1155, 1016);
            this.tabPurchaseHistory.TabIndex = 1;
            this.tabPurchaseHistory.Text = "PurchaseHistory";
            // 
            // lbSalesHistory
            // 
            this.lbSalesHistory.FormattingEnabled = true;
            this.lbSalesHistory.ItemHeight = 20;
            this.lbSalesHistory.Location = new System.Drawing.Point(367, 81);
            this.lbSalesHistory.Name = "lbSalesHistory";
            this.lbSalesHistory.Size = new System.Drawing.Size(631, 764);
            this.lbSalesHistory.TabIndex = 2;
            // 
            // btnPurchaseHistoryRedirection
            // 
            this.btnPurchaseHistoryRedirection.Location = new System.Drawing.Point(6, 81);
            this.btnPurchaseHistoryRedirection.Name = "btnPurchaseHistoryRedirection";
            this.btnPurchaseHistoryRedirection.Size = new System.Drawing.Size(170, 68);
            this.btnPurchaseHistoryRedirection.TabIndex = 1;
            this.btnPurchaseHistoryRedirection.Text = "Purchase history";
            this.btnPurchaseHistoryRedirection.UseVisualStyleBackColor = true;
            // 
            // btnEditFuelsRedirection
            // 
            this.btnEditFuelsRedirection.Location = new System.Drawing.Point(7, 7);
            this.btnEditFuelsRedirection.Name = "btnEditFuelsRedirection";
            this.btnEditFuelsRedirection.Size = new System.Drawing.Size(170, 68);
            this.btnEditFuelsRedirection.TabIndex = 0;
            this.btnEditFuelsRedirection.Text = "Edit fuels";
            this.btnEditFuelsRedirection.UseVisualStyleBackColor = true;
            this.btnEditFuelsRedirection.Click += new System.EventHandler(this.btnEditFuelsRedirection_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 1016);
            this.Controls.Add(this.tcAdminForm);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tcAdminForm.ResumeLayout(false);
            this.tabEditFuels.ResumeLayout(false);
            this.gbAddDiesel.ResumeLayout(false);
            this.gbAddDiesel.PerformLayout();
            this.gbAddCNG.ResumeLayout(false);
            this.gbAddCNG.PerformLayout();
            this.tabPurchaseHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdminForm;
        private System.Windows.Forms.TabPage tabEditFuels;
        private System.Windows.Forms.GroupBox gbAddDiesel;
        private System.Windows.Forms.TextBox tbDieselType;
        private System.Windows.Forms.Button btnPurchaseHistoryRedir;
        private System.Windows.Forms.Button btnEditFuelsRedir;
        private System.Windows.Forms.TabPage tabPurchaseHistory;
        private System.Windows.Forms.Label lblDieselSuitable;
        private System.Windows.Forms.Label lblDieselViscosity;
        private System.Windows.Forms.Label lblDieselPurity;
        private System.Windows.Forms.Label lblDieselPrice;
        private System.Windows.Forms.Label lblDieselName;
        private System.Windows.Forms.Button btnAddDiesel;
        private System.Windows.Forms.TextBox tbDieselSuitable;
        private System.Windows.Forms.TextBox tbDieselViscosity;
        private System.Windows.Forms.TextBox tbDieselPurity;
        private System.Windows.Forms.TextBox tbDieselPrice;
        private System.Windows.Forms.GroupBox gbAddCNG;
        private System.Windows.Forms.Label lblCNGSuitable;
        private System.Windows.Forms.Label lblCNGAirflowRes;
        private System.Windows.Forms.Label lblCNGPurity;
        private System.Windows.Forms.Label lblCNGPrice;
        private System.Windows.Forms.Label lblCNGType;
        private System.Windows.Forms.Button btnAddCNG;
        private System.Windows.Forms.TextBox tbCNGSuitable;
        private System.Windows.Forms.TextBox tbCNGAirflowRes;
        private System.Windows.Forms.TextBox tbCNGPurity;
        private System.Windows.Forms.TextBox tbCNGPrice;
        private System.Windows.Forms.TextBox tbCNGType;
        private System.Windows.Forms.Button btnPurchaseHistoryRedirection;
        private System.Windows.Forms.Button btnEditFuelsRedirection;
        private System.Windows.Forms.ListBox lbSalesHistory;
        private System.Windows.Forms.FlowLayoutPanel flowEdit;
    }
}