using System;
using System.Windows.Forms;

namespace WinFormsTaskCalculatingTheDate
{
    public partial class Form1 : Form
    {
        private DateTime date;
        private DateTime dateTimeNow = DateTime.Now;

        private string incorrectInputName = "Некоректный ввод";
        private string timeLessTodayName = "Время меньше сегодняшнего!!";
        private string errorName = "Ошибка!";

        public Form1() => InitializeComponent();
        private void sendDataButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";

            if (radioButtonTime.Checked)
            {
                DateApply(textBoxTime, false);
            }
            else
            {
                DateApply(textBoxDate, true);
            }
        }
        private void radioButtonTime_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange(radioButtonTime, textBoxTime);
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange(radioButtonDate, textBoxDate);
        }

        private void RadioButtonChange(RadioButton radioButton, MaskedTextBox textBox)
        {
            if (radioButton.Checked)
            {
                textBox.Enabled = true;
            }
            else
            {
                textBox.Enabled = false;
            }
        }

        private void textBoxDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                SendError(textBoxDate, incorrectInputName);
            }
        }

        private void textBoxTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                SendError(textBoxTime, incorrectInputName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelNow.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void DateApply(MaskedTextBox maskedTextBox, bool isTimeSizeBig)
        {
            if (maskedTextBox.MaskCompleted)
            {
                date = DateTime.Parse(maskedTextBox.Text);
                if (date > dateTimeNow)
                {
                    SetTextBox(isTimeSizeBig);
                }
                else
                {
                    //Придумать логику проработки времени 00-23
                    SendError(maskedTextBox, timeLessTodayName);
                }
            }
            else
            {
                SendError(maskedTextBox, incorrectInputName);
            }
        }

        private void SetTextBox(bool isTimeSizeBig)
        {
            TimeSpan timeSpan = date - dateTimeNow;
            TextBoxTimeSetup textBoxTimeSetup = new TextBoxTimeSetup();

            TextBoxTimeSetup.TextBoxValue[] timeValues = null;
            timeValues = textBoxTimeSetup.SelectSuitableTime(isTimeSizeBig, timeSpan);
            TextBoxTimeSetup.TimeTextBoxItem timeTextBoxItem = new TextBoxTimeSetup.TimeTextBoxItem(date, dateTimeNow, textBoxResult, timeValues);
        }

        private void SendError(MaskedTextBox textBox, string errorMessage)
        {
            MessageBox.Show(errorMessage, errorName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Clear();
        }
    }
}
