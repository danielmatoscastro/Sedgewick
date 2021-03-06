using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Representa uma distribuição de probabilidades para a soma de dois dados.
    /// </summary>
    public  abstract class SomaDeDados
    {
        /// <summary>
        /// Número de lados do dado.
        /// </summary>
        protected const int LADOS = 6;
        
        /// <summary>
        /// Array dist tal que dist[k] é a probabilidade dos dados somarem k.
        /// </summary>
        protected double[] dist;
        
        /// <summary>
        /// Retorna um vetor dist tal que dist[k] é a probabilidade aproximada dos lançamentos
        /// somarem k.
        /// </summary>
        public double[] Distribuicao
        {
            get { return dist; }
        }
        
        /// <summary>
        /// Retorna a probabilidade aproximada dos lançamentos de dois dados somarem K.
        /// Aproxima realizando N lançamentos.
        /// </summary>
        /// <param name="k">Soma dos dados.</param>
        /// <param name="N">Número de lançamentos.</param>
        /// <returns>Probabilidade aproximada dos dados somarem k.</returns>
        public double ProbabilidadeDeSomar(int k, int N)
        {
            if (SomaEhInvalida(k))
            {
                return 0;
            }
            
            return dist[k];
        }
        
        /// <summary>
        /// Verifica se o valor informado é uma soma válida para dois dados.
        /// </summary>
        /// <param name="k">Soma dos dados.</param>
        /// <returns>True caso a soma seja válida. False caso contrário.</returns>
        private static bool SomaEhInvalida(int k)
        {
            return k <= 0 || k > 2 * LADOS;
        }

        
        /// <summary>
        /// Gera um hash code para um objeto SomaDeDados.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        /// <summary>
        /// Verifica se duas distribuições são iguais (diferem em cada valor por 10e-3 ou menos.))
        /// </summary>
        /// <param name="obj">Distribuição a ser comparada.</param>
        /// <returns>True se a igualdade for satisfeita. False caso contrário.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is SomaDeDados))
            {
                return false;
            }

            SomaDeDados soma = (SomaDeDados) obj;

            if (soma.Distribuicao.Length != dist.Length)
            {
                return false;
            }

            for (int i = 0; i < dist.Length; i++)
            {
                if (Math.Abs(soma.Distribuicao[i] - dist[i]) > 10e-3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}