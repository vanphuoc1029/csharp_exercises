
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1, j = 1; 
            double sum1 = 1, sum2 = 0;
            while (i <= n)
            {
                while (j <= i)
                {
                    sum2 += j;
                    j++;
                }
                sum1 += 1/sum2;
                i++;
            }
            Console.WriteLine($"Sum: {sum1}");
        }
    }
} 
