using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.LINQ
{
    internal class LINQ1
    {
        //Each query is cpombination of three things
        /*
         * Initilization - target data from a data source
         * conditions - to filter out data
         * selection - to select data
         */
        //Three ways in which we write linq queries
        /*
         * Query syntax like SQL -> More readable, more like SQL
         * Method Syntax -> Not all operations can be expressed in SQL query. that's where we need methods
         * Mixed Syntax - (Query + Method)
         */
        //Query yntax 
        static List<int> num_list = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
        static void Query0()
        {
            var Query_res =  from num in num_list
                             where num % 2 == 0
                             select num;
            Console.WriteLine(Query_res);
            foreach (var item in Query_res) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Query1()
        {
            var Query_res = num_list.Where(num => num % 2 == 0).Select(num => num * num);
            foreach(var item in Query_res)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        static void Query2()
        {
            var Query_res = (from num in num_list
                             where num % 3 == 0
                             select num).Sum();
            Console.WriteLine(Query_res);
            Console.WriteLine();
        }
        static List<Student> student_list = new List<Student>()
        {
            new Student() { id=1,name="xyz_1",age=23},
            new Student() { id=2,name="xyz_2",age=33},
            new Student() { id=3,name="xyz_3",age=53}
        };
        static void IEnumerable_query()
        {
            IEnumerable<Student> Query = (from std in student_list
                                         select std);
            foreach(Student student in Query) { Console.WriteLine($"{student.id}, {student.name}"); }
            Console.WriteLine();
        }
        static void IQueryable_query()
        {
            IQueryable<Student> std_list = (from std in student_list
                                            select std).AsQueryable().Where(std => std.age>0);
            foreach(Student std in std_list)
            {
                Console.Write($"{std.name} : {std.age}");
            }
        }
        /*public static void Main(string[] args) 
        {
            Query0();
            Query1();
            Query2();
            IEnumerable_query();
            IQueryable_query();
            Console.ReadKey();
        }*/


    }
}
