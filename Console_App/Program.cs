using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FirstDLL;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j;
            i = Convert.ToDouble(Console.ReadLine());
            j = Convert.ToDouble(Console.ReadLine());
            Class1.SumFunc(i, j);
        }
    }
}
