//Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
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
            int sum = 0;
            for (int i = 0; i <= N; i++)
                {
                    sum += i;
                }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
