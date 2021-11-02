using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask_Rectangles
{
    public partial class Form1 : Form
    {
        private Rectangle rectangle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                //rectangle.SetPosition(e.X, e.Y);

                label.BorderStyle = BorderStyle.Fixed3D;
                //определение позиции статика в зависимости с какой стороны его начали расовать
                if (e.X > rectangle.X && e.Y > rectangle.Y)
                {
                    label.Location = new Point(rectangle.X, rectangle.Y);
                }
                else if (e.X > rectangle.X && e.Y < rectangle.Y)
                {
                    label.Location = new Point(rectangle.X, e.Y);
                }
                else if (e.X < rectangle.X && e.Y < rectangle.Y)
                {
                    label.Location = new Point(e.X, e.Y);
                }
                else
                {
                    label.Location = new Point(e.X, rectangle.Y);
                }

                if (e.X - rectangle.X <= 10 || e.Y - rectangle.Y <= 10)
                {
                    MessageBox.Show("Невозможно создать объект меньше чем 10х10", "Ошибка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    //заполнение опций нового статика
                    label.Size = new Size(e.X - rectangle.X, e.Y - rectangle.Y);
                    label.Text = $"{Rectangle.number}";
                    label.BackColor = Color.DarkOliveGreen;
                    label.FlatStyle = FlatStyle.Flat;

                    Controls.Add(label); //Добавление нвого статика в коллекцию элементов управления.
                    Text = $"Объект номер №{label.Text} - создан!";
                    label.MouseClick += Form1_MouseClick; //подписываем на два события для статика
                    label.MouseDoubleClick += Form1_MouseDoubleClick;
                }
            }
            else
            {
                MessageBox.Show("Для создания объекта нажмите левую кнопку мыши", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rectangle = new Rectangle(e.X, e.Y);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $"Объект №{item.Text} | Площадь: {item.Width * item.Height} | Х: {item.Location.X} | Y: {item.Location.Y}";
                    }
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numLabel = Rectangle.number;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (numLabel == Convert.ToInt32(item.Text))
                    {
                        Text = $"№{item.Text} объект - удалён!";
                        Controls.Remove(item);
                        item.MouseClick -= Form1_MouseClick;
                        item.MouseDoubleClick -= Form1_MouseDoubleClick;
                    }
                }
            }
        }
    }

    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int number { get; set; }

        public Rectangle(int x, int y)
        {
            X = x;
            Y = y;
            number++;
        }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


}
