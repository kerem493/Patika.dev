﻿using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Atama ve işlemi atama");
            int x = 3;
            int y = 5;
            y = y + 2;

            System.Console.WriteLine(y);
            y += 2;
            System.Console.WriteLine(y);
            y /= 1;
            System.Console.WriteLine(y);
            x += 2;
            System.Console.WriteLine(x);

            System.Console.WriteLine("Mantıksal operatörler");
            bool isSuccess = true;
            bool isComleted = false;
            if (isSuccess && isComleted)
            {
                System.Console.WriteLine("Perfect!");
            }

            if (isSuccess || isComleted)
            {
                System.Console.WriteLine("Great!");
            }
            if (isSuccess && !isComleted)
            {
                System.Console.WriteLine("Fine!");
            }


            System.Console.WriteLine("İlişkisel Operatörler");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            System.Console.WriteLine(sonuc);

            sonuc = a > b;
            System.Console.WriteLine(sonuc);
            sonuc = a <= b;
            System.Console.WriteLine(sonuc);
            sonuc = a == b;
            System.Console.WriteLine(sonuc);
            sonuc = a != b;
            System.Console.WriteLine(sonuc);



            System.Console.WriteLine("Aritmetik operatörler");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            System.Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            System.Console.WriteLine(sonuc2);
        }
    }
}
