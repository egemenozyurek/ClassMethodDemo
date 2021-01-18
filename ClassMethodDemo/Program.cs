using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Egemen";
            musteri.Soyad = "Ozyurek";

            Musteri musteri1 = new Musteri();
            musteri1.Id = 2;
            musteri1.Ad = "James";
            musteri1.Soyad = "Hetfield";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 3;
            musteri2.Ad = "Chester";
            musteri2.Soyad = "Bennington";

            Musteri[] musteriler = new Musteri[] { musteri, musteri1, musteri2 };

            MusteriManager legends = new MusteriManager();

            Console.WriteLine("***************Ekleme**************");
            legends.musteriEkle(musteri);
            legends.musteriEkle(musteri1);
            legends.musteriEkle(musteri2);

            Console.WriteLine("***************Listeleme**************");
            legends.MusteriListele(musteriler);

            Console.WriteLine("***************Silme**************");
            legends.musteriSil(musteri2);
        }
    }
}
