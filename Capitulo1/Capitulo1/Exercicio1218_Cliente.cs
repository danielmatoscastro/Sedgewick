using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.18.
    /// </summary>
    public class Exercicio1218_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o limite inferior: ");
                int linf = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o limite superior: ");
                int lsup = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de números a serem gerados: ");
                int N = Convert.ToInt32(Console.ReadLine());

                Random random = new Random(DateTime.Now.Millisecond);
                Accumulator accumulator = new Accumulator();

                for (int i = 0; i < N; i++)
                {
                    accumulator.AddDataValue(random.Next(linf, lsup + 1));
                }

                Console.WriteLine("Resultado:");
                Console.WriteLine(accumulator);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}