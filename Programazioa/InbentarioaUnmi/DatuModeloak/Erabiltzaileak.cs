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
        private bool minBurua;
        private bool iktArduraduna;

        // Get-Set
        public string Izena { get => izena; set => izena = value; }
        public string Pasahitza { get => pasahitza; set => pasahitza = value; }
        public Mintegiak Mintegia { get => mintegia; set => mintegia = value; }
        public bool MinBurua { get => minBurua; set => minBurua = value; }
        public bool IktArduraduna { get => iktArduraduna; set => iktArduraduna = value; }

        // Eraikitzaileak
        public Erabiltzaileak(string i, string p, Mintegiak m, bool mb, bool ikt)
        {
            this.izena = i;
            this.pasahitza = p;
            this.mintegia = m;
            this.minBurua = mb;
            this.minBurua = ikt;
        }
    }
}
