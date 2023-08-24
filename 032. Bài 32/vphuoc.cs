//Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không

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
            int count = 0;
            bool result = false;
            for(int i = 1; i < n; i++)
            {
                if (i * i == n)
                {
                    result = true;
                    break;
                }

            }
            if (result)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so chinh phuong");
            }
        }
    }
} 
