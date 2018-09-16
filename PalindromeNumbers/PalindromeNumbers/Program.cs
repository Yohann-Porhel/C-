using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumbers
{
    public static class Palindrome
    {

        // METHOD
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // MAIN
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number :");
            string input = Console.ReadLine();
            string reverse = Reverse(input);
            char[] charsInput = input.ToCharArray();
            char[] charsReverse = reverse.ToCharArray();

            for (int positionChar = 0; positionChar < charsReverse.Length;)
            {
                string message = "";
                for (int posCharReverse = 0; posCharReverse < charsReverse.Length; posCharReverse++)
                {
                    if ((charsReverse[posCharReverse]) != (charsInput[positionChar]))
                    {
                        message = "{0} isn't a palindrome";
                        break;
                    }
                    else
                    {
                        positionChar++;
                        message = "{0} is a palindrome";
                    }
                }
                Console.WriteLine(message, input);
                break;
            }
            Console.Read();
        }
    }
}