using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Potencia(5, 3, 0));
        }
        static int Potencia(int baze, int expoente, int cont)
        {
            
            if (cont == expoente)
            {
                return 1;
            }
            return baze * Potencia(baze, expoente, cont + 1);
        }
    }
}
