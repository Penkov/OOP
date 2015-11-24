using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                if (number <= 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine(squareRoot);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
