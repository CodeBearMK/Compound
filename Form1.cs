using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result1 = Math.Round(Convert.ToDouble(textBox1.Text) * Math.Pow((1 + (Convert.ToDouble(textBox3.Text) / 100)), Convert.ToDouble(textBox2.Text)),2);
            double result2 = result1 - Convert.ToDouble(textBox1.Text);
            label4.Text = "本利和 = NT$ " + result1.ToString() + "元\n總利息 = NT$ " + result2.ToString() + "元";
        }
    }
}
