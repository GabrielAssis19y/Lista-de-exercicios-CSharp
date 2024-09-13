using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int[] vetor = { 1, 2, 3, 4, 5, 6, 4, 4, 2, 4, 5, 4, 4, 6, 4, 5, 4, 5, 4,
1, 2, 3, 4, 5,
6, 4, 4, 2, 4, 5, 4, 4, 6, 4, 5, 4, 5, 4, 1, 2, 3, 4, 5, 6, 4, 4, 2, 4, 5,
4, 4, 6, 4,
5, 4, 5, 4 , 1, 2, 3, 4, 5, 6, 4, 4, 2, 4, 5, 4, 4, 6, 4, 5, 4, 5, 4, 1,
2, 3, 4, 5, 6, 4,
4, 2, 4, 5, 4, 4, 6, 4, 5, 4, 5, 4 };
            int num = 4;
            int ocorrencias = Ocorrencia(vetor, num, 0, vetor.Length - 1, cont);
            Console.WriteLine($"O número {num} ocorre {ocorrencias} vezes no vetor.");
        }
        static int Ocorrencia (int[] vetor, int num, int inicio, int tamanhovet, int cont)
        {
            if (inicio > tamanhovet)
            {
                return cont;
            }
            if (vetor[inicio] == num)
            {
                cont++;
            }
            return Ocorrencia(vetor, num, inicio + 1, tamanhovet, cont);
        }
    }
}
