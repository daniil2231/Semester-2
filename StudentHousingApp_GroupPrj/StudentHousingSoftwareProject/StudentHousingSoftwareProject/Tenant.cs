using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public partial class Tenant
    {
        private string tenantName;
        private string tenantPassword;
        private string houseNumber;
        private List<Task> myTasks = new List<Task>();
        private List<Event> myEvents = new List<Event>();

        public string HouseNumber
        {
            get
            {
                return this.houseNumber;
            }
            set
            {
                this.houseNumber = value;
            }
        }

        public string TenantName
        {
            get
            {
                return this.tenantName;
            }
            set
            {
                this.tenantName = value;
            }
        }

        public string TenantPassword
        {
            get
            {
                return this.tenantPassword;
            }
            set
            {
                this.tenantPassword = value;
            }
        }

        public List<Task> MyTasks
        {
            get
            {
                return this.myTasks;
            }
            set
            {
                this.myTasks = value;
            }
        }

        public List<Event> MyEvents
        {
            get
            {
                return this.myEvents;
            }
            set
            {
                this.myEvents = value;
            }
        }

        public Tenant(string name, string password, string houseNumber)
        {
            this.tenantName = name;
            this.tenantPassword = password;
            this.houseNumber = houseNumber;
            this.myEvents = new List<Event>();
        }

        public Tenant()
        {
            
        }

        public void SetMyTasks(List <Task> assignedTasks)
        {
            for (int i = 0; i < assignedTasks.Count; i++)
            {
                if (assignedTasks[i].AssignedPerson == tenantName)
                {
                    myTasks.Add(assignedTasks[i]);
                }
            }
        }

        public void AddMyTask(Task mytask) 
        {
            myTasks.Add(mytask);
        }

        public void SetMyEvents(List<Event> allEvents)
        {
            for (int i = 0; i < allEvents.Count; i++)
            {
                if (allEvents[i].Organizer == tenantName)
                { 
                    myEvents.Add(allEvents[i]);
                }
            }
        }

        public void AddMyEvent(Event newEvent)
        {
            MyEvents.Add(newEvent);
        }

        public void RemoveMyEvent(int index)
        {
            if (index != -1)
            {
                MyEvents.RemoveAt(index);
                
            }
        }
    }
}
