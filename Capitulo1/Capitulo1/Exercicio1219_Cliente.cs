using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.19
    /// </summary>
    public class Exercicio1219_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a data: ");
                string data = Console.ReadLine();
                Console.Write("Digite a transação: ");
                string transacao = Console.ReadLine();
                
                Console.WriteLine("Data:");
                Console.WriteLine(new Date(data));
                Console.WriteLine("Transação:");
                Console.WriteLine(new Transaction(transacao));
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