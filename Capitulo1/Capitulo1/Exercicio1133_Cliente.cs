using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Classe cliente para o exercício 1.1.33.
    /// </summary>
    public class Exercicio1133_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                ApresentarMenu();

                int opcao = LerOpcao();

                ExecutarOperacaoEscolhida(opcao);
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

        private static void ExecutarOperacaoEscolhida(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    ProdutoEscalar();
                    break;

                case 2:
                    ProdutoMatrizMatriz();
                    break;

                case 3:
                    Transposta();
                    break;

                case 4:
                    ProdutoMatrizVetor();
                    break;

                case 5:
                    ProdutoVetorMatriz();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static int LerOpcao()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void ApresentarMenu()
        {
            Console.WriteLine("Olá. Escolha a opção desejada.");
            Console.WriteLine("1. Produto escalar.");
            Console.WriteLine("2. Produto matriz-matriz.");
            Console.WriteLine("3. Transposta de uma matríz.");
            Console.WriteLine("4. Produto matriz-vetor.");
            Console.WriteLine("5. Produto vetor-matriz.");
        }

        private static void ProdutoVetorMatriz()
        {
            Console.WriteLine("Insira o vetor:");
            double[] vetor = LerVetor();

            Console.WriteLine("Insira a matriz:");
            double[][] matriz = LerMatriz();

            double[] resultado = Matrix.mult(vetor, matriz);

            Console.WriteLine("Resultado: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<double>(resultado));
        }

        private static void ProdutoMatrizVetor()
        {
            Console.WriteLine("Insira a matriz:");
            double[][] matriz = LerMatriz();

            Console.WriteLine("Insira o vetor:");
            double[] vetor = LerVetor();

            double[] resultado = Matrix.mult(matriz, vetor);

            Console.WriteLine("Resultado: ");
            Console.WriteLine(ImpressorVetorial.ImprimeArray<double>(resultado));
        }

        private static void Transposta()
        {
            Console.WriteLine("Insira a matriz:");
            double[][] matriz = LerMatriz();

            double[][] resultado = Matrix.Transpose(matriz);

            Console.WriteLine("Resultado:");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<double>(resultado));
        }

        private static void ProdutoMatrizMatriz()
        {
            Console.WriteLine("Insira a primeira matriz:");
            double[][] matrizA = LerMatriz();

            Console.WriteLine("Insira a segunda matriz:");
            double[][] matrizB = LerMatriz();

            double[][] resultado = Matrix.mult(matrizA, matrizB);

            Console.WriteLine("Resultado:");
            Console.WriteLine(ImpressorMatricial.ImprimeMatriz<double>(resultado));
        }

        private static void ProdutoEscalar()
        {
            Console.WriteLine("Insira o primeiro vetor:");
            double[] vetorA = LerVetor();

            Console.WriteLine("Insira o segundo vetor:");
            double[] vetorB = LerVetor();

            double resultado = Matrix.dot(vetorA, vetorB);

            Console.WriteLine("Resultado: {0}", resultado);
        }
        
        private static double[][] LerMatriz()
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int numLinhas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de colunas da matriz: ");
            int numColunas = Convert.ToInt32(Console.ReadLine());

            double[][] matriz = Matrix.InicializarMatriz<double>(numLinhas, numColunas);

            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    Console.Write("Digite o elemento [{0}][{1}]:", i, j);
                    matriz[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            return matriz;
        }

        private static double[] LerVetor()
        {
            Console.Write("Digite o número de elementos do vetor: ");
            int numElementos = Convert.ToInt32(Console.ReadLine());

            double[] vetor = new double[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine("Digite o elemento [{0}]: ", i);
                vetor[i] = Convert.ToDouble(Console.ReadLine());
            }

            return vetor;
        }
    }
}