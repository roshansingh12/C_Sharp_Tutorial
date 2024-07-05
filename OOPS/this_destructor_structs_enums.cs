using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    internal class this_destructor_structs_enums
    {
        public string name { get; set; }
        public string number { get; set; }
        //this key word is reference to the current instance of the class.
        //1. Accessing instance members using this keyword
        public this_destructor_structs_enums(string name, string number) {
            this.name = name;
            this.number = number;
        }
        //2. This key word used to call parameterized constructor with default values.   
        public this_destructor_structs_enums() : this("x","y") 
        {
            Console.WriteLine(this.name+"\n"+ this.number);
        }
        ~this_destructor_structs_enums()
        {
            Console.WriteLine("destructor called all the objects will be destructed!");
        }
        //this
        //struct
        /*
         * STRUCT is a value type that can encapsulate related data memebers and methods.
         * commonly used to represent lightweight objects that have small size and are immutable.
         */
        public struct point
        {
            int x;
            int y;
            public point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
            public int distanceFromOrigin()
            {
                return Convert.ToInt32(Math.Sqrt(x * x + y * y));
            }

        }
        //enums
        public enum vowels
        {
            a,e,i,o,u
        };
        //enums
        //: Array representing set of named constant
        // 
        //enums
        /*public static void Main(string[] args) {
            //this
            this_destructor_structs_enums obj = new this_destructor_structs_enums("roshan", "9716269993");
            this_destructor_structs_enums obj1 = new this_destructor_structs_enums("roshan", "9716269993");
            //this
            //struct
            point p = new point(23, 67);
            //p.x = 67;this is not correct as struct members are immutable.
            //in other words struct directly contains data not reference to the data , that's why 
            //struct is immutable.
            //while class contains reference to the variable, and values  can be changed.
            Console.WriteLine($"Distance from origin : {p.distanceFromOrigin()}");
            point p1 = new point(23, 67);
            //struct have value type euality, if two instance of struct have same data they are considered equal
            obj1.name ="abcd";
            Console.WriteLine(obj1.name);
            //struct
            //enum
            vowels v = vowels.e;
            if (v != vowels.a) { Console.WriteLine($"{v}"); }
            //ENUM parsing or string to enum
            vowels v0 = (vowels)Enum.Parse(typeof(vowels), "a");
            //enum

        }*/
    }
}