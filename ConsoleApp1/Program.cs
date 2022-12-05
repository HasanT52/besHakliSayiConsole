using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahminsayisi;
            

            Random random = new Random();
            tahminsayisi= random.Next(1, 100);      
            
            Console.WriteLine("Tahmin yapınız");

            for (int i = 4; i >= 0;)
            {

                int sayi = Convert.ToInt32(Console.ReadLine());

                if (i > 0)
                {
                    if (sayi < tahminsayisi)
                    {
                        Console.WriteLine("Tahminizi Yükseltin, kalan hakkınız: " + i);
                        i--;
                    }

                    else if (sayi > tahminsayisi)
                    {
                        Console.WriteLine("Tahminizi Azaltın, kalan hakkınız: " + i);
                        i--;
                    }

                    else
                    {
                        Console.WriteLine("Tebrıkler doğru tahmin");
                    }
                }

                else if(i == 0)
                {
                    Console.WriteLine("Bulamadınızz !!! Aradığınız sayı: " + tahminsayisi);
                    
                }

            }

        }
    }
}
