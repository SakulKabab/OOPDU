using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDU
{
    class Motocykl:Automobil
    {
        private string takt;
        public Motocykl() { }
        public Motocykl(string znacka, string model, string takt) : base(znacka, model)
        {
            this.takt = takt;
        }
        public Motocykl(string znacka, string model, string spz, string takt) : base(znacka, model, spz)
        {
            this.takt = takt;
        }
        public Motocykl(string znacka, string model, string spz, double spotreba, string takt) : base(znacka, model, spz, spotreba)
        {
            this.takt = takt;
        }
        public Motocykl(string znacka, string model, string spz, double spotreba, int vykon, string takt):base(znacka, model, spz, spotreba, vykon)
        {
            this.takt = takt;
        }
        public string GetTakt()
        {
            return takt;
        }
        public void SetTakt(string takt)
        {
            this.takt = takt;
        }
        public override string ToString()
        {
            string s = "Značka motocyklu: " + Znacka
                + "\nModel: " + Model
                + "\nSPZ: " + spz
                + "\nSpotřeba (l/100 km): " + spotreba
                + "\nVýkon (kW): " + vykon
                + "\nVýkon (HP): " + GetVykonHP()
                + "\nDruh motoru: " + GetTakt();
            return s;
        }
    }
}
