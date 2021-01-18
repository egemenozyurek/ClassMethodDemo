using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }

        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
        }

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "In Loving Memory");
        }
    }
}
