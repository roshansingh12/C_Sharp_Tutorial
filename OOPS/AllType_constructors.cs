using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    public class Constructors
    {
        public string name = "";
        public int age;
        public static string description = "";
        //default
        public Constructors() { Console.WriteLine("Default Constructor -> \npublic Constructors() {}"); }
        //parameterized
        public Constructors(string _name, int _age)
        {
            name = _name;
            age = _age;
            Console.WriteLine
                ("parametirized constructor -> \npublic Constructors(string _name,int _age) {\r\n            name = _name;\r\n            age = _age;\n}");
        }
        //copy constructor
        public Constructors(Constructors con)
        {
            name = con.name;
            age = con.age;
            Console.WriteLine
            ("Copy Constructor -> \npublic Constructors(Constructors con) {\r\n            name = con.name;\r\n            age = con.age;\n}");
        }
        //static constructor
        static Constructors()
        {
            //Console.WriteLine("this is static constructor which is called directly,and that's why only once");

        }
        public static void Write()//if not declared as public by default it is private
        {
            Console.WriteLine("Static Constructor -> \nstatic Constructors() {}");
            description = "Hello Ji! welcome";
            Console.WriteLine(description);
        }
        //Private cunstructor

        private Constructors(string msg)
        {
            Console.WriteLine("Private constructor -> \nprivate Constructors(int x)\r\n        {\n}");
        }
    }
    internal class AllType_constructors  : Constructors
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        static AllType_constructors()
        {
        }
        //public AllType_constructors(string str) : base(str) { }//here we are inheriting through private constructor
        //Constructors:
         /*Default Constructor -> not argumented/can create objects with constant properties defined in constructor.
         * Parameterized Constructor -> Argumented, create objects with parameters passed in.
         * Copy Constructor -> The purpose of a copy constructor is to initialize a new instance/object to the values of an existing instance.
         * static comstructor -> No access modifiers, can not  have parameter, called directlty, run only once, run in thread safe manner.
         * Private constructor -> Class with private constructor cann't be instentiated and cann't be derived.
         *                        Provide implementetion of singleton class pettern.
         */                   
        
        /*public static void Main(string[] args)
        {
            //default
            Constructors con = new Constructors();
            Console.WriteLine();
            //parameterized
            Constructors param_con = new Constructors("roshan", 23);
            Console.WriteLine();
            //copy
            Constructors copy_con = new Constructors(param_con);
            Console.WriteLine();
            //static
            Constructors static_con = new Constructors();
            Console.WriteLine();//this is wrong , this will call default constructor
            //static constructors used to difine static properties and call static methods! Directly or without an instance
            Constructors.Write();
        }*/
        /*public static void Main(string[] args)
        {
            AllType_constructors atc = new AllType_constructors();
            AllType_constructors.Id = 5;
            atc.name = "Roshan";//if static class have members, we cann't define it at time of object creation.
                                //we can access it using the object 
            // static members cann't be accessed with created object,
            // they need to direclt called.
            
        }*/
    }
}
