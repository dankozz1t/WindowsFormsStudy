using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTaskCalculatingTheDate
{
    public partial class Form1 : Form
    {
        private DateTime date;
        private DateTime dateTimeNow = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void sendDataButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";

            if (radioButtonTime.Checked)
            {
                if (textBoxTime.MaskCompleted)
                {
                    date = DateTime.Parse(textBoxTime.Text);
                    if (date > dateTimeNow)
                    {
                        TimeSpan timeSpan = date - dateTimeNow;
                        textBoxResult.Text += "Часов: " + ((int)timeSpan.TotalHours).ToString();
                        textBoxResult.Text += "\r\nМинут: " + ((int)timeSpan.TotalMinutes).ToString();
                        textBoxResult.Text += "\r\nСекунд: " + ((int)timeSpan.TotalSeconds).ToString();
                    }
                    else
                    {
                        //Придумать логику проработки времени 00-23
                        MessageBox.Show("Время меньше сегодняшнего!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxTime.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Некоректный ввод", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxTime.Clear();
                }
            }
            else
            {
                if (textBoxDate.MaskCompleted)
                {
                    date = DateTime.Parse(textBoxDate.Text);
                    if (date > dateTimeNow)
                    {
                        TimeSpan dateSpan = date - dateTimeNow;
                        textBoxResult.Text += "Дней: " + ((int)dateSpan.TotalDays + 1).ToString();
                        textBoxResult.Text += "\r\nМесяцев: " + ((int)dateSpan.TotalDays / 30).ToString();
                        textBoxResult.Text += "\r\nГодов: " + ((int)dateSpan.TotalDays / 365).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Дата меньше сегодняшней!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxDate.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Некоректный ввод", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxDate.Clear();
                }
            }
        }

        private void radioButtonTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTime.Checked)
                textBoxTime.Enabled = true;
            else
                textBoxTime.Enabled = false;
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked)
                textBoxDate.Enabled = true;
            else
                textBoxDate.Enabled = false;
        }

        private void textBoxDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Некоректный ввод", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDate.Clear();
            }
        }

        private void textBoxTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Некоректный ввод", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTime.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelNow.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
