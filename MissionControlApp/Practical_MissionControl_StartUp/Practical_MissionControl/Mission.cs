using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public class Mission
    {
        private string name;
        private DateTime launchDate;
        private DateTime returnDate;
        private string spaceship;
        private List<Astronaut> astronautsOnThisMission;
        
        public string Name
        {
            get { return this.name; }
        }

        public List<Astronaut> AstronautsOnThisMission
        {
            get { return astronautsOnThisMission; }
        }

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceship)
        {
            this.name = name;
            this.launchDate = launchDate;
            this.returnDate = returnDate;
            this.spaceship = spaceship;
            astronautsOnThisMission = new List<Astronaut>();
        }

        public Mission()
        {

        }

        public double CalculateMissionTimeInSpace()
        {
            return returnDate.Subtract(launchDate).TotalDays;
        }

        public override string ToString()
        {
            return $"Mission name: {name}, Launch date: {launchDate}, Return date: {returnDate}, Spaceship: {spaceship}";
        }
    }
}
