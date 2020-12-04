using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 2 == 1) {
                numericUpDown1.Value = numericUpDown1.Value + 1;
                progressBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
                textBox1.Text = numericUpDown1.Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (Int32.Parse(textBox1.Text) % 2 == 1) {
                    textBox1.Text = (Int32.Parse(textBox1.Text) + 1).ToString();
                    numericUpDown1.Value = Int32.Parse(textBox1.Text);
                    progressBar1.Value = Int32.Parse(textBox1.Text);
                }
            }
        }
    }
}
