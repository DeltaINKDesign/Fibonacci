using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            algorm();
        }

        int fibonacci(int ile)
        {
            if (ile <= 1) return ile;
            else return fibonacci(ile - 2) + fibonacci(ile - 1);
        }

        void algorm()
        {
            
            int range = hScrollBar1.Value;
            string zmienna = "0";
            double all = 0;
            for (int i = 1; i < range; i++)
            {
                int k = fibonacci(i);
                listBox1.Items.Add(k.ToString());
                listBox2.Items.Add(zmienna);
                zmienna = "0,";
                for(int j = 1; j < i; j++)
                {
                    zmienna += "0";

                }
                zmienna += k.ToString();
                if (i > 1)
                {
                    all += Convert.ToDouble(zmienna);
                }

            }
            textBox1.Text = all.ToString();
            double e = (1f / 89) - all;
            textBox2.Text = e.ToString();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            algorm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
