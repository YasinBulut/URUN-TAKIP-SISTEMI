namespace Proje_4
{
    partial class FrmAnaForm
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
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(30, 55);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(164, 135);
            this.btnkategori.TabIndex = 0;
            this.btnkategori.Text = "Kategori İşlemleri";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnurun
            // 
            this.btnurun.Location = new System.Drawing.Point(220, 55);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(163, 135);
            this.btnurun.TabIndex = 1;
            this.btnurun.Text = "Ürün İşlemleri";
            this.btnurun.UseVisualStyleBackColor = true;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(406, 55);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(171, 135);
            this.btnistatistik.TabIndex = 2;
            this.btnistatistik.Text = "İstatistikler";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(619, 260);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.btnurun);
            this.Controls.Add(this.btnkategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.Button btnistatistik;
    }
}