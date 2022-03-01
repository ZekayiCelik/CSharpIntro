using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] krediler = new string[7];
            krediler[0] = "hızlı kredi";
            krediler[1] = "kredi2";
            krediler[2] = "kredi3";
            krediler[3] = "kredi4";
            krediler[4] = "kredi5";
            krediler[5] = "kredi6";
            krediler[6] = "kredi7";

            for (int i = 0; i < 7; i++)
            //or (int i = 0; i <krediler.Length; i++) dizinin eleman sayısını verir
            {
                Console.WriteLine(krediler[i]);

            }

            Console.WriteLine("for döngüsü bitti");

            foreach (var kredi in krediler)
            {
                Console.WriteLine(kredi);

            }
             Console.WriteLine("foreach döngüsü bitti");
            int sayac = 0;
            while (sayac<7)
            {
                
                Console.WriteLine(krediler[sayac]);
                sayac++;

            }

            int sayac2 = 0;
            do
            {
                Console.WriteLine(krediler[sayac2]);
                sayac2++;
            } while (sayac2<7);


            
        }
    }
}
 