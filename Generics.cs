using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Generics<T,T1>
    {
        //internal class Advanced_Topics : this class only can be accessed within this assembly members only ;
        //Generics 

        //name of generic data should be declared same as passed in class ;
        public T value;
        public int num;
        public T1 value2;
        private List<T> myList = new List<T>();
        //above we declared variables T and T1 are generic types.
        //they can be defined with any type 
        public Generics(T a, T1 b, int c,List<T> mylist)
        {
            value= a;
            value2 = b;
            num = c;
            myList = mylist;
        }//This is constructor
        
        //Here we are returning the addition of T and T1 irrespective of their types
        public string add_any()
        {
            string res = string.Empty;
            for (int i=0;i<num;i++)
            {
                res += value.ToString() + value2.ToString();
            }
            return res;
        }

        //Below we are writing generic list elements
        public void writelist()
        {
            foreach(T el in myList)
            {
                Console.WriteLine(el);
            }
        }
        
        /*
         * Collections in .NET Framework:
           Generics are extensively used in .NET collections such as List<T>,
           Dictionary<TKey, TValue>, Queue<T>, Stack<T>, etc. These collections can 
           store elements of any data type, providing type safety and avoiding the need 
           of boxing and unboxing.

        whlie arraylist are not type safe , they need to be unboxed for further data operations
           
         */
        /*Code example
        List<int> numbers = new List<int>();
        Dictionary<string, int> ages = new Dictionary<string, int>();
        */
        /*
         * LINQ also make extensive use of generics
         * var res = numbers.Where(n=> n>9);
         * 
         * DbSet<User> users also example of Generics
         */

    }
    public class Test
    {
        /*public static void Main(string[] args)
        {
            Generics<string, int> gen = new Generics<string, int>("", 10, 5, new List<string>() { "a", "b", "c" });
            Console.WriteLine(gen.add_any());
            gen.writelist();

            int x = 10;
            object obj1 = x;
            Console.WriteLine(obj1);
            int y = (int)obj1;
            Console.WriteLine(y);
        }*/
    }
}