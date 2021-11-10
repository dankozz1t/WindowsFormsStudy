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
    public partial class Form2 : Form
    {


        //Передача через свойство
        //public string Product
        //{
        //    set
        //    {
        //        textBox1.Text = value;
        //    }
        //}

        //Передача через параметр
        //public Form2(string str)
        //{
        //    InitializeComponent();
        //    textBox1.Text = str;
        //}

        public Form2()
        {
            InitializeComponent();
        }


        public string Product
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        //Передача через перегрузку 
        public DialogResult ShowDialog(string s)
        {
            textBox1.Text = s;
            return ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
