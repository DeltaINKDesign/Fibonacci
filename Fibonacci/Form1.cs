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
            licz();
        }

        int fib(int ile)
        {
            if (ile <= 1) return ile;
            else return fib(ile - 2) + fib(ile - 1);
        }

        void licz()
        {
            
            int range = hScrollBar1.Value;
            string a = "0";
            double zlicz = 0;
            for (int i = 1; i < range; i++)
            {
                int k = fib(i);
                listBox1.Items.Add(k.ToString());
                listBox2.Items.Add(a);
                a = "0,";
                for(int j = 1; j < i; j++)
                {
                    a += "0";

                }
                a += k.ToString();
                if (i > 1)
                {
                    zlicz += Convert.ToDouble(a);
                }

            }
            textBox1.Text = zlicz.ToString();
            double e = (1f / 89) - zlicz;
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
            licz();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
