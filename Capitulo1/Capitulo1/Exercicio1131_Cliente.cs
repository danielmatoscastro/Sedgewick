using System;
using System.Drawing;
using System.Drawing.Imaging;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe cliente para o exercício 1.1.31.
    /// </summary>
    public class Exercicio1131_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o valor N:");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor p: ");
                double p = Convert.ToDouble(Console.ReadLine());

                RandomConnections rc = new RandomConnections(N, p);
                rc.Run(@"../../Exercicio1131.png");

                Console.WriteLine("Imagem gerada com sucesso.");
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