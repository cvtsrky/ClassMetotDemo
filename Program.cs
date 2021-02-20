using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Yusuf";
            musteri1.musteriSoyadi = "Kaymaz";
            musteri1.musteriUyelikTipi = "Bireysel";
            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 3;
            musteri3.musteriAdi = "Yusuf";
            musteri3.musteriSoyadi = "Sarıkaya";
            musteri3.musteriUyelikTipi = "Kurumsal";
            Musteri musteri2 = new Musteri();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            int secim = Giris();

            switch (secim)
            {
                case 1:
                    musteriManager.Ekle(musteri2);
                    musteriManager.Listele(musteriler);
                    break;
                case 2:
                    musteriManager.Sil(musteri1);
                    musteriManager.Listele(musteriler);
                    break;
                case 3:
                    musteriManager.Listele(musteriler);                   
                    break;
                default:
                    break;
            }
        }

        static int Giris()
        {
            
            Console.WriteLine("İşlem için lütfen seçim yapınız : ");
            Console.WriteLine("Müşteri eklemek için 1 i tuşlayın! ");
            Console.WriteLine("Müşteri silmek için 2 yi tuşlayın! ");
            Console.WriteLine("Müşterileri listelemek için 3 ü tuşlayın! ");
            int secim;
            secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
    }
}
