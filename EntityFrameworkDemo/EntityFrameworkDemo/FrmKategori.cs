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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbEntityProductEntities Db = new DbEntityProductEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAd = txtAd.Text;
            Db.Kategori.Add(kategori);
            Db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Kategoriler = Db.Kategori;
            dataGridView1.DataSource = Kategoriler.ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Kategori.ToList();
            txtAd.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Delete = Convert.ToInt32(txtId.Text);
            var Kategoriler = Db.Kategori.Find(Delete);
            Db.Kategori.Remove(Kategoriler);
            Db.SaveChanges();
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Update = Convert.ToInt32(txtId.Text);
            var Kategoriler = Db.Kategori.Find(Update);
            Kategoriler.KategoriAd = txtAd.Text;
            Db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }
    }
}
