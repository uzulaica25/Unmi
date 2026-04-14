using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    public class Erabiltzaileak
    {
        // Atributuak
        private string izena;
        private string pasahitza;
        private Mintegiak mintegia;
        private string rola;

        // Get-Set
        public string Izena { get => izena; set => izena = value; }
        public string Pasahitza { get => pasahitza; set => pasahitza = value; }
        public Mintegiak Mintegia { get => mintegia; set => mintegia = value; }
        public string Rola { get => rola; set => rola = value; }

        // Eraikitzaileak
        public Erabiltzaileak(string i, string p, Mintegiak m, string r)
        {
            this.izena = i;
            this.pasahitza = p;
            this.mintegia = m;
            this.rola = r;
        }
    }
}
