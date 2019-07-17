using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.14.
    /// </summary>
    public class Exercicio1214_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite a transação 1: ");
                Transaction tr1 = LerTransacao();
                Console.WriteLine("Digite a transação 2: ");
                Transaction tr2 = LerTransacao();

                if (tr1.Equals(tr2))
                {
                    Console.WriteLine("As transações são iguais.");
                }
                else
                {
                    Console.WriteLine("As transações são diferentes.");
                }

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

        private static Transaction LerTransacao()
        {
            Console.Write("Digite o nome do dono da transação: ");
            string who = Console.ReadLine();
            Console.Write("Digite a data da transação: ");
            string when = Console.ReadLine();
            Console.Write("Digite o valor da transação: ");
            string amount = Console.ReadLine();
                
            return new Transaction(String.Format("{0} {1} {2}", who, when, amount));
        }
    }
}