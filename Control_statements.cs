/*using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Control_statements
{
    public class Conditions_and_Loops
    {
        public static string str = Console.ReadLine();
        public static void Main(string[] args)
        {

            Console.Write("Enter any string");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') { goto a_vowel; }
                else
                {
                    continue;
                }
            a_vowel:
                Console.WriteLine("this string contains vowel!");
                break;
            }

            switch (str)
            {
                case "a": 
                    Console.WriteLine("a");
                    break;
                case "b":
                    Console.WriteLine("b");
                    break;
                default:
                    Console.WriteLine(str); break;
            }
        }
    }
}*/