using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.practice
{
    //private class static_non_static
    sealed class static_non_static
    {
        //public static string name;
        public string name;
        public static void write()
        {
            static_non_static sns = new static_non_static();
            Console.WriteLine(sns.name);
            //Console.WriteLine(name);//=> instance of class required to access its properties in static method.
        }
        static static_non_static()
        {
            //name = "roshan";
        }
    }
    public class sample1 
    {
        /*public static void Main(string[] args)
        {
            static_non_static sns = new static_non_static();
        }*/
    }
}
