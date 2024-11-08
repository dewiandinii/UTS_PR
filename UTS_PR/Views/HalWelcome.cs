using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_PR.Views
{
    public partial class HalWelcome : Form
    {
        public HalWelcome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalTugas halTugas = new HalTugas();

            //if (halTugas.ShowDialog() == DialogResult.OK)
            //{
            //    LoadDataHalTugas();
            //}

            //this.Show()
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    LoadDataHalTugas();
        //}

        //private void LoadDataHalTugas()
        //{
        //    try
        //    {
        //        dataGridView1.AllowUserToAddRows = false;

        //        DataTable mahasiswaData = dataAkunContext.All();
        //        if (mahasiswaData == null)
        //        {
        //            MessageBox.Show("Error: Gagal mengambil data mahasiswa");
        //            return;
        //        }

        //        dataGridView1.Columns.Clear();

        //        DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
        //        nomorColumn.HeaderText = "No";
        //        nomorColumn.Name = "nomor";
        //        dataGridView1.Columns.Add(nomorColumn);

        //        dataGridView1.DataSource = mahasiswaData;

        //        if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].Visible = false;
        //        if (dataGridView1.Columns["judul"] != null)
        //            dataGridView1.Columns["judul"].HeaderText = "Judul";
        //        if (dataGridView1.Columns["deskripsi"] != null)
        //            dataGridView1.Columns["deskripsi"].HeaderText = "Deskripsi";


        //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //        {
        //            dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
        //        }
        //}
    }
}
