using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public class Administration
    {
        private List<Tenant> tenantList;
        private List<Agency> adminList;
        private List<Task> taskList;
        private List<Task> tasksInHouse;

        private List<Event> eventList;
        private List<string> rules;
        private Dictionary<string, List<string>> complaintsRoommates;

        private List<string> complaintsToAgency;

        private Dictionary<string, List<string>> inbox;

        public List<Task> TasksInHouse
        {
            get
            {
                return tasksInHouse;
            }
            set
            {
                tasksInHouse = value;
            }
        }

        public List<Tenant> TenantList
        {
            get
            {
                return this.tenantList;
            }
            set
            {
                this.tenantList = value;
            }
        }

        public Dictionary<string, List<string>> Inbox
        {
            get
            {
                return inbox;
            }
            set
            {
                inbox = value;
            }
        }

        public Dictionary<string, List<string>> ComplaintsRoommates
        {
            get
            {
                return complaintsRoommates;
            }
            set
            {
                complaintsRoommates = value;
            }
        }

        public List<string> ComplaintsToAgency
        {
            get
            {
                return complaintsToAgency;
            }
            set
            {
                complaintsToAgency = value;
            }
        }

        public List<Agency> AdminList
        {
            get
            {
                return this.adminList;
            }
            set
            {
                this.adminList = value;
            }
        }

        public List<string> Rules
        {
            get
            {
                return rules;
            }
            set
            {
                rules = value;
            }
        }

        public List<Event> EventsList
        {
            get
            {
                return eventList;
            }
            set
            {
                eventList = value;
            }
        }

        public List<Task> TaskList
        {
            get
            {
                return taskList;
            }
            set
            {
                taskList = value;
            }
        }

        public Administration()
        {
            eventList = new List<Event>();
            tenantList = new List<Tenant>();
            taskList = new List<Task>();
            tasksInHouse = new List<Task>();
            rules = new List<string>();
            adminList = new List<Agency>();
            inbox = new Dictionary<string, List<string>>();
            complaintsRoommates = new Dictionary<string, List<string>>();
            complaintsToAgency = new List<string>();
            SetAgency();
            SetTenants();
        }

        public void SetTasksInHouse(string houseNumber)
        {
            tasksInHouse = new List<Task>();
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].HouseNumber == houseNumber)
                {
                    tasksInHouse.Add(taskList[i]);
                }
            }
        }

        public void SetRules()
        {
            rules.Add("Don't leave dirty dishes in the sink");
            rules.Add("Don't smoke inside the house");
            rules.Add("Don't leave plates inside your room");
            rules.Add("Follow the task schedule");
            rules.Add("Don't make a lot of noise after 23:00");
        }

        public void SetTenants()
        {
            TenantList.Add(new Tenant { TenantName = "Daniil", TenantPassword = "student", HouseNumber = "KW2024" });
            TenantList.Add(new Tenant { TenantName = "Jakub", TenantPassword = "student", HouseNumber = "KW2024" });
            TenantList.Add(new Tenant { TenantName = "Rens", TenantPassword = "student", HouseNumber = "OB2021" });
            TenantList.Add(new Tenant { TenantName = "Rositsa", TenantPassword = "student", HouseNumber = "OB2021" });
        }

        public void SetAgency()
        {
            AdminList.Add(new Agency { AgencyUsername = "John", AgencyPassword = "admin" });
            AdminList.Add(new Agency { AgencyUsername = "Mark", AgencyPassword = "admin" });
        }

        public void SetTasks()
        {
            taskList.Add(new Task { TypeOfTask = "Taking out the rubbish", Taken = false, Status = false, HouseNumber = "KW2024" });
            taskList.Add(new Task { TypeOfTask = "Taking out the rubbish", Taken = false, Status = false, HouseNumber = "OB2021" });
            taskList.Add(new Task { TypeOfTask = "Buy house utensils", Taken = false, Status = false, HouseNumber = "OB2021" });
            taskList.Add(new Task { TypeOfTask = "Buy house utensils", Taken = false, Status = false, HouseNumber = "KW2024" });
        }

        public void AddEventToAllEvents(Event events)
        {
            EventsList.Add(events);
        }

        public void RemoveEvent(int id)
        {
            int index = GetIndexOfEvent(id);
            if (index != -1)
            {
                EventsList.RemoveAt(index);
            }
        }

        public int GetIndexOfEvent(int id)
        {
            for (int i = 0; i < EventsList.Count; i++)
            {
                if (EventsList[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string ReturnHouseNumberOfTenant(string tenantName)
        {

            for (int i = 0; i < tenantList.Count; i++)
            {
                if (tenantList[i].TenantName == tenantName)
                {
                    return tenantList[i].HouseNumber;
                }
            }
            return "";
        }

        public void AddTenant(string newTenantName, string newTenantPassword, string houseNumber)
        {
            if (newTenantName != "" && newTenantPassword != "")
            {
                TenantList.Add(new Tenant { TenantName = newTenantName, TenantPassword = newTenantPassword, HouseNumber = houseNumber });
            }
        }

        public void RemoveTenant(int index)
        {
            TenantList.RemoveAt(index);
        }

        public void AddRule(string rule)
        {
            rules.Add(rule);
        }

        public void RemoveRule(int index)
        {
            rules.RemoveAt(index);
        }

        //public void AddComplaintsRoommates(string message) 
        //{
        //    if (message != "")
        //    {
        //    //omplaintsRoommates.Add(message);
        //    }
        //}

        public void AddComplaintsToAgency(string message)
        {
            if (message != "")
            {
                complaintsToAgency.Add(message);
            }
        }
        public void SendComplainToRoomates(string complain, DateTime time, string houseNumber)
        {

            if (complain != "")
            {
                if (ComplaintsRoommates.ContainsKey(houseNumber))
                {
                    ComplaintsRoommates[houseNumber].Add($"{time} : {complain}");
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add($"{time} : {complain}");
                    ComplaintsRoommates.Add(houseNumber, list);
                }

            }
        }

        public void SendMessageToTenants(string houseNumber, string message)
        {
       
            if (Inbox.ContainsKey(houseNumber))
            {
                List<string> list = Inbox[houseNumber];
                list.Add(message);
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(message);
                Inbox.Add(houseNumber, list);
            }
        }
    }
}
