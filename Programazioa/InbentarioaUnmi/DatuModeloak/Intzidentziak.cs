using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    /// <summary>
    /// Gailuekin lotutako intzidentziak (akatsak edo gertakariak) irudikatzen dituen klasea.
    /// </summary>
    public class Intzidentziak
    {
        // Atribututak
        private string id;  
        private Gailuak gailua;
        private string gailuMota;
        private DateOnly data;
        private string mezua;

        // Get-Set
        public string Id { get => id; set => id = value; }
        public Gailuak Gailua { get => gailua; set => gailua = value; }
        public string IDGailua => Gailua?.Id;
        public DateOnly Data { get => data; set => data = value; }
        public string Mezua { get => mezua; set => mezua = value; }
        public string GailuMota { get => gailuMota; set => gailuMota = value; }

        // Eraikitzailea
        /// <summary>
        /// Intzidentzia berri bat sortzen du gailu bati lotuta.
        /// </summary>
        /// <param name="id">Intzidentziaren identifikatzailea</param>
        /// <param name="g">Eragindako gailua</param>
        /// <param name="gailuMota">Gailuaren mota (Ordenagailua edo Inprimagailua)</param>
        /// <param name="d">Intzidentziaren data</param>
        /// <param name="m">Intzidentziaren mezua</param>
        public Intzidentziak(string id, Gailuak g,string gailuMota, DateOnly d, string m)
        {
            this.id = id;
            this.gailua = g;
            this.gailuMota = gailuMota;
            this.data = d;
            this.mezua = m;
        }
    }
}
