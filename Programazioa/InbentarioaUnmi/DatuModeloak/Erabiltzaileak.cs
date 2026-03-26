using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    public class Erabiltzaileak
    {
        //Atributuak
        private string izena;
        private string pasahitza;
        
        //Get-Setrrak
        public string Izena { get => izena; set => izena = value; }
        public string Pasahitza { get => pasahitza; set => pasahitza = value; }

        //Eraikitzailea
        public Erabiltzaileak(string i, string p)
        {
            this.izena = i;
            this.pasahitza = p;
        }
    }
}
