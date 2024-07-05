using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.Encapsulation
{
    /*
     * Encapsulation is process of binding data/propertie and methods together in one unit
     * Class or struct
     * And showing only required data or methods or properties
     * below balance inside bank class cann't be accessed outside class, but can be accessed via methods and constructor.
     */
    public class Bank
    {
        private int balance;
        private string name;
        public string Name { 
            get { return name; } 
            set {
                if (value.Contains("@")) { name = value; }
                else { Console.WriteLine("not a valid name"); }
            } }
        public Bank(int _balance)
        {
            if (_balance < 0) { Console.WriteLine("cann't set negative balance!"); }
            balance = _balance;
        }
        public void AddBalance(int bal)
        {
            balance += bal;
        }
        public int Withdraw(int bal)
        {
            if(balance <= 0)
            {
                Console.WriteLine("Not enough balannce");
                return balance;
            }
            balance -= bal;
            return balance;
            
        }
        public int Getbalance()
        {
            return balance;
        }

    }
    internal class Encapsulation
    {
        /*public static void Main(string[] args)
        {
            Bank bank = new Bank(-100);
            Bank bank0 = new Bank(100);
            bank0.AddBalance(1000);
            Console.WriteLine("Your Current balance : " + bank0.Withdraw(900));
            Console.WriteLine("Your Current balance : " + bank0.Getbalance());
            bank0.Name = "Roshan@123";
            Console.ReadKey();
        }*/
    }
}
