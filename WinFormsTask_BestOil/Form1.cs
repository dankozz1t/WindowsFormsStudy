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


        private List<Product> products = new List<Product>();

        private List<CheckBox> checkBoxes;
        private List<TextBox> textBoxes;
        private List<NumericUpDown> numericUpDowns;

        public Form1()
        {
            InitializeComponent();

            products = new List<Product>()
            {
                new Product { Name = "Чай", Price = 3.3M },
                new Product { Name = "Кофе", Price = 3.3M },
                new Product { Name = "Булка", Price = 3.3M },
                new Product { Name = "Какао", Price = 3.3M },
                new Product { Name = "Чай", Price = 3.3M }
            };

            checkBoxes = new List<CheckBox>(products.Count);
            textBoxes = new List<TextBox>(products.Count);
            numericUpDowns = new List<NumericUpDown>(products.Count);

            CreatePanelProduct();



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

        private void CreatePanelProduct()
        {
            checkBoxes.Clear();
            textBoxes.Clear();
            numericUpDowns.Clear();
            panel1.Controls.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = products[i].Name;
                checkBox.Location = new Point(6, 5 + i * 25);

                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBoxes.Add(checkBox);

                TextBox textBox = new TextBox();
                textBox.Location = new Point(120, 5 + i * 25);
                textBox.Size = new Size(44, 20);
                textBox.Text = products[i].Price.ToString();
                textBox.Enabled = false;

                textBoxes.Add(textBox);

                NumericUpDown numeric = new NumericUpDown();
                numeric.Location = new Point(170, 5 + i * 25);
                numeric.Size = new Size(44, 20);
                numeric.Value = 0;
                numeric.Enabled = false;

                numeric.ValueChanged += Numeric_ValueChanged;
                numericUpDowns.Add(numeric);

                panel1.Controls.Add(checkBox);
                panel1.Controls.Add(textBox);
                panel1.Controls.Add(numeric);


                //checkBox.CheckedChanged += TextBox_EnabledChanged;
                //CheckedCheckBox(checkBox, numeric);
            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    sum += products[i].Price * numericUpDowns[i].Value;
                }
            }

            labelMCSumGlobal.Text = sum.ToString("0.00");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                numericUpDowns[checkBoxes.IndexOf(checkBox)].Enabled = true;
            }
            else
            {
                numericUpDowns[checkBoxes.IndexOf(checkBox)].Value = 0;
                numericUpDowns[checkBoxes.IndexOf(checkBox)].Enabled = false;
            }
        }

        private void TextBox_EnabledChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

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

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.Text = "Добавление товара";
            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                products.Add(new Product {Name = formProduct.Product, Price = formProduct.Price});
                CreatePanelProduct();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    count++;
                }
            }

            if (count > 1)
            {
                MessageBox.Show("Выбраных товаров больше одного", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int ind = 0;
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        ind = i;
                        break;
                    }

                }

                FormProduct formProduct = new FormProduct();
                formProduct.Text = "Редактирование товара";

                formProduct.Product = checkBoxes[ind].Text;
                formProduct.Price = Convert.ToDecimal(textBoxes[ind].Text);

                if (formProduct.ShowDialog() == DialogResult.OK)
                {
                    products[ind] = new Product { Name = formProduct.Product, Price = formProduct.Price };
                    CreatePanelProduct();
                }
            }

        }
    }

    public class Product
    {
        public string Name;
        public decimal Price;
    }
}
