//Bài 19: Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!

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
            int i = 0, j = 1;
            double sum = 1, factorial = 1, power = 1;
            while (i <= n)
            {
                while (j <= 2*i+1)
                {
                    factorial *= j;
                    power *= x;
                    j++;
                }
                sum += power/factorial;
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
} 
