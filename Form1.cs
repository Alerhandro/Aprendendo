using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendendo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ff = Convert.ToInt32(09);
            richTextBox1.Text = richTextBox1.Text + ff;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(richTextBox1);
            int B =Convert.ToInt32(richTextBox1);
            int C = A + B;
            richTextBox1.Text = Convert.ToString(C);
        }
    }
}
