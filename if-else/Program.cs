using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time <= 18)
            {
                System.Console.WriteLine("İyi günler.");
            }
            else if (18 < time && time <= 22)
            {
                System.Console.WriteLine("İyi akşamlar.");
            }
            else
            {
                System.Console.WriteLine("İyi geceler.");
            }

            string sonuc = 18 < time && time <= 22 ? "İyi akşamlar" : time <= 18 ? "İyi günler." : "İyi geceler.";
            System.Console.WriteLine(sonuc);
        }
    }
}
