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
    public partial class FErabiltzailea : Form
    {
        public List<Erabiltzaileak> LisEra = new List<Erabiltzaileak>();
        public Erabiltzaileak era;
        public FErabiltzailea(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FErabiltzailea_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisEra = ErabiltzaileaDB.ErabiltzaileaZerrendatu();
            if (era.Rola == "MintegiBurua")
            {
                var filtrado = LisEra.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvErabiltzaileak.DataSource = filtrado;

            }
            else
            {
                dgvErabiltzaileak.DataSource = LisEra;
            }
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            int eragiketa;
            string Eizena, pas, rola = " ", min;
            Erabiltzaileak er;
            Mintegiak mintegia;
            while (true)
            {
                Eizena = Microsoft.VisualBasic.Interaction.InputBox("Izena:", "Erabiltzailea gehitu", "Erabiltzaile berriaren izena");
                if (string.IsNullOrEmpty(Eizena))
                {
                    throw new Exception("Erabiltzailearen izena ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                pas = Microsoft.VisualBasic.Interaction.InputBox("Pasahitza:", "Erabiltzailea gehitu", "Erabiltzaile berriaren pasahitza");
                if (string.IsNullOrEmpty(pas))
                {
                    throw new Exception("Erabiltzailearen pasahitza ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            if (era.Rola == "MintegiBurua")
            {
                while (rola != "1" && rola != "2")
                {
                    rola = Microsoft.VisualBasic.Interaction.InputBox("Rola: 1-Irakaslea edo 2-MintegiBurua", "Erabiltzailea gehitu", "Sartu rolaren zenbaki. Adb: Irakaslea bada sartu 1");
                    if (string.IsNullOrEmpty(rola))
                    {
                        throw new Exception("Erabiltzailearen rola ezin da hutsik egon.");
                    }

                }
                
            }else
            {
                while (rola != "1" && rola != "2" && rola != "3") 
                {
                    rola = Microsoft.VisualBasic.Interaction.InputBox("Rola: 1-Irakaslea, 2-MintegiBurua edo 3-IKTArtduraduna", "Erabiltzailea gehitu", "Sartu rolaren zenbaki. Adb: Irakaslea bada sartu 1");
                    if (string.IsNullOrEmpty(rola))
                    {
                        throw new Exception("Erabiltzailearen rola ezin da hutsik egon.");
                    }
                }
            }
            if(era.Rola == "MintegiBurua")
            {
                mintegia = era.Mintegia;
            }
            else
            {
                while (true)
                {
                    min = Microsoft.VisualBasic.Interaction.InputBox("Mintegiare ID-a:", "Erabiltzailea gehitu", "Erabiltzailearen mintegiaren ID-a");
                    if (string.IsNullOrEmpty(min))
                    {
                        throw new Exception("Erabiltzailearen mintegia ezin da hutsik egon.");
                    }
                    else
                    {
                        break;
                    }
                }
                mintegia = MintegiaDB.MintegiaBilatu(min);
            }
            if (rola == "1")
            {
                er = new Erabiltzaileak(Eizena, pas, mintegia, "Irakaslea");
            }
            else if (rola == "2")
            {
                er = new Erabiltzaileak(Eizena, pas, mintegia, "MintegiBurua");
            }
            else
            {
                er = new Erabiltzaileak(Eizena, pas, mintegia, "IKTArduraduna");
            }
            eragiketa = ErabiltzaileaDB.ErabiltzaileaGehitu(er);
            if (eragiketa == 1)
            {
                MessageBox.Show(Eizena + " erabiltzailea gehitu da.");
            }
            else
            {
                MessageBox.Show("Erabiltzailea ez da gehitu. Mesedez, saiatu berriro.");
            }
            FErabiltzailea_Load(sender, e);
        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {
            int erantzuna, z1 = 0;
            Erabiltzaileak er;
            string Id, pas;
            while (true)
            {
                Id = Microsoft.VisualBasic.Interaction.InputBox("ID-a:", "Erabiltzailearen pasahitza aldatu", "Pasahitza aldatu nahi diozun erabiltzailearen ID-a");
                if (string.IsNullOrEmpty(Id))
                {
                    throw new Exception("Erabiltzailearen ID-a ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                pas = Microsoft.VisualBasic.Interaction.InputBox("Pasahitza:", "Erabiltzailearen pasahitza aldatu", "Erabiltzailearen pasahitza berria");
                if (string.IsNullOrEmpty(pas))
                {
                    throw new Exception("Erabiltzailearen pasahitza ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            foreach (Erabiltzaileak era in LisEra)
            {
                if (era.Id != Id)
                {
                    z1++;
                }
                else
                {
                    break;
                }
            }
            er = LisEra[z1];
            erantzuna = ErabiltzaileaDB.ErabiltzaileaAldatu(er, pas);
            if (erantzuna == 1)
            {
                MessageBox.Show(Id + " erabiltzailearen pasahitza eguneratu da. Orain " + pas + " da.");
            }
            else
            {
                MessageBox.Show("Erabiltzailearen pasahitza ez da eguneratu. Mesedez, egiaztatu ID-a zuzena dela.");
            }
            FErabiltzailea_Load(sender, e);
        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            int z1 = 0, erantzuna;
            string Eid;
            Erabiltzaileak er;
            while (true)
            {
                Eid = Microsoft.VisualBasic.Interaction.InputBox("ID:", "Erabiltzailea ezabatu", "Ezabatu nahi duzun erabiltzailearen ID-a");
                if (string.IsNullOrEmpty(Eid))
                {
                    throw new Exception("Erabiltzailearen ID-a ezin da hutsik egon.");
                }
                else
                {
                    break;
                }
            }
            foreach (Erabiltzaileak era in LisEra)
            {
                if ( era.Id != Eid)
                {
                    z1++;
                }
                else
                {
                    break;
                }
            }
            er = LisEra[z1];
            if (era.Id == er.Id)
            {
                MessageBox.Show("Ezin duzu zure burua ezabatu.");
                return;
            }
            else
            {
                erantzuna = ErabiltzaileaDB.ErabiltzaileaEzabatu(er);
                if (erantzuna == 1)
                {
                    MessageBox.Show(er.Izena + " erabiltzailea ezabatu da.");
                }
                else
                {
                    MessageBox.Show("Erabiltzailea ez da ezabatu. Mesedez, egiaztatu ID-a zuzena dela.");
                }
            }
            FErabiltzailea_Load(sender, e);
        }
    }
}
