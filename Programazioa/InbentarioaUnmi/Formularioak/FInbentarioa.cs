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
            DatuakKargatu();
        }

        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            Gailuak g;

            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                Aktibatu(0);
                return;
            }

            g = GailuaSortu();

            if (InbentarioaDB.GailuaGehitu(g) == 1)
            {
                MessageBox.Show("Gailua gehitu da.");
                cbGehitu.Text = "Gehitu";
                Aktibatu(10);
            }
            else
            {
                MessageBox.Show("Errorea gailua gehitzean.");
            }
        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {
            string Id;
            int eran;
            Gailuak gberria = null, gz = null;
            if (cbAldatu.Text == "Aldatu")
            {
                cbAldatu.Text = "Gorde";
                Aktibatu(0);
                return;
            }

            gberria = GailuaSortu();
            Id = cmbId.Text;

            foreach (var g in LisInb)
            {
                if (g.Id == Id)
                {
                    gz = g;
                    break;
                }
            }

            eran = InbentarioaDB.GailuaAldatu(gz, gberria);

            if (eran == 1)
            {
                MessageBox.Show("Gailua aldatu da.");
                cbAldatu.Text = "Aldatu";
                Aktibatu(10);
            }
            else
            {
                MessageBox.Show("Errorea gailua aldatzean.");
            }
        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            string id;
            int erantzuna;
            Gailuak gz = null;

            if (cbEzabatu.Text == "Ezabatu")
            {
                cbEzabatu.Text = "Bai";
                Aktibatu(0);
                return;
            }

            id = cmbId.Text;
            foreach (var g in LisInb)
            {
                if (g.Id == id)
                {
                    gz = g;
                    break;
                }
            }

            DialogResult result = MessageBox.Show("Ziur zaude gailu hau ezabatu nahi duzula? Gailuarekin batera intzidentziak ezabatuko dira.", "Berretsi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                erantzuna = InbentarioaDB.GailuaEzabatu(gz);
                if (erantzuna == 1)
                {
                    erantzuna = InbentarioaDB.EzabatutakoGAiluak(gz);
                    if (erantzuna == 1)
                    {
                        MessageBox.Show("Gailua eta lotutako datuak ezabatu dira.");

                    }
                    else
                    {
                        MessageBox.Show("Ezin izan dira gailua ez gailuari lotutako datuak ezabatu.");
                    }
                }
                else
                {
                    MessageBox.Show("Errorea gailua ezabatzean.");
                }
            }
            cbEzabatu.Text = "Ezabatu";
            Aktibatu(10);
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
                cmbGailuMota.SelectedIndex = -1;
            }
            else if (z1 == 1 || z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = true;
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Enabled = true;
                txtMarka.Text = "";
                lblKokalekua.Visible = true;
                txtKokalekua.Visible = true;
                txtKokalekua.Enabled = true;
                txtKokalekua.Text = "";
                lblErosteData.Visible = true;
                dtpErosteData.Visible = true;
                dtpErosteData.Enabled = true;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                cmbMintegia.Enabled = true;
                cmbMintegia.DataSource = LisMin;
                cmbMintegia.DisplayMember = "Izena";
                cmbMintegia.SelectedIndex = -1;

                if (z1 == 2)
                {
                    cmbId.Focus();
                    cbAldatu.Visible = true;
                }
                else if (z1 == 3)
                {
                    txtMarka.Enabled = false;
                    txtKokalekua.Enabled = false;
                    dtpErosteData.Enabled = false;
                    cmbMintegia.Enabled = false;
                    txtCpu.Enabled = false;
                    txtRam.Enabled = false;
                    chbBai.Enabled = false;
                    cmbId.Focus();
                    cbEzabatu.Visible = true;
                }
                else
                {
                    cmbId.Enabled = false;
                    cbGehitu.Visible = true;
                    cbGehitu.Enabled = false;
                    txtMarka.Focus();
                }
            }
            else if (z1 == 4)
            {
                Desaktibatu();
                lblCpu.Visible = true;
                txtCpu.Visible = true;
                txtCpu.Text = "";
                lblRam.Visible = true;
                txtRam.Visible = true;
                txtRam.Text = "";
            }
            else if (z1 == 5)
            {
                Desaktibatu();
                lblKoloretakoa.Visible = true;
                chbBai.Visible = true;
                chbBai.Enabled = true;
            }
            else if (z1 == 10)
            {
                Desaktibatu();
                DatuakKargatu();
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvInprimagailua.Visible = true;
                dgvOrdenagailua.Visible = true;
            }
        }

        private void cmbGailuMota_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGailuMota.Text == "Ordenagailua")
            {
                Aktibatu(4);
            }
            else if (cmbGailuMota.Text == "Inprimagailua")
            {
                Aktibatu(5);
            }

            IdakKargatu();

            if (cbAldatu.Text == "Gorde")
            {
                Aktibatu(2);
            }
            else if (cbEzabatu.Text == "Bai")
            {
                Aktibatu(3);
            }
            else if(cbGehitu.Text == "Gorde")
            {
                Aktibatu(1);
            }
        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            string id;
            if (cmbId.SelectedValue == null)
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
            if (cbAldatu.Text == "Gorde")
            {
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
                cbAldatu.Enabled = true;
                cbGehitu.Enabled = true;
            }
        }

        private void DatuakKargatu()
        {
            LisInb = InbentarioaDB.GailuakListaratu(era);

            LisOrd.Clear();
            LisInp.Clear();

            foreach (var g in LisInb)
            {
                if (g is Ordenagailuak o) LisOrd.Add(o);
                else if (g is Inprimagailuak i) LisInp.Add(i);
            }

            dgvOrdenagailua.DataSource = null;
            dgvInprimagailua.DataSource = null;

            dgvOrdenagailua.DataSource = LisOrd;
            dgvInprimagailua.DataSource = LisInp;

            dgvInprimagailua.ReadOnly = true;
            dgvOrdenagailua.ReadOnly = true;
        }

        private Gailuak GailuaSortu()
        {
            string id, marka, kokalekua;
            Mintegiak mintegia;
            DateOnly data;

            id = cmbId.Text;
            marka = txtMarka.Text;
            kokalekua = txtKokalekua.Text;
            mintegia = (Mintegiak)cmbMintegia.SelectedItem;
            data = DateOnly.FromDateTime(dtpErosteData.Value);

            if (cmbGailuMota.Text == "Ordenagailua")
            {
                return new Ordenagailuak(id, marka, kokalekua, data, mintegia, txtCpu.Text, txtRam.Text);
            }

            return new Inprimagailuak(id, marka, kokalekua, data, mintegia, chbBai.Checked);
        }

        private void IdakKargatu()
        {
            cmbId.DataSource = null;
            cmbId.Items.Clear();

            if (cmbGailuMota.Text == "Ordenagailua")
                cmbId.DataSource = LisOrd;
            else if (cmbGailuMota.Text == "Inprimagailua")
                cmbId.DataSource = LisInp;

            cmbId.DisplayMember = "Id";
            cmbId.ValueMember = "Id";
        }

    }
}
