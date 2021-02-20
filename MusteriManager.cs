using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        



        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı : ");
            musteri.musteriAdi = Console.ReadLine();
            Console.WriteLine("Müşteri soyadı : ");
            musteri.musteriSoyadi = Console.ReadLine();
            Console.WriteLine("Müşteri id : ");
            musteri.musteriId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri üyelik tipi : ");
            musteri.musteriUyelikTipi = Console.ReadLine();
            Console.WriteLine("Müşteri başarıyla eklendi!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bütün müşteriler listeleniyor......");


        }
        public void Sil(Musteri musteri)
        {
            musteri.musteriAdi = null;
            musteri.musteriSoyadi = null;
            musteri.musteriId = 0;
            musteri.musteriUyelikTipi = null;
            Console.WriteLine("Müşteri başarıyla silindi!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Kalan müşteriler listeleniyor......");

        }
        public void Listele(Musteri[] musteri)
        {
            foreach (Musteri musteriler in musteri)
            {
                if (musteriler != null & musteriler.musteriId != 0)
                {
                    Console.WriteLine("Müşteri adı : " + musteriler.musteriAdi);
                    Console.WriteLine("Müşteri soyadı : " + musteriler.musteriSoyadi);
                    Console.WriteLine("Müşteri üyelik tipi : " + musteriler.musteriUyelikTipi);
                }
            }
            Console.WriteLine("Müşteriler başarıyla listelendi!");

        }
    }
}
