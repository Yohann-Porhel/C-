using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimorphic
{
    // A trimorphic number is a number whose cube ends in the number itself
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number of the raw ?");
            string first = Console.ReadLine();
            Console.WriteLine("Last number of the raw ?");
            string last = Console.ReadLine();

            double increment = Double.Parse(first);
            double maxrange = Double.Parse(last);

            do
            {
                double cube = Math.Pow(increment, 3);
                string result = cube.ToString();
                if (result.EndsWith(increment.ToString()))
                {
                    Console.WriteLine("{0} is a trimorphic number", increment.ToString());
                }
                increment++;

            } while (increment <= maxrange);
            Console.ReadKey();
        }

    }

}