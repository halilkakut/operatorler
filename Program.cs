using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine("*********Atama İşlemleri***********");
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x += 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            Console.WriteLine("*********Mantıksal Operatörler***********");
            bool isSuccess = true;
            bool isCompleted = true;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Greate!");
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            //İlişkisel Operatirler
            // <, >, <=, >=, ==, !=
            Console.WriteLine("*********İlişkisel Operatirler***********");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            
            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*********Aritmetik Operatörler");
            int sayi1 = 3;
            int sayi2 = 20;

            int sonuc1 = sayi2 / sayi1;
            Console.WriteLine(sonuc1);

            int sonuc2 = sayi2 % sayi1;
            Console.WriteLine(sonuc2);
        }
    }
}
