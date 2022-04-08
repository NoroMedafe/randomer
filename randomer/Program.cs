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
            int number = rand.Next(100);
            int randomNumber;
            int countRandomNumbers = 10;
            int firstMultiplicity = 3;
            int secondMultiplicity = 5;

            Console.WriteLine("Наше число:" + number);

            for (int i = 0; i < countRandomNumbers; i++)
            {
                randomNumber = rand.Next(100);
                Console.Write("Число:" + randomNumber);

                if (randomNumber < number)
                {
                    if (randomNumber % firstMultiplicity == 0 || randomNumber % secondMultiplicity == 0)
                    {
                        Console.Write(" Подошло" + "\n");
                        sum += randomNumber;
                    }
                    else 
                    {
                        Console.Write(" Не подошло" + "\n");
                    }
                }
                else
                {
                    Console.Write(" Не подошло" + "\n");
                }
            }

            Console.WriteLine("Сумма подходящих числах равна " + sum);
            Console.ReadKey();
        }
    }
}
