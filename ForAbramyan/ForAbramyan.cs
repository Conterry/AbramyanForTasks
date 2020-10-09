    using System;

namespace ForAbramyan
{
    public class ForAbramyan
    {
        static void Main(string[] args)
        {
            For17();
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

        public static void For1()
        {

            int k = ReadInt(); 
            int n = ReadInt();

            for(int i = 0; i<n; i++)
            {
                Console.WriteLine(k);
            }
        }

        public static void For5()
        {
            double a = ReadDouble();
            for(double i=0.1; i<=1; i++)
            {
                Console.WriteLine(a * i);
            }
        }

        public static void For9()
        {
            int a = ReadInt(), b = ReadInt();
            int s = 0;

            for(int i = a; a <= b; i++)
            {
                s += i * i;
            }
            Console.WriteLine(s);
        }

        public static void For13()
        {
            int n = ReadInt(), k=1;
            double s = 0, f = 1.1;

            for(double i = 1; i<=n ; i+= 1, k*=-1, f+=0.1)
            {
                s += f*k;
            }
            Console.WriteLine(s);
        }

        public static void For17()
        {
            double a = ReadDouble();
            int n = ReadInt();
            double s = 0;

            for(int i=0; i<n; i++)
            {
                s += Math.Pow(a, i);
            }

            Console.WriteLine(s);
        }

        public static void For21()
        {
            int n = ReadInt();
            double s = 0;

            for(int i=0, f=1; i<n; i++, f *= i)
            {
                s += 1 / f;
            }

            Console.WriteLine(s);
        }

        public static void For25()
        {
            double x = ReadDouble();
            double s = 0;
            int n = ReadInt();

            for(int i=0, d=1; i<n; i++, d *= -1)
            {
                s += d * Math.Pow(x, i) / n;
            }

            Console.WriteLine(s);

        }

        public static void For29()
        {
            int n = ReadInt();
            double a = ReadDouble();
            double b = ReadDouble();
            double h = (b - a) / n;

            Console.WriteLine(h);
            Console.WriteLine(a);
            for(int i = 0; i < n; i++, h+=h)
            {
                Console.WriteLine(a + h);
            }
        }
    }
}
