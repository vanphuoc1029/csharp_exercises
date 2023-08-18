//Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n:");
            n = int.Parse(Console.ReadLine());
            int tich = 1, i = 1, j = 1, sum = 0;
            while (i <= n) {
                while (j <= i )
                {
                    tich *= j;
                    j++;
                }
                sum += tich;
                i++;
            }
            Console.WriteLine($"sum: {sum}");            
        }
        
    }
}
