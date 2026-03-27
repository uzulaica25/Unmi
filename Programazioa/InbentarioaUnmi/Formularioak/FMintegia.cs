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
        public FMintegia()
        {
            InitializeComponent();
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            string Mizena;
            Mintegiak mi;

            Mizena = Microsoft.VisualBasic.Interaction.InputBox("izena:", "Mintegia gehitu", "Mintegi berriaren izena");

            if (!string.IsNullOrEmpty(Mizena))
            {
                MessageBox.Show(Mizena + " mintegia gehitu da.");
            }
            mi = new Mintegiak(Mizena);

        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {
           
        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {

        }
    }
}
