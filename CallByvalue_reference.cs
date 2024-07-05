using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial
{
    public class CallByvalue_reference
    {
        public static void change_and_show_by_value(int val)
        {
            val += val;
            Console.WriteLine(String.Format("value in method {0}",val));
        }
        public static void change_and_show_by_ref(ref int val)
        {
            val += val;
            Console.WriteLine("value in method {}"+val);
        }
        public static void initialize_var_by_out(out int val)
        {
            val = 50;
            Console.WriteLine(String.Format("here we have initialiazed var declared in Main method! {0}",val));
        }
        public static void in_type_checking(in int x)
        {
            //x = 90; => giving compile time error as in defines readonly variable hence cann't be modified or re-defined.
        }
        
        /*public static void Main(string[] args)
        {
            int val = 10;
            Console.WriteLine("passing variabl to the method and changing it inside method will not change the actual defined value!");
            Console.WriteLine("actual value {}"+val);
            change_and_show_by_value(val);
            Console.WriteLine("actual value {}"+val);
            Console.WriteLine("passing reference of variable to the method and changing it inside method will change the actual defined value!");
            change_and_show_by_ref(ref val);
            Console.WriteLine("actual value {}"+val);
            Console.WriteLine("assigning value from other method using 'out' keyword!");
            int out_val;
            initialize_var_by_out(out out_val);
            Console.WriteLine("actual value : out_val = "+out_val);
        }*/
    }
}
