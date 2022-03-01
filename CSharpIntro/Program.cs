using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamSayi = 34567;
            double ondalikliSayi=45.5;
            short sayi = 1985;
            byte numara = 25;
            //double ondalıklı sayı tutar int tam sayı tutar byte ile short tam sayı tutat
            //aradaki fark hafızada ne kadar yer tuttuğudur genellikle double int kullanılır

            string duyuru = "Duyurumuz var";
            // C sharpta "" tırnak önemlidir ve ; kod bitmelidir
            //string metinsel ifade tutar
            bool deger = true;

            double pıyasaDun = 11120.76;
            double pıyasaBugun = 11120.76;
            bool sonuc = pıyasaBugun > pıyasaDun;
            string mesajArtis = "Artış oku";
            string mesajAzalis = "Azalış oku";
            string mesajAyni = "Sabit oku";

            if (sonuc == true )
            {
                Console.WriteLine(mesajArtis);
              
            }
            else if (pıyasaDun == pıyasaBugun)
            {
                Console.WriteLine(mesajAyni);
            }
            else
            {
                Console.WriteLine(mesajAzalis);
            }
                 //Example: Ternary operator
            int x = 20, y = 10;

            var result1 = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result1);

            //Example:nested(iç içe geçmiş)
            int a = 10, b = 100;

            string result2 = a > b ? "x is greater than y" :
                                a < b ? "x is less than y" :
                                    a == b ? "x is equal to y" : "No result";

            Console.WriteLine(result2);


            Console.WriteLine("Hello World!");
        }
    }
}
