using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat ayındasınız.");
                    break;
                default:
                    System.Console.WriteLine("Yanlış veri girişi.");
                    break;


            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış ayındasınız");
                    break;


                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar");
                    break;


                default:
                    break;
            }
        }
    }
}
