using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical_MissionControl
{
    public partial class MissionControlForm : Form
    {
        Administration administration;

        public MissionControlForm()
        {
            InitializeComponent();
            administration = new Administration();
            administration.AddMission("Apollo 11", new DateTime(1969, 07, 16), new DateTime(1969, 07, 24), "CSM Columbia - LM Eagle");
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);
            administration.AddMission("Gemini 8", new DateTime(1966, 03, 16), new DateTime(1966, 03, 17), "Gemini SC8");
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);
            administration.AddMission("Expedition 30-31", new DateTime(2011, 11, 21), new DateTime(2012, 07, 01), "Soyuz TMA-03M");
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);
            administration.AddMission("Expedition 17", new DateTime(2008, 04, 08), new DateTime(2008, 10, 24), "Soyuz TMA-12");
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);
            administration.AddMission("Expedition 44", new DateTime(2015, 06, 11), new DateTime(2015, 09, 11), "Soyuz TMA 16M");
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);

            administration.AddAstronaut("Neil Armstrong", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Buzz Aldrin", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("David Scott", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Michael Collins", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Andre Kuipers", "Male", "Dutch");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Oleg Kononenko", "Male", "Russian");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Don Petitt", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Sergey Volkov", "Male", "Russian");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Kimiya Yui", "Male", "Japanese");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            administration.AddAstronaut("Kjell N. Lindgren", "Male", "American");
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);

            administration.AssignAstronautToMission("Neil Armstrong" , "Apollo 11");
            administration.AssignAstronautToMission("Neil Armstrong" , "Gemini 8");
            administration.AssignAstronautToMission("Buzz Aldrin" , "Apollo 11");
            administration.AssignAstronautToMission("David Scott" , "Gemini 8");
            administration.AssignAstronautToMission("Michael Collins" , "Apollo 11");
            administration.AssignAstronautToMission("Andre Kuipers" , "Expedition 30-31");
            administration.AssignAstronautToMission("Oleg Kononenko" , "Expedition 30-31");
            administration.AssignAstronautToMission("Oleg Kononenko" , "Expedition 17");
            administration.AssignAstronautToMission("Oleg Kononenko" , "Expedition 44");
            administration.AssignAstronautToMission("Don Petitt" , "Expedition 30-31");
            administration.AssignAstronautToMission("Sergey Volkov" , "Expedition 17");
            administration.AssignAstronautToMission("Kimiya Yui" , "Expedition 44");
            administration.AssignAstronautToMission("Kjell N. Lindgren" , "Expedition 44");
        }

        private void btAddAstronaut_Click(object sender, EventArgs e)
        {
            administration.AddAstronaut(tbAstronautName.Text, cbAstronautDetails.Text, tbAstronautNationality.Text);
            cbAstronautDetails.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
            cbAstronauts.Items.Add(administration.Astronauts.Last<Astronaut>().Name);
        }

        private void btShowAllMissions_Click(object sender, EventArgs e)
        {
            lbMissions.Items.Clear();

            foreach (Mission mission in administration.Missions)
            {
                lbMissions.Items.Add(mission.ToString());
            }
        }

        private void btAddMission_Click(object sender, EventArgs e)
        {
            administration.AddMission(tbMissionName.Text, dtpLaunchDate.Value, dtpReturnDate.Value, tbSpaceship.Text);
            cbMissions.Items.Add(administration.Missions.Last<Mission>().Name);
        }

        private void btShowAstronautDetails_Click(object sender, EventArgs e)
        {
            lbMissionHistory.Items.Clear();
            lbTravelCompanions.Items.Clear();

            foreach (Astronaut astronaut in administration.Astronauts)
            {
                if (cbAstronautDetails.Text == astronaut.Name)
                {
                    foreach (Mission mission in astronaut.MissionsOfThisAstronaut)
                    {
                        lbMissionHistory.Items.Add(mission.ToString());

                        foreach (Astronaut astronaut1 in mission.AstronautsOnThisMission)
                        {
                            lbTravelCompanions.Items.Add(astronaut1.Name);
                        }
                    }

                    tbDaysInSpace.Text = astronaut.CalculateTotalDaysInSpace().ToString();
                    tbLongestMission.Text = astronaut.CalculateLongestMission().ToString();
                }
            }
        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            administration.AssignAstronautToMission(cbAstronauts.Text, cbMissions.Text);
        }
    }
}
