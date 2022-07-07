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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKategori form1 = new FrmKategori();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik();
            frmİstatistik.Show();
        }
    }
}
