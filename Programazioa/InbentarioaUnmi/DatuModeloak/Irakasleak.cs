using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    public class Irakasleak
    {
        // Atributuak
        private string izena;
        private Mintegiak mintegia;
        private bool minBurua;

        //Get-Seterrak
        public string Izena { get => izena; set => izena = value; }
        public bool MinBurua { get => minBurua; set => minBurua = value; }
        internal Mintegiak Mintegia { get => mintegia; set => mintegia = value; }

        //Eraikitzailea
        public Irakasleak(string i, Mintegiak m, bool mb)
        {
            this.izena = i;
            this.mintegia = m;
            this.minBurua = mb;
        }
    }
}
