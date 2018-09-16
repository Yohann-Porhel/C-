using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your IP Adress :");
            string adress = Console.ReadLine();
            string[] parts = adress.Split('.');
            string message = "";

            if (parts.Length == 4)
            {
                foreach (string part in parts)
                {
                    if ((Int32.Parse(part)) >= 0 && (Int32.Parse(part)) <= 255)
                    {
                        message = "{0} is a valid IP Adress";
                    }
                    else
                    {
                        message = "{0} is not a valid IP Adress";
                        break;
                    }
                }                
            }
            else
            {
                message = "{0} is not a valid IP Adress";
            }
            Console.WriteLine(message, adress);
            Console.ReadKey();
        }
    }
}
