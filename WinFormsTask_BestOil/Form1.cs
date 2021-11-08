using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsTask_BestOil
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> petrol = new Dictionary<string, float>();

        //Обьекты для отслеживания количества продуктов для подсчета общей суммы
        private PastValue pastValueCountProducts1 = new PastValue();
        private PastValue pastValueCountProducts2 = new PastValue();
        private PastValue pastValueCountProducts3 = new PastValue();
        private PastValue pastValueCountProducts4 = new PastValue();

        public Form1()
        {
            InitializeComponent();

            //---------------------Инициализация бензина 
            petrol.Add("A-92", (float)26.57);
            petrol.Add("A-95", (float)27.35);
            petrol.Add("A-95+", (float)28.31);
            petrol.Add("ДТ", (float)25.15);
            petrol.Add("Газ", (float)12.58);

            foreach (var f in petrol)
            {
                comboBoxGSPetrol.Items.Add(f.Key);
            }
            //-----------------------

            comboBoxGSPetrol.Text = comboBoxGSPetrol.Items[0].ToString(); //По умолчанию берет первый элемент (бензина)
        }

        private void TextBox_EnabledChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox.Enabled)
                textBox.BackColor = Color.White;
            else
                textBox.BackColor = Color.LightGray;
        }

        private void radioButtonGSCount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxGSMoney.Enabled = false;
            textBoxGSMoney.Text = "0";

            labelGSUnit.Text = "грн";
            groupBoxGSTo.Text = "К оплате";

            labelGSResult.Text = "0";
            textBoxGSLiters.Enabled = true;
        }

        private void radioButtonGSSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxGSLiters.Enabled = false;
            textBoxGSLiters.Text = "0";

            labelGSUnit.Text = "л";
            groupBoxGSTo.Text = "К выдаче";

            labelGSResult.Text = "0";
            textBoxGSMoney.Enabled = true;
        }

        private void comboBoxGSPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxGSPrice.Text = Convert.ToString(petrol[comboBoxGSPetrol.Text]);
        }

        private void textBoxGSLiters_TextChanged(object sender, EventArgs e)
        {
            float liter = 0;
            float.TryParse(textBoxGSLiters.Text, out liter);

            if (liter > 0)
            {
                labelGSResult.Text = Convert.ToString(liter * float.Parse(textBoxGSPrice.Text));
            }
            else
            {
                labelGSResult.Text = "0";
            }
        }

        private void textBoxGSMoney_TextChanged(object sender, EventArgs e)
        {
            float money = 0;
            float.TryParse(textBoxGSMoney.Text, out money);

            if (money > 0)
            {
                string sum = Convert.ToString(money / float.Parse(textBoxGSPrice.Text));
                try
                {
                    labelGSResult.Text = sum.Remove((sum.IndexOf(',') + 3)); //Удлаяет все после ,00

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Не ломай меня!!!", "Черт!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    labelGSResult.Text = "0";
                    textBoxGSMoney.Text = "0";
                }
            }
            else
            {
                labelGSResult.Text = "0";
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxGSLiters.Enabled)
            {
                labelSum.Text = Convert.ToString(float.Parse(labelGSResult.Text) + float.Parse(labelMCSumGlobal.Text));
            }
            else
            {
                float money = 0;
                float.TryParse(textBoxGSMoney.Text, out money);

                float sum = 0;
                float.TryParse(labelMCSumGlobal.Text, out sum);

                labelSum.Text = Convert.ToString(money + sum);
            }
        }

        private void CheckedCheckBox(CheckBox checkBox, NumericUpDown numericUpDown) //Метод проверки активности чекбокса
        {
            if (checkBox.Checked)
            {
                numericUpDown.Enabled = true;
                numericUpDown.Value = 0;
            }
            else
            {
                numericUpDown.Value = 0;
                numericUpDown.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedCheckBox(checkBox1, numericCafeProduct1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckedCheckBox(checkBox2, numericCafeProduct2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckedCheckBox(checkBox3, numericCafeProduct3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckedCheckBox(checkBox4, numericCafeProduct4);
        }


        private void CheckedPriceValueChanged(TextBox price, bool operation) //Метод изменения общей суммы Кафе
        {
            float sum = float.Parse(price.Text);
            float oldSum = float.Parse(labelMCSumGlobal.Text);

            if (operation)
            {
                labelMCSumGlobal.Text = Convert.ToString(oldSum + sum);
            }
            else
            {
                labelMCSumGlobal.Text = Convert.ToString(oldSum - sum);
            }
        }

        private void CheckedGlobalValueChanged(NumericUpDown cafeProduct, TextBox price, PastValue pastValue) //Метод проверки прошлого колв продуктов
        {
            if ((int)cafeProduct.Value > pastValue.value) //Если количество продуктов больше прошлого количества, тогда + цена, иначе -
            {
                CheckedPriceValueChanged(price, true);
            }
            else
            {
                CheckedPriceValueChanged(price, false); 
            }

            pastValue.value = (int)cafeProduct.Value; //Обновляю прошлое значение колв продуктов.
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CheckedGlobalValueChanged(numericCafeProduct1, textBoxPrice1, pastValueCountProducts1);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CheckedGlobalValueChanged(numericCafeProduct2, textBoxPrice2, pastValueCountProducts2);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CheckedGlobalValueChanged(numericCafeProduct3, textBoxPrice3, pastValueCountProducts3);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            CheckedGlobalValueChanged(numericCafeProduct4, textBoxPrice4, pastValueCountProducts4);
        }

    }

    public class PastValue
    {
        public int value = -1;
    }
}
