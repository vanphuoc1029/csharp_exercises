//Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n
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
            int i = 1, j = 1, sum = 0, power = 1;
            while (i <= n)
            {
                while (j <= 2*i)
                {
                    power *= x;
                    j++;
                }
                sum += power;
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
} 
