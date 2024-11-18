using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.Sync_Async_Await
{
    //Notes : Asynchronous programming aminly used for applications dealing with Input/Output bounds
    //such as get/post/put data from network request
    //or File I/O

    //Multithreading used to execute multiple threads parallely
    //it is sued for more general purpuses
    //tasks like background operations/ handling multiple requests simultenously
    internal class Asynchronous_Programming
    {
        public static async Task<int> sum(int a, int b)
        {
            //Console.WriteLine("Sum1 called");
            //Thread.Sleep(5000);
            await Task.Delay(3000);
            //Console.WriteLine("Sum2 called");
            //Console.WriteLine("Sum3 called");
            return a + b;
        }
        public static async Task CalculateSum(int a, int b)
        {
            //Console.WriteLine("Sum4 called");
            var x = await Task.Run(()=>sum(a,b) );
            //Console.WriteLine("Sum5 called");
            Console.WriteLine("Sum : "+x);
        }
        public static async Task CalculateMul(int a,int b)
        {
            //Console.WriteLine("Mul1 called");
            //var x = await Task.Run(() => { Thread.Sleep(2000); return (a * b); });
            await Task.Delay(2000);
            var x = a * b;
            Console.WriteLine($"Multiplication : {x}");
            //Console.WriteLine("Mul2 called");
        }
        public static void CalculateMinus(int a, int b)
        {
            Console.WriteLine($"a - b : {a-b}");
        }

        /*public static async Task callMethods_Tasks()
        {
            Task sum =  CalculateSum(4, 5);
            Task Mul = CalculateMul(4, 5);
            Task Sub = Task.Run(()=>CalculateMinus(5, 2));
            await Task.WhenAll(sum, Mul, Sub);
        }*/
        public static async Task callMethods()
        {
            await CalculateSum(4, 5);
            await CalculateMul(4, 5);
            CalculateMinus(5, 2);
        }
        /*public static async Task Main(string[] args)
        {
            Console.WriteLine("Program started.....");
            await callMethods();
            Console.WriteLine("Program Ended....");
        }*/
    }
    public class multithreading_programming
    {
        public static void Task1(string name)
        {
            Console.Write($"{name} started ");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write($"|{name}:{i}|");
            }

        }
        public static void Task2(string name)
        {
            Console.WriteLine($"{name} started ");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write($"|{name}:{i}|");
            }
            Console.WriteLine();
        }
        
        /*public static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => { Task1("Task1"); });
            Thread thread2 = new Thread(() => { Task2("Task2"); });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Both tasks completed");
        }*/
    }
    
}
