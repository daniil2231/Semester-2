using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalDemoInClassWithAbstract
{
    public partial class Form1 : Form
    {
        AnimalAdministration animalAdministration;

        public Form1()
        {
            InitializeComponent();
            animalAdministration = new AnimalAdministration();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            lbAnimals.Items.Clear();

            if (tbAnimalName.Text != string.Empty)
            {
                if (cbAnimalType.Text == "Duck")
                {
                    animalAdministration.AddAnimal(new Duck(tbAnimalName.Text));
                }
                else if (cbAnimalType.Text == "Cat")
                {
                    animalAdministration.AddAnimal(new Cat(tbAnimalName.Text));
                }
                else if (cbAnimalType.Text == "Dog")
                {
                    animalAdministration.AddAnimal(new Dog(tbAnimalName.Text));
                }
            }

            foreach (Animal animal in animalAdministration.GetAnimals())
            {
                lbAnimals.Items.Add(animal);
            }
        }

        private void btnMakeAnimalSpeak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animalAdministration.GetAnimals()[lbAnimals.SelectedIndex].Speak());
        }
    }
}
