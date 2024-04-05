using System;

namespace OOP_Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            p1.metod1 = "Dijar";
            p1.metod2 = "Zejnullahi";

            Console.WriteLine(p1.metod1 + " " + p1.metod2);

            DateTime födelsedatum = new DateTime(2006, 12, 11);
            Console.WriteLine(födelsedatum.ToString());

            Console.WriteLine("Hur gammal är du?");
            p1.ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Myndig: " + p1.myndig());

            Class1 p2 = new Class1();
            Console.WriteLine("Hur lång är du i meter?");
            p2.metod3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du i kg?");
            p2.metod4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Längd: " + p2.metod3);
            Console.WriteLine("Vikt: " + p2.metod4);
            Console.WriteLine("BMI: " + p2.BMI());
        }
    }
}