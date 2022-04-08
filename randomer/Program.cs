using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int sum = 0;
            int number = rand.Next(0, 100);
            int[] massiveNumbers = new int[10]; 
            Console.WriteLine("Наше число:" + number);

            for (int i = 0; i < massiveNumbers.Length; i++)
            {
                massiveNumbers[i] = rand.Next(-30,100);
                Console.Write("Число:" + massiveNumbers[i]);
                if (massiveNumbers[i] >0 && massiveNumbers[i] <= number)
                {
                    if (massiveNumbers[i] % 3 == 0 || massiveNumbers[i] % 5 == 0)
                    {
                        Console.Write(" Подошло" + "\n");
                        sum += massiveNumbers[i];
                    }
                    else Console.Write(" Не подошло" + "\n");
                }
                else Console.Write(" Не подошло" + "\n");
            }

            Console.WriteLine("Сумма подходящих числах равна " + sum);
            Console.ReadKey();
        }
    }
}
