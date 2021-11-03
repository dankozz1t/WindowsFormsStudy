using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsTask_Rectangles
{
    public partial class Form1 : Form
    {
        private Object _object;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;

                //определение позиции обьекта в зависимости с какой стороны его начали расовать
                if (e.X > _object.X && e.Y > _object.Y)
                    label.Location = new Point(_object.X, _object.Y);
                else if (e.X > _object.X && e.Y < _object.Y)
                    label.Location = new Point(_object.X, e.Y);
                else if (e.X < _object.X && e.Y < _object.Y)
                    label.Location = new Point(e.X, e.Y);
                else
                    label.Location = new Point(e.X, _object.Y);
                

                if (e.X - _object.X <= 10 || e.Y - _object.Y <= 10)
                {
                    MessageBox.Show("Невозможно создать объект меньше чем 10х10", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label.Size = new Size(e.X - _object.X, e.Y - _object.Y);
                    label.Text = $"{Object.number}";
                    label.BackColor = Color.DarkOliveGreen;
                    label.FlatStyle = FlatStyle.Flat;

                    Controls.Add(label); //Добавление нвого обьекта в коллекцию элементов управления.
                    Text = $"Объект номер №{label.Text} - создан!";

                    label.MouseClick += Form1_MouseClick; 
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
                _object = new Object(e.X, e.Y);
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
            int numLabel = Object.number;
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

    public class Object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int number { get; set; }

        public Object(int x, int y)
        {
            X = x;
            Y = y;
            number++;
        }

    }


}
