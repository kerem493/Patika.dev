using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Lütfen bir sayı girin : ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= sayac; i++)
            // {
            //     if(i%2 == 1)
            //         System.Console.WriteLine(i);
            // }
            // Console.Read();

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("tek toplam : " + tekToplam);
            System.Console.WriteLine("çift toplam : " + ciftToplam);
        }
    }
}
