using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "arroz";
            string string2 = "roz";
            Console.WriteLine(Substring(string1,string2,0,0,string2.Length-1,string1.Length-1));
        }
        static bool Substring (string string1,string string2, int indice, int contstring2, int tamstring2, int tamstring1) 
        {
            if (contstring2 > tamstring2)
            {
                return true;
            }
            if (indice > tamstring1)
            {
                return false;
            }
            if (string1[indice] == string2[contstring2])
            {
                return Substring(string1, string2, indice+1, contstring2+1, tamstring2, tamstring1);
            }
            else
            {
                return Substring(string1, string2, indice +1, 0, tamstring2, tamstring1);
            }

        } 
    }
}
