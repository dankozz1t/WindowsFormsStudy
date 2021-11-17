using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsTaskTreeVievPlants
{
    public partial class Form1 : Form
    {
        List<Plant> plants;
        private int sotrColumn { get; set; } = -1; // индек колоны которая сортируется

        public Form1()
        {
            InitializeComponent();

            plants = new List<Plant>
            {
                new Plant("Фикус", 64.34, new DateTime(2021,11,12)),
                new Plant("Роза", 100.43, new DateTime(2021,11,18)),
                new Plant("Денежное дерево",      43.10, new DateTime(2021,10,29)),
                new Plant("Хлорофитум",      36.12, new DateTime(2021,11,14)),
                new Plant("Кактус",      7.00, new DateTime(2021,10,18)),
                new Plant("Сингориум",  250.21, new DateTime(2021,11,07))
            };

            RedrawingListView();
        }

        void RedrawingListView()
        {
            listView1.Items.Clear();
            foreach (var item in plants)
            {
                ListViewItem i = new ListViewItem(item.Name);
                i.SubItems.Add(item.Price.ToString());
                i.SubItems.Add(item.DateWatering.ToShortDateString());
                listView1.Items.Add(i);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e) //Скрысятил у Кости
        {
            if (e.Column != sotrColumn)
            {
                foreach (var item in listView1.Columns)
                {
                    if ((item as ColumnHeader).Index == e.Column)
                    {
                        (item as ColumnHeader).Text = (item as ColumnHeader).Text.TrimEnd(new char[] { ' ', '↓', '↑' });
                        (item as ColumnHeader).Text += " ↑";
                    }
                    else (item as ColumnHeader).Text = (item as ColumnHeader).Text.TrimEnd(new char[] { ' ', '↓', '↑' });
                }
                sotrColumn = e.Column;

                switch (e.Column)
                {
                    case 0:
                        plants.Sort();  break;
                    case 1:
                        plants.Sort(new PriceComparer()); break;
                    case 2:
                        plants.Sort(new DateWateringComparer()); break;
                }
            }
            else
            {
                foreach (var item in listView1.Columns)
                {
                    sotrColumn = -1;
                    if ((item as ColumnHeader).Index == e.Column)
                    {
                        (item as ColumnHeader).Text = (item as ColumnHeader).Text.TrimEnd(new char[] { ' ', '↑', '↓' });
                        (item as ColumnHeader).Text += " ↓";
                    }
                }
                plants.Reverse();
            }

            RedrawingListView();
        }


        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "Добавление";

            if (form2.ShowDialog() == DialogResult.OK)
            {
                plants.Add(new Plant(form2._Name, form2._Price, form2._DateWatering));
                RedrawingListView();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items.RemoveAt(i);
                    plants.RemoveAt(i);
                }
            };
            RedrawingListView();
        }
    }
}
