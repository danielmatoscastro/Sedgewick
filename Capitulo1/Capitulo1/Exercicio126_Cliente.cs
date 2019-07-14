using System;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.6.
    /// </summary>
    public class Exercicio126_Cliente
    {
        private static bool EhRotacaoCircular(string a, string b)
        {
            return a.Length == b.Length && (a + a).IndexOf(b) != -1;
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite a string A:");
                string a = Console.ReadLine();
                Console.WriteLine("Digite a string B:");
                string b = Console.ReadLine();

                if (EhRotacaoCircular(a, b))
                {
                    Console.WriteLine("As strings são uma rotação circular.");
                }
                else
                {
                    Console.WriteLine("As strings não são uma rotação circular.");
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
    }
}