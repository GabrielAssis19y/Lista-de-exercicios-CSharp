using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Contador("beterraba", 'i', 0));
        }
        static int Contador (string palavra, char caractere, int inicio)
        {
            if (inicio > palavra.Length-1)
            {
                return 0;
            }
            if (palavra[inicio] == caractere)
            {
                return 1 + Contador(palavra, caractere, inicio + 1);
            }
            return Contador(palavra, caractere, inicio + 1);
        }
    }
}
