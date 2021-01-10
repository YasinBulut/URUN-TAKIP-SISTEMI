using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_4
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Urun.ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.UrunAd = txtad.Text;
            t.Marka = txtmarka.Text;
            t.Stok = short.Parse(txtstok.Text);
            t.Kategori = int.Parse(cmbkategori.SelectedValue.ToString());
            t.Fiyat = decimal.Parse(txtfiyat.Text);
            t.Durum = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtstok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.UrunAd = txtad.Text;
            urun.Stok = short.Parse(txtstok.Text);
            urun.Marka = txtmarka.Text;
            urun.Fiyat = decimal.Parse(txtfiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.KategoryId,
                                   x.KategoryAd
                               }
                             ).ToList();
            cmbkategori.ValueMember = "KategoryId";
            cmbkategori.DisplayMember = "KategoryAd";
            cmbkategori.DataSource = kategoriler;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtdurum.Text = "";
            txtfiyat.Text = "";
            txtid.Text = "";
            txtmarka.Text = "";
            txtstok.Text = "";
            cmbkategori.Text = "";
        }
    }
}
