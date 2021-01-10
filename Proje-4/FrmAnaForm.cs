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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            FrmKategori frk = new FrmKategori();
            frk.Show();
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            FrmUrun fru = new FrmUrun();
            fru.Show();
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fri = new Frmİstatistik();
            fri.Show();
        }
    }
}
