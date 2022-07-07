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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        DbEntityProductEntities Db = new DbEntityProductEntities();
        private void button1_Click(object sender, EventArgs e)
        {
           
            var Admn = (from x in Db.AdminPanel where x.Kullanıcı == textBoxAdmin.Text && x.Sifre == textBoxSifre.Text select x);
            if (Admn.Any())
            {
                FrmAna frmAna = new FrmAna();
                frmAna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
