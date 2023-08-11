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
            Console.Write("Nhap N: ");
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (float i = 0; i <= N; i++)
            {
                sum += 1 / (2*i+1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
