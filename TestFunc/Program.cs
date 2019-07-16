using System;

namespace TestFunction
{
    static class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 4, 5, 8, 9, 10, 12, 20, 30, 35, 48 };
            Console.WriteLine("1, 3, 4, 5, 8, 9, 10, 12, 20, 30, 35, 48");
            Console.Write("Введите целое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            var i = Bsearch(arr, x);

            Console.WriteLine(i);
        }

        static int Bsearch(int[] numbers, int x)
        {
            var result = -1;
            var low = 0;
            var high = numbers.Length - 1;
            while (low <= high)
            {
                var middle = (low + high) / 2;
                if (x < numbers[middle])
                {
                    high = middle - 1;
                    result = middle;
                }
                else
                {
                    low = middle + 1;
                }
            }

            if (result < 0)
                Console.WriteLine("В массиве отсутствует число больше " + x + ".");
            else
                Console.WriteLine("Индекс числа, которое больше " + x + " равен: ");

            return result;
        }
    }
}
