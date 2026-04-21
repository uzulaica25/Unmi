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
        private void FInbentarioa_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisInb.Clear();
            LisInp.Clear();
            LisOrd.Clear();
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
            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                Aktibatu(0);
            }
            else
            {
                string Id = " ", Marka, Kokalekua, Cpu, Ram;
                bool Koloretakoa;
                int erantzuna;
                DateOnly ers;
                Mintegiak mintegia;
                Gailuak g;

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
                }

                erantzuna = InbentarioaDB.GailuaGehitu(g);
                if (erantzuna == 1)
                {
                    MessageBox.Show("Gailua gehitu da.");
                    cbGehitu.Text = "Gehitu";
                    Aktibatu(10);
                    FInbentarioa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errorea gailua gehitzean.");
                }
            }
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
                }
                gz = LisInb[cmbId.SelectedIndex];
                erantzuna = InbentarioaDB.GailuaAldatu(gz, g);
                if (erantzuna == 1)
                {
                    MessageBox.Show("Gailua aldatu da.");
                    cbAldatu.Text = "Aldatu";
                    Aktibatu(10);
                    FInbentarioa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errorea gailua aldatzean.");
                }
            }
            else
            {
                Aktibatu(0);
                
                cbAldatu.Text = "Gorde";
            }
        }
        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            Gailuak gz;

            if (cbEzabatu.Text == "Gorde")
            {
                gz = LisInb[cmbId.SelectedIndex];
                erantzuna = InbentarioaDB.GailuaEzabatu(gz);
                if (erantzuna == 1)
                {
                    erantzuna = InbentarioaDB.EzabatutakoGAiluak(gz);
                    if(erantzuna == 1)
                    {
                        MessageBox.Show("Gailua eta lotutako datuak ezabatu dira.");
                    }
                    else
                    {
                        MessageBox.Show("Gailua ezabatu da, baina errorea egon da lotutako datuak ezabatzean.");
                    }
                    MessageBox.Show("Gailua ezabatu da.");
                    cbEzabatu.Text = "Aldatu";
                    Aktibatu(10);
                    FInbentarioa_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errorea gailua ezabatzean.");
                }
            }
            else
            {
                Aktibatu(0);

                cbEzabatu.Text = "Gorde";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Desaktibatu()
        {
            // Formularioko elementuak ezkutatzen ditu.

            dgvInprimagailua.Visible = false;
            dgvOrdenagailua.Visible = false;
            cbGehitu.Visible = false;
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            cbIrten.Visible = true;
            lblId.Visible = false;
            cmbId.Visible = false;
            lblMarka.Visible = false;
            txtMarka.Visible = false;
            lblKokalekua.Visible = false;
            txtKokalekua.Visible = false;
            lblMintegia.Visible = false;
            cmbMintegia.Visible = false;
            lblErosteData.Visible = false;
            dtpErosteData.Visible = false;
            lblKoloretakoa.Visible = false;
            chbBai.Visible = false;
            lblCpu.Visible = false;
            txtCpu.Visible = false;
            lblRam.Visible = false;
            txtRam.Visible = false;
            lblGailuMota.Visible = false;
            cmbGailuMota.Visible = false;
        }
        private void Aktibatu(int z1)
        {
            List<Mintegiak> LisMin = new List<Mintegiak>();

            LisMin = MintegiaDB.MintegiakListaratu();
            // z1 0=Gailu mota, 1=Gehitu, 2=Aldatu, 3=Ezabatu, 4=Ordenagailua, 5=Inprimagailua, 10=Gehitu/Aldatu amaitu
            if (z1 == 0)
            {
                Desaktibatu();
                cmbGailuMota.Focus();
                lblGailuMota.Visible = true;
                cmbGailuMota.Visible = true;
                cmbGailuMota.Text = "";
            }
            else if (z1 == 1)
            {
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
                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena";
                cmbId.Enabled = false;
                cbGehitu.Visible = true;
                cbGehitu.Enabled = false;
                txtMarka.Focus();
            }
            else if (z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Enabled = false;
                lblKokalekua.Visible = true;
                txtKokalekua.Visible = true;
                txtKokalekua.Enabled = false;
                lblErosteData.Visible = true;
                dtpErosteData.Visible = true;
                dtpErosteData.Enabled = false;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                cmbMintegia.Enabled = false;
                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena";

                if (z1 == 2)
                {
                    cbAldatu.Visible = true;
                }
                else
                {
                    cbEzabatu.Visible = true;
                }
                cmbId.Focus();
            }
            else if (z1 == 4)
            {
                lblCpu.Visible = true;
                txtCpu.Visible = true;
                txtCpu.Enabled = false;
                lblRam.Visible = true;
                txtRam.Visible = true;
                txtRam.Enabled = false;
            }
            else if (z1 == 5)
            {
                lblKoloretakoa.Visible = true;
                chbBai.Visible = true;
                chbBai.Enabled = false;
            }
            else if (z1 == 10)
            {
                Desaktibatu();
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvInprimagailua.Visible = true;
                dgvOrdenagailua.Visible = true;
            }
        }
        private void cmbGailuMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desaktibatu();
            if (cmbGailuMota.Text == "Ordenagailua")
            {
                Aktibatu(4);
            }
            else if (cmbGailuMota.Text == "Inprimagailua")
            {
                Aktibatu(5);
            }
            if(cbGehitu.Text == "Gorde")
            {
                Aktibatu(1);
            }else
            {
                if (cmbGailuMota.Text == "Ordenagailua")
                {
                    cmbId.DataSource = null;
                    cmbId.Items.Clear();
                    cmbId.DataSource = this.LisOrd;
                    cmbId.DisplayMember = "Id";
                    cmbId.ValueMember = "Id";
                }
                else if (cmbGailuMota.Text == "Inprimagailua")
                {
                    cmbId.DataSource = null;
                    cmbId.Items.Clear();
                    cmbId.DataSource = this.LisInp;
                    cmbId.DisplayMember = "Id";
                    cmbId.ValueMember = "Id";
                }
                if (cbAldatu.Text == "Gorde")
                {
                    Aktibatu(2);
                }
                else if(cbEzabatu.Text == "Gorde")
                {
                    Aktibatu(3);
                }   
            }            
        }
        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            string id;
            if(cmbId.SelectedValue == null)
            {
                return;
            }
            else
            {
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
        private void cmbId_Leave(object sender, EventArgs e)
        {
            if(cbAldatu.Text == "Gorde")
            {
                cmbId.Enabled = false;
                txtMarka.Enabled = true;
                txtKokalekua.Enabled = true;
                cmbMintegia.Enabled = true;
                dtpErosteData.Enabled = true;
                txtCpu.Enabled = true;
                txtRam.Enabled = true;
                chbBai.Enabled = true;
            }
            else
            {
                cbEzabatu.Enabled = true;
                cbEzabatu.Focus();
            }
        }
        private void txtMarka_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                txtMarka.Enabled = false;
                txtKokalekua.Enabled = true;
                txtKokalekua.Focus();
            }
            else
            {
                txtMarka.Focus();
            }
        }
        private void txtKokalekua_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKokalekua.Text))
            {
                txtKokalekua.Enabled = false;
                cmbMintegia.Enabled = true;
                cmbMintegia.Focus();
            }
            else
            {
                txtKokalekua.Focus();
            }
        }
        private void cmbMintegia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbMintegia.Text))
            {
                dtpErosteData.Enabled = true;
                cmbMintegia.Enabled = false;
                dtpErosteData.Focus();
            }
            else
            {
                cmbMintegia.Focus();
            }
        }
        private void dtpErosteData_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dtpErosteData.Text))
            {
                dtpErosteData.Enabled = false;
                if (cmbGailuMota.Text == "Ordenagailua")
                {
                    txtCpu.Enabled = true;
                    txtCpu.Focus();
                }
                else
                {
                    chbBai.Enabled = true;
                    chbBai.Focus();
                }
            }
            else
            {
                dtpErosteData.Focus();
            }
        }
        private void txtCpu_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCpu.Text))
            {
                txtCpu.Enabled = false;
                txtRam.Enabled = true;
                txtRam.Focus();
            }
            else
            {
                txtCpu.Focus();
            }
        }
        private void chbBai_Leave(object sender, EventArgs e)
        {
            cbGehitu.Enabled = true;
            cbAldatu.Enabled = true;
        }
        private void txtRam_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRam.Text))
            {
                txtRam.Enabled = false;
                cbAldatu.Enabled= true;
                cbGehitu.Enabled= true;
            }
        }
    }
}
