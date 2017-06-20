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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lbOverview.Items.Add(partijCon.getPartij());
        }

        private void btnNieuwePartij_Click(object sender, EventArgs e)
        {

        }
    }
}
