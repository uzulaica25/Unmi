using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InbentarioaUnmi.Formularioak
{
    public partial class FInbentarioa : Form
    {
        // Select motak repasau informaziua erakusteko
        public List<Gailuak> LisInb = new List<Gailuak>();
        public Erabiltzaileak era;
        public FInbentarioa(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {

        }

        private void FInbentarioa_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisInb = InbentarioaDB.GailuakListaratu();
            List<Ordenagailuak> LisOrd = new List<Ordenagailuak>();
            List<Inprimagailuak> LisInp = new List<Inprimagailuak>();
            foreach(var g in LisInb)
            {
                if (g is Ordenagailuak o)
                {
                    LisOrd.Add(o);
                }
                else if (g is Inprimagailuak i)
                {
                    LisInp.Add(i);
                }
            }
            if (era.Rola == "Irakaslea")
            {
                cbGehitu.Visible = false;
                cbAldatu.Visible = false;
                cbEzabatu.Visible = false;
                var filtrado1 = LisOrd.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                var filtrado2 = LisInp.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvOrdenagailua.DataSource = filtrado1;
                dgvInprimagailua.DataSource = filtrado2;

            }
            else if (era.Rola == "MintegiBurua")
            {
                var filtrado1 = LisOrd.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                var filtrado2 = LisInp.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvOrdenagailua.DataSource = filtrado1;
                dgvInprimagailua.DataSource = filtrado2;

            }
            else
            {
                dgvOrdenagailua.DataSource = LisOrd;
                dgvInprimagailua.DataSource = LisInp;
            }
        }

        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {

        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {

        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {

        }
    }
}
