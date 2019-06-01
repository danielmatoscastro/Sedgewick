using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo1_Cliente
{
    class Exercicio1121_Cliente
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas: ");
            int numLinhas = Convert.ToInt32(Console.ReadLine());

            List<Tuple<string, int, int>> tabela = new List<Tuple<string, int, int>>();

            for (int i = 0; i < numLinhas; i++)
            {
                Console.WriteLine("Digite uma linha: ");
                string[] entrada = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Tuple<string, int, int> linha = new Tuple<string, int, int>(entrada[0],
                                                        Convert.ToInt32(entrada[1]),
                                                        Convert.ToInt32(entrada[2]));

                tabela.Add(linha);
            }

            Console.WriteLine("=================================================");
            Console.WriteLine("Resultado: ");

            foreach (Tuple<string, int, int> linha in tabela)
            {
                Console.WriteLine("{0} \t{1} \t{2} \t{3:0.000}",
                       linha.Item1, linha.Item2, linha.Item3, Convert.ToDouble(linha.Item2) / linha.Item3);
            }

            Console.ReadKey();
        }
    }
}
