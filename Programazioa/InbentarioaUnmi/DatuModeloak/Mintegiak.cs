using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    public class Mintegiak
    {
        // Atributuak
        private string izena;

        // Get-Set
        public string Izena { get => izena; set => izena = value; }

        // Eraikitzailea
        public Mintegiak(string i)
        {
            this.izena = i;
        }
    }
}
