using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sommanumerilistbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction F1 = Fraction.Parse(textBox1.Text);
            Fraction F2 = Fraction.Parse(textBox2.Text);
            label1.Text = F1.Somma(F2).ToString();
            textBox1.Text = F1.ToString();
            textBox2.Text = F2.ToString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            Fraction c = Fraction.Parse(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction fsomma;
            Fraction c = null;
            Fraction b;
            ;
            for( int i = 0; i < listBox1.Items.Count; i++ ) 
            {
                listBox1.Items[i] = Fraction.Parse(textBox3.Text);
            }
            foreach (Fraction item in listBox1.Items)
            {
                b = item;
            fsomma = c.Somma(b);
            textBox3.Text += fsomma;
            }
            
            
        }
    }
}
