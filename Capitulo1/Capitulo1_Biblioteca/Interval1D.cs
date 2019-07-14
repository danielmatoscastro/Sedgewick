using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um intervalo em uma reta.
    /// </summary>
    public class Interval1D
    {
        private double left;
        private double right;

        /// <summary>
        /// Extremo esquerdo do intervalo.
        /// </summary>
        public double Left
        {
            get { return left; }
        }

        /// <summary>
        /// Extremo direito do intervalo.
        /// </summary>
        public double Right
        {
            get { return right; }
        }

        /// <summary>
        /// Tamanho do intervalo.
        /// </summary>
        public double Length
        {
            get { return Math.Abs(right - left); }
        }

        /// <summary>
        /// Objeto que representa um intervalo em uma reta.
        /// </summary>
        /// <param name="left">Extremo esquerdo do intervalo.</param>
        /// <param name="right">Extremo direito do intervalo.</param>
        public Interval1D(double left, double right)
        {
            this.left = left;
            this.right = right;
        }

        /// <summary>
        /// Verifica se o valor informado está dentro do intervalo.
        /// </summary>
        /// <param name="x">Valor a ser verificado.</param>
        /// <returns>True se x éstá no intervalo. False caso contrário.</returns>
        public bool Contains(double x)
        {
            return left <= x && x <= right;
        }

        /// <summary>
        /// Verifica se o intervalo informado tem algum ponto em comum com este intervalo.
        /// </summary>
        /// <param name="that">Intervalo a ser verificado.</param>
        /// <returns>
        /// True caso esta instância e o intervalo informado tenham algum valor em comum.
        /// False caso contrário.
        /// </returns>
        public bool Intersects(Interval1D that)
        {
            return this.Contains(that.left) || this.Contains(that.Right);
        }

        /// <summary>
        /// Representa o intervalo como uma string.
        /// </summary>
        /// <returns>String representando o intervalo.</returns>
        public override string ToString()
        {
            return String.Format("[{0}, {1}]", left, right);
        }
    }
}