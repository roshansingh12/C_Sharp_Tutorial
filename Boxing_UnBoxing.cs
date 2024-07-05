using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial
{
    internal class Boxing_UnBoxing
    {
        public static void Main(string[] args)
        {
            //boxing -> converting value type (int,double,string) to reference type (object)
            int val = 10;
            object obj_val = val; // boxing
            //unboxing -> converting reference type (object) to value type (int, string,short)
            string val_val = (string)obj_val;
        }
    }
}
