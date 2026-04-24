using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    /// <summary>
    /// Inbentarioko gailu orokor bat irudikatzen duen klasea.
    /// </summary>
    public class Gailuak
    {
        // Atributuak
        private string id;
        private string marka;
        private string kokalekua;
        private DateOnly erosteData;
        private Mintegiak mintegia;

        // Get-Set
        public string Id { get => id; set => id = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Kokalekua { get => kokalekua; set => kokalekua = value; }
        public DateOnly ErosteData { get => erosteData; set => erosteData = value; }
        public Mintegiak Mintegia { get => mintegia; set => mintegia = value; }
        public string MintegiaIzena => Mintegia.Izena;

        // Eraikitzailea
        /// <summary>
        /// Oinarrizko gailu bat sortzen du bere datu guztiekin.
        /// </summary>
        /// <param name="i">Gailuaren IDa</param>
        /// <param name="m">Marka</param>
        /// <param name="k">Kokalekua</param>
        /// <param name="e">Erosteko data</param>
        /// <param name="mi">Dagokion mintegia</param>
        public Gailuak(string i, string m, string k, DateOnly e, Mintegiak mi)
        {
            this.id = i;
            this.marka = m;
            this.kokalekua = k;
            this.erosteData = e;
            this.mintegia = mi;
        }
    }

    /// <summary>
    /// Ordenagailu motako gailua irudikatzen duen klasea.
    /// CPU eta RAM informazioa gehitzen du.
    /// </summary>
    public class Ordenagailuak : Gailuak
    {
        // Atributuak
        private string cpu;
        private string ram;

        // Get-Set
        public string Cpu { get => cpu; set => cpu = value; }
        public string Ram { get => ram; set => ram = value; }

        // Eraikitzailea
        /// <summary>
        /// Ordenagailu berri bat sortzen du bere hardware datuekin.
        /// </summary>
        /// <param name="i">IDa</param>
        /// <param name="m">Marka</param>
        /// <param name="k">Kokalekua</param>
        /// <param name="e">Erosteko data</param>
        /// <param name="mi">Mintegia</param>
        /// <param name="c">CPU informazioa</param>
        /// <param name="r">RAM informazioa</param>
        public Ordenagailuak(string i, string m, string k, DateOnly e, Mintegiak mi, string c, string r) : base(i, m, k, e, mi)
        {
            this.cpu = c;
            this.ram = r;
        }
    }

    /// <summary>
    /// Inprimagailu motako gailua irudikatzen duen klasea.
    /// Kolorezko inprimaketa duen ala ez adierazten du.
    /// </summary>
    public class Inprimagailuak : Gailuak
    {
        // Atributuak
        private bool koloretakoa;

        // Get-Set
        public bool Koloretakoa { get => koloretakoa; set => koloretakoa = value; }

        // Eraikitzailea
        /// <summary>
        /// Inprimagailu berri bat sortzen du kolore informazioarekin.
        /// </summary>
        /// <param name="i">IDa</param>
        /// <param name="m">Marka</param>
        /// <param name="k">Kokalekua</param>
        /// <param name="e">Erosteko data</param>
        /// <param name="mi">Mintegia</param>
        /// <param name="ko">Koloretakoa den ala ez</param>
        public Inprimagailuak(string i, string m, string k, DateOnly e, Mintegiak mi, bool ko) : base(i, m, k, e, mi)
        {
            this.koloretakoa = ko;
        }
    }
}
