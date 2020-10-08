using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine( "Введите чесло А");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите чесло В");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a * a + b * b + " сума квадратов");
                Console.WriteLine(a * a + 2 * a * b + b * b + " Квадрат сумы");
                if (a * a + b * b == a * a + 2 * a * b + b * b) Console.WriteLine("они равны");
                else if (a * a + b * b > a * a + 2 * a * b + b * b) Console.WriteLine("сума квадратов больше");
                else Console.WriteLine("Квадрат сумы больше");
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
