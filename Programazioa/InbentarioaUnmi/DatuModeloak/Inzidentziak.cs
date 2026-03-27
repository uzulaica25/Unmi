using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    public class Inzidentziak
    {
        // Atribututak
        private Gailuak gailua;
        private DateOnly data;
        private string mezua;

        // Get-Set
        public Gailuak Gailua { get => gailua; set => gailua = value; }
        public DateOnly Data { get => data; set => data = value; }
        public string Mezua { get => mezua; set => mezua = value; }

        // Eraikitzaileak
        public Inzidentziak(Gailuak g, DateOnly d, string m)
        {
            this.gailua = g;
            this.data = d;
            this.mezua = m;
        }
    }
}
