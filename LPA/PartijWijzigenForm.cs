using LPA.Controllers;
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
    public partial class PartijWijzigenForm : Form
    {
        PartijController partijCon = new PartijController();
        string oudnaam;
        public PartijWijzigenForm(string oudnaam)
        {
            InitializeComponent();
            this.oudnaam = oudnaam;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            partijCon.updatePartij(oudnaam, txtNaam.Text, txtLijsttrekker.Text);
        }
    }
}
