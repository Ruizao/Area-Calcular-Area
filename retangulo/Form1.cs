using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        retangulo r = new retangulo();
        private void Button1_Click(object sender, EventArgs e)
        {
            r.Altura = textBox1.Text;
            r.Largura = textBox2.Text;
            if (radioButton1.Checked) label4.Text = r.Area;
            else if (radioButton2.Checked) label4.Text = r.Perimetro;
            else if (radioButton3.Checked) label4.Text = r.Diagonal;
        }
    }
}
