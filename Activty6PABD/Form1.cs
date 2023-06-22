using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activty6PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dATAPRODIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dATAPRODIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 fm = new Form2(); 
            fm.Show();
            this.Hide();
        }

        private void dATAMAHASISWAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMahasiswa form= new FormDataMahasiswa();
            form.Show();
            this.Hide();
        }

        private void dATASTATUSMAHASISWAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr= new Form4();
            fr.Show();
            this.Hide();
        }
    }
}
