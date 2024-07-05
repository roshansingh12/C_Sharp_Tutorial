using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.practice
{
    public class _Emp
    {
        public string ID;
    }
    public class Dept
    {
        public string ID;
    }
    public partial class PartialClassAndMethods : _Emp
    {
        public string name;
        public int age;
        
    }
    public partial class PartialClassAndMethods
    {
        public string address;
    }
    public class Program : PartialClassAndMethods
    {
        public Program(int age,string name,string address) : base()
        {
            this.age = age;
            this.name = name;
            this.address = address;
        }
        Program pgm = new Program(36, "roshan", "xyz 44900");
    }
}
