using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     System.Console.WriteLine("Bir sayı girin : ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            // }
            // catch (Exception ex)
            // {
            //     System.Console.WriteLine("Hata : " + ex.Message.ToString());
            // }
            // finally
            // {
            //     System.Console.WriteLine("İşlem tamamlandı.");
            // }

            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-22222222222");
            }
            catch (ArgumentException ex)
            {

                System.Console.WriteLine("Boş değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Format uygun değil.");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("çok küçük ya da çok büyük bir değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("İşlem başarıyla tamamlanmıştır.");
            }
        }
    }
}
