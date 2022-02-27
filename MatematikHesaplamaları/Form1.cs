using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;
            birkenar=Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;
            label4.Text = alan .ToString();
            label6.Text = cevre .ToString();      
            panel1.Visible = true;

            int  uzun;
            int dikalan, dikcevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            dikalan = birkenar * uzun;
            dikcevre = (2 * birkenar) + (2 * uzun);
            label4.Text = dikalan.ToString();
            label6.Text = dikcevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "KARE";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DİKDORTGEN";
            label2.Text = "Kısa Kenar";
            label7.Visible = true;
            textBox2.Visible = true;
        }
    }
}
