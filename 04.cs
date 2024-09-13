using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            string palavra = "arara";
            Console.Write(Pali(palavra, inicio, palavra.Length - 1));

        }
        static bool Pali (string palavra, int inicio, int fim)
        {
            if (inicio >= fim)
            {
                return true;
            }
            if (palavra[inicio] != palavra[fim])
            {
                return false;
            }
            return Pali(palavra, inicio + 1, fim - 1);
        }
    }
}
