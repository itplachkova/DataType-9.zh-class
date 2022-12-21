using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = -100;
            byte n2 = 128;
            short n3 = -3540;
            ushort n4 = 64876;
            int n5 = 2147483647;
            int n6 = -1141583228;
            long n7 = -1223372036854775808;
            Console.WriteLine($"{n1}, {n2}, {n3}, {n4}, {n5}, {n6}, {n7}");
        }
    }
}
