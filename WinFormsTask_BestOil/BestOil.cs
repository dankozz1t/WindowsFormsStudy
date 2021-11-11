using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsTask_BestOil
{
    [Serializable]
    public partial class BestOil : Form
    {
        private bool Admin;

        private List<Product> products = new List<Product>();
        private List<Pentol> pentols = new List<Pentol>();

        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<NumericUpDown> numericUpDowns = new List<NumericUpDown>();

        public BestOil(bool admin)
        {
            LoadProducts();
            LoadPentols();

            Admin = admin;
            InitializeComponent();

            if (Admin)
            {
                CreateAdminPanel();
            }

            CreatePanelProduct();
            CreatePanelPentol();
        }

        private void CreateAdminPanel()
        {
            Size size = new Size(75, 23);
            Color BackColor = Color.FromArgb(84, 152, 169);
            Color ForeColor = Color.FromArgb(162, 22, 11);
            FlatStyle flatStyle = FlatStyle.Popup;
            Font font = new Font("Montserrat", 8, FontStyle.Bold);

            Button buttonAddCafe = new Button();
            buttonAddCafe.Text = "Добавить";
            buttonAddCafe.Location = new Point(10, 174);
            buttonAddCafe.Size = size;
            buttonAddCafe.FlatStyle = flatStyle;
            buttonAddCafe.Font = font;
            buttonAddCafe.BackColor = BackColor;
            buttonAddCafe.ForeColor = ForeColor;
            buttonAddCafe.Click += new EventHandler(buttonAddProduct_Click);
            groupBoxMiniCafe.Controls.Add(buttonAddCafe);

            Button buttonEditCafe = new Button();
            buttonEditCafe.Text = "Изменить";
            buttonEditCafe.Location = new Point(88, 174);
            buttonEditCafe.Size = size;
            buttonEditCafe.FlatStyle = flatStyle;
            buttonEditCafe.Font = font;
            buttonEditCafe.BackColor = BackColor;
            buttonEditCafe.ForeColor = ForeColor;
            buttonEditCafe.Click += new EventHandler(buttonEditProduct_Click);
            groupBoxMiniCafe.Controls.Add(buttonEditCafe);

            Button buttonDeleteCafe = new Button();
            buttonDeleteCafe.Text = "Удалить";
            buttonDeleteCafe.Location = new Point(165, 174);
            buttonDeleteCafe.Size = size;
            buttonDeleteCafe.FlatStyle = flatStyle;
            buttonDeleteCafe.Font = font;
            buttonDeleteCafe.BackColor = BackColor;
            buttonDeleteCafe.ForeColor = ForeColor;
            buttonDeleteCafe.Click += new EventHandler(buttonDeleteProduct_Click);
            groupBoxMiniCafe.Controls.Add(buttonDeleteCafe);

            Button buttonAddGasStation = new Button();
            buttonAddGasStation.Text = "Добавить";
            buttonAddGasStation.Location = new Point(10, 174);
            buttonAddGasStation.Size = size;
            buttonAddGasStation.FlatStyle = flatStyle;
            buttonAddGasStation.Font = font;
            buttonAddGasStation.BackColor = BackColor;
            buttonAddGasStation.ForeColor = ForeColor;
            buttonAddGasStation.Click += new EventHandler(buttonAddPetrol_Click);
            groupBoxGasStation.Controls.Add(buttonAddGasStation);

            Button buttonEditGasStation = new Button();
            buttonEditGasStation.Text = "Изменить";
            buttonEditGasStation.Location = new Point(88, 174);
            buttonEditGasStation.Size = size;
            buttonEditGasStation.FlatStyle = flatStyle;
            buttonEditGasStation.Font = font;
            buttonEditGasStation.BackColor = BackColor;
            buttonEditGasStation.ForeColor = ForeColor;
            buttonEditGasStation.Click += new EventHandler(buttonEditPetrol_Click);
            groupBoxGasStation.Controls.Add(buttonEditGasStation);

            Button buttonDeleteGasStation = new Button();
            buttonDeleteGasStation.Text = "Удалить";
            buttonDeleteGasStation.Location = new Point(165, 174);
            buttonDeleteGasStation.Size = size;
            buttonDeleteGasStation.FlatStyle = flatStyle;
            buttonDeleteGasStation.Font = font;
            buttonDeleteGasStation.BackColor = BackColor;
            buttonDeleteGasStation.ForeColor = ForeColor;
            buttonDeleteGasStation.Click += new EventHandler(buttonDeletePetrol_Click);
            groupBoxGasStation.Controls.Add(buttonDeleteGasStation);
        }

        private void CreatePanelPentol()
        {
            comboBoxGSPetrol.Items.Clear();
            textBoxGSPrice.Clear();

            foreach (var pentol in pentols)
            {
                comboBoxGSPetrol.Items.Add(pentol.Name);
            }
            comboBoxGSPetrol.Text = comboBoxGSPetrol.Items[0].ToString();
            SavePentols();
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
            }

            SaveProducts();
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
            foreach (var pentol in pentols)
            {
                if (pentol.Name == comboBoxGSPetrol.SelectedItem)
                {
                    textBoxGSPrice.Text = pentol.Price.ToString();
                    break;
                }
            }
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
                labelGSResult.Text = (money / float.Parse(textBoxGSPrice.Text)).ToString("00.00");
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


        //-------------------------------------- КНОПКИ БЕНЗИНА
        private void buttonAddPetrol_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange();
            formChange.Text = "Добавление топлива";
            if (formChange.ShowDialog() == DialogResult.OK)
            {
                pentols.Add(new Pentol { Name = formChange.Product, Price = formChange.Price });
                CreatePanelPentol();
            }
        }

        private void buttonEditPetrol_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange();
            formChange.Text = "Редактирование топлива";
            formChange.Product = comboBoxGSPetrol.SelectedItem.ToString();
            formChange.Price = Convert.ToDecimal(textBoxGSPrice.Text);
            if (formChange.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < pentols.Count; i++)
                {
                    if (pentols[i].Name == comboBoxGSPetrol.SelectedItem)
                    {
                        pentols[i] = new Pentol { Name = formChange.Product, Price = formChange.Price };
                        CreatePanelPentol();
                        break;
                    }
                }
            }
        }

        private void buttonDeletePetrol_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pentols.Count; i++)
            {
                if (pentols[i].Name == comboBoxGSPetrol.SelectedItem)
                {
                    pentols.RemoveAt(i);
                    CreatePanelPentol();
                    break;
                }
            }
        }

        //-------------------------------------- КНОПКИ ПРОДУКТОВ
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange();
            formChange.Text = "Добавление товара";
            if (formChange.ShowDialog() == DialogResult.OK)
            {
                products.Add(new Product { Name = formChange.Product, Price = formChange.Price });
                CreatePanelProduct();
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
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

                FormChange formChange = new FormChange();
                formChange.Text = "Редактирование товара";

                formChange.Product = checkBoxes[ind].Text;
                formChange.Price = Convert.ToDecimal(textBoxes[ind].Text);

                if (formChange.ShowDialog() == DialogResult.OK)
                {
                    products[ind] = new Product { Name = formChange.Product, Price = formChange.Price };
                    CreatePanelProduct();
                }
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    checkBoxes.RemoveAt(i);
                    products.RemoveAt(i);
                    CreatePanelProduct();
                    ind++;
                }
            }
            if (ind < 0)
                MessageBox.Show("Выберите продукт", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public void SaveProducts()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));

            using (Stream stream = File.Create("../../Save/Products.xml"))
            {
                xml.Serialize(stream, products);
            }
        }
        public void LoadProducts()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));

            using (Stream stream = File.OpenRead("../../Save/Products.xml"))
            {
                products = (List<Product>)xml.Deserialize(stream);
            }
        }

        public void SavePentols()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Pentol>));

            using (Stream stream = File.Create("../../Save/Pentols.xml"))
            {
                xml.Serialize(stream, pentols);
            }
        }
        public void LoadPentols()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Pentol>));

            using (Stream stream = File.OpenRead("../../Save/Pentols.xml"))
            {
                pentols = (List<Pentol>)xml.Deserialize(stream);
            }
        }
    }

    [Serializable]
    public class Pentol
    {
        public string Name;
        public decimal Price;
        public Pentol() { }
    }

    [Serializable]
    public class Product
    {
        public string Name;
        public decimal Price;
        public Product() { }
    }


}
