using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {   // Musteri classıda burda geliyor
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Dogukan";
            musteri1.Soyad = "Bayraktar";
            musteri1.HesapBakiyesi = 500;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ceren";
            musteri2.Soyad = "Bayraktar";
            musteri2.HesapBakiyesi = 1500;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Drogba";
            musteri3.Soyad = "Bayraktar";
            musteri3.HesapBakiyesi = 1500;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            //MusterManagerı burda cagırıyoruz
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("-----------");
            Console.WriteLine("Listede olan bütün müşterilerimiz");
            musteriManager.Liste(musteriler);
            Console.WriteLine("-----------");
            Console.WriteLine("Silinen Müşteriler");
            musteriManager.MusteriSil(musteriler);
        }
    }
}
