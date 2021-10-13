using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLinq
{
    class Program
    {
        static void Main()
        {
            int[] vetor = new int[11];

            //leitura dos dados informador pelo usuario
            Console.WriteLine("Leitura do vetor, informe os números abaixo:");
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Vetor[" + i + "] :");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int npar = (from n in vetor select n).Where(n => n % 2 == 0).Count();
            int nimpar = (from n in vetor select n).Where(n => n % 2 > 0).Count();

            Console.WriteLine($"Total de números impares é {nimpar} e total de números pares é {npar}.");
            Console.ReadLine();
        }
    }
}
