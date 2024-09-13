using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inverter("pergaminho", 0);
        }
        static void Inverter (string palavra, int inicio)
        {
            
            if (inicio == palavra.Length-1)
            {
                Console.Write(palavra[inicio]);
                return;
            }
            Inverter(palavra, inicio + 1);
            Console.Write(palavra[inicio]);

        }
    }
}
