using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Soma(987654321289176543));
        }
        static long Soma (long n)
        {
            if (n < 10)
            {
                return n;
            }
            return n%10 + Soma(n/10);
        }
    }
}
