using System;

namespace CsCampHomeworks_Kodlama.io
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Serpil";
            musteri.Soyad = "TY";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri);
            musteriManager.List(musteri);
            musteriManager.Delete(musteri);
            

            Console.WriteLine("***Always Say Hello World***");
        }
    }
}
