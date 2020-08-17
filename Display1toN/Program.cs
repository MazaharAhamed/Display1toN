using System;

namespace Display1toN
{
    class Program
    {
        public static void Print1(int n)
        {
            if (n == 0)
                return;
            Console.Write(n+" ");
            Print1(n - 1);
        }

        public static void Print2(int n)
        {
            if (n == 0)
                return;
            Print2(n - 1);
            Console.Write(n + " ");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Print1(x);
            Console.WriteLine("");

            Print2(x);
            Console.WriteLine("");
        }
    }
}
