using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name0 Surname0
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id =1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Name0";
            musteri1.Soyadi = "Surname0";
            musteri1.TcNo = "12345678910";


            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "SirketName0";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            //new bellekteki bir referans numarası
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
