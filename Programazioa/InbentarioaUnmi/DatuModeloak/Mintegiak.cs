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
        private string id;
        private string izena;

        // Get-Set
        public string Id { get => id; set => id = value; }
        public string Izena { get => izena; set => izena = value; }


        // Eraikitzailea
        public Mintegiak(string id, string i)
        {
            this.id = id;
            this.izena = i;
        }
        public Mintegiak(string i)
        {
            this.izena = i;
        }
    }
}
