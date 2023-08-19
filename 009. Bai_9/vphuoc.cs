using System;
using System.Collections.Generic;
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
            int tich = 1, i = 1;
            while (i <= n) {
                tich *= i;
                i++;
            }
            Console.WriteLine($"tich: {tich}");
            
            Console.Read();
        }
        
    }
}
