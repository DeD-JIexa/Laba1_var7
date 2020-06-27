using System;

namespace Laba1_var7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num == 0) || (reverse(num, 0) == num));
            Console.ReadKey(true);
        }
        private static int reverse(int num, int acc)
        {
            while (num > 0) { acc = acc * 10 + num % 10; num /= 10; }
            return acc;
        }
    }
}
