using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Solutions
{
    class Program
    {
        static double Elso_feladat(int n)
        {
            if (n == 0)
            {
                return 5;
            }
            return (Math.Pow(Elso_feladat(n - 1), 2) + 2 * Elso_feladat(n - 1)) / 10;
        }

        public static int Lnko(int a, int b)
        {
            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            else if (b == 0)
            {
                return a;
            }

            return Lnko(b, a - b);
        }

        static int Masodik_feladat(int a, int b)
        {
            return (a * b) / Lnko(a, b);
        }

        static int Harmadik_feladat(int c1, int c2, int n)
        {
            if (n == 0)
            {
                return c1;
            }

            if (n == 1)
            {
                return c2;
            }

            return Harmadik_feladat(c1, c2, n - 2) + Harmadik_feladat(c1, c2, n - 1);
        }

        static int Vsetkojedno(int a, int d)
        {
            if (a == 0)
            {
                return 0;
            }
            else
            {
                d = Vsetkojedno(a / 2, d);
                return d + (a % 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(Elso_feladat(i) + " ");
            }


            Console.WriteLine("\n\n------------------------------\n");
            Console.WriteLine("2. feladat");
            Console.Write("Adja meg az A számot: ");
            int input_a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az B számot: ");
            int input_b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A legkissebb közös többszörö ({input_a};{input_b})-nek: {Masodik_feladat(input_a, input_b)}");


            Console.WriteLine("\n\n------------------------------\n");
            Console.WriteLine("3. feladat");
            Console.Write("Adja meg a c1-et: ");
            int input_c1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a c2-et: ");
            int input_c2 = int.Parse(Console.ReadLine());
            Console.Write("Hányadik tagra (n) kíváncsi: ");
            int input_n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < input_n; i++)
            {
                Console.Write(Harmadik_feladat(input_c1, input_c2, i) + " ");
            }


            Console.WriteLine("\n\n------------------------------\n");
            Console.WriteLine("4. feladat");
            int d = 0;
            Console.WriteLine($"Eredmény: {Vsetkojedno(35, d)}");

            Console.ReadKey();
        }
    }
}
