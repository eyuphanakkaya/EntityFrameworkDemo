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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityProductEntities Db = new DbEntityProductEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            lblKategori.Text = Db.Kategori.Count().ToString();
            lblUrun.Text = Db.Urun.Count().ToString();
            lblAktifMusteri.Text = Db.Musteri.Count(x => x.Durum == true).ToString();
            lblPasifMusteri.Text = Db.Musteri.Count(x => x.Durum == false).ToString();
            lblStok.Text = Db.Urun.Sum(x => x.Stok).ToString();
            lblYüksekFiyatUrun.Text = (from x in Db.Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            lblDusukFiyatUrun.Text = (from x in Db.Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            lblKasaTutar.Text = Db.Satis.Sum(x =>x.Fiyat).ToString();
            lblBeyazEsya.Text = Db.Urun.Count(x => x.Kategori == 2).ToString();
            lblSehir.Text = (from x in Db.Musteri select x.Sehir).Distinct().Count().ToString();
        }
    }
}
