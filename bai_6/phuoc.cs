//Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)
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
            for (float i = 1; i <= N; i++)
            {
                sum += 1 / (i*(i+1));
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
