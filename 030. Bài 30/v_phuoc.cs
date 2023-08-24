// Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không

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
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n%i == 0)
                {
                    sum += i; 
                   
                }    
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} la so hoan thien");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so hoan thien");
            }
        }
    }
} 
