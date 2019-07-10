using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa a distribuição de probabilidades (aproximada) da soma de dois dados.
    /// </summary>
    public class SomaDeDadosAproximada : SomaDeDados
    {
        /// <summary>
        /// Cria um objeto que representa a distribuição de probabilidades
        /// da soma de dois dados. Aproxima esta distribuição reaizando N
        /// lançamentos simulados.
        /// </summary>
        /// <param name="N">Número de lançamentos.</param>
        public SomaDeDadosAproximada(int N)
        {
            dist = new double[2*LADOS+1];
            
            AproximarDistribuicao(N);
        }
        

        /// <summary>
        /// Aproxima a distribuição de probabilidades da soma de dois dados
        /// realizando N lançamentos simulados.
        /// </summary>
        /// <param name="N">Número de lançamentos.</param>
        private void AproximarDistribuicao(int N)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < N; i++)
            {
                int dadoA = random.Next(1, LADOS + 1);
                int dadoB = random.Next(1, LADOS + 1);

                dist[dadoA + dadoB] += 1;
            }

            for (int i = 0; i < dist.Length; i++)
            {
                dist[i] /= N;
            }
        }
    }
}