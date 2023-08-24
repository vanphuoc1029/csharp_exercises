//Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn

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
            double s = 0;
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                s = Math.Sqrt(2 + s);
            }
            Console.WriteLine($"S: {s}");
        }
    }
} 
