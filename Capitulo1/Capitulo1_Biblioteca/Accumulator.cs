using System;
using System.Text;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um acumulador.
    /// </summary>
    public class Accumulator
    {
        private double s;
        private double m;
        private int N;

        /// <summary>
        /// Média dos valores dos valores acumulados.
        /// </summary>
        public double Mean
        {
            get { return m; }
        }

        /// <summary>
        /// Variância dos valores acumulados.
        /// </summary>
        public double Var
        {
            get { return s / (N - 1); }
        }

        /// <summary>
        /// Desvio padrão dos valores acumulados.
        /// </summary>
        public double Stddev
        {
            get { return Math.Sqrt(Var); }
        }
        
        /// <summary>
        /// Objeto que representa um acumulador.
        /// </summary>
        public Accumulator()
        {
            s = 0;
            m = 0;
            N = 0;
        }

        /// <summary>
        /// Adiciona um valor ao total acumulado.
        /// </summary>
        /// <param name="val">Valor a ser adicionado.</param>
        public void AddDataValue(double val)
        {
            N++;
            s = s + 1.0 * (N - 1) / N * (val - m) * (val - m);
            m = m + (val - m) / N;
        }

        /// <summary>
        /// Retorna uma representação como string do acumulador.
        /// </summary>
        /// <returns>String que representa o acumulador.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0} valores\n", N));
            sb.Append(String.Format("Média: {0}\n", Mean));
            sb.Append(String.Format("Variância: {0}\n", Var));
            sb.Append(String.Format("Desvio padrão: {0}\n", Stddev));
            
            return sb.ToString();
        }
    }
}