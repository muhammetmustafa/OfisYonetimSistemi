using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfisYonetimSistemi.Modeller;
using OfisYonetimSistemi.Veritabaniİslemleri;

namespace OfisYonetimSistemi.Ekranlar
{
    public partial class MusteriDetayEkrani : Form
    {
        private int _id;

        public MusteriDetayEkrani()
        {
            InitializeComponent();
        }

        public MusteriDetayEkrani(int id)
        {
            InitializeComponent();

            _id = id;
        }

        private void MusteriDetayEkrani_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                var musteri = MusteriVeritabaniIslemleri.DetayAl(_id);
                if (musteri == null)
                {
                    MessageBox.Show("Müşteri bulunamadı");
                    return;
                }

                cbAktifMi.Checked = musteri.AktifMi;
                txtAd.Text = musteri.Ad;
                txtSoyad.Text = musteri.Soyad;
                txtTelefon.Text = musteri.Telefon;
                txtKimlikNo.Text = musteri.KimlikNo;
                txtEmail.Text = musteri.Email;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var musteri = new Musteri();
            musteri.Id = _id;
            musteri.AktifMi = cbAktifMi.Checked;
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtTelefon.Text;
            musteri.KimlikNo = txtKimlikNo.Text;
            musteri.Email = txtEmail.Text;
            
            if (musteri.Id <= 0)
            {
                //insert e gidecek
                var sonuc = MusteriVeritabaniIslemleri.Yeni(musteri);
                if (sonuc)
                {
                    AutoClosingMessageBox.Show("Kayıt başarılı");
                }
                _id = musteri.Id;
            }
            else
            {
                var sonuc = MusteriVeritabaniIslemleri.Guncelle(musteri);
                if (sonuc)
                {
                    AutoClosingMessageBox.Show("Güncelleme başarılı");
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cbAktifMi.Checked = true;
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtTelefon.Text = null;
            txtKimlikNo.Text = null;
            txtEmail.Text = null;
        }
    }
}
