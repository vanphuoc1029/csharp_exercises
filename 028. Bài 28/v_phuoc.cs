//Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
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
            int s = 0;
            for(int i = 1; i < n; i++)
            {
                if (n%i == 0)
                {
                    s += i;
                }    
            }
            Console.WriteLine($"Tong uoc nguyen duong nho hon {n}: {s}");
        }
    }
} 
