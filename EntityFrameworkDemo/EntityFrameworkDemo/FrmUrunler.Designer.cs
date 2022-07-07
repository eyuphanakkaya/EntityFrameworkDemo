
namespace EntityFrameworkDemo
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urun Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kategori:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(513, 31);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(117, 41);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(513, 87);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 41);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(513, 151);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 41);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(513, 208);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 41);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(513, 268);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 41);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 27);
            this.txtId.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(150, 75);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(160, 27);
            this.txtUrunAd.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(149, 117);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(161, 27);
            this.txtMarka.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(150, 197);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(160, 27);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(150, 161);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(160, 27);
            this.txtStok.TabIndex = 4;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(150, 230);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(160, 27);
            this.TxtDurum.TabIndex = 6;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(150, 268);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(160, 28);
            this.comboBoxKategori.TabIndex = 7;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 197);
            this.dataGridView1.TabIndex = 19;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}