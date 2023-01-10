using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public class Event
    {
     
        private static int EventId { get; set; }
        public int Id { get; private set; }
        private string typeOfEvent;
        private string houseNumber;
        private string organizer;
        private string dateEvent;
        
        public Event(string typeOfEvent, string organizer, string dateEvent, string houseNumber)
        {
            this.typeOfEvent = typeOfEvent;
            this.organizer = organizer;
            this.dateEvent = dateEvent;
            Id = GetNextEventID();
            this.houseNumber = houseNumber;
        }

        public Event()
        {

        }

        private int GetNextEventID()
        {
            EventId = EventId + 1;
            return EventId;
        }

        public string TypeOfEvent
        {
            get
            {
                return typeOfEvent;
            }
            set
            {
                typeOfEvent = value;
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

        public string Organizer
        {
            get
            {
                return organizer;
            }
            set
            {
                organizer = value;
            }
        }

        public string DateEvent
        {
            get
            {
                return dateEvent;
            }
            set
            {
                dateEvent = value;
            }
        }

        public string GetInfoEvent()
        {
            return $"{this.typeOfEvent} - {this.organizer} ({this.dateEvent})";
        }
    }
}
