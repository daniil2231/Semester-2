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
    public partial class TenantForm : Form
    {
        Administration administration;
        Tenant tenant = new Tenant();
        Login login = new Login();

        public TenantForm()
        {
            InitializeComponent();
        }

        public TenantForm(Administration administration, string username, string password)
        {
            InitializeComponent();
            this.administration = administration;
            login = new Login(username, password);

            string houseNumber = administration.ReturnHouseNumberOfTenant(login.LoginUsername);
            tenant = new Tenant(login.LoginUsername, login.LoginPassword, houseNumber);

            lblLogedStudent.Text = tenant.TenantName;
            lblHouseNum.Text = tenant.HouseNumber;
            tcTenantAccount.SelectedTab = tabHome;
            tenant.SetMyEvents(administration.EventsList);
            administration.SetTasksInHouse(tenant.HouseNumber);
            tenant.SetMyTasks(administration.TasksInHouse);

            DisplayTasks();
            DisplayMyTasks();
            DisplayEvents();
            DisplayMessageTenant();
        }

        public void DisplayTasks()
        {
            lbTasks.Items.Clear();
            for (int i = 0; i < administration.TasksInHouse.Count; i++)
            {
                lbTasks.Items.Add(administration.TasksInHouse[i].GetInfoTask());
            }
        }

        public void DisplayMyTasks()
        {
            lbMyTasks.Items.Clear();

            for (int i = 0; i < tenant.MyTasks.Count; i++)
            {
                lbMyTasks.Items.Add(tenant.MyTasks[i].GetInfoTask());
            }
        }

        public void DisplayEvents()
        {
            lbEvents.Items.Clear();
            if (administration.EventsList.Count != 0)
            {
                for (int i = 0; i < administration.EventsList.Count; i++)
                {
                    if (tenant.HouseNumber == administration.EventsList[i].HouseNumber)
                    {
                        lbEvents.Items.Add(administration.EventsList[i].GetInfoEvent());
                    }
                }
            }
            else
            {
                lbEvents.Items.Add("No events");
            }
        }

        private void DisplayMessageTenant()
        {
            lbInbox.Items.Clear();
            if (administration.Inbox.ContainsKey(tenant.HouseNumber))
            {
                foreach (var item in administration.Inbox[tenant.HouseNumber])
                {

                    lbInbox.Items.Add(item);
                }
            }
            else
            {
                lbInbox.Items.Add("No messages");
            }
        }

        public void DisplayMessagesFromRoomates()
        {
            lbComplaints.Items.Clear();
            if (administration.ComplaintsRoommates.ContainsKey(tenant.HouseNumber))
            {
                foreach (var item in administration.ComplaintsRoommates[tenant.HouseNumber])
                {
                    lbComplaints.Items.Add(item);
                }
            }
            else
            {
                lbComplaints.Items.Add("No messages");
            }
        }

        private void DisplayRulesTenant()
        {
            lbRuless.Items.Clear();
            for (int i = 0; i < administration.Rules.Count; i++)
            {
                lbRuless.Items.Add(administration.Rules[i]);
            }
        }

        private void btnSendComplaintToAgency_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (rtbComplaintToAgency.Text != "")
            {
                administration.AddComplaintsToAgency($"House: {tenant.HouseNumber} - {now} : {rtbComplaintToAgency.Text}");
                rtbComplaintToAgency.Text = "";
            }
        }

        public void DisplayMyEvents()
        {
            lbEvents.Items.Clear();
            if (tenant.MyEvents.Count != 0)
            {
                for (int i = 0; i < tenant.MyEvents.Count; i++)
                {
                    lbEvents.Items.Add(tenant.MyEvents[i].GetInfoEvent());
                }
            }
            else
            {
                lbEvents.Items.Add("No events");
            }
        }

        public void DisplayMyFinishedTasks()
        {
            lbMyTasks.Items.Clear();

            for (int i = 0; i < tenant.MyTasks.Count; i++)
            {
                lbMyTasks.Items.Add(tenant.MyTasks[i].GetInfoTask());
            }
        }

        private void LoggingOutClearInfo()
        {
            login = new Login();
            tenant = new Tenant();
        }

        private void btnTake_Click_1(object sender, EventArgs e)
        {
            if (lbTasks.SelectedIndex != -1 && administration.TasksInHouse[lbTasks.SelectedIndex].Taken == false)
            {
                administration.TasksInHouse[lbTasks.SelectedIndex].Taken = true;
                administration.TasksInHouse[lbTasks.SelectedIndex].AssignedPerson = tenant.TenantName;
                tenant.AddMyTask(administration.TasksInHouse[lbTasks.SelectedIndex]);
            }

            lbTasks.Items.Clear();
            lbMyTasks.Items.Clear();
            DisplayMyTasks();
            DisplayTasks();
        }

        private void cbMyEvents_CheckedChanged(object sender, EventArgs e)
        {
            lbEvents.Items.Clear();
            if (cbMyEvents.Checked == true)
            {
                DisplayMyEvents();
                btnRemoveSelectedEvent.Visible = true;
            }
            else
            {
                DisplayEvents();
                btnRemoveSelectedEvent.Visible = false;
            }
        }

        private void btnRemoveSelectedEvent_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = lbEvents.SelectedIndex;
            if(selectedIndex != -1)
            {
                administration.RemoveEvent(tenant.MyEvents[selectedIndex].Id);
                tenant.RemoveMyEvent(selectedIndex);
                DisplayMyEvents();
            }
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            if (lbMyTasks.SelectedIndex != -1)
            {
                tenant.MyTasks[lbMyTasks.SelectedIndex].Status = true;
                string nameOfDoneTaks = tenant.MyTasks[lbMyTasks.SelectedIndex].TypeOfTask;
                for (int i = 0; i < administration.TasksInHouse.Count; i++)
                {
                    if (administration.TasksInHouse[i].TypeOfTask == nameOfDoneTaks)
                    {
                        administration.TasksInHouse[i].Status = true;
                    }
                }
            }
            DisplayMyTasks();
            DisplayTasks();
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            lbEventsCalTab.Items.Clear();
            foreach (Event events in administration.EventsList)
            {
                if (monthCalendar1.SelectionRange.Start.ToShortDateString() == events.DateEvent)
                {
                    if (tenant.HouseNumber == events.HouseNumber)
                    {
                        lbEventsCalTab.Items.Add(events.GetInfoEvent());
                    }
                }
            }
        }

        private void tbEventName_Enter_1(object sender, EventArgs e)
        {
            if (tbEventName.Text == "Insert type of event...")
            {
                tbEventName.Text = "";
                tbEventName.ForeColor = Color.Black;
            }
        }

        private void tbEventName_Leave_1(object sender, EventArgs e)
        {
            if (tbEventName.Text == "")
            {
                tbEventName.Text = "Insert type of event...";
                tbEventName.ForeColor = Color.DarkGray;
            }
        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            if (tbEventName.Text == String.Empty || tbEventName.Text == "Insert type of event...")
            {
                MessageBox.Show("Bruh, add some real event!!!");
            }
            else
            {
                string eventName = tbEventName.Text;

                Event events = new Event(eventName, tenant.TenantName, monthCalendar1.SelectionRange.Start.ToShortDateString(), tenant.HouseNumber);
                tenant.AddMyEvent(events);
                administration.AddEventToAllEvents(events);
                lbEventsCalTab.Items.Add(events.GetInfoEvent());
                tbEventName.Text = "Insert type of event...";
                tbEventName.ForeColor = Color.DarkGray;
            }
        }

        private void btnSendComplaintToRoommates_Click_1(object sender, EventArgs e)
        {
            lbComplaints.Items.Clear();
            DateTime now = DateTime.Now;
            administration.SendComplainToRoomates(rtbComplaintToRoommates.Text, now, tenant.HouseNumber);
            DisplayMessagesFromRoomates();
            rtbComplaintToRoommates.Text = "";
        }

        private void btnSendComplaintToAgency_Click_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (rtbComplaintToAgency.Text != "")
            {
                administration.AddComplaintsToAgency($"House: {tenant.HouseNumber} - {now} : {rtbComplaintToAgency.Text}");
                rtbComplaintToAgency.Text = "";
            }
        }

        private void tcTenantAccount_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tcTenantAccount.SelectedIndex == 0)
            {
                //lbTasks.Items.Clear();
                //lbEvents.Items.Clear();
                //lbInbox.Items.Clear();
                DisplayTasks();
                DisplayMyTasks();
                DisplayEvents();
                DisplayMessageTenant();
            }
            else if (tcTenantAccount.SelectedIndex == 1)
            {
                lbEventsCalTab.Items.Clear();
                foreach (Event events in administration.EventsList)
                {
                    if (monthCalendar1.SelectionRange.Start.ToShortDateString() == events.DateEvent)
                    {
                        if (tenant.HouseNumber == events.HouseNumber)
                        {
                            lbEventsCalTab.Items.Add(events.GetInfoEvent());
                        }
                    }
                }
            }
            else if (tcTenantAccount.SelectedIndex == 2)
            {
                DisplayRulesTenant();
            }
            else if (tcTenantAccount.SelectedIndex == 3)
            {
                DisplayMessagesFromRoomates();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoggingOutClearInfo();
            cbMyEvents.Checked = false;

            lbComplaints.Items.Clear();
            lbEventsCalTab.Items.Clear();
            lbTasks.Items.Clear();
            lbMyTasks.Items.Clear();
            this.Close();
        }
    }
}
