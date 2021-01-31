using System;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> kullanicilar = new MyDictionary<int, string>();
            //Diğer listelerde olduğu gibi Add() metodu ile ekleme yapıyoruz..
            kullanicilar.Add(1, "Deniz TENİK");
            kullanicilar.Add(2, "Merve ŞEKERCİ");
            kullanicilar.Add(3, "Alper KAYA");
            kullanicilar.Add(4, "Sezai ÇİNAR");
            kullanicilar.Add(5, "Sema YAŞAR");
            kullanicilar.Add(6, "Gizem TINAZ");
            kullanicilar.Add(7, "Banu ÇİNAR");

            Console.WriteLine("Listedeki Kullanıcı Sayısı: "+ kullanicilar.Count);
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                Console.WriteLine(kullanicilar.Key[i]+" "+kullanicilar.Value[i]);
            }


            Console.ReadLine();
      
        }
    }
}
