using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    /// <summary>
    /// Mintegi baten oinarrizko datuak irudikatzen dituen klasea.
    /// </summary>
    public class Mintegiak
    {
        // Atributuak
        private string id;
        private string izena;

        // Get-Set
        public string Id { get => id; set => id = value; }
        public string Izena { get => izena; set => izena = value; }


        // Eraikitzailea
        /// <summary>
        /// Mintegi berri bat sortzen du ID eta izenarekin.
        /// </summary>
        /// <param name="id">Mintegiaren identifikatzailea</param>
        /// <param name="i">Mintegiaren izena</param>
        public Mintegiak(string id, string i)
        {
            this.id = id;
            this.izena = i;
        }
        /// <summary>
        /// Mintegi bat sortzen du izenarekin soilik.
        /// IDa ondoren esleitu daiteke.
        /// </summary>
        /// <param name="i">Mintegiaren izena</param>
        public Mintegiak(string i)
        {
            this.izena = i;
        }
    }
}
