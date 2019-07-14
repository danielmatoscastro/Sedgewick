using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um acumulador.
    /// </summary>
    public class Accumulator
    {
        private double total;
        private int N;

        /// <summary>
        /// Média dos valores dos valores acumulados.
        /// </summary>
        public double Mean
        {
            get { return total / N; }
        }
        
        /// <summary>
        /// Objeto que representa um acumulador.
        /// </summary>
        public Accumulator()
        {
            total = 0;
            N = 0;
        }

        /// <summary>
        /// Adiciona um valor ao total acumulado.
        /// </summary>
        /// <param name="val">Valor a ser adicionado.</param>
        public void addDataValue(double val)
        {
            total += val;
            N++;
        }

        /// <summary>
        /// Retorna uma representação como string do acumulador.
        /// </summary>
        /// <returns>String que representa o acumulador.</returns>
        public override string ToString()
        {
            return String.Format("Mean ({0} values): {1}", N, Mean);
        }
    }
}