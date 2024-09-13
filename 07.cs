using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Somar(2,7));
        }
        static int Somar (int a,int b)
        {
            if (a == b)
            {
                return b;
            }
            return a + Somar(a+1,b);
        }
    }
}
