using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Contador(678854));
        }
        static int Contador (int n)
        {
            if (n < 10)
            {
                return 1;
            }
            return 1 + Contador(n / 10);
        }
    }
}
