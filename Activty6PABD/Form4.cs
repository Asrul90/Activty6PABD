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
    public partial class Form4 : Form
    {
        private string stringConnection = "data source=BIBLE\\SQLEXPRESS;" + "database=ProdiTI;User ID=sa;Password=AS0203rul";
        private SqlConnection koneksi;
        

        private void refreshform()
        {
            cbxNAMA.Enabled = false;
            cbxSTATUSMAHASISWA.Enabled = false;
            cbxTAHUNMASUK.Enabled = false;
            cbxNAMA.SelectedIndex = -1;
            cbxSTATUSMAHASISWA.SelectedIndex = -1;
            cbxTAHUNMASUK.SelectedIndex = -1;
            txtNIM.Visible = false;
            SAVE.Enabled = false;
            CLEAR.Enabled = false;
            ADD.Enabled = false;
        }
        public Form4()
        {
            InitializeComponent();
            koneksi= new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
            koneksi.Close();
        }

        private void cbNAMA()
        {
            koneksi.Open();
            string str = "select nama_mahasiswa from dbo.mahasiswa where " +
                "not EXIST(select id_status from dbo.status_mahasiswa where " +
                "status_mahasiswa.nim = mahasiswa.nim)";
            SqlCommand cmd= new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet(); 
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxNAMA.DisplayMember = "nama_mahasiswa";
            cbxNAMA.ValueMember= "NIM";
            cbxNAMA.DataSource= ds.Tables[0];
        }

        private void cbTAHUNMASUK()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxTAHUNMASUK.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    cbxTAHUNMASUK.Items.Add(l.ToString());
                }
            }
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxNAMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nim = "";
            string strs = "select NIm from dbo.mahasiswa where nama_mahasiswa = @nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nm", cbxNAMA.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nim = dr["NIM"].ToString();
            }
            dr.Close();
            koneksi.Close();

            txtNIM.Text = nim;
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            dataGridView();
            OPEN.Enabled=false;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            cbxTAHUNMASUK.Enabled = true;
            cbxNAMA.Enabled = true;
            cbxSTATUSMAHASISWA.Enabled = true;
            txtNIM.Visible = true;
            cbTAHUNMASUK();
            cbNAMA();
            CLEAR.Enabled = true;
            SAVE.Enabled = true;
            ADD.Enabled = false;

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            string nim = txtNIM.Text;
            string statusMahasiswa = cbxSTATUSMAHASISWA.Text;
            string tahunMasuk = cbxTAHUNMASUK.Text;
            int count = 0;
            string tempKodeStatus = "";
            string KodeStatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo. status_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();
            if (count == 0)
            {
                KodeStatus = "1";
            }
            else
            {
                string queryStrings = "select max (id-status) from dbo.status_mahasiswa";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalKodeStatusInt = totalStatusMahasiswa + 1;
                KodeStatus = Convert.ToString(finalKodeStatusInt);
            }
            string queryString = "insert into dbo.status_mahasiswa (id_status, nim" +
                "status_mahasiswa, tahun_masuk)" + "values(@ids, @NIM, @sm, @tm)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("ids", KodeStatus));
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("sm", statusMahasiswa));
            cmd.Parameters.Add(new SqlParameter("tm", tahunMasuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxTAHUNMASUK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
