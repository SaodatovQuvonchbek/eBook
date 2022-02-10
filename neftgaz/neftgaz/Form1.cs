using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neftgaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("bin/1.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            axAcroPDF1.LoadFile("bin/3.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            axAcroPDF1.LoadFile("bin/1.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            axAcroPDF1.LoadFile("bin/2.pdf");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            axAcroPDF1.LoadFile("bin/1.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("bin/4.pdf");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
