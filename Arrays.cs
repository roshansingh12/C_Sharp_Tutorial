/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial
{
    internal class Arrays
    {
        public static void Display(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        //method overloading, same name different type parameters
        public static void Display(string[] array)
        {
            foreach (string i in array)
            {
                Console.Write(i + " ");
            }
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //1D array of length n
            int[] integer_1D_array = new int[n];
            //appending values in aray
            for(var i = 0; i < n; i++)
            {
                integer_1D_array[i]=i;
            }
            //Array to function
            Display(integer_1D_array);
            Console.WriteLine();
            //Multi Dimensional Array
            int[,] multidimensional_array = new int[n,2];
            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    multidimensional_array[i, j] = i;
                    Console.Write(multidimensional_array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //array of array or jagged array
            string[][] str_arr = new string[n][];
            for (int i = 0; i < n; i++)
            {
                str_arr[i] = new string[i];//each row will be of legth equal to it's row number
                for(int j = 0; j < i; j++)
                {
                    Console.Write(String.Format("enter value of str_arr[{0}][{1}] = ",i,j));
                    str_arr[i][j] = Console.ReadLine();
                }

            }

            for(int i = 0; i < n; i++)
            {
                Display(str_arr[i]);
                Console.WriteLine();
            }
            //Params are way of paasing list of values to the method without declaring them in method
            void display(params int[] values)
            {
                foreach(var i in values)
                {
                    Console.Write(i);
                }
            }
            display(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("apssing values of different datatypes using 'params object[]'");
            void display_objects(params object[] values)
            {
                foreach(var v in values)
                {
                    
                    Console.Write(v);
                }
            }
            display_objects("roshan",'a',6, new int[3] {1,2,3});

        }
    }
}
*/