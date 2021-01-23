using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri> { };
        
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("---Müşteri Ekleme---");
            Console.WriteLine("{0} Eklenmiştir!!\n", musteri.MusteriAdi);
            Musteriler.Add(musteri);

        }
        public void MusteriListesi()
        {
            Console.WriteLine("Musteri Listesi");
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine(
                    "Adı :"+Musteri.MusteriAdi + " " +
                    "Soyadı :" +" "+Musteri.MusteriSoyadi + " "+
                    "Telefon :"  + Musteri.MusteriTelefon  + " "+
                    "Şube :"  +  Musteri.MusteriSube);

            }
         }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("---Müşteri Silme---");
            Console.WriteLine(musteri.MusteriAdi +  " isimli Müşteri Silinmiştir." );
            

            Musteriler.Remove(musteri);
        }


    }
}
