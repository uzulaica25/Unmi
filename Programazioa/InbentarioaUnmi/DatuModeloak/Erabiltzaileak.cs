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
        private string id;
        private string izena;
        private string pasahitza;
        private Mintegiak mintegia;
        private string rola;

        // Get-Set
        public string Id { get => id; set => id = value; }
        public string Izena { get => izena; set => izena = value; }
        public string Pasahitza { get => pasahitza; set => pasahitza = value; }
        public Mintegiak Mintegia { get => mintegia; set => mintegia = value; }
        public string MintegiaIzena => Mintegia?.Izena;
        public string Rola { get => rola; set => rola = value; }
        

        // Eraikitzaileak
        public Erabiltzaileak(string id, string iz, string p, Mintegiak m, string r)
        {
            this.id = id;
            this.izena = iz;
            this.pasahitza = p;
            this.mintegia = m;
            this.rola = r;
        }
        public Erabiltzaileak( string iz, string p, Mintegiak m, string r)
        {
            this.izena = iz;
            this.pasahitza = p;
            this.mintegia = m;
            this.rola = r;
        }
    }
}
