namespace Activty6PABD
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNAMA = new System.Windows.Forms.ComboBox();
            this.cbxSTATUSMAHASISWA = new System.Windows.Forms.ComboBox();
            this.cbxTAHUNMASUK = new System.Windows.Forms.ComboBox();
            this.ADD = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.OPEN = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAMA MAHASISWA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMOR INDUK MAHASISWA      ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "STATUS MAHASISWA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TAHUN MASUK";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxNAMA
            // 
            this.cbxNAMA.FormattingEnabled = true;
            this.cbxNAMA.Location = new System.Drawing.Point(386, 280);
            this.cbxNAMA.Name = "cbxNAMA";
            this.cbxNAMA.Size = new System.Drawing.Size(174, 24);
            this.cbxNAMA.TabIndex = 5;
            this.cbxNAMA.SelectedIndexChanged += new System.EventHandler(this.cbxNAMA_SelectedIndexChanged);
            // 
            // cbxSTATUSMAHASISWA
            // 
            this.cbxSTATUSMAHASISWA.FormattingEnabled = true;
            this.cbxSTATUSMAHASISWA.Location = new System.Drawing.Point(386, 352);
            this.cbxSTATUSMAHASISWA.Name = "cbxSTATUSMAHASISWA";
            this.cbxSTATUSMAHASISWA.Size = new System.Drawing.Size(174, 24);
            this.cbxSTATUSMAHASISWA.TabIndex = 6;
            this.cbxSTATUSMAHASISWA.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbxTAHUNMASUK
            // 
            this.cbxTAHUNMASUK.FormattingEnabled = true;
            this.cbxTAHUNMASUK.Location = new System.Drawing.Point(386, 402);
            this.cbxTAHUNMASUK.Name = "cbxTAHUNMASUK";
            this.cbxTAHUNMASUK.Size = new System.Drawing.Size(174, 24);
            this.cbxTAHUNMASUK.TabIndex = 7;
            this.cbxTAHUNMASUK.SelectedIndexChanged += new System.EventHandler(this.cbxTAHUNMASUK_SelectedIndexChanged);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(587, 280);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 24);
            this.ADD.TabIndex = 8;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(587, 352);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 24);
            this.CLEAR.TabIndex = 9;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(587, 402);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 24);
            this.SAVE.TabIndex = 10;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(686, 85);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(75, 23);
            this.OPEN.TabIndex = 11;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(383, 322);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 12;
            this.txtNIM.Text = "txtNIM";
            this.txtNIM.Click += new System.EventHandler(this.label5_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(12, 415);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 13;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.cbxTAHUNMASUK);
            this.Controls.Add(this.cbxSTATUSMAHASISWA);
            this.Controls.Add(this.cbxNAMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "DATA STATUS MAHASISWA";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNAMA;
        private System.Windows.Forms.ComboBox cbxSTATUSMAHASISWA;
        private System.Windows.Forms.ComboBox cbxTAHUNMASUK;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Button Close;
    }
}