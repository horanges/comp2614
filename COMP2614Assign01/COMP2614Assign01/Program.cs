//COMP2614 Assign01 
// Calculates squares and cubes of even numbers between 0 and 20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int square;
            int cube;
            int numberSum = 0;
            int squareSum = 0;
            int cubeSum = 0;

            const int COLUMN_WIDTH = 26;
            const int UPPER_LIMIT = 20;

            Console.WriteLine("{0,8} {1,8} {2,8}", "number", "square", "cube");
            Console.WriteLine(new string('-', COLUMN_WIDTH));

            // displays even numbers from 0 to 20 and their corresponding squares and cubes
            while (number <= UPPER_LIMIT)
            {
                square = number * number;
                cube = number * number * number;

                Console.WriteLine("{0,8} {1,8:N0} {2,8:N0}", number, square, cube);

                numberSum += number;
                squareSum += square;
                cubeSum += cube;

                number += 2;
            }

            Console.WriteLine(new string('-', COLUMN_WIDTH));
            Console.WriteLine("{0,8} {1,8:N0} {2,8:N0}", numberSum, squareSum, cubeSum);
        }
    }
}
