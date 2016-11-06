using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTests
{
    public partial class Form1 : Form
    {
        QuadEq Q;
        List<double> list;
        public Form1()
        {
            InitializeComponent();
            Q = new QuadEq();
            list = new List<double>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list = Q.ResultPlease(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            label4.Text = "x1 = " +list[0].ToString() + "; x2 = " + list[1].ToString();
        }
    }
}
