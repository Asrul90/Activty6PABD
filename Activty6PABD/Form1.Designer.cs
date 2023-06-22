namespace Activty6PABD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dATAPRODIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAMAHASISWAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATASTATUSMAHASISWAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Data Master";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATAPRODIToolStripMenuItem,
            this.dATAMAHASISWAToolStripMenuItem,
            this.dATASTATUSMAHASISWAToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton1.Text = "Data Master";
            // 
            // dATAPRODIToolStripMenuItem
            // 
            this.dATAPRODIToolStripMenuItem.Name = "dATAPRODIToolStripMenuItem";
            this.dATAPRODIToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.dATAPRODIToolStripMenuItem.Text = "DATA PRODI";
            this.dATAPRODIToolStripMenuItem.Click += new System.EventHandler(this.dATAPRODIToolStripMenuItem_Click_1);
            // 
            // dATAMAHASISWAToolStripMenuItem
            // 
            this.dATAMAHASISWAToolStripMenuItem.Name = "dATAMAHASISWAToolStripMenuItem";
            this.dATAMAHASISWAToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.dATAMAHASISWAToolStripMenuItem.Text = "DATA MAHASISWA";
            this.dATAMAHASISWAToolStripMenuItem.Click += new System.EventHandler(this.dATAMAHASISWAToolStripMenuItem_Click);
            // 
            // dATASTATUSMAHASISWAToolStripMenuItem
            // 
            this.dATASTATUSMAHASISWAToolStripMenuItem.Name = "dATASTATUSMAHASISWAToolStripMenuItem";
            this.dATASTATUSMAHASISWAToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.dATASTATUSMAHASISWAToolStripMenuItem.Text = "DATA STATUS MAHASISWA";
            this.dATASTATUSMAHASISWAToolStripMenuItem.Click += new System.EventHandler(this.dATASTATUSMAHASISWAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem dATAPRODIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATAMAHASISWAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASTATUSMAHASISWAToolStripMenuItem;
    }
}

