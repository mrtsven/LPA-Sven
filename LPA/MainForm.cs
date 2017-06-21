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
        public MainForm()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            dgMainView.Rows.Clear();
            //test
            List<Partij> partijen = new List<Partij>();
            foreach (Partij item in partijCon.getPartij())
            {
                dgMainView.Rows.Add(item.id, item.naam, item.lijsttrekker);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            refreshGrid();
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
            refreshGrid();
        }
    }
}
