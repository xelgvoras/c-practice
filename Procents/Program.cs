using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада, процентную ставку и срок вклада через пробел");
            var inputLine = Console.ReadLine();
            var accumulation = Calculate(inputLine);
            Console.WriteLine(accumulation);
        }

        static private double Calculate(string userInput)
        {
            char delimiter = ' ';
            string[] substrings = userInput.Split(delimiter);
            var sum = double.Parse(substrings[0]);
            var interestRate = double.Parse(substrings[1]) / 100;
            var termOfDeposite = double.Parse(substrings[2]);
            for (int i = 0; i < termOfDeposite; i++)
            {
                sum += (sum * interestRate) / 12;
            }
            return sum;
        }
    }
}
