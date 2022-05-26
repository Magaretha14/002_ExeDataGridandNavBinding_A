using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_ExeDataGridandNavBinding_A
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new DataGrid().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new DataBinding().Show();
            this.Hide();
        }
    }
}
