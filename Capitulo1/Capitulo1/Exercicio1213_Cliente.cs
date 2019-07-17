using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.13.
    /// </summary>
    public class Exercicio1213_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o nome do dono da transação: ");
                string who = Console.ReadLine();
                Console.Write("Digite a data da transação: ");
                string when = Console.ReadLine();
                Console.Write("Digite o valor da transação: ");
                string amount = Console.ReadLine();
                
                Transaction tr = new Transaction(String.Format("{0} {1} {2}", who, when, amount));
                
                Console.WriteLine(tr);
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