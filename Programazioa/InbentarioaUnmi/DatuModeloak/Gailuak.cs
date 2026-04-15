using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuModeloak
{
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
        public string IdMintegia => mintegia.Id;

        // Eraikitzailea
        public Gailuak(string i, string m, string k, DateOnly e, Mintegiak mi)
        {
            this.id = i;
            this.marka = m;
            this.kokalekua = k;
            this.erosteData = e;
            this.mintegia = mi;
        }
    }

    public class Ordenagailuak : Gailuak
    {
        // Atributuak
        private string cpu;
        private string ram;
        // Get-Set
        public string Cpu { get => cpu; set => cpu = value; }
        public string Ram { get => ram; set => ram = value; }
        // Eraikitzailea
        public Ordenagailuak(string i, string m, string k, DateOnly e, Mintegiak mi, string c, string r) : base(i, m, k, e, mi)
        {
            this.cpu = c;
            this.ram = r;
        }
    }
    public class Inprimagailuak : Gailuak
    {
        // Atributuak
        private bool koloretakoa;
        // Get-Set
        public bool Koloretakoa { get => koloretakoa; set => koloretakoa = value; }
        // Eraikitzailea
        public Inprimagailuak(string i, string m, string k, DateOnly e, Mintegiak mi, bool ko) : base(i, m, k, e, mi)
        {
            this.koloretakoa = ko;
        }
    }
}
