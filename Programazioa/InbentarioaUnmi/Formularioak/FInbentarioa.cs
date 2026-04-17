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
            dgvOrdenagailua.DataSource = LisOrd;
            dgvInprimagailua.DataSource = LisInp;
        }

        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            string Id = " ", Marka, Kokalekua, Cpu, Ram;
            bool Koloretakoa;
            int erantzuna;
            DateOnly ers;
            Mintegiak mintegia;
            Gailuak g;

            if (cbGehitu.Text == "Gorde")
            {
                if (cmbMintegia.SelectedItem == null)
                {
                    MessageBox.Show("Mintegia aukeratu behar duzu.");
                    return;
                }

                Marka = txtMarka.Text;
                Kokalekua = txtKokalekua.Text;
                mintegia = (Mintegiak)cmbMintegia.SelectedItem;
                ers = DateOnly.FromDateTime(dtpErosteData.Value);

                if (cmbGailuMota.Text == "Ordenagailua")
                {
                    Cpu = txtCpu.Text;
                    Ram = txtRam.Text;

                    g = new Ordenagailuak(Id, Marka, Kokalekua, ers, mintegia, Cpu, Ram);
                }
                else
                {
                    Koloretakoa = chbBai.Checked;

                    g = new Inprimagailuak(Id, Marka, Kokalekua, ers, mintegia, Koloretakoa);

                    Desaktibatu(5);
                }

                erantzuna = InbentarioaDB.GailuaGehitu(g);
                if (erantzuna == 1)
                {
                    MessageBox.Show("Gailua gehitu da.");
                    cbGehitu.Text = "Gehitu";
                    Desaktibatu(5);
                }
                else
                {
                    MessageBox.Show("Errorea gailua gehitzean.");
                }
            }
            else
            {
                Desaktibatu(0);

                cbGehitu.Text = "Gorde";
            }
            FInbentarioa_Load(sender, e);
        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {
            string Id, Marka, Kokalekua, Cpu, Ram;
            bool Koloretakoa;
            int erantzuna;
            DateOnly ers;
            Mintegiak mintegia;
            Gailuak g, gz;

            if (cbAldatu.Text == "Gorde")
            {
                Id = cmbId.Text;
                Marka = txtMarka.Text;
                Kokalekua = txtKokalekua.Text;
                mintegia = (Mintegiak)cmbMintegia.SelectedItem;
                ers = DateOnly.FromDateTime(dtpErosteData.Value);

                if (cmbGailuMota.Text == "Ordenagailua")
                {
                    Cpu = txtCpu.Text;
                    Ram = txtRam.Text;

                    g = new Ordenagailuak(Id, Marka, Kokalekua, ers, mintegia, Cpu, Ram);
                }
                else
                {
                    Koloretakoa = chbBai.Checked;

                    g = new Inprimagailuak(Id, Marka, Kokalekua, ers, mintegia, Koloretakoa);

                    Desaktibatu(5);
                }
                gz = LisInb[cmbId.SelectedIndex];
                erantzuna = InbentarioaDB.GailuaAldatu(gz, g);
                if (erantzuna == 1)
                {
                    MessageBox.Show("Gailua aldatu da.");
                    cbAldatu.Text = "Aldatu";
                    Desaktibatu(5);
                    FInbentarioa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errorea gailua gehitzean.");
                }
            }
            else
            {
                Desaktibatu(0);
                if (cmbGailuMota.Text == "Ordenagailua")
                {
                    cmbId.DataSource = null;
                    cmbId.Items.Clear();
                    cmbId.DataSource = this.LisOrd;
                    cmbId.DisplayMember = "Id";
                    cmbId.ValueMember = "Id";
                }
                else
                {
                    cmbId.DataSource = null;
                    cmbId.Items.Clear();
                    cmbId.DataSource = this.LisInp;
                    cmbId.DisplayMember = "Id";
                    cmbId.ValueMember = "Id";
                }
                cbAldatu.Text = "Gorde";
            }
        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Desaktibatu(double z1)
        {
            List<Mintegiak> LisMin = new List<Mintegiak>();

            LisMin = MintegiaDB.MintegiakListaratu();

            // z1 1 = Gehitu (4 = Ordenagailua, 5 = Inprimagailua), 2 = Aldatu, 3 = Ezabatu
            if (z1 == 0)
            {
                lblGailuMota.Visible = true;
                cmbGailuMota.Visible = true;

                cbGehitu.Visible = false;
                cbAldatu.Visible = false;
                cbEzabatu.Visible = false;
                dgvInprimagailua.Visible = false;
                dgvOrdenagailua.Visible = false;
            }
            else if (z1 == 1 || z1 == 2 || z1 == 3)
            {
                lblGailuMota.Visible = false;
                cmbGailuMota.Visible = false;
                lblId.Visible = true;
                cmbId.Visible = true;
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                lblKokalekua.Visible = true;
                txtKokalekua.Visible = true;
                lblErosteData.Visible = true;
                dtpErosteData.Visible = true;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                lblKoloretakoa.Visible = true;
                chbBai.Visible = true;
                lblCpu.Visible = true;
                txtCpu.Visible = true;
                lblRam.Visible = true;
                txtRam.Visible = true;

                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena";

                if (z1 == 1)
                {
                    cbGehitu.Visible = true;
                    cbAldatu.Visible = false;
                    cbEzabatu.Visible = false;
                    cmbId.Enabled = false;
                    
                }
                else if (z1 == 2)
                {
                    cbGehitu.Visible = false;
                    cbAldatu.Visible = true;
                    cbEzabatu.Visible = false;
                }
                else
                {
                    cbGehitu.Visible = false;
                    cbAldatu.Visible = false;
                    cbEzabatu.Visible = true;
                }
            }
            else if (z1 == 4)
            {
                lblGailuMota.Visible = false;
                cmbGailuMota.Visible = false;
                lblId.Visible = true;
                cmbId.Visible = true;
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                lblKokalekua.Visible = true;
                txtKokalekua.Visible = true;
                lblErosteData.Visible = true;
                dtpErosteData.Visible = true;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                lblKoloretakoa.Visible = false;
                chbBai.Visible = false;
                chbBai.Visible = true;
                lblCpu.Visible = true;
                txtCpu.Visible = true;
                lblRam.Visible = true;
                txtRam.Visible = true;

                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena";
                
            }
            else if (z1 == 5)
            {
                lblGailuMota.Visible = false;
                cmbGailuMota.Visible = false;
                lblId.Visible = true;
                cmbId.Visible = true;
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                lblKokalekua.Visible = true;
                txtKokalekua.Visible = true;
                lblErosteData.Visible = true;
                dtpErosteData.Visible = true;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                lblKoloretakoa.Visible = true;
                chbBai.Visible = true;
                lblCpu.Visible = false;
                txtCpu.Visible = false;
                lblRam.Visible = false;
                txtRam.Visible = false;

                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena"; 
            }
            else
            {
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvInprimagailua.Visible = true;
                dgvOrdenagailua.Visible = true;

                lblId.Visible = false;
                cmbId.Visible = false;
                lblMarka.Visible = false;
                txtMarka.Visible = false;
                lblKokalekua.Visible = false;
                txtKokalekua.Visible = false;
                lblErosteData.Visible = false;
                dtpErosteData.Visible = false;
                lblMintegia.Visible = false;
                cmbMintegia.Visible = false;
                lblKoloretakoa.Visible = false;
                chbBai.Visible = false;
                lblCpu.Visible = false;
                txtCpu.Visible = false;
                lblRam.Visible = false;
                txtRam.Visible = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbGailuMota_Leave(object sender, EventArgs e)
        {

        }

        private void cmbGailuMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGailuMota.Text == "Ordenagailua")
            {
                Desaktibatu(4);
            }
            else if (cmbGailuMota.Text == "Inprimagailua")
            {
                Desaktibatu(5);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            string id;
            id = cmbId.SelectedValue.ToString();
            foreach (var g in LisInb)
            {
                if (g.Id == id)
                {
                    txtMarka.Text = g.Marka;
                    txtKokalekua.Text = g.Kokalekua;
                    dtpErosteData.Value = g.ErosteData.ToDateTime(TimeOnly.MinValue);
                    cmbMintegia.SelectedItem = g.Mintegia;
                    if (g is Ordenagailuak o)
                    {
                        txtCpu.Text = o.Cpu;
                        txtRam.Text = o.Ram;
                    }
                    else if (g is Inprimagailuak i)
                    {
                        chbBai.Checked = i.Koloretakoa;
                    }
                }
            }
        }
    }
}
