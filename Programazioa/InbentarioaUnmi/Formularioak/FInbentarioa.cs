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
        public List<Gailuak> LisInb = new List<Gailuak>();
        public BindingList<Inprimagailuak> LisInp = new BindingList<Inprimagailuak>();
        public BindingList<Ordenagailuak> LisOrd = new BindingList<Ordenagailuak>();
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
            if (this.txi)
            {
                cbGehitu.Focus();
                LisInb = InbentarioaDB.GailuakListaratu(era);
                foreach (var g in LisInb)
                {
                    if (g is Ordenagailuak o)
                    {
                        this.LisOrd.Add(o);
                    }
                    else if (g is Inprimagailuak i)
                    {
                        this.LisInp.Add(i);
                    }
                }
            }
            dgvOrdenagailua.DataSource = LisOrd;
            dgvInprimagailua.DataSource = LisInp;
        }

        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            Gailuak g;
            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                if (era.Rola == "IKTArduraduna")
                {
                    LisInp.Add(new Inprimagailuak(
                        "ID",
                        "Marka",
                        "Kokalekua",
                        DateOnly.FromDateTime(DateTime.Now),
                        new Mintegiak("ID", "Mintegia"),
                        true
                    ));
                }
            }
            else
            {
                cbGehitu.Text = "Gehitu";
                g = LisInp.LastOrDefault();
                InbentarioaDB.GailuaGehitu(g);
            }

        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {

        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Desaktibatu(int z1)
        {
            // z1 1 = Gehitu, 2 = Aldatu, 3 = Ezabatu
            if (z1 == 1 || z1 == 2 || z1 == 3)
            {
                dgvInprimagailua.Visible = false;
                dgvOrdenagailua.Visible = false;

                lblId.Visible = true;
                txtId.Visible = true;
                txtId.Enabled = false;

                if (z1 == 1)
                {
                    cbAldatu.Visible = false;
                    cbEzabatu.Visible = false;
                }
                else if (z1 == 2)
                {
                    cbGehitu.Visible = false;
                    cbEzabatu.Visible = false;
                }
                else
                {
                    cbGehitu.Visible = false;
                    cbAldatu.Visible = false;
                }
            }
            else
            {
                cbAldatu.Visible = false;
                cbEzabatu.Visible = false;
            }
    }
}
