using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public class Task
    {
        private string typeOfTask;
        private string assignedPerson;
        private string houseNumber;
        private bool taken;
        private bool status;

        public string TypeOfTask
        {
            get
            {
                return typeOfTask;
            }
            set
            {
                typeOfTask = value;
            }
        }

        public bool Status
        {
            get {
                return status;
            }
            set 
            {
                status = value;
            }
        }

        public bool Taken
        {
            get
            {
                return taken;
            }
            set
            {
                taken = value;
            }
        }

        public string AssignedPerson
        {
            get
            {
                return assignedPerson;
            }
            set
            {
                assignedPerson = value;
            }
        }
        
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

        //public string DateTask
        //{
        //    get
        //    {
        //        return dateTask;
        //    }
        //    set
        //    {
        //        dateTask = value;
        //    }
        //}
        
        public Task(string typeOfTask, bool taken, bool status, string houseNumber)
        {
            this.typeOfTask = typeOfTask;
            assignedPerson = string.Empty;
            this.houseNumber = houseNumber;
            this.taken = false;
            this.status = false;
        }

        public Task()
        {

        }

        public string GetInfoTask()
        {
            string ifTaken = "";
            if (taken)
            {
                ifTaken = "Taken";
            }
            else
            {
                ifTaken = "Free";
            }
            string ifDone = "";
            if (status)
            {
                ifDone = "Finished";
            }
            else
            {
                ifDone = "Unfinished";
            }
            if (taken) {
                return $"{typeOfTask} ({assignedPerson})| {ifDone} ";
            }
            else {

                return $"{typeOfTask} ({assignedPerson}) | {ifTaken}"; 
            }
        }
    }
}
