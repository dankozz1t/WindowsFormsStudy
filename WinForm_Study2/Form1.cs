using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Study2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

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


        private void buttonLoadF_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Что-то открыть...";
            open.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt||";
            open.FilterIndex = 2; //Начинает с второго фильтра

            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = File.OpenText(open.FileName);
                richTextBox1.Text = stream.ReadToEnd();
                stream.Close();
            }

        }

        private void buttonSaveF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить";


            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(save.FileName);
                stream.Write(richTextBox1.Text);
                stream.Close();
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }

        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }


        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string txt = richTextBox1.Text;
            //richTextBox1.Text = "";
            //for (int i = 0; i < txt.Length; i++)
            //{
            //    richTextBox1.SelectionColor = Color.FromArgb(random.Next(1, 250), random.Next(1, 250), random.Next(1, 250));
            //    //richTextBox1.Text += txt[i];
            //}
        }
    }
}
