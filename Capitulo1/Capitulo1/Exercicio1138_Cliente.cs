using System;
using System.Diagnostics;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.1.38.
    /// </summary>
    public class Exercicio1138_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lendo listas.");
                
                LeitorDeLista leitorTransacoes = new LeitorDeLista(@"../../algs4-data/largeT.txt");
                LeitorDeLista leitorWhitelist = new LeitorDeLista(@"../../algs4-data/largeW.txt");

                int[] transacoes = leitorTransacoes.Ler<int>();
                int[] whitelist = leitorWhitelist.Ler<int>();

                Console.WriteLine("Rodando busca binária.");
                
                Stopwatch swBuscaBinaria = new Stopwatch();
                swBuscaBinaria.Start();
                foreach (int transacao in transacoes)
                {
                    BuscaBinaria.Rank(transacao, whitelist);
                }

                swBuscaBinaria.Stop();

                Console.WriteLine("Rodando busca linear.");
                
                Stopwatch swForcaBruta = new Stopwatch();
                swForcaBruta.Start();
                foreach (int transacao in transacoes)
                {
                    BuscaForcaBruta.Rank(transacao, whitelist);
                }

                swForcaBruta.Stop();

                Console.WriteLine("Tempo busca binária: {0} segundos.", swBuscaBinaria.Elapsed.TotalSeconds);
                Console.WriteLine("Tempo força bruta: {0} segundos.", swForcaBruta.Elapsed.TotalSeconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
} 