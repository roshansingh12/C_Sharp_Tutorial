using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers;
namespace C_sharp_tutorial.Sync_Async_Await
{
    internal class Synchronous_programming
    {
        //Synchronous programming runs methods next after previous.
        //means syncrnous program run in sequential way.
        //1. program

        public static void calculateSum(int a, int b)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"sum of {a}, {b} is : {a+b} ");
        }
        public static void calculateMultiplication(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a}, {b} is : {a * b} ");
        }
        /*public static void Main(string[] args)
        {
            Console.WriteLine("Syncronous programming sstarted");
            calculateSum(30,90);
            calculateMultiplication(9, 8);
        }*/
    }
}
