//Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không

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
            for(int i = 2; i < n; i++)
            {
                if (n%i == 0)
                {
                    count ++; 
                   
                }    
            }
            if (count == 0)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
        }
    }
} 
