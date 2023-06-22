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
        private string stringConnection = "Data Source=BIBLE\\SQLEXPRESS;Initial Catalog=Activity6PABD;User ID=sa;Password=AS0203rul";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();



        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNAMA.DataBindings.Clear();
            this.txtALAMAT.DataBindings.Clear();
            this.comboBox1.DataBindings.Clear();
            this.dtTANGALLAHIR.DataBindings.Clear();
            this.cbxPRODI.DataBindings.Clear();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            dtTANGALLAHIR.Value = DateTime.Now;
            cbxPRODI.Enabled = true;
            Prodicbx();

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text;
            nama= txtNAMA.Text;
            jk = comboBox1.Text;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            txtNIM.Enabled= false;
            txtNAMA.Enabled= false;
            comboBox1.Enabled= false;
            txtALAMAT.Enabled= false;
            dtTANGALLAHIR.Enabled= false;
            cbxPRODI.Enabled= false;
            btnADD.Enabled= true;
            btnSAVE.Enabled= false;
            btnCLEAR.Enabled= false;
            clearBinding();
           
        }

        public FormDataMahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
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
            comboBox1.DataSource= ds.Tables[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT nim, nama_mahasiswa, jenis_kelamin, alamat, tgl_lahir, id_prodi FROM mahasiswa", koneksi));
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNIM.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "NIM", true));
            this.txtNAMA.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtALAMAT.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.comboBox1.DataBindings.Add(new Binding("Text", this.customersBindingSource, "jenis_kelamin", true));
            this.dtTANGALLAHIR.DataBindings.Add(new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbxPRODI.DataBindings.Add(new Binding("Text", this.customersBindingSource, "id_prodi", true));
        }
    }
}
