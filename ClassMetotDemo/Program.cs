using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "kmry";
            musteri1.Soyadi = "yldz";
            musteri1.Id = 123456;
            musteri1.Yas = 26;
            musteri1.KayıtTarihi = 2021;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mrv";
            musteri2.Soyadi = "Rzgr";
            musteri2.Id = 987654;
            musteri2.Yas = 35;
            musteri2.KayıtTarihi = 2013;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musterimanager = new MusteriManager();

            //Müşteri Listeleme
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("---------Müşteri Listelendi--------");
                Console.WriteLine("Musteri.Adi:"+ musteri.Adi);
                Console.WriteLine("Musteri.Soyadi:"+ musteri.Soyadi);
                Console.WriteLine("Musteri.Id:"+ musteri.Id);
                Console.WriteLine("Musteri.Yas:"+ musteri.Yas);
                Console.WriteLine("Musteri.KayıtTarihi:"+ musteri.KayıtTarihi);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Müşteri Ekleme
            Console.WriteLine("-----------Müşteri Eklendi-----------");
            musterimanager.Ekle(musteri1);

            //Müşteri Silme
            Console.WriteLine("-----------Müşteri Silme--------------");
            musterimanager.Sil(musteri2);
           
        }
    }
}
