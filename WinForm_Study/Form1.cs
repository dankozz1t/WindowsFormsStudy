using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WinForm_Study
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void GlobalBtm_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(50);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Аууууууууууууу!!!", "Ау", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Вы нажали ДА", "Сработало нажатие ДА", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.GlobalBtm.Text = $"{e.X.ToString()} | {e.Y.ToString()}";

            if ((e.X > label1.Location.X - 20 && e.X < label1.Location.X + label1.Width + 20) &&
                (e.Y > label1.Location.Y - 20 && e.Y < label1.Location.Y + label1.Height + 20))
            {
                if (e.X > label1.Location.X - 20 && e.X < label1.Location.X) //движение курсора с лева по оси Х
                {
                    label1.Left += 10;
                }
                else if (e.X < label1.Location.X + label1.Width + 20 &&
                         e.X > label1.Location.X + label1.Width) //движение курсора с права по оси Х
                {
                    label1.Left -= 10;
                }
                else if (e.Y > label1.Location.Y - 20 && e.Y < label1.Location.Y) //движение курсора с верху по оси У
                {
                    label1.Top += 10;
                }
                else if (e.Y < label1.Location.Y + label1.Height + 20 &&
                         e.Y > label1.Location.Y + label1.Height) //движение курсора с низу по оси У
                {
                    label1.Top -= 10;
                }

                //Проверка границ окна и возврат «статика» в центр
                if ((label1.Location.X < 0 || label1.Location.X > ClientSize.Width - label1.Width) ||
                    (label1.Location.Y < 0 || label1.Location.Y > ClientSize.Height - label1.Height))
                {
                    LableCenter(label1);
                }

            }
        }

        void LableCenter(Label lable) //центрирование «статика»
        {
            label1.Left = (ClientSize.Width - label1.Size.Width) / 2;
            label1.Top = (ClientSize.Height - label1.Size.Height) / 2;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = "Вы нажали ";
            if (e.Button == MouseButtons.Left)
            {
                txt += "ЛЕВУЮ";
            }

            if (e.Button == MouseButtons.Right)
            {
                txt += "ПРАВУЮ";
            }

            if (e.Button == MouseButtons.Middle)
            {
                txt += "ЦЕНТРАЛЬНУЮ(КОЛЁСИКО)";
            }
            txt += " кнопку миши";

            MessageBox.Show(txt, "Нажатие миши", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void GlobalBtm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Правая Кнопка миши", "Нажатие миши", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАЙКА!", "вы нажали на зайку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        List<Label> list;
        private void button1_Click(object sender, EventArgs e)
        {

            list = new List<Label>();
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedItems != null)
                {
                    for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    {
                        listBox2.Items.Add(listBox1.SelectedItems[i]);
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedItems != null)
                {
                    while (listBox1.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                        {
                            listBox2.Items.Add(listBox1.SelectedItems[i]);
                            listBox1.Items.Remove(listBox1.SelectedItems[i]);
                        }
                    }
                }
            }
        }

        private void buttonCheListBox_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                MessageBox.Show($"Выбран {comboBox1.SelectedItem.ToString()}", comboBox1.SelectedItem.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count <= 100)
                progressBar2.Value = listBox2.Items.Count;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.FromArgb(trackBar1.Value,trackBar2.Value, trackBar3.Value);
        }
    }
}
