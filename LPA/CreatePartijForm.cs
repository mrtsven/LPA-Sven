﻿using LPA.Controllers;
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
    public partial class CreatePartijForm : Form
    {
        PartijController partijCon = new PartijController();
        public CreatePartijForm()
        {

            InitializeComponent();
        }

        private void btnCreatePartij_Click(object sender, EventArgs e)
        {
            partijCon.createPartij(txtNaam.Text, txtLijstTrekker.Text);
            MessageBox.Show("Partij aangemaakt!");
        }
    }
}
