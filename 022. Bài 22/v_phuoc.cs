//Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n
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
            int tich = 1;
            for(int i = 1; i <= n; i++)
            {
                if (n%i == 0)
                {
                    tich *= i;
                }    
            }
            Console.Write($"Tich = {tich} ");
        }
    }
} 
