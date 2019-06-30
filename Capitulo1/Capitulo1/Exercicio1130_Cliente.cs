using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe cliente para o exercício 1.1.30
    /// </summary>
    public class Exercicio1130_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o valor de N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                bool[][] matriz = new bool[N][];

                for (int i = 0; i < N; i++)
                {
                    matriz[i] = new bool[N];
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i != 0 && j != 0 && MaximoDivisorComum.Mdc(i, j) == 1)
                        {
                            matriz[i][j] = true;
                        }
                        else
                        {
                            matriz[i][j] = false;
                        }
                    }
                }

                Console.WriteLine(ImpressorMatricial.ImprimeMatriz(matriz));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            ;
        }
    }
}