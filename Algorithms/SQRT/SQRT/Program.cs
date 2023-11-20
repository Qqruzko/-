using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQRT
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number to find root");
            double target_x = double.Parse(Console.ReadLine());
            Sqrt(target_x);
        }
        static void Sqrt(double target_x)
        {
            double oldx = 0;
            double x = 1;
            do
            {
                oldx = x;
                x = (x + target_x / x) / 2;

            }
            while (oldx != x);
            Console.WriteLine(x);
            Console.WriteLine(x * x);
            Console.ReadLine();
        }
    }
}
