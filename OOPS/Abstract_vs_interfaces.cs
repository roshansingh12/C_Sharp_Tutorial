using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    abstract class abstract_class
    {
        public abstract string abstract_name { get; set; }
        public string nonabstract_name { get; private set; }
        public abstract_class(string name)
        {
            nonabstract_name = name;
        }
        public abstract string get_name();
        /*public abstract string get_name_implemented()
        {
            return nonabstract_name+" "+abstract_name;
        }*/
        //compile time error, abstract methods can not contain implmentation.
        public string get_name_by_nonabstract_method()
        {
            return nonabstract_name+" "+abstract_name;
        }
    }
    public interface interface_1
    {
        public string interface_name { get; set; }
        string get_name_by_interface();
    }
    internal class Abstract_vs_interfaces : abstract_class, interface_1
    {
        //child class should implement all abstract and interface properties  and methods
        public Abstract_vs_interfaces(string name) : base(name)
        {
            //constructor in abstract class used to initialize properties of abstract class.
        }
        public override string abstract_name { get; set; }//abstract properties and methods should always be overriden
        public override string get_name()
        {
            return abstract_name;
        }
        public string interface_name { get; set; }//Interface methods do not overriden, they just implemented in child class
        public string get_name_by_interface()
        {
            return "interface method";
        }

    }
}
