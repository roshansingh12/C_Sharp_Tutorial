namespace C_sharp
{
    public class DelegatesAndEvents
    {
        public delegate void del_ev(int a, int b);
        event del_ev my_event;
        public DelegatesAndEvents()
        {
            this.my_event += Add;
            this.my_event += Mul;
            this.my_event += Sub;
        }
        public delegate void calculator(int a, int b);
        public static void Add(int a, int b)
        {
            Console.Write("Addition : " + (a + b) + " ");
        }
        public static void Mul(int a, int b)
        {
            Console.Write("Multiplication : "+ (a * b) + " ");
        }
        public static void Sub(int a, int b)
        {
            Console.Write("Subtraction : "+(a - b) + " ");
        }

       /* public static void Main(string[] args)
        {
            calculator cal_del = new calculator(Add);
            cal_del += Mul;
            cal_del+= Sub;
            cal_del(10, 20);
            var any_del = delegate (int a, int b)
            {
                Console.WriteLine("values : "+a + "," + b);
            };
            any_del(10, 20);

            DelegatesAndEvents dne = new DelegatesAndEvents();
            dne.my_event(30, 30);
        }*/
        
        //event is notification mechanism that depends on delegates
        //events depoendent on delegates 
        //events are wrapper over delegate to improve its security

    }
}