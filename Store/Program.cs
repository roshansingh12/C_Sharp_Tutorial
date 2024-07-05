/*using System;
using System.Security.Cryptography.X509Certificates;
using C_sharp;

namespace C_sharp_tutorial.Store
{
    public class Program
    {
        static int res = 0;
        public static int Add(int a)
        {
            res += a;
            return res;
        }
        public static int Mul(int a)
        {
            res *= a;
            return res;
        }
        public static void Display()
        {
            Console.WriteLine(res);
        }
        //CASE 2
        public static void WriteString(string s)
        {
            Console.WriteLine(s);
        }
        public static void SendString(DelegatesAndEvents.myDelString Str)
        {
            Str("Hello");
        }
        //CASE 2

        public static void Main(string[] args)
        {
            Console.WriteLine("c sharp topics : >");
            Console.WriteLine("Generics : ");
            Generics<int, string> int_str_generics = new Generics<int, string>(1, "Roshan ", 3, new List<int> { 1, 2, 3, 4, 5 });
            Console.WriteLine(int_str_generics.add_any());
            Generics<int, int> int_int_generics = new Generics<int, int>(1, 5, 3, new List<int> { 1, 3 });
            Console.WriteLine(int_int_generics.add_any());
            Generics<string, string> str_str_generics = new Generics<string, string>("Singh ", "Roshan ", 3, new List<string> { "a", "b", "c" });
            Console.WriteLine(str_str_generics.add_any());
            str_str_generics.writelist();

            //Delegates
            DelegatesAndEvents.myDel del = new DelegatesAndEvents.myDel(Add);
            del(10);
            Display();
            DelegatesAndEvents.myDel del0 = new DelegatesAndEvents.myDel(Mul);
            del0(10);
            Display();

            //multicasting of delegate. "res = 0"
            res = 0;
            DelegatesAndEvents.myDel Del;
            Del = del;
            Del += del0;
            Del(20);
            Display();

            //removing delegates , "res = 400"
            Del -= del0;
            Del(30);
            Display();

            //passing methods as parameters to delegates and delegates to other method
            //basically apssing methods as parameters to another method : CASE 2    
            //CASE 2
            DelegatesAndEvents.myDelString mydelstr = new DelegatesAndEvents.myDelString(WriteString);
            //here we can directly do like : " mydelstr("hello") "
            //also if we want to pass some "operated string or string form other method" which takes 
            //delegate as parameter 
            SendString(mydelstr);
            //CASE 2
        }
    }
}*/

//Access modifiers and encapsulation
/*using System;
using C_sharp_tutorial.OOPS;
namespace C_sharp_tutorial.Store
{
    public class Program0 : public_class
    {
        public void display()
        {
            Console.WriteLine(internal_var);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            public_class pub_c = new public_class();
            //private and protected are not accessible outside the assembly as well
            //but protected can be accessed by the child class object which inherits parent class cpontaining
            //protected member.
            
        }
    }
}*/