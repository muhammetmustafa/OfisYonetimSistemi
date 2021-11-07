using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfisYonetimSistemi.Veritabaniİslemleri;

namespace OfisYonetimSistemi.Ekranlar
{
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani()
        {
            InitializeComponent();
        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            btnAra_Click(null, null);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvMusteriler.Rows.Clear();

            var musterileri = MusteriVeritabaniIslemleri.TumunuListele();
            foreach (var musteri in musterileri)
            {
                dgvMusteriler.Rows.Add(musteri.Id, musteri.AktifMi, musteri.Ad, musteri.Soyad, musteri.Email);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            var musteriEkrani = new MusteriDetayEkrani();
            musteriEkrani.ShowDialog(this);

            btnAra_Click(null, null);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Müşteri seçilmemiş");
                return;
            }

            var seciliSatir = (int)dgvMusteriler.SelectedRows[0].Cells[0].Value;

            var musteriEkrani = new MusteriDetayEkrani(seciliSatir);
            musteriEkrani.ShowDialog(this);

            btnAra_Click(null, null);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Müşteri seçilmemiş");
                return;
            }

            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Ofis Yönetim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }


            foreach (DataGridViewRow dgvMusterilerSelectedRow in dgvMusteriler.SelectedRows)
            {
                var seciliSatir = (int)dgvMusterilerSelectedRow.Cells[0].Value;
                var sonuc = MusteriVeritabaniIslemleri.Sil(seciliSatir);
                if (sonuc)
                {
                    dgvMusteriler.Rows.Remove(dgvMusterilerSelectedRow);
                }
            }
        }
    }
}
