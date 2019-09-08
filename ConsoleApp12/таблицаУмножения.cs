using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер таблицы по ширине: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер таблицы по высоте: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            for (int i = 1; i <= width * height; i++)
            {
                Console.Write($"{i,4}");
                if (i % (width * count) == 0)
                {
                    count++;
                    if (count == height + 1)
                    {
                        break;
                    }
                    Console.WriteLine();
                    Console.Write($"{count, 4}");
                    i = (i / width) + 1;
                }
                i += count - 1;
            }

            Console.ReadKey();
        }
    }
}
