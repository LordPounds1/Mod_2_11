using System;

namespace CompareAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.WriteLine("Введите радиус круга:");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата:");
            double a = Convert.ToDouble(Console.ReadLine());

            double S_kruga = pi * r * r;
            double S_kvad = a * a;

            if (S_kruga > S_kvad)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (S_kruga < S_kvad)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }
    }
}