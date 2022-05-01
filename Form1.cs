using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string znacka = textBox1.Text, model = textBox2.Text, spz = textBox3.Text;
            double spotreba = double.Parse(textBox4.Text);
            int vykon = int.Parse(textBox5.Text);
            Automobil auto = new Automobil(znacka, model, spz, spotreba, vykon);
            MessageBox.Show(auto.ToString());
            MessageBox.Show(auto.Znacka + " " + auto.Model + "\nSPZ: " + auto.Spz + "\nSpotřeba: " + auto.GetSpotreba() + "\nVýkon: " + auto.GetVykon() + " kW - " + auto.GetVykonHP()+" HP");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string znacka = textBox6.Text, model = textBox7.Text, spz = textBox8.Text;
            double spotreba = double.Parse(textBox9.Text);
            int vykon = int.Parse(textBox10.Text);
            string takt;
            if (radioButton1.Checked) takt = "Dvoutakt";
            else takt = "Čtyřtakt";
            Motocykl moto = new Motocykl(znacka, model, spz, spotreba, vykon, takt);
            MessageBox.Show(moto.ToString());
            MessageBox.Show(moto.Znacka + " " + moto.Model + "\nSPZ: " + moto.Spz + "\nSpotřeba: " + moto.GetSpotreba() + "\nVýkon: " + moto.GetVykon() + " kW - " + moto.GetVykonHP() + " HP\nDruh motoru: " + moto.GetTakt());
        }
    }
}
