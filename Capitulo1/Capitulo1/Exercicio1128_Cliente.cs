using Capitulo1_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe de teste para o exercício 1.1.28
    /// </summary>
    class Exercicio1128_Cliente
    {
        static void Main(string[] args)
        {
            LeitorDeLista whiteListArq = new LeitorDeLista(@"C:\Users\danie\Documents\whitelist.txt");
            LeitorDeLista transacoesArq = new LeitorDeLista(@"C:\Users\danie\Documents\transacoes.txt");

            int[] whitelist = whiteListArq.Ler<int>();
            int[] transacoes = transacoesArq.Ler<int>();

            Array.Sort(whitelist);

            Console.WriteLine("Whitelist antes de remover duplicatas: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(whitelist));

            whitelist = Vetor.RemoveDuplicatas<int>(whitelist);

            Console.WriteLine("Whitelist depois de remover duplicatas: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<int>(whitelist));

            Console.WriteLine("===============================================");

            Console.WriteLine("Transações presentes na whitelist: ");

            foreach (int i in transacoes)
            {
                if (BuscaBinaria.Rank(i, whitelist) != -1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
