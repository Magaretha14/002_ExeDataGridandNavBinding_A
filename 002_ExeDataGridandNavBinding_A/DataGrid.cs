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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;

            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Teal;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            this.dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;
            this.dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormDataGrid().Show();
            this.Close();
        }
    }
}
