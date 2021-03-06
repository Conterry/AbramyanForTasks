﻿using System;
using System.Transactions;


namespace ForAbramyan
{
    public class ForTasks
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

        public static int For9(int a, int b)
        {
            int s = 0;

            for(int i = a; a <= b; i++)
            {
                s += i * i;
            }
            return s;
        }

        public static double For13(int n)
        {
            int k=1;
            double s = 0, f = 1.1;

            for(double i = 1; i<=n ; i+= 1, k*=-1, f+=0.1)
            {
                s += f*k;
            }

            return s;
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

        public static void For33()
        {
            int n = ReadInt();
            int f1 = 1, f2 = 1, res;

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for(int i = 2; i < n; i++)
            {
                res = f1;
                f1 = f2;
                f2 = res + f2;
                Console.WriteLine(f2);
            }
        }

        public static void For37()
        {
            int n = ReadInt();
            double s=0;

            for (int i = 1; i <= n; i++)
            {
                s += Math.Pow(i, i);
            }

            Console.WriteLine(s);
        }
    }
}
