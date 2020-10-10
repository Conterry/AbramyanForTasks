using System;

namespace WhileAbramyan
{
    class WhileTasks
    {
        static void Main(string[] args)
        {
        }

        public static int ReadInt()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        public static double ReadDouble()
        {
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

        public static void While1()
        {
            double a = ReadDouble();
            double b = ReadDouble();

            while (a > b)
            {
                a -= b;
            }

            Console.WriteLine(a);
        }
    }
}
