using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo da distribuição binomial.
    /// </summary>
    public class DistribuicaoBinomial
    {
        private static double[][] tabela;
        private static long contador;

        /// <summary>
        /// Calcula recursivamente a probabilidade de se conseguir k sucessos em
        /// N ensaios de Bernoulli.
        /// </summary>
        /// <param name="N">Número de ensaios de Bernoulli.</param>
        /// <param name="k">Número de sucessos.</param>
        /// <param name="p">Probabilidade de sucesso em cada ensaio 
        /// de Bernoulli.</param>
        /// <returns>Probabilidade de k acertos em N ensaios de Bernoulli.</returns>
        public static double Binomial(int N, int k, double p)
        {
            if ((N == 0) && (k == 0))
            {
                return 1.0;
            }

            if ((N < 0) || (k < 0))
            {
                return 0.0;
            }

            return (1 - p) * Binomial(N - 1, k, p) + p * Binomial(N - 1, k - 1, p);
        }



        /// <summary>
        /// Calcula recursivamente a probabilidade de se conseguir k sucessos em
        /// N ensaios de Bernoulli. Mantém uma contagem do número de chamadas`recursivas.
        /// </summary>
        /// <param name="N">Número de ensaios de Bernoulli.</param>
        /// <param name="k">Número de sucessos.</param>
        /// <param name="p">Probabilidade de sucesso em cada ensaio 
        /// de Bernoulli.</param>
        /// <returns>Tupla contendo a contagem das chamadas e 
        /// a probabilidade de k acertos em N ensaios de Bernoulli 
        /// (nesta ordem).
        /// </returns>
        public static Tuple<long, double> BinomialComContagem(int N, int k, double p)
        {
            contador = 1;

            double retorno = BinomialComContagemPvt(N, k, p);

            return new Tuple<long, double>(contador, retorno);
        }

        private static double BinomialComContagemPvt(int N, int k, double p)
        {
            if ((N == 0) && (k == 0))
            {
                return 1.0;
            }

            if ((N < 0) || (k < 0))
            {
                return 0.0;
            }

            contador += 2;
            return (1 - p) * BinomialComContagemPvt(N - 1, k, p) + 
                         p * BinomialComContagemPvt(N - 1, k - 1, p);
        }

        /// <summary>
        /// Calcula recursivamente a probabilidade de se conseguir k sucessos em
        /// N ensaios de Bernoulli. Usa programação dinâmica.
        /// </summary>
        /// <param name="N">Número de ensaios de Bernoulli.</param>
        /// <param name="k">Número de sucessos.</param>
        /// <param name="p">Probabilidade de sucesso em cada ensaio 
        /// de Bernoulli.</param>
        /// <returns>Probabilidade de k acertos em N ensaios de Bernoulli.</returns>
        public static double BinomialProgramacaoDinamica(int N, int k, double p)
        {
            InicializaTabela(N, k, p);
            PreencherTabela(N, k, p);

            return (1 - p) * tabela[N - 1][k] + p * tabela[N - 1][k - 1];

        }

        private static void PreencherTabela(int N, int k, double p)
        {
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < k + 1; j++)
                {
                    tabela[i][j] = (1 - p) * tabela[i - 1][j] + p * tabela[i - 1][j - 1];
                }
            }
        }

        private static void InicializaTabela(int N, int k, double p)
        {
            tabela = new double[N][];
            for (int i = 0; i < N; i++)
            {
                tabela[i] = new double[k+1];
            }

            tabela[0][0] = 1.0;

            for (int i = 1; i < k+1; i++)
            {
                tabela[0][i] = 0.0;
            }

            for (int i = 1; i < N; i++)
            {
                tabela[i][0] = (1 - p) * tabela[i - 1][0];
            }
        }
    }
}
