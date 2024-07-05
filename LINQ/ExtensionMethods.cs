using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.LINQ
{
    /*public class Program
    {
        public static void Main(string[] agrs)
        {   string sentence = Console.ReadLine();
            Program pg = new Program();
            var value = pg._countvowels(sentence);
            Console.WriteLine(value);
        }
        public int _countvowels(string s)
        {
            int val = s.countvowels();
            return val;
        }
    }*/
    /*static class ExtensionMethods
    {
        //public int x;
        //static ExtensionMethods() { }
        public static int countvowels(this string str)
        {
            int c = 0;
            foreach(var ch in str)
            {
                if ("aeiou".Contains(ch.ToString())) { c += 1; }
            }
            return c;
        }
    }*/

    //Synchronous programming : task excuted in a sequance

    //Asynchronous programming : multiple tasks can be executed concurrently.
    
    public class _Book
    {
        public string name;
        public int id;
        public override string ToString()
        {
            return name+" "+id;
        }

    }
    public class Program
    {
        //const x; ......//const need to initialize at time of declaration
        public readonly int val;//readonly not need to initialize at time of declaration
        /*public static void Main(string[] args)
        {
            List<int> arr = new List<int>() {2,3,4,5,6,7,8,9,10};
            var squared_arr = arr.square();
            foreach(var el in squared_arr.Where(x=>x%3==0).Select(x=>x)){
                Console.Write(el + " ");
            }
            int x = 10;
            Math_ext.Display(x);
            string s = "actual string ";
            Console.WriteLine(s);
            Math_ext.Display(ref s);
            Console.WriteLine(s);
            int out_x;
            Math_ext.Display(out out_x);
            Console.WriteLine(out_x);
            //Recursion
            Console.WriteLine(Math_ext.factorial(5));
            _Book book = new _Book();
            book.id = 23;
            book.name = "star wars";
            Console.WriteLine(book.ToString());

        }*/
    }
    static class Math_ext
    {
        public static int factorial(int a)
        {
            var x = a;
            if(a>1)
            {
                Console.WriteLine(a);
                x = x * factorial(a-1);
            }
            return x;
        }
        public static void Display(int a)
        {
            Console.WriteLine(a);
        }
        public static void Display(ref string str) 
        {
            str += "changed!";
            Console.WriteLine(str);
        }
        public static void Display(out int x)
        {
            x = 10;
            Console.WriteLine(x);
        }
        public static List<int> square(this List<int> arr)
        {
            for(int i = 0; i < arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Math.Pow(arr[i],2));
            }
            return arr;
        }
        
    }

    //REAL EXTENSION METHOD EXAMPLE -> 
    //Adding new methods to existing class using another static class , these ,methods are static

    public class Aclass
    {
        public int x = 0;
        public void sample1()
        {

        }
    }

    static class Bclass
    {
        public static void Bsample1(this Aclass A)
        {
            Console.WriteLine("this is B class , will extend A class methods.");
        }
        public static void Main(string[] args)
        {
            Aclass a_ = new Aclass();
            a_.sample1();
            a_.Bsample1();//here you can see Aclass donot actually includes Bsample1 method but
                          //got extended method =. this Bsample1 method is extension method for Aclass
        }
    }

    public class A
    {
        public void GetA() { }
        public void GetB() { }
        public virtual void GetC() { }
    }
    public class B : A
    {
        public void GetD() { }
        public override void GetC() { }
    }
    public class Program_A_B
    {
        public static void Main(string[] args)
        {
            A A_ = new B();
            A_.GetC();
        }
    }
}
