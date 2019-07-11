using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um intervalo em um plano 2D.
    /// </summary>
    public class Interval2D
    {
        private Interval1D x;
        private Interval1D y;

        /// <summary>
        /// Objeto que representa um intervalo em um plano 2D (um retângulo).
        /// </summary>
        /// <param name="x">Intervalo no eixo X.</param>
        /// <param name="y">Intervalo no eixo Y.</param>
        public Interval2D(Interval1D x, Interval1D y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Calcula a área do intervalo.
        /// </summary>
        /// <returns>Área do intervalo.</returns>
        public double Area()
        {
            return x.Length * y.Length;
        }

        /// <summary>
        /// Verifica se o intervalo contém o dado ponto.
        /// </summary>
        /// <param name="p">Ponto a ser verificado.</param>
        /// <returns>True caso o intervalo contenha o ponto. False caso contrário.</returns>
        public bool Contains(Point2DBook p)
        {
            return x.Contains(p.X) && y.Contains(p.Y);
        }
        
        /// <summary>
        /// Verifica se o intervalo é intersectado por outro intervalo.
        /// </summary>
        /// <param name="that">Intervalo a ser verificado.</param>
        /// <returns>True caso o intervalo intercepte o informado. False caso contrário.</returns>
        public bool Intersects(Interval2D that)
        {
            return x.Intersects(that.x) && y.Intersects(that.y);
        }

        /// <summary>
        /// Desenha o intervalo.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}