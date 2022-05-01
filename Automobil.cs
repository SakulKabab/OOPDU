using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDU
{
    class Automobil
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        protected string spz;
        public string Spz
        {
            get
            {
                return spz;
            }
            set
            {
                string s = value;
                bool chyba = false;
                if (s.Length == 8)
                {
                    for (int i = 0; i < s.Length && !chyba; ++i)
                    {
                        if (i == 3) i++;
                        if (char.IsLetterOrDigit(s[i])) { }
                        else chyba = true;
                    }
                    if (s[3] == ' ') { }
                    else chyba = true;
                }
                else chyba = true;
                if (!chyba) spz = s.ToUpper();
                else MessageBox.Show("Chybně zadaná SPZ. SPZ zadejte ve formátu 'XXX XXXX'.");
            }
        }
        protected double spotreba;
        protected int vykon;
        public Automobil() { }
        public Automobil(string znacka, string model)
        {
            Znacka = znacka;
            Model = model;
        }
        public Automobil(string znacka, string model, string spz)
        {
            Znacka = znacka;
            Model = model;
            Spz = spz;
        }
        public Automobil(string znacka, string model, string spz, double spotreba)
        {
            Znacka = znacka;
            Model = model;
            Spz = spz;
            this.spotreba = spotreba;
        }
        public Automobil(string znacka, string model, string spz, double spotreba, int vykon)
        {
            Znacka = znacka;
            Model = model;
            Spz = spz;
            this.spotreba = spotreba;
            this.vykon = vykon;
        }
        public double GetSpotreba()
        {
            return spotreba;
        }
        public void SetSpotreba(double spotreba)
        {
            this.spotreba = spotreba;
        }
        public int GetVykon()
        {
            return vykon;
        }
        public void SetVykon(int vykon)
        {
            this.vykon = vykon;
        }
        public double GetVykonHP()
        {
            return vykon*1.36;
        }
        public override string ToString()
        {
            string s = "Značka automobilu: " + Znacka
                + "\nModel: " + Model
                + "\nSPZ: " + spz
                + "\nSpotřeba (l/100 km): " + spotreba
                + "\nVýkon (kW): " + vykon
                + "\nVýkon (HP): " + GetVykonHP();
            return s;
        }
    }
}
