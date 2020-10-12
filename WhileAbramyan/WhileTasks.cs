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

        public static void While5()
        {
            int n = ReadInt();

            while (n > 2)
            {
                n /= 2;
            }

            Console.WriteLine(n);
        }

        public static int While9(int n)
        {
            
            int k = 0;

            while(n >= Math.Pow(3, k))
            {
                k++;
            }

            return k
        }

        public static void While12()
        {
            int n = ReadInt();
            int k = 1;
            int s = 0;

            while(s <= n-k)
            {
                s += k;
                k++;
            }

            Console.WriteLine(k);
            Console.WriteLine(s);
        }

        public static int While15(double p)
        {
            double Money = 1000;
            int i = 0;

            while(Money < 1100d)
            {
                Money += Money * p / 100;
                i++;
            }

            return i;   
        }

        public static bool While20()
        {
            int n = ReadInt();
            int k = 0;

            while (k != 2)
            {
                k = n % 10;
                n /= 10;
            }

            if (k == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool While24()
        {
            int n = ReadInt();
            int f1 = 1, f2 = 1, res;

            while (n <= f2)
            {
                res = f1;
                f1 = f2;
                f2 = res + f2;
            }

            if(f2 == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void While28()
        {
            int n = ReadInt();
            double a1 = 2, a2 = 2 +1/a1, res;

            while (a2 - a1 >= n)
            {
                res = a1;
                a1 = a2;
                a2 = 2+ 1/ res;
            }

            Console.WriteLine(a2);

        }

    }
}
