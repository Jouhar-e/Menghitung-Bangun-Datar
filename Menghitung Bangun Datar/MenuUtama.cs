﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menghitung_Bangun_Datar
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 persegi  = new Form1();
            persegi.ShowDialog();
        }
    }
}
