using System;

namespace задание_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            KUB(a, out V, out S);
            Console.Write("Объем куба =");
            Console.WriteLine(V);
            Console.Write("Площадь ребр куба =");
            Console.WriteLine(S);

            Console.ReadKey();
        }
        static void KUB(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
        }
    }
}

