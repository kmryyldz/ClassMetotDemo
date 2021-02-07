using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Musteri eklendi : " + musteri.Adi + " " + musteri.Soyadi);

        }
        public void Sil (Musteri musteri) 
        {
          Console.WriteLine(" Musteri silindi : " + musteri.Adi + " " + musteri.Soyadi);
        }
            

    }
}
