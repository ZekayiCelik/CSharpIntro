using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();

            Console.WriteLine(matematik.Bol(20,0));
        }
    }

    class Matematik
    {

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public decimal Bol(int sayi1,int sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Catch çalıştı bir hata oluştu");
                throw new DivideByZeroException("payda sıfır olamaz");
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch çalıştı başka bir hata oluştu");
                throw new DllNotFoundException("payda sıfır olamaz");
            }
            catch(Exception)
            {
                Console.WriteLine("hiç öngörmediğim bir hata oluştu yöneticinize başvurunuz");
                throw;
            }
            finally
            {
                Console.WriteLine("finally çalıştı");
            }
          
        }
    }   
    
}
