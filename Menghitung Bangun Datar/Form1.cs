using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           double luas = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
           double keliling = double.Parse(textBox1.Text) * 4;
           textBox2.Text = luas.ToString();
           textBox3.Text = keliling.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
