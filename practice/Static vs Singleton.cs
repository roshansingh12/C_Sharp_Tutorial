using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial.practice
{
    internal class Static_vs_Singleton
    {
        /*public: error -> access modifiers not allowed on static constructor*/ static Static_vs_Singleton()
        {

        }
    }
    public class Singleton
    {
        public static Singleton _instance = null;
        public static readonly object padlock = new object();
        private Singleton() { }
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            return new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

    }
    public class _Program 
    {
        /*public static void Main(string[] args)
        {
            Singleton _singleton1 = Singleton.GetInstance;
            Singleton _singleton2 = Singleton.GetInstance;
            Console.WriteLine(_singleton2 == _singleton1);
        }*/
    }
}
