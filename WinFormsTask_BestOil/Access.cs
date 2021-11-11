using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask_BestOil
{
    public partial class Access : Form
    {

        public Access()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxpPassword.Text == "admin")
            {
                this.Hide();
                BestOil bestOilAdmin = new BestOil(true);
                bestOilAdmin.Text = "BestOil <<ADMIN>>";
                bestOilAdmin.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                BestOil bestOilAdmin = new BestOil(false);
                bestOilAdmin.Text = "BestOil <<USER>>";
                bestOilAdmin.ShowDialog();
                this.Close();
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
