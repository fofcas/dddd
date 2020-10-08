using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число А");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число B");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число С");
                double c = double.Parse(Console.ReadLine());
                if (a % 2 == 0 ^ b % 2 == 0) Console.WriteLine("Одно из чисел A и В четное ");
                else Console.WriteLine("Ни одно или оба из чисисел A и В четное");
                if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0) Console.WriteLine("Каждое из чисел А,В,С кратно трем");
                else Console.WriteLine("Не каждое из чисел А,В,С кратно трем");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
