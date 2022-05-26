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
    public partial class Login : Form
    {
        readonly string Username = "MagarethaWS";
        readonly string Password = "Put1414";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textUsername.Text == Username && textPassword.Text == Password)
            {
                new MainMenu().Show();
                this.Hide();
            }
            else if (textUsername.Text == "" && textPassword.Text == "")
            {
                MessageBox.Show("Anda belum mengisi username dan password. Username = MagarethaWS, Password = Put1414");
            }
            else if (textUsername.Text == Username && textPassword.Text == "")
            {
                MessageBox.Show("Password Salah");
            }
            else if (textUsername.Text == "" && textPassword.Text == Password)
            {
                MessageBox.Show("Username Salah");
            }
            else
            {
                MessageBox.Show("Username dan Password Salah. Username = MagarethaWS, Password = Put1414 ");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
                textPassword.Focus();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
