using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GoToCSharpStud;

namespace WinForm_Study3
{
    public partial class Form1 : Form
    {
        private TreeView tree;
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            
            students = new List<Student>
            {
                new Student
                {
                    FirstName = "Федор",
                    LastName = "Фролов",
                    BirthDay = new DateTime(1990, 10, 19),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 923456
                    },
                },
             new Student
             {
                 FirstName = "Ирина",
                 LastName = "Никанорова",
                 BirthDay = new DateTime(1991, 10, 12),
                 StudentCard = new StudentCard
                 {
                     Series = "AB",
                     Number = 223456
                 },
             },
             new Student
             {
                 FirstName = "Игорь",
                 LastName = "Николаев",
                 BirthDay = new DateTime(1989, 8, 10),
                 StudentCard = new StudentCard
                 {
                     Series = "AC",
                     Number = 123454
                 },
             },
             new Student
             {
                 FirstName = "Ольга",
                 LastName = "Сидорова",
                 BirthDay = new DateTime(1988, 4, 13),
                 StudentCard = new StudentCard
                 {
                     Series = "BC",
                     Number = 123450
                 },
             }
            };

            foreach (var student in students)
            {
                ListViewItem i = new ListViewItem(student.LastName);
                i.SubItems.Add(student.FirstName);
                i.SubItems.Add(student.BirthDay.ToShortDateString());
                i.SubItems.Add(student.StudentCard.Number.ToString());
                i.SubItems.Add(student.StudentCard.Series);

                listView1.Items.Add(i);
            }




            contextMenuStrip1.ForeColor = Color.Aquamarine;

            TreeNode node = new TreeNode("Академия");
            node.Nodes.Add(new TreeNode("Группы"));
            node.Nodes.Add(new TreeNode("Преподаватели"));

            treeView1.Nodes.Add(node);
            treeView1.Nodes.Add(new TreeNode("Академия 3"));
            treeView2.Nodes.Add(new TreeNode("Продукты"));
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "Добавление";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                tree.SelectedNode.Nodes.Add(form2.MyName);
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            tree = treeView1;
        }

        private void treeView2_Click(object sender, EventArgs e)
        {
            tree = treeView2;
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "Редактирование";
            form2.MyName = tree.SelectedNode.Text;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                tree.SelectedNode.Text = form2.MyName;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.SelectedNode.Remove();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 3)
            {
                //students.Sort();
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItems, DragDropEffects.Copy);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat));
        }




        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            listBox3.Items.Add(e.Data.GetData(DataFormats.StringFormat));
        }

        private void listBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            listBox4.DoDragDrop(listBox4.SelectedItems, DragDropEffects.Copy);
        }
    }
}
