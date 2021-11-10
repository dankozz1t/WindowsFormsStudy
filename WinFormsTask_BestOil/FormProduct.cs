using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask_BestOil
{
    public partial class FormProduct : Form
    {
        public string Product
        {
            get { return textBox1.Text;}
            set { textBox1.Text = value; }
        }

        public decimal Price
        {
            get { return Convert.ToDecimal(textBox2.Text);}
            set { textBox2.Text = value.ToString(); }
        }

        public FormProduct()
        {
            InitializeComponent();

            //textBox1.Text = Product;
            //textBox2.Text = Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = textBox1.Text;
            Price = Convert.ToDecimal(textBox2.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
