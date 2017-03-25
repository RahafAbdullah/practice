using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Myfirst programm
            Console.WriteLine(" Hello World ");
            float x = float.MinValue;
            short y = short.MaxValue;
            int z = int.MaxValue;
            Console.WriteLine(" float {0} \n short {1} \n int {2} ", x, y, z);
            float a = 1f / 3;
            double b = 1d / 3;
            decimal c = 1m / 3;
            decimal d = 1m / 3;
            Console.WriteLine(" float {0} \n double {1} \n decimal {2} \n decimal2 {3}", a, b, c,d);
            Console.ReadLine();

        }
    }
}
