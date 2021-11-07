using System;

namespace OfisYonetimSistemi.Modeller
{
    public class Musteri : TemelModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string KimlikNo { get; set; }
        public string Email { get; set; }
    }
}