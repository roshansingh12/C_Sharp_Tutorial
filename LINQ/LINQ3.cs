/*using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_sharp_tutorial.LINQ
{
    public class Employee
    {
        public int id;
        public string name;
        public string gender;
    }
   
    internal class LINQ3
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Quantifier operator : returns boolean value which shows if some or all elements of sequence setisfies the given condition.");
            List<Employee> list = new List<Employee>() {
                new Employee(){id=0,name="abcd0",gender="male" },
                new Employee(){id=1,name="abcd1",gender="female"  },
                new Employee(){id=2,name="abcd2",gender="male"  },
                new Employee(){id=3,name="abcd3",gender="female"  },
                new Employee(){id=4,name="abcd4",gender="male"  },
                new Employee(){id=5,name="abcd5",gender="male"  },
                new Employee(){id=6,name="abcd6",gender="female"  }
            };
            Employee emp = new Employee() {id=0,name="abcd0"};
            Console.WriteLine(list.Any(x => x.id > 3));
            Console.WriteLine(list.All(x => x.id >= 0));
            List<int> nums = new List<int>() {1,2,3,4,5,6,7 };
            Console.WriteLine(nums.Contains(3));
            var res = list.GroupBy(x => x.gender);
            foreach(var val in res)
            {
                Console.WriteLine(val.Key);
                var sum = 0;
                foreach(var item in val)
                {
                    sum += item.id;
                }
                Console.WriteLine($"Sum of id's of {val.Key} " + sum);
            }
            res = list.GroupBy(x => x.gender);
            res = res.ToList();
            Console.WriteLine();
            Console.WriteLine(res.Count());

        }
    }
}
*/