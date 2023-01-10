using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemAssignment
{
    public partial class Form1 : Form
    {
        Administration administration;

        public Form1()
        {
            InitializeComponent();
            administration = new Administration();
        }

        private bool CheckIfPCNExists(int pcn)
        {
            foreach (Person person in administration.GetPersons())
            {
                if (person.Pcn == Convert.ToInt32(tbPCN.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked == true)
            {
                tbSalary.Enabled = false;
            }
            else
            {
                tbSalary.Enabled = true;
            }
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTeacher.Checked == true)
            {
                tbECs.Enabled = false;
            }
            else
            {
                tbECs.Enabled = true;
            }
        }

        private void btnStartNewSchoolyear_Click(object sender, EventArgs e)
        {
            if (tbPCNActionForm.Text != string.Empty)
            {
                int flag = -1;
                foreach (Person person in administration.GetPersons())
                {
                    if (person.Pcn == Convert.ToInt32(tbPCNActionForm.Text))
                    {
                        person.StartAnotherSchoolyear();
                        flag = 1;
                    }
                }

                if (flag == -1)
                {
                    MessageBox.Show("No person with such PCN can be found.");
                }
            }
        }

        private void btnAddToAdministration_Click(object sender, EventArgs e)
        {
            if (tbPCN.Text != string.Empty && tbName.Text != string.Empty && tbAge.Text != string.Empty && tbYearsAtSchool.Text != string.Empty)
            {
                if (CheckIfPCNExists(Convert.ToInt32(tbPCN.Text)) == false)
                {
                    if (rbStudent.Checked == true)
                    {
                        administration.AddPerson(new Student(Convert.ToInt32(tbAge.Text), tbName.Text, Convert.ToInt32(tbPCN.Text), Convert.ToInt32(tbYearsAtSchool.Text), Convert.ToInt32(tbECs.Text)));
                    }
                    else if (rbTeacher.Checked == true)
                    {
                        administration.AddPerson(new Teacher(Convert.ToInt32(tbAge.Text), tbName.Text, Convert.ToInt32(tbPCN.Text), Convert.ToInt32(tbYearsAtSchool.Text), Convert.ToDouble(tbSalary.Text), JobPosition.JUNIOR_TEACHER));
                    }
                }
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (tbPCNActionForm.Text != string.Empty)
            {
                int flag = -1;
                foreach (Teacher teacher in administration.GetPersons())
                {
                    if (teacher.Pcn == Convert.ToInt32(tbPCNActionForm.Text))
                    {
                        teacher.MakePromotion();
                        flag = 1;
                    }
                }

                if (flag == -1)
                {
                    MessageBox.Show("No teacher with such PCN can be found.");
                }
            }
        }

        private void btnAddECs_Click(object sender, EventArgs e)
        {
            if (tbAddECs.Text != string.Empty)
            {
                int flag = -1;
                foreach (Student student in administration.GetPersons())
                {
                    if (student.Pcn == Convert.ToInt32(tbPCNActionForm.Text))
                    {
                        student.AddECs(Convert.ToInt32(tbAddECs.Text));
                        flag = 1;
                    }
                }

                if (flag == -1)
                {
                    MessageBox.Show("No student with such PCN can be found.");
                }
            }
        }

        private void btnShowPersons_Click(object sender, EventArgs e)
        {
            lbShowAll.Items.Clear();

            if (cbShowPeople.Text != string.Empty)
            {
                if (cbShowPeople.Text == "All")
                {
                    foreach (Person person in administration.GetPersons())
                    {
                        lbShowAll.Items.Add(person.ToString());
                    }
                }
                else if (cbShowPeople.Text == "Students")
                {
                    foreach (Student student in administration.GetPersons())
                    {
                        lbShowAll.Items.Add(student.ToString());
                    }
                }
                else if (cbShowPeople.Text == "Teachers")
                {
                    foreach (Teacher teacher in administration.GetPersons())
                    {
                        lbShowAll.Items.Add(teacher.ToString());
                    }
                }
            }
        }

        private void btnSearchPartialName_Click(object sender, EventArgs e)
        {
            lbShowAll.Items.Clear();

            if (tbPartialName.Text != string.Empty)
            {
                foreach (Person person in administration.CheckForPartialName(tbPartialName.Text))
                {
                    lbShowAll.Items.Add(person.ToString());
                }
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbShowAll.Items.Clear();

            if (tbPCNActionForm.Text != string.Empty)
            {
                int flag = -1;
                foreach (Person person in administration.GetPersons())
                {
                    if (person.Pcn == Convert.ToInt32(tbPCNActionForm.Text))
                    {
                        lbShowAll.Items.Add(administration.GetPersonByPCN(Convert.ToInt32(tbPCNActionForm.Text)));
                        flag = 1;
                    }
                }

                if (flag == -1)
                {
                    MessageBox.Show("No person with such PCN can be found.");
                }
            }
        }

        private void btnCelebrateBirthday_Click(object sender, EventArgs e)
        {
            if (tbPCNActionForm.Text != string.Empty)
            {
                foreach (Person person in administration.GetPersons())
                {
                    if (person.Pcn == Convert.ToInt32(tbPCNActionForm.Text))
                    {
                        person.CelebrateBirthday();
                    }
                }
            }
        }
    }
}
