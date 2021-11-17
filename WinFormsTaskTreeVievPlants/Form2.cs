using System;
using System.Windows.Forms;

namespace WinFormsTaskTreeVievPlants
{
    public partial class Form2 : Form
    {
        public string _Name
        {
            get { return this.textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public double _Price
        {
            get { return Convert.ToDouble(this.textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public DateTime _DateWatering
        {
            get { return this.dateTimePicker1.Value; }
            set { this.dateTimePicker1.Value = value; }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
                this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
