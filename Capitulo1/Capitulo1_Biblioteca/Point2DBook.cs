using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um ponto no plano 2D.
    /// </summary>
    public class Point2DBook
    {
        private double x;
        private double y;

        /// <summary>
        /// Coordenada X (cartesiana).
        /// </summary>
        public double X
        {
            get => x;
        }

        /// <summary>
        /// Coordenada Y (cartesiana).
        /// </summary>
        public double Y
        {
            get => y;
        }

        /// <summary>
        /// Coordenada R (polar).
        /// </summary>
        public double R
        {
            get { return Math.Sqrt(x * x + y * y); }
        }

        /// <summary>
        /// Coordenada Theta (polar).
        /// </summary>
        public double Theta
        {
            get { return Math.Atan(y / x); }
        }

        /// <summary>
        /// Objeto que representa um ponto no plano 2D.
        /// </summary>
        /// <param name="x">Coordenada X (cartesiana).</param>
        /// <param name="y">Coordenada Y (cartesiana).</param>
        public Point2DBook(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Calcula a distância entre dois pontos.
        /// </summary>
        /// <param name="that">Ponto cuja distância será calculada.</param>
        /// <returns>Distância entre a instância atual e a informada.</returns>
        public double DistanceTo(Point2DBook that)
        {
            double distX = this.x - that.x;
            double distY = this.Y - that.Y;

            return Math.Sqrt(distX * distX + distY * distY);
        }

        /// <summary>
        /// Desenha o ponto.
        /// </summary>
        /// <exception cref="NotImplementedException">Corpo do método ainda não está implementado.</exception>
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}