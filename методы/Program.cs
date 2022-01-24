using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {        
        static void Main(string[] args)
        {
            double ST (double a, double b, double c)
            {
                double P = (a + b + c) / 2;
                double S = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
                return S;
            }
            void SravnST (double s1, double s2)
            {
                if (s1 > s2) Console.WriteLine($"_Площаль первого больше..");
                else
                    if (s1 < s2) Console.WriteLine($"_Площадь второго больше..");
                    else
                        Console.WriteLine($"_Площади равны..");
            }
            bool Prover (double a, double b, double c)
            {
                bool result;
                if ((a < b + c) & (b < a + c) & (c < a + b)) result = true; else result = false;
                return result;
            }
            double[] storona  = new double[6];
            begin:
            Console.WriteLine($"_Введите длины сторон двух треугольников..");
            for ( int i=0; i<6; i++)
            {
                storona[i] = Convert.ToDouble(Console.ReadLine());
            }
            if ((Prover(storona[0], storona[1], storona[2]) == false) | (Prover(storona[3], storona[4], storona[5]) == false))
            {
                Console.WriteLine($"_Неверные данные. Треугольник(и) не определен(ы)..");
                goto begin;
            }
            SravnST(ST(storona[0], storona[1], storona[2]),ST(storona[3], storona[4], storona[5]));
            Console.WriteLine($"GoodBuy!!");
            Console.ReadKey();
        }
    }
}

