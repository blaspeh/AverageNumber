using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //first number
            Console.Write("Enter the first number (num1): ");
            var num1 = Console.ReadLine();
            int successifulNum1;
            bool isSuccessufulNum1 = int.TryParse(num1, out successifulNum1);

            if (!isSuccessufulNum1)
            {
                Console.WriteLine("Please enter a number for num1! ");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //second number
            Console.Write("Enter the second number (num2): ");
            var num2 = Console.ReadLine();
            int successifulNum2;
            bool isSuccessufulNum2 = int.TryParse(num2, out successifulNum2);

            if (!isSuccessufulNum2)
            {
                Console.WriteLine("Please enter a number for num2!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //third number
            Console.Write("Enter the third number (num3): ");
            var num3 = Console.ReadLine();
            int successifulNum3;
            bool isSuccessufulNum3 = int.TryParse(num3, out successifulNum3);

            if (!isSuccessufulNum3)
            {
                Console.WriteLine("Please enter a number for num3!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //third number
            Console.Write("Enter the fourth number (num3): ");
            var num4 = Console.ReadLine();
            int successifulNum4;
            bool isSuccessufulNum4 = int.TryParse(num4, out successifulNum4);

            if (!isSuccessufulNum4)
            {
                Console.WriteLine("Please enter a number for num4!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int average = (successifulNum1 + successifulNum2 + successifulNum3 + successifulNum4) / 4;
            Console.WriteLine("The average of " + successifulNum1 + ", " + successifulNum2 + ", " + successifulNum3 + ", " + successifulNum4 + " is "+ average);
            Console.ReadLine();

        }
    }
}
