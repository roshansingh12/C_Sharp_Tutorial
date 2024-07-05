using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    public abstract class ACalculate {
        public abstract void Abs_Add(int a, int b);
        //private int x;
        public abstract int X { get; set; }
    }
    interface ICalculate//interfaces can include method declarations without implementation.
    {
        //int x=0 -> is not valid inside interface, properties can only be declared here.
        int x { get; set; }//properties should be same declared or implemented in child class

        void Add(int a, int b);//interface peoperties and methods by defAULt are public.
        void Mul(int a, int b);
        void Sub(int a, int b);
        void Div(int a, int b);
    }
    

    public class Inheritance : ACalculate, ICalculate
    {
        public Inheritance() : base() {  }
        public override int X { get; set; }//abstract properties should also be overriden and implemented in smae manner
        public override void Abs_Add(int a, int b)
        {
            Console.WriteLine("Abstract class method");
        }
        public int x { get; set; } //interface properties not need to overriden, they shoould be implemented same
        public void Add(int c, int d)
        {
            Console.WriteLine(c + d);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        /*public static void Main(string[] args)
        {
            Inheritance inh= new Inheritance();
            inh.Add(90, 10);
            inh.Sub(90,10);
            inh.Mul(90, 10);
            inh.Div(90, 10);

            //SingleA SA = new SingleA(); 
            SingleB SB = new SingleB();
            //MultilevelA MA = new MultilevelA();
            //MultilevelB MB = new MultilevelB();
            MultilevelC MC = new MultilevelC();
            //HierarchicalA HA = new HierarchicalA();
            HierarchicalB HB = new HierarchicalB();
            HierarchicalC HC = new HierarchicalC();
            HierarchicalD HD = new HierarchicalD();
            new MultipleA();
        }*/

    }

    //Inheritance : Multilevel, single level, Hierarchical and multiple
    //Single inheritance: parent class inhertied by one child class
    //class A inherited by class B
    //Heirarchical inheritance: Parent class inherited by two or more child class
    //class A inherited by class b and class C
    //Multilevel : parent class inherited by a class and this class also inherited by other class
    //class A inherited by class B and class b inherited by class C
    //Multiple inheritance : Multiple interfaces inherited by a child class
    //Interface IA and IB inheroted by Class A
    
    //single level inheritance
    class SingleA
    {
        public SingleA() { Console.WriteLine("parent class SingleA"); }
    }
    class SingleB : SingleA
    {
        public SingleB() : base() { Console.WriteLine("child class SingleB of parent class SingleA"); }
    }

    //multilevel inheritance
    class MultilevelA
    {
        public MultilevelA() { Console.WriteLine("parent class multilevelA"); }
        public void Display(string s) { Console.WriteLine(s); }//not inherited as not defined as vritual/abstract
        //if you want to inherit class methods it should be
        public virtual void _Display() { Console.WriteLine("parent class"); }
    }
    class MultilevelB : MultilevelA
    {
        public MultilevelB() : base() { Console.WriteLine("class multilevelA chlid of MultilevelA class and parent of MultilevelC class"); }
        public void Display(string s,int b) { Console.WriteLine(s); }
        public sealed override void _Display()
        {
            Console.WriteLine("child class");
        }//if you want to prevent further override of _Display method it should b decalred sealed
    }
    class MultilevelC : MultilevelB
    {
        public MultilevelC() : base() { Console.WriteLine("child class of MultilevelB"); }
        //public override void _Display() { } you will see compile time error here
    }
    //hierarchical
    class HierarchicalA
    {
        public HierarchicalA() { Console.WriteLine("parent class HierarchicalA"); }
    }
    class HierarchicalB : HierarchicalA
    {
        public HierarchicalB() : base() { Console.WriteLine("class HierarchicalB child of class HierarchicalA"); }
    }
    class HierarchicalC : HierarchicalA
    {
        public HierarchicalC() : base() { Console.WriteLine("class HierarchicalC child of class HierarchicalA"); }
    }
    class HierarchicalD : HierarchicalA
    {
        public HierarchicalD() : base() { Console.WriteLine("class HierarchicalD child of class HierarchicalA"); }
    }

    //Multiple
    class A { }
    class B { }
    interface I1
    {
        int Sum(int a, int b);
    }
    interface I2 
    { 

    }
    interface I3
    {

    }
    class MultipleA :A, I1, I2, I3
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public MultipleA()
        {
            Console.WriteLine("class multipleA inherits state and behaviours of I1, I2, I3 interfaces and of class A, multiple inheritance can only inherit one base class");
        }
    }

}