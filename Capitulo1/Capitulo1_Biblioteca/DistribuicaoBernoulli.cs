using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo da distribuição Bernoulli.
    /// </summary>
    public class DistribuicaoBernoulli
    {
        private double p;
        private static int[] resultados;
        private Random random;

        public DistribuicaoBernoulli(double p)
        {
            this.p = p;
            this.random = new Random(DateTime.Now.Millisecond);
            
            int pPerc = (int) Math.Round(p * 100);
            resultados = new int[100];

            for (int i = 0; i < resultados.Length; i++)
            {
                resultados[i] = i < pPerc ? 1 : 0;
            }
        }

        /// <summary>
        /// Indica o resultado de um evento de Bernoulli com probabilidade de sucesso p.
        /// </summary>
        /// <returns>True em caso de sucesso, falha caso contrário.</returns>
        public bool Bernoulli()
        {
            int resultado = random.Next(0, resultados.Length);

            return resultados[resultado] == 1;
        }
    }
}