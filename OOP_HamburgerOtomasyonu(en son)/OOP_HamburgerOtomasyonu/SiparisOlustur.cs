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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        string secilenEkstralar = "";
        decimal toplamFiyat = 0;
        decimal menuFiyat = 0;
        decimal ekstraFiyat = 0;
        decimal siparisFiyati = 0;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {

            cmbMenu.DataSource = Hamburger.menuler.ToList();

            foreach (Ekstra ekstra1 in Ekstra.ekstralar)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = ekstra1.EkstraAdi;
                flwEkstra.Controls.Add(checkBox);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Hamburger menu = new Hamburger();
            menu = (Hamburger)cmbMenu.SelectedItem;

            if (nudAdet.Value > 0)
            {
                if (rbKucuk.Checked)
                {
                    menuFiyat = menu.MenuFiyat;
                    menu.MenuBoy = MenuBoy.Kucuk;
                }
                else if (rbOrta.Checked)
                {
                    menuFiyat = menu.MenuFiyat + 2;
                    menu.MenuBoy = MenuBoy.Orta;
                }
                else if (rbBuyuk.Checked)
                {
                    menuFiyat = menu.MenuFiyat + 5;
                    menu.MenuBoy = MenuBoy.Buyuk;
                }

                foreach (Control control in flwEkstra.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;

                        foreach (Ekstra ekstra1 in Ekstra.ekstralar)
                        {
                            if (checkBox.Checked)
                            {
                                if (checkBox.Text == ekstra1.EkstraAdi)
                                {
                                    ekstraFiyat += ekstra1.Fiyat;
                                    secilenEkstralar += ekstra1 + " ";
                                    Siparis.ekstralar.Add(ekstra1);
                                }
                            }
                        }
                    }
                }
                menu.Adet = Convert.ToInt32(nudAdet.Value);

                siparisFiyati = (menuFiyat + ekstraFiyat) * menu.Adet;
                toplamFiyat += siparisFiyati;

                listBox1.Items.Add($"{menu.MenuAdi} {menu.MenuBoy} ({secilenEkstralar}) {siparisFiyati}");
                lblToplamTutar.Text = toplamFiyat.ToString();

                Siparis.Ciro += toplamFiyat;
                Siparis.ToplamSiparisSayisi += listBox1.Items.Count;
                Siparis.EkstraMalzemeGeliri += ekstraFiyat;
            }
            else
            {
                MessageBox.Show("Lütfen menü adedi giriniz!");
            }
            ekstraFiyat = 0;
            secilenEkstralar = "";
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Sayısı: " + listBox1.Items.Count + "\nToplam Sipariş Tutarı:" + toplamFiyat.ToString("C2") + "\nSiparişi Tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Temizle();
            }
            
        }
        private void Temizle()
        {
            toplamFiyat = 0;
            secilenEkstralar = "";
            lblToplamTutar.Text = "0";

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    comboBox.SelectedItem = null;
                }
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;

                    foreach (Control gbxControl in groupBox.Controls)
                    {
                        if (gbxControl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)gbxControl;

                            rb.Checked = false;
                        }
                    }
                }
                if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flw = (FlowLayoutPanel)control;

                    foreach (Control flwControl in flw.Controls)
                    {
                        if (flwControl is CheckBox)
                        {
                            CheckBox cb = (CheckBox)flwControl;

                            cb.Checked = false;
                        }
                    }
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)control;

                    nud.Value = 0;
                }
                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;

                    listBox.Items.Clear();
                }
            }
        }
    }
}
