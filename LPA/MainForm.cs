using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPA.Controllers;
using LPA.Domain;

namespace LPA
{
    public partial class MainForm : Form
    {
        private PartijController partijCon = new PartijController();
        private CoalitieController coalitieCon = new CoalitieController();
        private UitslagController uitslagCon = new UitslagController();
        public MainForm()
        {
            InitializeComponent();
            foreach (Uitslag item in uitslagCon.getUitslag())
            {
                cbUitslagKiezen.Items.Add(item.naam);
            }
        }

        public List<int> ZetelsCount(int uitslagID)
        {
            int totaalStem;
            List<Partij> lijstMet = new List<Partij>();
            List<int> zetelLijst = new List<int>();
            partijCon.getPartijMet(uitslagID);
            foreach (var stem in lijstMet)
            {
                totaalStem = stem.stemmers;
                zetelLijst.Add(totaalStem / stem.stemmers * 150);

            }

            


            return zetelLijst;
        }

        private void refreshGridNoVotes()
        {
            dgMainView.Rows.Clear();
            dgMainView.Columns[3].Visible = false;
            dgMainView.Columns[4].Visible = false;
            List<Partij> partijen = new List<Partij>();
            foreach (Partij item in partijCon.getPartij())
            {
                dgMainView.Rows.Add(item.id, item.naam, item.lijsttrekker);
            }
        }

        private void refreshGridWithVotes()
        {
            dgMainView.Rows.Clear();
            
            dgMainView.Columns[3].Visible = true;
            dgMainView.Columns[4].Visible = true;
            int id = cbUitslagKiezen.SelectedIndex + 1;
            ZetelsCount(id);
            foreach (Partij item in partijCon.getPartijMet(id))
            {
                dgMainView.Rows.Add(item.id, item.naam, item.lijsttrekker, item.stemmers);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnWithVotes_Click(object sender, EventArgs e)
        {
            refreshGridWithVotes();
        }

        private void btnNieuwePartij_Click(object sender, EventArgs e)
        {
            CreatePartijForm newPartij = new CreatePartijForm();
            this.Hide();
            newPartij.ShowDialog();
            this.Show();
        }

        private void btnWijzigPartij_Click(object sender, EventArgs e)
        {
            int rijIndex = dgMainView.CurrentCell.RowIndex;
            int columnindex = dgMainView.CurrentCell.ColumnIndex;

            string geselecteerdCell = dgMainView.Rows[rijIndex].Cells[columnindex].Value.ToString();
            PartijWijzigenForm wijzigPartij = new PartijWijzigenForm(geselecteerdCell);
            this.Hide();
            wijzigPartij.ShowDialog();
            this.Show();
            refreshGridWithVotes();
        }

        private void btnNieuwUitslag_Click(object sender, EventArgs e)
        {
            NieuweUitslagForm nieuwUitslag = new NieuweUitslagForm();
            this.Hide();
            nieuwUitslag.ShowDialog();
            this.Show();
            refreshGridWithVotes();
        }

        private void btnAllePartijen_Click(object sender, EventArgs e)
        {
            refreshGridNoVotes();
        }
    }
}
