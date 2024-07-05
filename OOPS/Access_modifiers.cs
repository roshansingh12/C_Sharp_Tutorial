/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.OOPS
{
    //Access modifieres
    public class public_class
    {
        public string public_var="";
        private string private_var = "";
        internal string internal_var = "";
        protected string protected_var = "";
        protected internal string protected_internal_var = "";
        private protected string private_protected = "";
        //private members of one class cann't be accesed from another class
        //protected are accessile iwthin same assemble and different assembly only in classes deriving the parent class
        //that contains the members
    }
    public class ClassTemp: public_class
    {
        //drived class inside same assembly
        public ClassTemp() : base(){ }
        public void display()
        {
            Console.WriteLine(public_var);
            Console.WriteLine(protected_var);
            Console.WriteLine(protected_internal_var);
            Console.WriteLine(internal_var);
            Console.WriteLine(private_protected);
            //Console.WriteLine(private_var);-> compile time error
        }
    }
    internal class Access_modifiers
    {
        //non-drived class inside same assembly
        public static void Main()
        {
            public_class pub_c = new public_class();
            Console.WriteLine(pub_c.public_var);
            Console.WriteLine(pub_c.internal_var);
            Console.WriteLine(pub_c.protected_internal_var);

        }
    }
    //scope of members defined in one class
    /*
     * With the class
     * -> (public/private/protected/internal/protected internal/private protected) (All)
     * 
     * with the derived class in same assembly
     * -> (public,protected) (Not-> private)
     * 
     * with the non-derived class in same assembl
     * -> (public) (Not-> private/protected)
     * 
     * with the drived class in other assembly (public,protected) (Not-> private)
     * with the non-derived class in other assembly (public) (Not-> private)
     *

}
*/