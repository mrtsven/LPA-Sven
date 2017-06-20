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
        PartijController partijController;
        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show(partijController.getPartij().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
