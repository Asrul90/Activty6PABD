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
    
    public partial class FormDataMahasiswa : Form
    {
        private string stringConnection = "data source=BIBLE\\SQLEXPRESS;" + "database=ProdiTI;User ID=sa;Password=AS0203rul";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource= new BindingSource();
        

        private void Form3_load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter= new SqlDataAdapter(new SqlCommand("select m.nim m.nama_mahasiswa," +
                "m.alamat, m.jenis_kel, m.tgl_lahir, p.nama_prodi from dbo.mahasiswa m " +
                "join dbo.prodi p on m.id_prodi", koneksi));
            DataSet ds = new DataSet(); 
            dataAdapter.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNIM.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "NIM", true));
            this.txtNAMA.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtALAMAT.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cbxJENISKELAMIN.DataBindings.Add(new Binding("Text", this.customersBindingSource, "jenis kel", true));
            this.dtTANGALLAHIR.DataBindings.Add(new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbxPRODI.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNAMA.DataBindings.Clear();
            this.txtALAMAT.DataBindings.Clear();
            this.cbxJENISKELAMIN.DataBindings.Clear();
            this.dtTANGALLAHIR.DataBindings.Clear();
            this.cbxPRODI.DataBindings.Clear();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNAMA.Text = "";
            txtALAMAT.Text = "";
            dtTANGALLAHIR.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNAMA.Enabled = true;
            cbxJENISKELAMIN.Enabled = true;
            txtALAMAT.Enabled = true;
            dtTANGALLAHIR.Enabled= true;
            cbxPRODI.Enabled= true;
            Prodicbx();
            btnSAVE.Enabled = true;
            btnCLEAR.Enabled = true;
            btnADD.Enabled = true;

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text;
            nama= txtNAMA.Text;
            jk = cbxJENISKELAMIN.Text;
            alamat = txtALAMAT.Text;
            tgl = dtTANGALLAHIR.Value;
            prodi = cbxPRODI.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_prodi from dbo.prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType= CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", prodi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_prodi"].ToString());
            }
            dr.Close();
            string str = "insert intp dbo.mahasiswa (nim, nama_mahasiswa, jenis_kelamin, alamat, tgl_lahir, id_prodi)" + "values(@NIM, @jk, @Tgl, @id";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("Nm", nama));
            cmd.Parameters.Add(new SqlParameter("jk", jk));
            cmd.Parameters.Add(new SqlParameter("AL", alamat));
            cmd.Parameters.Add(new SqlParameter("Tgl", tgl));
            cmd.Parameters.Add(new SqlParameter("Idp", prodi));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "suksess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();


        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void refreshform()
        {
            txtNIM.Enabled= false;
            txtNAMA.Enabled= false;
            cbxJENISKELAMIN.Enabled= false;
            txtALAMAT.Enabled= false;
            dtTANGALLAHIR.Enabled= false;
            cbxPRODI.Enabled= false;
            btnADD.Enabled= false;
            btnSAVE.Enabled= false;
            btnCLEAR.Enabled= false;
            clearBinding();
            Form3_load();
        }

        public FormDataMahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection();
            this.bnMahasiswa.BindingSource = this.customersBindingSource;
            refreshform();

        }

        private void Prodicbx()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxPRODI.DisplayMember = "nama_prodi";
            cbxPRODI.ValueMember= "id_prodi";
            cbxJENISKELAMIN.DataSource= ds.Tables[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
