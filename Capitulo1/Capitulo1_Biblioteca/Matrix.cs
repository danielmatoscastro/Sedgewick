using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para operações envolvendo matrizes e vetores.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Calcula o produto escalar de dois vetores.
        /// </summary>
        /// <param name="x">Primeiro vetor.</param>
        /// <param name="y">Segundo vetor.</param>
        /// <returns>Produto escalar dos vetores informados.</returns>
        public static double dot(double[] x, double[] y)
        {
            double resultado = 0;
            
            for (int i = 0; i < x.Length; i++)
            {
                resultado += x[i] * y[i];
            }

            return resultado;
        }

        /// <summary>
        /// Calcula o produto matricial de duas matrizes quadradas de mesma ordem.
        /// </summary>
        /// <param name="a">Primeira matriz.</param>
        /// <param name="b">Segunda matriz.</param>
        /// <returns>Produto de A e B.</returns>
        /// <exception cref="ArgumentException">Se as matrizes não forem quadradas de mesma ordem.</exception>
        public static double[][] mult(double[][] a, double[][] b)
        {
            int N = a.Length;
            
            if (!EhMatrizQuadrada(a, N) || !EhMatrizQuadrada(b, N))
            {
                throw new ArgumentException("As matrizes informadas devem ser quadradas e de mesma ordem.");
            }

            double[][] resultado = InicializarMatriz<double>(N, N);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        resultado[i][j] += a[i][k] * b[k][j];
                    }
                }
            }

            return resultado;
        }

        /// <summary>
        /// Valida se a matriz informada é quadrada de ordem N.
        /// </summary>
        /// <param name="matriz">Matriz a ser validade.</param>
        /// <param name="N">Ordem.</param>
        /// <returns>True caso a matriz seja quadrada de ordem N. False caso contrário.</returns>
        private static bool EhMatrizQuadrada(double[][] matriz, int N)
        {
            if (matriz.Length != N)
            {
                return false;
            }
            
            for (int i = 0; i < N; i++)
            {
                if (matriz[i].Length != N)
                {
                    return false;
                }
            }

            return true;
        } 
        
        /// <summary>
        /// Cria uma matriz de double do tamanho informado.
        /// </summary>
        /// <param name="numLinhas">Número de linhas da matriz.</param>
        /// <param name="numColunas">Número de colunas da matriz.</param>
        /// <returns>Matriz[numLinhas][numColunas]</returns>
        public static T[][] InicializarMatriz<T>(int numLinhas, int numColunas)
        {
            T[][] matriz = new T[numLinhas][];
            for (int i = 0; i < numLinhas; i++)
            {
                matriz[i] = new T[numColunas];
            }

            return matriz;
        }

        /// <summary>
        /// Faz a transposta da matriz informada.
        /// </summary>
        /// <param name="a">Matriz cuja tranposta será realizada.</param>
        /// <returns>Transposta da matriz A.</returns>
        public static double[][] Transpose(double[][] a)
        {
            int numLinhas = a[0].Length;
            int numColunas = a.Length;

            double[][] transposta = InicializarMatriz<double>(numLinhas, numColunas);

            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    transposta[i][j] = a[j][i];
                }
            }

            return transposta;
        }
        
        /// <summary>
        /// Realiza a multiplicação entre uma matriz e um vetor.
        /// </summary>
        /// <param name="a">Matriz.</param>
        /// <param name="x">Vetor.</param>
        /// <returns>Produto enre a matriz a e o vetor x.</returns>
        /// <exception cref="ArgumentException">Se a multiplicação não for possível.</exception>
        public static double[] mult(double[][] a, double[] x)
        {
            if (!multiplicacaoEhPossivel(a, x))
            {
                throw new ArgumentException("Tamanhos das entradas não são compatíveis.");
            }

            int tamResultado = a.Length;
            double[] resultado = new double[tamResultado];
            
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length; j++)
                {
                    resultado[i] += a[i][j] * x[j];
                }
            }

            return resultado;
        }
        
        /// <summary>
        /// Verifica se a multiplicação entre matriz e vetor é possível.
        /// </summary>
        /// <param name="a">Matriz.</param>
        /// <param name="x">Vetor.</param>
        /// <returns>True caso a multiplicação seja possível. False caso contrário.</returns>
        private static bool multiplicacaoEhPossivel(double[][] a, double[] x)
        {
            int numColunasA = a[0].Length;
            int numLinhasX = x.Length;

            return numColunasA == numLinhasX;
        }

        /// <summary>
        /// Realiza a multiplicação entre um vetor e uma matriz.
        /// </summary>
        /// <param name="y">Vetor.</param>
        /// <param name="a">Matriz.</param>
        /// <returns>Produto entre o vetor y e a matriz a.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double[] mult(double[] y, double[][] a)
        {
            if (!multiplicacaoEhPossivel(y, a))
            {
                throw new ArgumentException("Tamanhos das entradas não são compatíveis.");
            }

            int tamResultado = a[0].Length;
            double[] resultado = new double[tamResultado];
            
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length; j++)
                {
                    resultado[i] += a[j][i] * y[j];
                }
            }

            return resultado;
        }

        /// <summary>
        /// Verifica se a multiplicação entre vetor e matriz é possível.
        /// </summary>
        /// <param name="y">Vetor.</param>
        /// <param name="a">Matriz.</param>
        /// <returns>True caso a multiplicação seja possível. False caso contrário.</returns>
        private static bool multiplicacaoEhPossivel(double[] y, double[][] a)
        {
            int numColunasY = y.Length;
            int numLinhasA = a.Length;

            return numLinhasA == numColunasY;
        }
    }
}