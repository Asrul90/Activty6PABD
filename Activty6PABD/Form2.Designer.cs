namespace Activty6PABD
{
    partial class Form2
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
            this.OPEN = new System.Windows.Forms.Button();
            this.nmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(641, 127);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(120, 21);
            this.OPEN.TabIndex = 1;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(304, 325);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(158, 22);
            this.nmp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAMA PRODI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(304, 373);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(70, 21);
            this.SAVE.TabIndex = 4;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(486, 326);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(63, 21);
            this.ADD.TabIndex = 5;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(394, 373);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(68, 22);
            this.CLEAR.TabIndex = 6;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "DATA PRODI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button button1;
    }
}