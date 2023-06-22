using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activty6PABD
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=BIBLE\\SQLEXPRESS;" + "database=ProdiTI;User ID=sa;Password=AS0203rul";
        private SqlConnection koneksi;
        

        private void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            OPEN.Enabled = false;
            CLEAR.Enabled = false;
        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection();
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            dataGridView();
            OPEN.Enabled = false;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            nmp.Enabled= true;
            SAVE.Enabled = true;
            CLEAR.Enabled = true;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;
            if (nmProdi == "")
            {
                MessageBox.Show("masukkan nama prodi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (nama_prodi)" + "values(@id)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("data berhasil disimpan", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }
    }
}
