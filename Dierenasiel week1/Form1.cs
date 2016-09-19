using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenasiel_week1
{
    public partial class Form1 : Form
    {
        private Shelter s = new Shelter();
        public Form1()
        {
            InitializeComponent();
            loadAnimals();
        }

        private void btnNewAnimal_Click(object sender, EventArgs e)
        {
            if (rbDog.Checked == true)
            {
                Dog d = new Dog(tbNaam.Text, Convert.ToInt32(tbBirthYear.Text), tbRace.Text, false);
                s.animals.Add(d);
            }

            if (rbCat.Checked == true)
            {
                Cat c = new Cat(tbBehaviour.Text, tbNaam.Text, Convert.ToInt32(tbBirthYear.Text), tbRace.Text, false);
                s.animals.Add(c);
            }

            else
            {
                MessageBox.Show("Er moet een hond of kat gekozen worden");
            }

            loadAnimals();
        }

        public void loadAnimals()
        {
            listBox1.Items.Clear();
            foreach (Animal a in s.animals)
            {
                if (a is Cat)
                {
                    listBox1.Items.Add(a as Cat);
                }

                if (a is Dog)
                {
                    listBox1.Items.Add(a as Dog);
                }
            }
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is Dog)
            {
                Dog g = listBox1.SelectedItem as Dog;

                g.Walk();
                loadAnimals();
            }

            else
            {
                MessageBox.Show("Alleen honden kunnen uitgelaten worden");
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Dog)
            {
                Dog g = listBox1.SelectedItem as Dog;

                g.Reserve();
            }
            if (listBox1.SelectedItem is Cat)
            {
                Cat c = listBox1.SelectedItem as Cat;

                c.Reserve();
            }

            loadAnimals();
        }
    }
}
