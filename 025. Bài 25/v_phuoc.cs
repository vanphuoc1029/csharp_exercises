
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
            Console.Write($"Cac uoc so le cua {n} la:");
            for(int i = 1; i <= n; i++)
            {
                if (n%i == 0)
                {
                    if (i%2 == 0){
                        Console.Write($"{i} ");
                    }
                }    
            }
        }
    }
} 
