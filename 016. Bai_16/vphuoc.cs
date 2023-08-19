
using Microsoft.Win32;
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
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            int i = 1, j = 1;
            double sum1 = 0, sum2 = 0, power = 1;
            while (i <= n)
            {
                while (j <= i)
                {
                    sum2 += j;
                    power *= x;
                    j++;
                }
                sum1 += power/sum2;
                i++;
            }
            Console.WriteLine($"Sum: {sum1}");
        }
    }
} 
