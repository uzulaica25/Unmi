using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InbentarioaUnmi.Formularioak
{
    /// <summary>
    /// Erabiltzaileen kudeaketarako erabiltzen den Windows Form-a.
    /// CRUD eragiketak (sortu, aldatu, ezabatu eta bistaratzea) kudeatzen ditu.
    /// </summary>
    public partial class FErabiltzailea : Form
    {
        public List<Erabiltzaileak> LisEra = new List<Erabiltzaileak>();
        public Erabiltzaileak era;
        /// <summary>
        /// FErabiltzailea formularioa hasieratzen du eta uneko erabiltzailea ezartzen du.
        /// </summary>
        /// <param name="era">Saioa hasi duen erabiltzailea</param>
        public FErabiltzailea(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Formularioa kargatzean hasierako datuak eta ikuspegia prestatzen ditu.
        /// Erabiltzaileen zerrenda kargatu eta rolearen arabera iragazten du.
        /// </summary>
        private void FErabiltzailea_Load(object sender, EventArgs e)
        {
            Aktibatu(10);
            cbGehitu.Focus();
            LisEra.Clear();
            LisEra = ErabiltzaileaDB.ErabiltzaileaZerrendatu();
            dgvErabiltzaileak.DataSource = null;
            if (era.Rola == "MintegiBurua")
            {
                var filtrado = LisEra.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvErabiltzaileak.DataSource = filtrado;

            }
            else
            {
                dgvErabiltzaileak.DataSource = LisEra;
            }
            dgvErabiltzaileak.ReadOnly = true;
        }
        /// <summary>
        /// Erabiltzaile berria gehitzeko prozesua kudeatzen du.
        /// Sarrera datuak balidatu eta datu-basean gordetzen ditu.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cbGehitu_Click(object sender, EventArgs e)
        {
            int eragiketa;
            string Eizena, pas, rola = " ", min;
            Erabiltzaileak er;
            Mintegiak mintegia;

            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                Aktibatu(1);
            }
            else
            {
                Eizena = txtErabiltzailea.Text;
                pas = txtPasahitza.Text;
                rola = cmbRola.Text;
                min = cmbMintegia.Text;
                mintegia = MintegiaDB.MintegiaBilatu(min);
                er = new Erabiltzaileak(Eizena, pas, mintegia, rola);
                eragiketa = ErabiltzaileaDB.ErabiltzaileaGehitu(er);
                if (eragiketa == 1)
                {
                    MessageBox.Show(Eizena + " erabiltzailea gehitu da.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erabiltzailea ez da gehitu. Mesedez, saiatu berriro.");
                    cbGehitu_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// Aukeratutako erabiltzailearen datuak eguneratzen ditu.
        /// Rolaren eta mintegiaren arabera balidazio gehigarriak aplikatzen ditu.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cbAldatu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            Erabiltzaileak er;
            Mintegiak mintegia;
            string Id, pas, erab, rola, min;

            if (cbAldatu.Text == "Aldatu")
            {
                cbAldatu.Text = "Gorde";
                Aktibatu(2);
            }
            else
            {
                Id = cmbId.Text;
                erab = txtErabiltzailea.Text;
                pas = txtPasahitza.Text;
                rola = cmbRola.Text;
                min = cmbMintegia.Text;
                mintegia = MintegiaDB.MintegiaBilatu(min);
                if (rola == "MintegiBurua")
                {
                    foreach (var usu in LisEra)
                    {
                        if (usu.Rola == rola && usu.Mintegia.Izena == min)
                        {
                            MessageBox.Show("Mintegi horrek jada badu mintegi burua");
                            return;
                        }
                    }
                }
                er = new Erabiltzaileak(Id, erab, pas, mintegia, rola);
                erantzuna = ErabiltzaileaDB.ErabiltzaileaAldatu(er);
                if (erantzuna == 1)
                {
                    MessageBox.Show(er.Izena + " erabiltzailearen datuak aldatu dira.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erabiltzailea ez da aldatu. Mesedez, saiatu berriro.");
                    cbAldatu_Click(sender, e);
                }
                cbAldatu.Text = "Aldatu";
            }
        }
        /// <summary>
        /// Aukeratutako erabiltzailea datu-basetik ezabatzen du.
        /// Segurtasun balidazioak aplikatzen ditu (bere burua edo rol kritikoak ez ezabatzeko).
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            string Eid;
            Erabiltzaileak er = null;
            if (cbEzabatu.Text == "Ezabatu")
            {
                cbEzabatu.Text = "Bai";
                Aktibatu(3);
            }
            else
            {
                Eid = cmbId.Text;
                if (Eid == era.Id)
                {
                    MessageBox.Show("Ezin duzu zure erabiltzailea ezabatu. Mesedez, sartu beste ID bat.");
                    cmbId.Focus();
                    return;
                }
                else if (cmbRola.Text == "IKTArduraduna")
                {
                    MessageBox.Show("Ezin duzu IKT arduradun bat ezabatu. Mesedez, sartu beste ID bat.");
                    cmbId.Focus();
                    return;
                }
                else
                {

                    foreach (var item in LisEra)
                    {
                        if (item.Id == Eid)
                        {
                            er = item;
                            break;
                        }
                    }
                    erantzuna = ErabiltzaileaDB.ErabiltzaileaEzabatu(er);
                    if (erantzuna == 1)
                    {
                        MessageBox.Show("Erabiltzailea ezabatu da.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erabiltzailea ez da ezabatu. Mesedez, saiatu berriro.");
                        cbEzabatu_Click(sender, e);
                    }
                }
            }
        }
        /// <summary>
        /// Formularioaren elementuen ikusgarritasuna eta egoera kudeatzen ditu.
        /// </summary>
        private void Desaktibatu()
        {
            // Formularioko elementuak ezkutatzen ditu.

            dgvErabiltzaileak.Visible = false;
            cbGehitu.Visible = false;
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            cbIrten.Visible = true;
            lblId.Visible = false;
            cmbId.Visible = false;
            lblErabiltzailea.Visible = false;
            txtErabiltzailea.Visible = false;
            lblPasahitza.Visible = false;
            txtPasahitza.Visible = false;
            lblRola.Visible = false;
            cmbRola.Visible = false;
            cmbMintegia.Visible = false;
            lblMintegia.Visible = false;
        }
        /// <summary>
        /// Formularioaren elementuen ikusgarritasuna eta egoera kudeatzen ditu.
        /// Eragiketa motaren arabera (gehitu, aldatu, ezabatu) interfazea egokitzen du.
        /// </summary>
        private void Aktibatu(int z1)
        {
            Desaktibatu();
            // z1 1=Gehitu, 2=Aldatu, 3=Ezabatu, 10=Hasiera panela
            if (z1 == 1 || z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = true;
                if (era.Rola == "MintegiBurua")
                {
                    cmbRola.Text = "Irakaslea";
                    cmbMintegia.Text = era.Mintegia.Izena;
                    var MintEra = LisEra.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                    cmbId.DataSource = MintEra;
                }
                else
                {
                    cmbId.DataSource = LisEra;
                    cmbRola.SelectedIndex = -1;
                    MintegiakKargatu();
                }
                cmbId.DisplayMember = "Id";
                cmbId.ValueMember = "Id";
                cmbId.SelectedIndex = -1;
                lblErabiltzailea.Visible = true;
                txtErabiltzailea.Visible = true;
                txtErabiltzailea.Enabled = false;
                txtErabiltzailea.Text = "";
                lblPasahitza.Visible = true;
                txtPasahitza.Visible = true;
                txtPasahitza.Enabled = false;
                txtPasahitza.Text = "";
                lblRola.Visible = true;
                cmbRola.Visible = true;
                cmbRola.Enabled = false;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                cmbMintegia.Enabled = false;


                if (z1 == 2)
                {
                    cbAldatu.Visible = true;
                    cmbId.Focus();
                }
                else if (z1 == 3)
                {
                    cbEzabatu.Visible = true;
                    cmbId.Focus();
                }
                else
                {
                    txtErabiltzailea.Enabled = true;
                    txtPasahitza.Enabled = true;
                    if (era.Rola == "IKTArduraduna")
                    {
                        cmbRola.Enabled = true;
                        cmbMintegia.Enabled = true;
                    }
                    cmbId.Enabled = false;
                    cbGehitu.Visible = true;
                    cbGehitu.Enabled = false;
                }
            }
            else if (z1 == 10)
            {
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvErabiltzaileak.Visible = true;
            }
        }
        /// <summary>
        /// Aukeratutako erabiltzailearen datuak interfazean kargatzen ditu.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;

            id = cmbId.Text;
            foreach (var item in LisEra)
            {
                if (item.Id == id)
                {
                    if (era.Rola == "MintegiBurua" && item.Rola == "IKTArduraduna")
                    {
                        txtPasahitza.Enabled = false;
                    }
                    else
                    {
                        txtPasahitza.Enabled = true;
                    }
                        txtErabiltzailea.Text = item.Izena;
                    txtPasahitza.Text = item.Pasahitza;
                    if (era.Rola == "MintegiBurua")
                    {
                        cmbMintegia.Text = era.Mintegia.Izena;
                        cmbRola.Text = item.Rola;
                    }
                    else
                    {
                        cmbMintegia.Text = item.Mintegia.Izena;
                        cmbRola.Text = item.Rola;
                    }
                    break;
                }
            }
        }
        /// <summary>
        /// Erabiltzaile izenaren balidazioa egiten du.
        /// Izen bikoiztuak saihesten ditu.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void txtErabiltzailea_Leave(object sender, EventArgs e)
        {
            string t;
            bool txi = false;
            if (!string.IsNullOrWhiteSpace(txtErabiltzailea.Text) && cbGehitu.Text == "Gorde")
            {
                t = txtErabiltzailea.Text;
                foreach (var item in LisEra)
                {
                    if (item.Izena == t)
                    {
                        MessageBox.Show("Erabiltzaile izen hori dagoeneko existitzen da. Mesedez, sartu beste bat.");
                        txtErabiltzailea.Text = "";
                        txtErabiltzailea.Focus();
                        txi = true;
                        break;
                    }
                }
                if (txi)
                {
                    txtErabiltzailea.Focus();
                }
                else
                {
                    txtPasahitza.Enabled = true;
                    txtPasahitza.Focus();
                }
            }
        }
        /// <summary>
        /// Pasahitzaren luzera eta segurtasuna balidatzen ditu.
        /// Gutxienez 8 karaktere behar ditu.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void txtPasahitza_Leave(object sender, EventArgs e)
        {
            string t;
            if (!string.IsNullOrWhiteSpace(txtPasahitza.Text))
            {
                t = txtPasahitza.Text;
                if (t.Length < 8)
                {
                    MessageBox.Show("Pasahitzak gutxienez 8 karaktere izan behar ditu. Mesedez, sartu beste bat.");
                    txtPasahitza.Text = "";
                    txtPasahitza.Focus();
                }
                else
                {
                    if (era.Rola == "IKTArduraduna")
                    {
                        cmbRola.Enabled = true;
                        cmbRola.Focus();
                    }
                    else
                    {
                        cbGehitu.Focus();
                        cbGehitu.Enabled = true;
                    }

                }
            }
        }
        /// <summary>
        /// Erabiltzailearen rola aukeratzean, hurrengo eremua (mintegia) aktibatzen du.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cmbRola_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRola.Text))
            {
                cmbMintegia.Enabled = true;
                cmbMintegia.Focus();
            }
        }
        /// <summary>
        /// Mintegia aukeratzean, gehitu botoia aktibatzen du eta fokua bertara pasatzen du.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cmbMintegia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbMintegia.Text))
            {
                cbGehitu.Enabled = true;
                cbGehitu.Focus();
            }
        }
        /// <summary>
        /// Erabiltzaile ID bat aukeratzean, formularioaren eremuak egokitzen ditu
        /// aldaketa edo ezabaketa moduan lan egiteko.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Ekitaldiaren datuak</param>
        private void cmbId_Leave(object sender, EventArgs e)
        {
            cmbId.Enabled = false;
            if (cbAldatu.Text == "Gorde")
            {
                txtErabiltzailea.Enabled = true;
                if (era.Rola == "IKTArduraduna")
                {
                    txtPasahitza.Enabled = true;
                    cmbRola.Enabled = true;
                    cmbMintegia.Enabled = true;
                }
                txtErabiltzailea.Focus();
            }
            else
            {
                cbEzabatu.Focus();
            }
        }
        /// <summary>
        /// Mintegi zerrenda datu-basetik kargatzen du eta ComboBox-ean erakusten du.
        /// </summary>
        /// <remarks>
        /// Mintegiak datu-iturritik eskuratu eta interfazean aukeraketa gisa bistaratzen ditu.
        /// </remarks>
        private void MintegiakKargatu()
        {
            var lisMin = MintegiaDB.MintegiakListaratu();
            cmbMintegia.DataSource = lisMin;
            cmbMintegia.DisplayMember = "Izena";
            cmbMintegia.ValueMember = "Id";
            cmbMintegia.SelectedIndex = -1;
        }
        /// <summary>
        /// Datu-taulan pasahitzak ezkutatzen ditu segurtasuna mantentzeko.
        /// MintegiBurua rolarentzat soilik aplikatzen da.
        /// </summary>
        /// <param name="sender">Ekitaldiaren iturburua</param>
        /// <param name="e">Formateo ekitaldiaren datuak</param>
        private void dgvErabiltzaileak_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(era.Rola == "MintegiBurua")
            {
                if (dgvErabiltzaileak.Columns[e.ColumnIndex].Name == "Pasahitza")
                {
                    if (e.Value != null)
                    {
                        e.Value = new string('*', e.Value.ToString().Length);
                    }
                }
            }
        }
    }
}
