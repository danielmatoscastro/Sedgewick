using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.1.37
    /// </summary>
    public class Exercicio1137_Cliente
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int M = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o número de embaralhamentos: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[M];
            int[][] tabela = Matrix.InicializarMatriz<int>(M, M);
            
            for (int i = 0; i < N; i++)
            {
                InicializaArray(arr);
                Vetor.BadShuffle<int>(arr);
                PreencheTabela(tabela, arr);
            }

            Console.WriteLine("Resultado: ");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<int>(tabela));
            Console.ReadKey();
        }

        private static void PreencheTabela(int[][] tabela, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int elemento = arr[i];
                tabela[elemento][i] += 1;
            }
        }
        
        private static void InicializaArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
    }
}