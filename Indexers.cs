using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial
{
    public class Detail
    {
        public int id;
        public string summary;

        public Detail(int _id,string _summary)
        {
            id = _id;
            summary = _summary;
        }

        public object this[int i]
        {
            get
            {
                switch (i)
                {
                    case(0): return this[0];
                        //break; -> unreachable
                    default:return this[1];
                }
            }
            set
            {
                switch (i)
                {
                    case (0):
                        this[0]= value;
                        break;
                    default:
                        this[1]= value;
                        break;
                }
            }
        }
    }
    internal class Indexers // Indexer<T> this is Generic class 
    {
        public static void Main(string[] args)
        {
            //dynamic x = 4;
            //x = x + "Roshan";//dynamic varaibles don't give compile time error but will raise at runtime.
            Detail det = new Detail(0,"Story");
            Console.WriteLine(
$@"id : {det[0]}
Summary : {det[1]}");
        }
    }
}
