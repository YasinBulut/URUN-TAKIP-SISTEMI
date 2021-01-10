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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            lbl1.Text = db.Tbl_Kategori.Count().ToString();
            lbl2.Text = db.Tbl_Urun.Count().ToString();
            lbl3.Text = db.Tbl_Urun.Sum(x =>x.Stok).ToString();
            lbl4.Text = db.Tbl_Musteri.Count(x => x.Durum == false).ToString();
            lbl5.Text = db.Tbl_Musteri.Count(x => x.Durum == true).ToString();
            lbl6.Text = (from x in db.Tbl_Musteri select x.MusteriSehir).Distinct().Count().ToString();
            lbl7.Text = (from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            lbl8.Text = (from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            lbl9.Text = db.Tbl_Satis.Sum(z => z.Fiyat).ToString() + " TL";
            lbl10.Text = db.MARKAGETIR().FirstOrDefault();
            lbl11.Text = db.Tbl_Urun.Count(x => x.UrunAd == "Buzdolabı").ToString();
            lbl12.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString();
        }
    }
}
