using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //public static void yazdir()
        //{
        //    Console.WriteLine("bu bir metottur");
        //    Console.WriteLine();
        //    Console.Write("Burası metodun başka bir satırıdır");
        //    Console.WriteLine();
        //}
        //public static void toplama()
        //{
        //    int sayi1 = 24, sayi2 = 30;
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}
        //public static void ardisiksayilar()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    yazdir();
        //    Console.WriteLine("*******************");
        //    Console.WriteLine("*******************");
        //    yazdir();
        //    Console.WriteLine("*******************");
        //    toplama();
        //    Console.WriteLine("*******************");
        //    ardisiksayilar();
        //    Console.ReadLine();

        //}
        //------Void metotla rda parametre kullanımı-------
        public static void MetinYaz(string p)
        {
            Console.WriteLine("***********");
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine("*********");

        }
        public static void MetinYaz2(string parametre)
        {
            Console.WriteLine("-------");
            Console.WriteLine();
            Console.WriteLine(parametre);
            Console.WriteLine();
            Console.WriteLine("-------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("kelimeyi giriniz: ");

            string kelime = Console.ReadLine();

            MetinYaz2(kelime);
            

            MetinYaz("Merhaba");
            Console.ReadLine();
        }


    }
}
