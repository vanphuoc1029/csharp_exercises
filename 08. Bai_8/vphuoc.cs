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
            double S = 0, i = 0;
            while (i <= n) {
                S += (2 * i + 1) / (2 * i + 2);
                i++;
            }
            Console.WriteLine($"S: {S}");
            
            Console.Read();
        }
        
    }
}
