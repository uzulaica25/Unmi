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
    public partial class FMintegia : Form
    {
        public Erabiltzaileak era;
        public List<Mintegiak> LisMin = new List<Mintegiak>();
        public FMintegia(Erabiltzaileak era)
        {
            this.era = era;
            InitializeComponent();
        }
        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FMintegia_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisMin = MintegiaDB.MintegiakListaratu();
            dgvMintegiak.DataSource = LisMin;
        }
        private void cbGehitu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            string Mizena;
            Mintegiak mi;
            while (true)
            {
                Mizena = Microsoft.VisualBasic.Interaction.InputBox("Izena:", "Mintegia gehitu", "Mintegi berriaren izena");
                if (string.IsNullOrEmpty(Mizena))
                {
                    throw new Exception("Mintegiaren izena ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
                mi = new Mintegiak(Mizena);
                erantzuna = MintegiaDB.MintegiakGehitu(mi);
            if(erantzuna == 1)
            {
                MessageBox.Show(Mizena + " mintegia gehitu da.");
            }
            else
            {
                MessageBox.Show("Mintegia ez da gehitu. Mesedez, saiatu berriro.");
            }
                FMintegia_Load(sender, e);
        }
        private void cbAldatu_Click_1(object sender, EventArgs e)
        {
            int erantzuna;
            string Mid, berria;
            while (true)
            {
                Mid = Microsoft.VisualBasic.Interaction.InputBox("ID-a:", "Mintegiaren izena aldatu", "Aldatu nahi dizun mintegiaren ID-a");
                if (string.IsNullOrEmpty(Mid))
                {
                    throw new Exception("Mintegiaren ID-a ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                berria = Microsoft.VisualBasic.Interaction.InputBox("Izena:", "Mintegiaren izena aldatu", "Mintegiaren izen berria");
                if (string.IsNullOrEmpty(berria))
                {
                    throw new Exception("Mintegiaren izen berria ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            erantzuna = MintegiaDB.MintegiakAldatu(Mid, berria);
            if (erantzuna == 1)
            {
                MessageBox.Show(Mid + " mintegiaren izena eguneratu da. Orain " + berria + " da.");
            }
            else
            {
                MessageBox.Show("Mintegiaren izena ez da eguneratu. Mesedez, egiaztatu ID-a zuzena dela.");
            }
            FMintegia_Load(sender, e);
        }
        private void cbEzabatu_Click_1(object sender, EventArgs e)
        {
            int z1 = 0, erantzuna;
            string Mizena;
            Mintegiak mi;
            while (true)
            {
                Mizena = Microsoft.VisualBasic.Interaction.InputBox("ID:", "Mintegia ezabatu", "Ezabatu nahi duzun mintegiaren ID-a");
                if (string.IsNullOrEmpty(Mizena))
                {
                    throw new Exception("Mintegiaren ID-a ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            foreach (Mintegiak m in LisMin)
            {
                if (m.Id != Mizena)
                {
                    z1++;
                }
                else
                {
                    break;
                }
            }
            mi = LisMin[z1];
            erantzuna = MintegiaDB.MintegiakEzabatu(mi);
            if (erantzuna == 1)
            {
                MessageBox.Show(mi.Izena + " mintegia ezabatu da.");
            }
            else
            {
                MessageBox.Show("Mintegia ez da ezabatu. Mesedez, egiaztatu ID-a zuzena dela.");
            }
            FMintegia_Load(sender, e);
        }
    }
}
