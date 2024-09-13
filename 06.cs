using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Primo(3,2));
        }
        static bool Primo (int n, int divisor)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == divisor)
            {
                return true;
            }
            if (n%divisor == 0)
            {
                return false;
            }
            
            return Primo(n, divisor + 1);
        }
    }
}
