using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace binaryadderwithcarry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calculeazasumaabbinar()
        {
            binaddc abcr = new binaddc(0, 0, 0, 0);
            abcr.a = 1;
            abcr.b = 1;
            abcr.addcAB();
            Text = "a= " + abcr.a.ToString() + " + b= " + abcr.b.ToString();
            Text += " => r=" + abcr.r.ToString() + " : c =" + abcr.c.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            calculeazasumaabbinar();
        }
    }
}
