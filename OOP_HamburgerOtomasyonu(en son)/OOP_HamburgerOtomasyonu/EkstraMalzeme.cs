using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();

            ekstra.EkstraAdi = txtEkstra.Text;
            ekstra.Fiyat = nudEkstraFiyat.Value;

            Ekstra.ekstralar.Add(ekstra);

            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;
        }
    }
}
