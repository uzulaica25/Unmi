using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
    /// <summary>
    /// Sistemako erabiltzaile bat irudikatzen duen klasea.
    /// Erabiltzailearen oinarrizko datuak eta rola kudeatzen ditu.
    /// </summary>
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
        /// <summary>
        /// Erabiltzaile berri bat sortzen du bere datu guztiekin, IDarekin batera.
        /// </summary>
        /// <param name="id">Erabiltzailearen identifikatzailea</param>
        /// <param name="iz">Erabiltzailearen izena</param>
        /// <param name="p">Pasahitza</param>
        /// <param name="m">Dagokion mintegia</param>
        /// <param name="r">Erabiltzailearen rola</param>
        public Erabiltzaileak(string id, string iz, string p, Mintegiak m, string r)
        {
            this.id = id;
            this.izena = iz;
            this.pasahitza = p;
            this.mintegia = m;
            this.rola = r;
        }

        /// <summary>
        /// Erabiltzaile bat sortzen du IDrik gabe (automatikoki esleitzeko kasuetarako).
        /// </summary>
        /// <param name="iz">Erabiltzailearen izena</param>
        /// <param name="p">Pasahitza</param>
        /// <param name="m">Mintegia</param>
        /// <param name="r">Rola</param>
        public Erabiltzaileak( string iz, string p, Mintegiak m, string r)
        {
            this.izena = iz;
            this.pasahitza = p;
            this.mintegia = m;
            this.rola = r;
        }
    }
}
