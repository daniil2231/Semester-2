using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public class Administration
    {
        List<Astronaut> astronauts = new List<Astronaut>();
        List<Mission> missions = new List<Mission>();
        
        public List<Astronaut> Astronauts
        {
            get { return this.astronauts; }
        }

        public List<Mission> Missions
        {
            get { return this.missions; }
        }

        public void AddAstronaut(string name, string gender, string nationality)
        {
            astronauts.Add(new Astronaut(name, gender, nationality));
        }

        public void AddMission(string name, DateTime launchDate, DateTime returnDate, string spaceship)
        {
            missions.Add(new Mission(name, launchDate, returnDate, spaceship));
        }

        public void AssignAstronautToMission(string astronautName, string missionName)
        {
            Astronaut astroAdd = new Astronaut();
            Mission misAdd = new Mission();

            foreach (Astronaut astro in Astronauts)
            {
                if (astronautName == astro.Name)
                {
                    astroAdd = astro;
                }
            }

            foreach (Mission mis in Missions)
            {
                if (missionName == mis.Name)
                {
                    misAdd = mis;
                }
            }

            misAdd.AstronautsOnThisMission.Add(astroAdd);
            astroAdd.MissionsOfThisAstronaut.Add(misAdd);
        }
    }
}
