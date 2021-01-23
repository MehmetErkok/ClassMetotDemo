using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamıza Hoşgeldiniz");
            Musteri musteri = new Musteri();
            musteri.MusteriId =1;
            musteri.MusteriAdi = "Mehmet";
            musteri.MusteriSoyadi = "Büşra";
            musteri.MusteriTelefon = 11111111;
            musteri.MusteriSube = "İstanbul";


            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 2;
            musteri1.MusteriAdi = "Büşra";
            musteri1.MusteriSoyadi = "Mehmet";
            musteri1.MusteriTelefon = 222222;
            musteri1.MusteriSube = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 3;
            musteri2.MusteriAdi = "Şerife";
            musteri2.MusteriSoyadi="Oğuzhan";
            musteri2.MusteriTelefon=333333;
            musteri2.MusteriSube = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 4;
            musteri3.MusteriAdi = "Oğuzhan";
            musteri3.MusteriSoyadi = "Şerife";
            musteri3.MusteriTelefon = 44444;
            musteri3.MusteriSube="İstanbul";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri);
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);

            musteriManager.MusteriListesi();


            musteriManager.MusteriSilme(musteri3);
            musteriManager.MusteriSilme(musteri);


            musteriManager.MusteriListesi();








        }
    }
}
