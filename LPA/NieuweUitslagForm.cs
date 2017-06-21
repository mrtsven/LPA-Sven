using LPA.Controllers;
using LPA.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                cbPartij.Items.Add(item);
                cbPartij.SelectedIndex = 0;
            }
        }

        private void btnNieuwUitslag_Click(object sender, EventArgs e)
        {
            try
            {
                string dt = this.dtUitslagDatum.Value.ToString("yyyy-MM-dd");
                uitslagCon.createUitslag(txtUitslagNaam.Text, dt);
                MessageBox.Show("Uitslag aangemaakt!");
            }
            catch (SqlException)
            {
                    MessageBox.Show("Datum of naam is al gebruikt");
            }


        }

        private void btnInvoerStem_Click(object sender, EventArgs e)
        { 

            int selectedID = (cbPartij.SelectedItem as Partij).id;
            uitslagCon.voegStemmenIn(selectedID, Convert.ToInt32(nStemmen.Value), txtUitslagNaam.Text);
        }
    }
}
