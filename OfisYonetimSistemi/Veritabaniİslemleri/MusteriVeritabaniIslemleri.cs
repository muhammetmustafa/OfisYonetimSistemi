using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfisYonetimSistemi.Modeller;

namespace OfisYonetimSistemi.Veritabaniİslemleri
{
    public class MusteriVeritabaniIslemleri
    {
        public static List<Musteri> TumunuListele()
        {
            const string sorgu = @"
SELECT 
    [Id],
    [OlusturulmaTarihi],
    [AktifMi],
    [Ad],
    [Soyad],
    [Telefon],
    [KimlikNo],
    [Email]
FROM dbo.Musteriler
";
            var list = new List<Musteri>();

            using (var connection = new SqlConnection(GlobalAyarlar.BaglantiAdresi))
            {
                var command = new SqlCommand(sorgu, connection);
                
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var musteri = new Musteri();
                        musteri.Id = reader.GetInt32(0);
                        musteri.OlusturulmaTarihi = reader.GetDateTime(1);
                        musteri.AktifMi = reader.GetBoolean(2);
                        musteri.Ad = reader.GetString(3);
                        musteri.Soyad = reader.GetString(4);
                        musteri.Telefon = reader.GetString(5);
                        musteri.KimlikNo = reader.GetString(6);
                        musteri.Email = reader.GetString(7);

                        list.Add(musteri);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return list;
        }

        public static Musteri DetayAl(int musteriId)
        {
            const string sorgu = @"
SELECT TOP 1
    [Id],
    [OlusturulmaTarihi],
    [AktifMi],
    [Ad],
    [Soyad],
    [Telefon],
    [KimlikNo],
    [Email]
FROM dbo.Musteriler
WHERE Id = @MusteriId
";
            using (var connection = new SqlConnection(GlobalAyarlar.BaglantiAdresi))
            {
                var command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("MusteriId", musteriId);

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var musteri = new Musteri();
                        musteri.Id = reader.GetInt32(0);
                        musteri.OlusturulmaTarihi = reader.GetDateTime(1);
                        musteri.AktifMi = reader.GetBoolean(2);
                        musteri.Ad = reader.GetString(3);
                        musteri.Soyad = reader.GetString(4);
                        musteri.Telefon = reader.GetString(5);
                        musteri.KimlikNo = reader.GetString(6);
                        musteri.Email = reader.GetString(7);

                        return musteri;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return null;
        }


        public static bool Yeni(Musteri musteri)
        {
            const string sorgu = @"

INSERT INTO dbo.Musteriler
(
    [OlusturulmaTarihi] ,
    [AktifMi]           ,
    [Ad]                ,
    [Soyad]             ,
    [Telefon]           ,
    [KimlikNo]          ,
    [Email]             
)
VALUES
(
    @OlusturulmaTarihi ,
    @AktifMi           ,
    @Ad                ,
    @Soyad             ,
    @Telefon           ,
    @KimlikNo          ,
    @Email             
)

SELECT CAST(SCOPE_IDENTITY() AS INT)
";

            using (var connection = new SqlConnection(GlobalAyarlar.BaglantiAdresi))
            {
                var command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("OlusturulmaTarihi", DateTime.Now);
                command.Parameters.AddWithValue("AktifMi", musteri.AktifMi);
                command.Parameters.AddWithValue("Ad", musteri.Ad);
                command.Parameters.AddWithValue("Soyad", musteri.Soyad);
                command.Parameters.AddWithValue("Telefon", musteri.Telefon);
                command.Parameters.AddWithValue("KimlikNo", musteri.KimlikNo);
                command.Parameters.AddWithValue("Email", musteri.Email);

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        musteri.Id = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (musteri.Id > 0)
                return true;

            return false;
        }

        public static bool Guncelle(Musteri musteri)
        {
            const string sorgu = @"

UPDATE dbo.Musteriler
    SET AktifMi = @AktifMi,
        Ad = @Ad,
        Soyad = @Soyad,
        Telefon = @Telefon,
        KimlikNo = @KimlikNo,
        Email = @Email
WHERE Id = @Id
";

            using (var connection = new SqlConnection(GlobalAyarlar.BaglantiAdresi))
            {
                var command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("Id", musteri.Id);
                command.Parameters.AddWithValue("AktifMi", musteri.AktifMi);
                command.Parameters.AddWithValue("Ad", musteri.Ad);
                command.Parameters.AddWithValue("Soyad", musteri.Soyad);
                command.Parameters.AddWithValue("Telefon", musteri.Telefon);
                command.Parameters.AddWithValue("KimlikNo", musteri.KimlikNo);
                command.Parameters.AddWithValue("Email", musteri.Email);

                try
                {
                    connection.Open();
                    var sonuc = command.ExecuteNonQuery();
                    return sonuc > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return false;
        }

        public static bool Sil(int musteriId)
        {
            const string sorgu = @"

DELETE FROM dbo.Musteriler
WHERE Id = @Id
";

            using (var connection = new SqlConnection(GlobalAyarlar.BaglantiAdresi))
            {
                var command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("Id", musteriId);

                try
                {
                    connection.Open();
                    var sonuc = command.ExecuteNonQuery();
                    return sonuc > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return false;
        }
    }
}