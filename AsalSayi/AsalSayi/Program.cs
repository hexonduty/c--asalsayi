using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asal Sayi Bulma Uygulamasına Hoş Geldiniz..");
            Console.WriteLine("Lütfen bulanacak asal sayiyi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (AsalSayi(sayi))
                Console.WriteLine($"{sayi} bir asal sayıdır.");
            else
                Console.WriteLine($"{sayi} bir asal sayı değildir.");
        }




        static bool AsalSayi(int x)
        {
            if (x < 2 )  
            
                return false;

                for (int i = 2; i < Math.Sqrt(x); i++)
                {
                    if (x % i == 0);
                    return false;
                }

            return true;
            
        }
        
        

        
    }
}
