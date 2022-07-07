using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        DbEntityProductEntities Db = new DbEntityProductEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Urun.ToList();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in Db.Urun
                                        select new 
                                        { 
                                        x.UrunAd,
                                        x.Marka,
                                        x.Stok,
                                        x.Fiyat,
                                        x.Kategori1.KategoriAd,
                                        x.Durum
                                        }).ToList();

            var Kategoriler = (from x in Db.Kategori
                               select new
                               {
                                   x.KategoriId,
                                   x.KategoriAd
                               }).ToList();
            comboBoxKategori.ValueMember = "KategoriId";
            comboBoxKategori.DisplayMember = "KategoriAd";
            comboBoxKategori.DataSource = Kategoriler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFiyat.Text = "";
            txtId.Text = "";
            txtMarka.Text = "";
            txtUrunAd.Text = "";
            TxtDurum.Text = "";
            txtStok.Text = "";
            comboBoxKategori.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAd = txtUrunAd.Text;
            urun.Marka = txtMarka.Text;
            urun.Stok = short.Parse(txtStok.Text);
            urun.Fiyat = decimal.Parse(txtFiyat.Text);
            urun.Durum = bool.Parse(TxtDurum.Text);
            urun.Kategori = int.Parse(comboBoxKategori.SelectedValue.ToString());
            Db.Urun.Add(urun);
            Db.SaveChanges();
            MessageBox.Show("Ürün Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            var Urunler = Db.Urun.Find(Id);
            Db.Urun.Remove(Urunler);
            Db.SaveChanges();
            MessageBox.Show("Urun Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            var Urunler = Db.Urun.Find(Id);
            Urunler.UrunAd = txtUrunAd.Text;
            Urunler.Marka = txtMarka.Text;
            Urunler.Stok = short.Parse(txtStok.Text);
            Urunler.Fiyat = decimal.Parse(txtFiyat.Text);
            Urunler.Durum = bool.Parse(TxtDurum.Text);
            Urunler.Kategori = int.Parse(comboBoxKategori.SelectedValue.ToString());
            Db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = comboBoxKategori.SelectedValue.ToString();
        }
    }
}
