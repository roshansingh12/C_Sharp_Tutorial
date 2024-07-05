using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    class ClassA
    {
        public int display(int x)
        {
            return x;
        }
        public int display(int x,int y)
        {
            return x = y;
        }
        public string display(string x, int y)
        {
            string res = "";
            for (int i = 0; i < y; i++) { res += " " + x; }
            return res;
        }
        public int display(int y,string x)
        {
            string res = "";
            for (int i = 0; i < y; i++) { res += " " + x; }
            return res.Length;
        }
        public object display(string x, int y, int z) { return new { x, y, z }; }
        public virtual string Add(string a, string b)//method that will be overriden decalred virtual
        {
            return a + b;
        }
        //public sealed virtual string Add(string a, string b) -> if we want a method to not be overriden we can use sealed
        //or remove virtual 
    }
    class ClassB : ClassA
    {
        public ClassB() : base() { }
        //overriding add method of class classA
        public override string Add(string a, string b)//both methods should have same name, return type and parameters type
        {
            return (Convert.ToInt32(a)+ Convert.ToInt32(b)).ToString();
        }
    }
    internal class polymorphism
    {
        /*public static void Main(string[] args)
        {
            Console.WriteLine("overriding->");
            ClassA A = new ClassA();
            Console.WriteLine(A.Add("1", "1"));
            ClassB B = new ClassB();
            Console.WriteLine(B.Add("1", "1"));
            Console.WriteLine("<-overriding");

            ClassB b = new ClassB();
            Console.WriteLine("overloading->");
            Console.WriteLine(@"
            Console.WriteLine(b.display(10));
            Console.WriteLine(b.display(10,20));
            Console.WriteLine(b.display(""roshan"",2));
            Console.WriteLine(b.display(2,""roshan""));
            Console.WriteLine(b.display(""roshan"",25, 14));
            ");
            Console.WriteLine(b.display(10));
            Console.WriteLine(b.display(10,20));
            Console.WriteLine(b.display("roshan",2));
            Console.WriteLine(b.display(2,"roshan"));
            Console.WriteLine(b.display("roshan",25, 14));
            Console.WriteLine("<- overloading");
        }*/
    }
}
