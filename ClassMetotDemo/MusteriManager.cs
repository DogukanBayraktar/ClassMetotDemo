using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Eklendi."+"\n"+"Müşterimizin Adı : " + musteri.Ad + "\n" + "Müşterimizin Soyadı : " +musteri.Soyad+ "\n"+"Müşterinin Parası :" +musteri.HesapBakiyesi);
        }
        public void MusteriSil(Musteri[] liste) 
        {
            foreach (var musteri in liste)
            {
                Console.WriteLine("Eskiden Müşterimiz : " + musteri.Ad + " " + musteri.Soyad);
            }
        }
        public void Liste(Musteri[]liste) 
        { 
            foreach(var musteri in liste) 
            {
                Console.WriteLine("Müşterilerimizin Listesi. Müşterimizin Adı : " + musteri.Ad + " Müşterimizin Soyadı : " + musteri.Soyad);
            }
        }
    }
}
