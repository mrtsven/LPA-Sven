using LPA.Controllers;
using LPA.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPA
{
    public partial class NieuweUitslagForm : Form
    {
        PartijController partijCon = new PartijController();
        UitslagController uitslagCon = new UitslagController();
        List<Partij> partijen = new List<Partij>();
        public NieuweUitslagForm()
        {
            InitializeComponent();
            //test
            foreach (Partij item in partijCon.getPartij())
            {
                cbPartij.Items.Add(item.ToString());
            }
        }

        private void btnNieuwUitslag_Click(object sender, EventArgs e)
        {


            string dt = this.dtUitslagDatum.Value.ToString("yyyy-MM-dd");
            uitslagCon.createUitslag(txtUitslagNaam.Text, dt);
            MessageBox.Show("Uitslag aangemaakt!");

        }

        private void btnInvoerStem_Click(object sender, EventArgs e)
        { 
            int id = cbPartij.SelectedIndex + 1;
            uitslagCon.voegStemmenIn(id, Convert.ToInt32(nStemmen.Value), txtUitslagNaam.Text);
        }
    }
}
