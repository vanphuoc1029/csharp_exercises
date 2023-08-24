//Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25


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
            int max = 1;
            for(int i = 1; i < n; i++)
            {
                if (n%i == 0)
                {
                    if (i % 2 == 1)
                    {
                        if (i > max)
                        {
                            max = i;
                        }
                    }
                    
                }    
            }
            Console.WriteLine($"Uoc so le lon nhat cua {n}: {max}");
        }
    }
} 
