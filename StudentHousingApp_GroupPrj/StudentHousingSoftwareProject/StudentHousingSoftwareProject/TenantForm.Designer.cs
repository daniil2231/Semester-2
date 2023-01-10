
namespace StudentHousingSoftwareProject
{
    partial class TenantForm
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
            this.tcTenantAccount = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblFinishedTasks = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnRemoveSelectedEvent = new System.Windows.Forms.Button();
            this.cbMyEvents = new System.Windows.Forms.CheckBox();
            this.lblInbox = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lbInbox = new System.Windows.Forms.ListBox();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.lbMyTasks = new System.Windows.Forms.ListBox();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventsCalTab = new System.Windows.Forms.Label();
            this.lbEventsCalTab = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabRules = new System.Windows.Forms.TabPage();
            this.lbRuless = new System.Windows.Forms.ListBox();
            this.tabMakeComplaint = new System.Windows.Forms.TabPage();
            this.gbComplaintToAgency = new System.Windows.Forms.GroupBox();
            this.btnSendComplaintToAgency = new System.Windows.Forms.Button();
            this.rtbComplaintToAgency = new System.Windows.Forms.RichTextBox();
            this.gbComplaintToRoommates = new System.Windows.Forms.GroupBox();
            this.btnSendComplaintToRoommates = new System.Windows.Forms.Button();
            this.rtbComplaintToRoommates = new System.Windows.Forms.RichTextBox();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogedStudent = new System.Windows.Forms.Label();
            this.lblHouseNum = new System.Windows.Forms.Label();
            this.pcBoxTenant = new System.Windows.Forms.PictureBox();
            this.tcTenantAccount.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.tabMakeComplaint.SuspendLayout();
            this.gbComplaintToAgency.SuspendLayout();
            this.gbComplaintToRoommates.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTenantAccount
            // 
            this.tcTenantAccount.Controls.Add(this.tabHome);
            this.tcTenantAccount.Controls.Add(this.tabCalendar);
            this.tcTenantAccount.Controls.Add(this.tabRules);
            this.tcTenantAccount.Controls.Add(this.tabMakeComplaint);
            this.tcTenantAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTenantAccount.Location = new System.Drawing.Point(316, 51);
            this.tcTenantAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcTenantAccount.Name = "tcTenantAccount";
            this.tcTenantAccount.SelectedIndex = 0;
            this.tcTenantAccount.Size = new System.Drawing.Size(779, 512);
            this.tcTenantAccount.TabIndex = 6;
            this.tcTenantAccount.SelectedIndexChanged += new System.EventHandler(this.tcTenantAccount_SelectedIndexChanged_1);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.PeachPuff;
            this.tabHome.Controls.Add(this.lblFinishedTasks);
            this.tabHome.Controls.Add(this.btnDone);
            this.tabHome.Controls.Add(this.btnTake);
            this.tabHome.Controls.Add(this.btnRemoveSelectedEvent);
            this.tabHome.Controls.Add(this.cbMyEvents);
            this.tabHome.Controls.Add(this.lblInbox);
            this.tabHome.Controls.Add(this.lblEvents);
            this.tabHome.Controls.Add(this.lblTasks);
            this.tabHome.Controls.Add(this.lbInbox);
            this.tabHome.Controls.Add(this.lbEvents);
            this.tabHome.Controls.Add(this.lbTasks);
            this.tabHome.Controls.Add(this.lbMyTasks);
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHome.Size = new System.Drawing.Size(771, 484);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // lblFinishedTasks
            // 
            this.lblFinishedTasks.AutoSize = true;
            this.lblFinishedTasks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishedTasks.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblFinishedTasks.Location = new System.Drawing.Point(37, 239);
            this.lblFinishedTasks.Name = "lblFinishedTasks";
            this.lblFinishedTasks.Size = new System.Drawing.Size(113, 28);
            this.lblFinishedTasks.TabIndex = 12;
            this.lblFinishedTasks.Text = "My tasks";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(249, 397);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(91, 23);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(247, 190);
            this.btnTake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(91, 25);
            this.btnTake.TabIndex = 9;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click_1);
            // 
            // btnRemoveSelectedEvent
            // 
            this.btnRemoveSelectedEvent.Location = new System.Drawing.Point(539, 180);
            this.btnRemoveSelectedEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveSelectedEvent.Name = "btnRemoveSelectedEvent";
            this.btnRemoveSelectedEvent.Size = new System.Drawing.Size(208, 38);
            this.btnRemoveSelectedEvent.TabIndex = 8;
            this.btnRemoveSelectedEvent.Text = "Remove selected event";
            this.btnRemoveSelectedEvent.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedEvent.Visible = false;
            this.btnRemoveSelectedEvent.Click += new System.EventHandler(this.btnRemoveSelectedEvent_Click_1);
            // 
            // cbMyEvents
            // 
            this.cbMyEvents.AutoSize = true;
            this.cbMyEvents.Location = new System.Drawing.Point(399, 190);
            this.cbMyEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMyEvents.Name = "cbMyEvents";
            this.cbMyEvents.Size = new System.Drawing.Size(99, 20);
            this.cbMyEvents.TabIndex = 7;
            this.cbMyEvents.Text = "My events";
            this.cbMyEvents.UseVisualStyleBackColor = true;
            this.cbMyEvents.CheckedChanged += new System.EventHandler(this.cbMyEvents_CheckedChanged);
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInbox.Location = new System.Drawing.Point(376, 240);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(76, 28);
            this.lblInbox.TabIndex = 5;
            this.lblInbox.Text = "Inbox";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEvents.Location = new System.Drawing.Point(376, 19);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(90, 28);
            this.lblEvents.TabIndex = 4;
            this.lblEvents.Text = "Events";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTasks.Location = new System.Drawing.Point(37, 19);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(81, 28);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "Tasks";
            // 
            // lbInbox
            // 
            this.lbInbox.FormattingEnabled = true;
            this.lbInbox.ItemHeight = 15;
            this.lbInbox.Location = new System.Drawing.Point(381, 273);
            this.lbInbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbInbox.Name = "lbInbox";
            this.lbInbox.Size = new System.Drawing.Size(366, 169);
            this.lbInbox.TabIndex = 2;
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 15;
            this.lbEvents.Location = new System.Drawing.Point(381, 53);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(366, 124);
            this.lbEvents.TabIndex = 1;
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 15;
            this.lbTasks.Location = new System.Drawing.Point(35, 53);
            this.lbTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(301, 124);
            this.lbTasks.TabIndex = 0;
            // 
            // lbMyTasks
            // 
            this.lbMyTasks.FormattingEnabled = true;
            this.lbMyTasks.ItemHeight = 15;
            this.lbMyTasks.Location = new System.Drawing.Point(35, 273);
            this.lbMyTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMyTasks.Name = "lbMyTasks";
            this.lbMyTasks.Size = new System.Drawing.Size(303, 109);
            this.lbMyTasks.TabIndex = 11;
            // 
            // tabCalendar
            // 
            this.tabCalendar.BackColor = System.Drawing.Color.PeachPuff;
            this.tabCalendar.Controls.Add(this.label1);
            this.tabCalendar.Controls.Add(this.btnAddEvent);
            this.tabCalendar.Controls.Add(this.tbEventName);
            this.tabCalendar.Controls.Add(this.lblEventsCalTab);
            this.tabCalendar.Controls.Add(this.lbEventsCalTab);
            this.tabCalendar.Controls.Add(this.monthCalendar1);
            this.tabCalendar.Location = new System.Drawing.Point(4, 24);
            this.tabCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCalendar.Size = new System.Drawing.Size(771, 484);
            this.tabCalendar.TabIndex = 1;
            this.tabCalendar.Text = "Calendar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Select date by pressing it on the calendar)";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(472, 317);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(109, 23);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click_1);
            // 
            // tbEventName
            // 
            this.tbEventName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEventName.Location = new System.Drawing.Point(393, 255);
            this.tbEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(272, 23);
            this.tbEventName.TabIndex = 3;
            this.tbEventName.Text = "Insert type of event...";
            this.tbEventName.Enter += new System.EventHandler(this.tbEventName_Enter_1);
            this.tbEventName.Leave += new System.EventHandler(this.tbEventName_Leave_1);
            // 
            // lblEventsCalTab
            // 
            this.lblEventsCalTab.AutoSize = true;
            this.lblEventsCalTab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsCalTab.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEventsCalTab.Location = new System.Drawing.Point(396, 38);
            this.lblEventsCalTab.Name = "lblEventsCalTab";
            this.lblEventsCalTab.Size = new System.Drawing.Size(85, 26);
            this.lblEventsCalTab.TabIndex = 2;
            this.lblEventsCalTab.Text = "Events";
            // 
            // lbEventsCalTab
            // 
            this.lbEventsCalTab.FormattingEnabled = true;
            this.lbEventsCalTab.ItemHeight = 15;
            this.lbEventsCalTab.Location = new System.Drawing.Point(393, 70);
            this.lbEventsCalTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEventsCalTab.Name = "lbEventsCalTab";
            this.lbEventsCalTab.Size = new System.Drawing.Size(272, 154);
            this.lbEventsCalTab.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // tabRules
            // 
            this.tabRules.BackColor = System.Drawing.Color.PeachPuff;
            this.tabRules.Controls.Add(this.lbRuless);
            this.tabRules.Location = new System.Drawing.Point(4, 24);
            this.tabRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRules.Name = "tabRules";
            this.tabRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRules.Size = new System.Drawing.Size(771, 484);
            this.tabRules.TabIndex = 2;
            this.tabRules.Text = "Rules";
            // 
            // lbRuless
            // 
            this.lbRuless.FormattingEnabled = true;
            this.lbRuless.ItemHeight = 15;
            this.lbRuless.Location = new System.Drawing.Point(47, 39);
            this.lbRuless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRuless.Name = "lbRuless";
            this.lbRuless.Size = new System.Drawing.Size(675, 379);
            this.lbRuless.TabIndex = 0;
            // 
            // tabMakeComplaint
            // 
            this.tabMakeComplaint.BackColor = System.Drawing.Color.PeachPuff;
            this.tabMakeComplaint.Controls.Add(this.gbComplaintToAgency);
            this.tabMakeComplaint.Controls.Add(this.gbComplaintToRoommates);
            this.tabMakeComplaint.Controls.Add(this.lbComplaints);
            this.tabMakeComplaint.Location = new System.Drawing.Point(4, 24);
            this.tabMakeComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMakeComplaint.Name = "tabMakeComplaint";
            this.tabMakeComplaint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMakeComplaint.Size = new System.Drawing.Size(771, 484);
            this.tabMakeComplaint.TabIndex = 3;
            this.tabMakeComplaint.Text = "Make a complaint";
            // 
            // gbComplaintToAgency
            // 
            this.gbComplaintToAgency.Controls.Add(this.btnSendComplaintToAgency);
            this.gbComplaintToAgency.Controls.Add(this.rtbComplaintToAgency);
            this.gbComplaintToAgency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComplaintToAgency.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbComplaintToAgency.Location = new System.Drawing.Point(400, 242);
            this.gbComplaintToAgency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbComplaintToAgency.Name = "gbComplaintToAgency";
            this.gbComplaintToAgency.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbComplaintToAgency.Size = new System.Drawing.Size(316, 187);
            this.gbComplaintToAgency.TabIndex = 2;
            this.gbComplaintToAgency.TabStop = false;
            this.gbComplaintToAgency.Text = "To agency";
            // 
            // btnSendComplaintToAgency
            // 
            this.btnSendComplaintToAgency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaintToAgency.Location = new System.Drawing.Point(129, 155);
            this.btnSendComplaintToAgency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendComplaintToAgency.Name = "btnSendComplaintToAgency";
            this.btnSendComplaintToAgency.Size = new System.Drawing.Size(75, 23);
            this.btnSendComplaintToAgency.TabIndex = 1;
            this.btnSendComplaintToAgency.Text = "Send";
            this.btnSendComplaintToAgency.UseVisualStyleBackColor = true;
            this.btnSendComplaintToAgency.Click += new System.EventHandler(this.btnSendComplaintToAgency_Click_1);
            // 
            // rtbComplaintToAgency
            // 
            this.rtbComplaintToAgency.Location = new System.Drawing.Point(15, 32);
            this.rtbComplaintToAgency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbComplaintToAgency.Name = "rtbComplaintToAgency";
            this.rtbComplaintToAgency.Size = new System.Drawing.Size(287, 117);
            this.rtbComplaintToAgency.TabIndex = 0;
            this.rtbComplaintToAgency.Text = "";
            // 
            // gbComplaintToRoommates
            // 
            this.gbComplaintToRoommates.Controls.Add(this.btnSendComplaintToRoommates);
            this.gbComplaintToRoommates.Controls.Add(this.rtbComplaintToRoommates);
            this.gbComplaintToRoommates.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComplaintToRoommates.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbComplaintToRoommates.Location = new System.Drawing.Point(400, 26);
            this.gbComplaintToRoommates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbComplaintToRoommates.Name = "gbComplaintToRoommates";
            this.gbComplaintToRoommates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbComplaintToRoommates.Size = new System.Drawing.Size(316, 190);
            this.gbComplaintToRoommates.TabIndex = 1;
            this.gbComplaintToRoommates.TabStop = false;
            this.gbComplaintToRoommates.Text = "To roommates";
            // 
            // btnSendComplaintToRoommates
            // 
            this.btnSendComplaintToRoommates.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaintToRoommates.Location = new System.Drawing.Point(129, 157);
            this.btnSendComplaintToRoommates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendComplaintToRoommates.Name = "btnSendComplaintToRoommates";
            this.btnSendComplaintToRoommates.Size = new System.Drawing.Size(75, 23);
            this.btnSendComplaintToRoommates.TabIndex = 1;
            this.btnSendComplaintToRoommates.Text = "Send";
            this.btnSendComplaintToRoommates.UseVisualStyleBackColor = true;
            this.btnSendComplaintToRoommates.Click += new System.EventHandler(this.btnSendComplaintToRoommates_Click_1);
            // 
            // rtbComplaintToRoommates
            // 
            this.rtbComplaintToRoommates.Location = new System.Drawing.Point(15, 30);
            this.rtbComplaintToRoommates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbComplaintToRoommates.Name = "rtbComplaintToRoommates";
            this.rtbComplaintToRoommates.Size = new System.Drawing.Size(287, 120);
            this.rtbComplaintToRoommates.TabIndex = 0;
            this.rtbComplaintToRoommates.Text = "";
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 15;
            this.lbComplaints.Location = new System.Drawing.Point(46, 56);
            this.lbComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(299, 349);
            this.lbComplaints.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.LightSalmon;
            this.panelUser.Controls.Add(this.btnLogout);
            this.panelUser.Controls.Add(this.lblLogedStudent);
            this.panelUser.Controls.Add(this.lblHouseNum);
            this.panelUser.Location = new System.Drawing.Point(0, -1);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(279, 653);
            this.panelUser.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(154, 128);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 26);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lblLogedStudent
            // 
            this.lblLogedStudent.AutoSize = true;
            this.lblLogedStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblLogedStudent.Location = new System.Drawing.Point(10, 40);
            this.lblLogedStudent.Name = "lblLogedStudent";
            this.lblLogedStudent.Size = new System.Drawing.Size(236, 32);
            this.lblLogedStudent.TabIndex = 0;
            this.lblLogedStudent.Text = "/Logged in user/";
            // 
            // lblHouseNum
            // 
            this.lblHouseNum.AutoSize = true;
            this.lblHouseNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNum.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHouseNum.Location = new System.Drawing.Point(13, 90);
            this.lblHouseNum.Name = "lblHouseNum";
            this.lblHouseNum.Size = new System.Drawing.Size(97, 17);
            this.lblHouseNum.TabIndex = 3;
            this.lblHouseNum.Text = "/House num/";
            // 
            // pcBoxTenant
            // 
            this.pcBoxTenant.BackColor = System.Drawing.Color.DimGray;
            this.pcBoxTenant.Image = global::StudentHousingSoftwareProject.Properties.Resources.street;
            this.pcBoxTenant.Location = new System.Drawing.Point(0, -1);
            this.pcBoxTenant.Name = "pcBoxTenant";
            this.pcBoxTenant.Size = new System.Drawing.Size(1132, 653);
            this.pcBoxTenant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxTenant.TabIndex = 5;
            this.pcBoxTenant.TabStop = false;
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 649);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.tcTenantAccount);
            this.Controls.Add(this.pcBoxTenant);
            this.Name = "TenantForm";
            this.Text = "TenantForm";
            this.tcTenantAccount.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            this.tabRules.ResumeLayout(false);
            this.tabMakeComplaint.ResumeLayout(false);
            this.gbComplaintToAgency.ResumeLayout(false);
            this.gbComplaintToRoommates.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxTenant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBoxTenant;
        private System.Windows.Forms.TabControl tcTenantAccount;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lblFinishedTasks;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnRemoveSelectedEvent;
        private System.Windows.Forms.CheckBox cbMyEvents;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.ListBox lbInbox;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.ListBox lbMyTasks;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblEventsCalTab;
        private System.Windows.Forms.ListBox lbEventsCalTab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabRules;
        private System.Windows.Forms.ListBox lbRuless;
        private System.Windows.Forms.TabPage tabMakeComplaint;
        private System.Windows.Forms.GroupBox gbComplaintToAgency;
        private System.Windows.Forms.Button btnSendComplaintToAgency;
        private System.Windows.Forms.RichTextBox rtbComplaintToAgency;
        private System.Windows.Forms.GroupBox gbComplaintToRoommates;
        private System.Windows.Forms.Button btnSendComplaintToRoommates;
        private System.Windows.Forms.RichTextBox rtbComplaintToRoommates;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLogedStudent;
        private System.Windows.Forms.Label lblHouseNum;
    }
}