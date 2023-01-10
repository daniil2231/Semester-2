using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public class Astronaut
    {
        private string name;
        private string gender;
        private string nationality;
        private List<Mission> missionsOfThisAstronaut;
       
        public string Name
        {
            get { return name; }
        }

        public List<Mission> MissionsOfThisAstronaut
        {
            get { return missionsOfThisAstronaut; }
        }

        public Astronaut(string name, string gender, string nationality)
        {
            this.name = name;
            this.gender = gender;
            this.nationality = nationality;
            missionsOfThisAstronaut = new List<Mission>();
        }

        public Astronaut()
        {

        }

        public double CalculateTotalDaysInSpace()
        {
            double daysInSpace = 0;

            foreach (Mission mission in missionsOfThisAstronaut)
            {
                daysInSpace += mission.CalculateMissionTimeInSpace();
            }

            return daysInSpace;
        }

        public double CalculateLongestMission()
        {
            double daysInSpace = double.MinValue;

            foreach (Mission mission in missionsOfThisAstronaut)
            {
                if (daysInSpace < mission.CalculateMissionTimeInSpace())
                {
                    daysInSpace = mission.CalculateMissionTimeInSpace();
                }
            }

            return daysInSpace;
        }
    }
}
