using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Study2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Product = textBox1.Text;
            //f.Show();
            //f.ShowDialog();
            //f.ShowDialog(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Product = textBox1.Text;
            //f.Show();
            //f.ShowDialog();
            //f.ShowDialog(textBox1.Text);
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(f.Product);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
